S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 16202
Date: 2018-04-23 13:40:09+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf75a8648, r1   = 0xf7e1a1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7e1a1b8, r5   = 0x00012cd0
r6   = 0xf7e2ce88, r7   = 0xf75a8250
r8   = 0x000005e0, r9   = 0xf708b824
r10  = 0xf7e129d8, fp   = 0x00000000
ip   = 0xf75a7030, sp   = 0xfff80f90
lr   = 0xf74eb5d0, pc   = 0xf74e79fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:    107864 KB
Buffers:     27260 KB
Cached:     145840 KB
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
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6c22000 f6c25000 r-xp /lib/libattr.so.1.1.0
f6c2e000 f6c35000 r-xp /lib/libcrypt-2.13.so
f6c65000 f6c68000 r-xp /lib/libcap.so.2.21
f6c70000 f6c72000 r-xp /usr/lib/libiri.so
f6c7a000 f6c97000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ca0000 f6ca4000 r-xp /usr/lib/libsmack.so.1.0.0
f6cae000 f6cb0000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cb8000 f6cbd000 r-xp /usr/lib/libffi.so.5.0.10
f6cc5000 f6cc6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6cce000 f6cd0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cd8000 f6cda000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ce4000 f6cf4000 r-xp /lib/libresolv-2.13.so
f6cf8000 f6d10000 r-xp /usr/lib/liblzma.so.5.0.3
f6d18000 f6d1a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d22000 f6d51000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d5a000 f6d69000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d72000 f6d7c000 r-xp /usr/lib/libsensord-shared.so
f6d85000 f6db9000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dc2000 f6e95000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ea0000 f6eb6000 r-xp /lib/libz.so.1.2.5
f6ebe000 f6ec4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ecd000 f6f42000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f4c000 f6f66000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6f6e000 f6f74000 r-xp /lib/librt-2.13.so
f6f7d000 f6f9b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fa5000 f6fa6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fae000 f6fb3000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fbb000 f708b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f708c000 f70b6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70bf000 f70d6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70de000 f7147000 r-xp /lib/libm-2.13.so
f7150000 f71e4000 r-xp /usr/lib/libstdc++.so.6.0.16
f71f7000 f71fc000 r-xp /usr/lib/libctx-client.so.0.8.3
f7204000 f720b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7213000 f723d000 r-xp /usr/lib/libsensor.so.1.9.6
f7246000 f7312000 r-xp /usr/lib/libxml2.so.2.7.8
f731f000 f7321000 r-xp /usr/lib/libiniparser.so.0
f732a000 f732d000 r-xp /usr/lib/libbundle.so.0.1.22
f7335000 f733b000 r-xp /usr/lib/libappsvc.so.0.1.0
f7343000 f7366000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f736e000 f73af000 r-xp /usr/lib/libeina.so.1.7.99
f73b8000 f73cf000 r-xp /usr/lib/libecore.so.1.7.99
f73e6000 f73ef000 r-xp /usr/lib/libvconf.so.0.2.45
f73f7000 f740b000 r-xp /lib/libpthread-2.13.so
f7416000 f7423000 r-xp /usr/lib/libaul.so.0.1.0
f742d000 f742f000 r-xp /lib/libdl-2.13.so
f7438000 f7443000 r-xp /lib/libunwind.so.8.0.1
f7470000 f7478000 r-xp /lib/libgcc_s-4.6.so.1
f7479000 f759d000 r-xp /lib/libc-2.13.so
f75ab000 f75ad000 r-xp /usr/lib/libdlog.so.0.0.0
f75b5000 f75c1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75ca000 f75cf000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75d7000 f75db000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75e4000 f75e6000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f75ef000 f75f2000 r-xp /usr/lib/libappcore-agent.so.1.1
f7610000 f762d000 r-xp /lib/ld-2.13.so
f7636000 f7639000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7639000 f763d000 r-xp /usr/lib/libsys-assert.so
f7e08000 f7e56000 rw-p [heap]
fff63000 fff84000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16202)
Call Stack Count: 1
 0: (0xf74e79fc) [/lib/libc.so.6] + 0x6e9fc
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
2.021+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:32.021+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:32:29,78
04-23 13:39:32.221+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:32.221+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:32:229,79
04-23 13:39:32.421+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:32.421+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:32:429,78
04-23 13:39:32.611+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:32.621+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:32:627,78
04-23 13:39:32.811+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:32.821+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:32:827,78
04-23 13:39:33.021+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:33.021+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:33:29,78
04-23 13:39:33.211+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:33.241+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:33:228,78
04-23 13:39:33.421+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:33.421+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:33:429,78
04-23 13:39:33.621+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:33.621+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:33:629,78
04-23 13:39:33.821+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:33.821+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:33:829,78
04-23 13:39:34.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:34.031+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:34:39,78
04-23 13:39:34.231+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:34.231+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:34:239,78
04-23 13:39:34.421+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:34.421+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:34:429,77
04-23 13:39:34.621+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:34.621+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:34:629,77
04-23 13:39:34.821+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:34.821+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:34:829,77
04-23 13:39:35.031+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:35.031+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:35:38,77
04-23 13:39:35.221+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:35.221+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:35:229,77
04-23 13:39:35.421+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:35.421+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:35:430,77
04-23 13:39:35.621+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:35.621+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:35:630,78
04-23 13:39:35.821+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:35.831+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:35:830,78
04-23 13:39:36.021+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:36.081+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:36:31,78
04-23 13:39:36.221+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:36.221+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:36:231,78
04-23 13:39:36.421+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:36.421+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:36:430,77
04-23 13:39:36.621+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:36.621+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:36:630,77
04-23 13:39:36.821+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:36.821+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:36:830,77
04-23 13:39:37.021+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:37.021+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:37:30,77
04-23 13:39:37.221+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:37.221+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:37:230,77
04-23 13:39:37.421+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:37.421+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:37:431,78
04-23 13:39:37.621+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:37.621+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:37:631,78
04-23 13:39:37.821+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:37.821+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:37:831,78
04-23 13:39:38.021+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:38.021+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:38:31,77
04-23 13:39:38.221+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:38.221+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:38:231,78
04-23 13:39:38.421+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:38.421+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:38:431,77
04-23 13:39:38.621+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:38.621+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:38:631,78
04-23 13:39:38.821+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:38.821+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:38:831,77
04-23 13:39:39.021+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:39.021+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:39:32,77
04-23 13:39:39.221+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:39.221+0200 I/heartrate(14402): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:39:39:232,77
04-23 13:39:39.421+0200 I/heartrate(14402): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:39:39.431+0200 E/RESOURCED( 2551): lowmem-limit.c: lowmem_limit_cb(305) > some application was crashed by kernel when it exceeded the threshold (104857600)
04-23 13:39:39.531+0200 W/AUL     (16118): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 13:39:39.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:39:39.531+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:39.531+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:39.531+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:39.531+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:39.531+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:39.531+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:39:39.531+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:39:39.531+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:39:39.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12446
04-23 13:39:39.531+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:39:39.541+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12446
04-23 13:39:39.541+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12446)
04-23 13:39:39.551+0200 E/AUL     (16118): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:39:48.641+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:39:48.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:39:48.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:39:48.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9745
04-23 13:39:48.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:39:48.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9745), cmd(0)
04-23 13:39:48.661+0200 I/utils   ( 9745): specific action
04-23 13:39:48.661+0200 I/httppostreq( 9745): internet connection check received
04-23 13:39:48.661+0200 I/httppostreq( 9745): internet connection != null
04-23 13:39:48.661+0200 I/CAPI_NETWORK_CONNECTION( 9745): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:39:48.661+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9745)
04-23 13:39:48.661+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.httppostreq
04-23 13:39:48.661+0200 I/httppostreq( 9745): internet connection type...
04-23 13:39:48.661+0200 I/httppostreq( 9745): internet connection type 1
04-23 13:39:48.661+0200 I/httppostreq( 9745): internet available
04-23 13:39:48.661+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:39:48.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:39:48.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9745
04-23 13:39:48.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9742
04-23 13:39:48.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:39:48.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9742), cmd(0)
04-23 13:39:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:39:48.691+0200 I/utils   ( 9742): specific action
04-23 13:39:48.691+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9742)
04-23 13:39:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:39:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:39:48.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:39:48.691+0200 I/httppostreq( 9745): request sent to service es.ugr.frailty.servicemanager
04-23 13:39:48.691+0200 I/servicemanager( 9742): internet connection available. stop all sensors
04-23 13:39:48.691+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:39:48.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:39:48.691+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:39:48.701+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:39:48.701+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 16123
04-23 13:39:48.751+0200 E/CAPI_APPFW_APPLICATION(16123): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:39:48.751+0200 E/CAPI_APPFW_APPLICATION(16123): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:39:48.751+0200 I/utils   (16123): trying to start service: es.ugr.frailty.accelerometer
04-23 13:39:48.751+0200 I/utils   (16123): es.ugr.frailty.accelerometer sensor supported
04-23 13:39:48.761+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 16123
04-23 13:39:48.761+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(16123) type(svcapp) bg(0)
04-23 13:39:48.761+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [16123]
04-23 13:39:48.771+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (16123) was created
04-23 13:39:48.781+0200 I/utils   (16123): es.ugr.frailty.accelerometer listener started
04-23 13:39:48.781+0200 I/accelerometer(16123): stopping es.ugr.frailty.accelerometer service
04-23 13:39:48.781+0200 E/CAPI_APPFW_APP_CONTROL(16123): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:39:48.781+0200 E/accelerometer(16123): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:39:48.781+0200 I/CAPI_APPFW_APPLICATION(16123): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:39:48.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:39:48.791+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16123
04-23 13:39:48.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:39:48.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:39:48.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:39:48.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:39:48.841+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16123
04-23 13:39:48.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:39:48.871+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16123)
04-23 13:39:48.881+0200 I/servicemanager( 9742): es.ugr.frailty.accelerometer stop request sent!
04-23 13:39:48.881+0200 I/servicemanager( 9742): App control destroyed.
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:48.881+0200 E/servicemanager( 9742): deleting timer 0
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:48.881+0200 E/servicemanager( 9742): deleting timer 1
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:48.881+0200 E/servicemanager( 9742): deleting timer 2
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:48.881+0200 E/servicemanager( 9742): deleting timer 3
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:48.881+0200 E/servicemanager( 9742): deleting timer 4
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:48.881+0200 E/servicemanager( 9742): deleting timer 5
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:48.881+0200 E/servicemanager( 9742): deleting timer 6
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:48.881+0200 E/servicemanager( 9742): deleting timer 7
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:48.881+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:39:48.881+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:39:48.881+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:39:48.881+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:39:48.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:39:48.881+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:39:48.891+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 16136
04-23 13:39:48.901+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:39:48.921+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:39:48.941+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 16136
04-23 13:39:48.941+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(16136) type(svcapp) bg(0)
04-23 13:39:48.951+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:39:48.951+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [16136]
04-23 13:39:48.951+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16136)
04-23 13:39:48.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:39:48.971+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16136
04-23 13:39:48.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:39:49.011+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:39:49.021+0200 E/CAPI_APPFW_APPLICATION(16136): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:39:49.031+0200 E/CAPI_APPFW_APPLICATION(16136): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:39:49.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:39:49.041+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16136
04-23 13:39:49.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:39:49.081+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (16136) was created
04-23 13:39:49.091+0200 I/utils   (16136): specific action
04-23 13:39:49.091+0200 I/recorder(16136): obteniendo datos locales...
04-23 13:39:49.111+0200 I/accelerometer(16123): es.ugr.frailty.accelerometer listener destroyed
04-23 13:39:49.111+0200 I/recorder(16136): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:39:49.111+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:39:49.121+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:39:49.121+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:39:49.121+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:39:49.121+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:39:49.121+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:39:49.121+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:39:49.121+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:39:49.121+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:39:49.121+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:39:49.121+0200 I/recorder(16136): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:39:49.171+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 11161367265631524483589
04-23 13:39:49.211+0200 W/AUL     (16143): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:39:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:39:49.211+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:49.211+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:49.211+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:49.211+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:49.211+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:49.211+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:39:49.211+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:39:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:39:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 16136
04-23 13:39:49.211+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:39:49.221+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16136
04-23 13:39:49.221+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(16136)
04-23 13:39:49.231+0200 E/AUL     (16143): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:39:49.261+0200 W/AUL     (16144): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:39:49.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:39:49.271+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:39:49.271+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:39:49.271+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:39:49.271+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:39:49.271+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:39:49.271+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:39:49.271+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:39:49.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:39:49.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 16123
04-23 13:39:49.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:39:49.281+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16123
04-23 13:39:49.281+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(16123)
04-23 13:39:49.281+0200 E/AUL     (16144): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:39:50.791+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 13:40:08.631+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:40:08.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:40:08.641+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:40:08.641+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9745
04-23 13:40:08.661+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:40:08.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9745), cmd(0)
04-23 13:40:08.661+0200 I/utils   ( 9745): specific action
04-23 13:40:08.661+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9745)
04-23 13:40:08.661+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.httppostreq
04-23 13:40:08.661+0200 I/httppostreq( 9745): internet connection check received
04-23 13:40:08.661+0200 I/httppostreq( 9745): internet connection != null
04-23 13:40:08.661+0200 I/CAPI_NETWORK_CONNECTION( 9745): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:40:08.661+0200 I/httppostreq( 9745): internet connection type...
04-23 13:40:08.661+0200 I/httppostreq( 9745): internet connection type 1
04-23 13:40:08.661+0200 I/httppostreq( 9745): internet available
04-23 13:40:08.661+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:40:08.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:40:08.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9745
04-23 13:40:08.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9742
04-23 13:40:08.691+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:40:08.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(9742), cmd(0)
04-23 13:40:08.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:40:08.691+0200 I/utils   ( 9742): specific action
04-23 13:40:08.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:40:08.691+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:40:08.701+0200 W/CAPI_APPFW_APP_CONTROL( 9742): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:40:08.701+0200 I/servicemanager( 9742): internet connection available. stop all sensors
04-23 13:40:08.701+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:40:08.701+0200 W/AUL     ( 9745): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9742)
04-23 13:40:08.701+0200 I/httppostreq( 9745): request sent to service es.ugr.frailty.servicemanager
04-23 13:40:08.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:40:08.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:40:08.711+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 16193
04-23 13:40:08.711+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:40:08.751+0200 E/CAPI_APPFW_APPLICATION(16193): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:40:08.751+0200 E/CAPI_APPFW_APPLICATION(16193): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:40:08.761+0200 I/utils   (16193): trying to start service: es.ugr.frailty.accelerometer
04-23 13:40:08.761+0200 I/utils   (16193): es.ugr.frailty.accelerometer sensor supported
04-23 13:40:08.761+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 16193
04-23 13:40:08.761+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(16193) type(svcapp) bg(0)
04-23 13:40:08.761+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16193)
04-23 13:40:08.761+0200 I/servicemanager( 9742): es.ugr.frailty.accelerometer stop request sent!
04-23 13:40:08.761+0200 I/servicemanager( 9742): App control destroyed.
04-23 13:40:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:40:08.761+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:40:08.761+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:40:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:40:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:40:08.761+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:40:08.761+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:40:08.761+0200 E/servicemanager( 9742): deleting timer 0
04-23 13:40:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:40:08.761+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:40:08.761+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:40:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:40:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:40:08.761+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:40:08.761+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:40:08.761+0200 E/servicemanager( 9742): deleting timer 1
04-23 13:40:08.761+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:40:08.761+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:40:08.761+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:40:08.771+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (16193) was created
04-23 13:40:08.771+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [16193]
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:40:08.781+0200 E/servicemanager( 9742): deleting timer 2
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:40:08.781+0200 E/servicemanager( 9742): deleting timer 3
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:40:08.781+0200 E/servicemanager( 9742): deleting timer 4
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:40:08.781+0200 E/servicemanager( 9742): deleting timer 5
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:40:08.781+0200 E/servicemanager( 9742): deleting timer 6
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:40:08.781+0200 E/servicemanager( 9742): deleting timer 7
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:573 _ecore_magic_fail() 
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** IN FUNCTION: ecore_timer_del()
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:40:08.781+0200 E/EFL     ( 9742): ecore<9742> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** SPANK SPANK SPANK!!!
04-23 13:40:08.781+0200 E/EFL     ( 9742): *** Now go fix your code. Tut tut tut!
04-23 13:40:08.781+0200 E/servicemanager( 9742): deleting timer 8
04-23 13:40:08.781+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:40:08.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:40:08.791+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9742
04-23 13:40:08.801+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:40:08.801+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 16202
04-23 13:40:08.831+0200 I/utils   (16193): es.ugr.frailty.accelerometer listener started
04-23 13:40:08.831+0200 I/accelerometer(16193): stopping es.ugr.frailty.accelerometer service
04-23 13:40:08.831+0200 E/CAPI_APPFW_APP_CONTROL(16193): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:40:08.831+0200 E/accelerometer(16193): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:40:08.831+0200 I/CAPI_APPFW_APPLICATION(16193): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:40:08.851+0200 E/CAPI_APPFW_APPLICATION(16202): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:40:08.851+0200 E/CAPI_APPFW_APPLICATION(16202): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:40:08.851+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 16202
04-23 13:40:08.851+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(16202) type(svcapp) bg(0)
04-23 13:40:08.851+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [16202]
04-23 13:40:08.861+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:40:08.871+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16193
04-23 13:40:08.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:40:08.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:40:08.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:40:08.911+0200 W/AUL     ( 9742): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16202)
04-23 13:40:08.911+0200 I/servicemanager( 9742): request sent to service es.ugr.frailty.recorder
04-23 13:40:08.911+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (16202) was created
04-23 13:40:08.921+0200 I/utils   (16202): specific action
04-23 13:40:08.921+0200 I/recorder(16202): obteniendo datos locales...
04-23 13:40:08.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:40:08.931+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16202
04-23 13:40:08.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:40:08.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:40:08.991+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 16193
04-23 13:40:09.001+0200 I/recorder(16202): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:11:719,1.256232,-2.703890,9.075976
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:11:915,1.646262,-1.940579,9.451650
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:12:133,1.557728,-2.222932,9.475577
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:12:323,1.820938,-2.344966,9.391829
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:12:534,1.476372,-2.151148,9.585647
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:12:732,1.543371,-2.447858,9.521042
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:12:948,1.622334,-2.550749,9.245867
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:13:175,1.605584,-2.395216,9.482756
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:13:351,1.679761,-2.407180,9.487542
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:13:549,1.648655,-2.352145,9.413363
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:13:756,1.624727,-2.376073,9.487542
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:13:957,1.619941,-2.368894,9.501899
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:14:154,1.631905,-2.388037,9.530612
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:14:352,1.658226,-2.488536,9.509077
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:14:597,1.753939,-2.404787,9.353544
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:14:753,1.749153,-2.404787,9.468399
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:14:973,1.722832,-2.409572,9.375079
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:15:153,1.789831,-2.301895,9.358330
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:15:354,1.607977,-2.404787,9.628718
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:15:553,1.792224,-1.902294,9.533006
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:15:769,1.720440,-2.060220,9.578469
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:15:996,1.607977,-2.560320,9.678967
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:16:189,1.478764,-2.136791,9.566505
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:16:379,1.538585,-2.500499,9.726824
04-23 13:40:09.001+0200 I/recorder(16202): SM-R760,23/04/2018,13:31:16:581,1.538585,-2.608176,9.834501
04-23 13:40:09.061+0200 W/CRASH_MANAGER(14429): worker.c: worker_job(1205) > 1116202726563152448360
