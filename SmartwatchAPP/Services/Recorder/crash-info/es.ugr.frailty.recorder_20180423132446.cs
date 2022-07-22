S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 32450
Date: 2018-04-23 13:24:46+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf76d6250, r1   = 0x00000000
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7a71a78, r5   = 0x00000170
r6   = 0xf7a71be8, r7   = 0xf76d6250
r8   = 0x00000638, r9   = 0xf71b9824
r10  = 0xf7a299d8, fp   = 0x00000000
ip   = 0xf76d5030, sp   = 0xffdedbd8
lr   = 0xf76195d0, pc   = 0xf76159fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      9908 KB
Buffers:     70360 KB
Cached:     181896 KB
VmPeak:      13756 KB
VmSize:      12728 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7840 KB
VmRSS:        7840 KB
VmData:       2756 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6d50000 f6d53000 r-xp /lib/libattr.so.1.1.0
f6d5c000 f6d63000 r-xp /lib/libcrypt-2.13.so
f6d93000 f6d96000 r-xp /lib/libcap.so.2.21
f6d9e000 f6da0000 r-xp /usr/lib/libiri.so
f6da8000 f6dc5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6dce000 f6dd2000 r-xp /usr/lib/libsmack.so.1.0.0
f6ddc000 f6dde000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6de6000 f6deb000 r-xp /usr/lib/libffi.so.5.0.10
f6df3000 f6df4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6dfc000 f6dfe000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6e06000 f6e08000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6e12000 f6e22000 r-xp /lib/libresolv-2.13.so
f6e26000 f6e3e000 r-xp /usr/lib/liblzma.so.5.0.3
f6e46000 f6e48000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6e50000 f6e7f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e88000 f6e97000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ea0000 f6eaa000 r-xp /usr/lib/libsensord-shared.so
f6eb3000 f6ee7000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6ef0000 f6fc3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6fce000 f6fe4000 r-xp /lib/libz.so.1.2.5
f6fec000 f6ff2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ffb000 f7070000 r-xp /usr/lib/libsqlite3.so.0.8.6
f707a000 f7094000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f709c000 f70a2000 r-xp /lib/librt-2.13.so
f70ab000 f70c9000 r-xp /usr/lib/libsystemd.so.0.4.0
f70d3000 f70d4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f70dc000 f70e1000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70e9000 f71b9000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71ba000 f71e4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f71ed000 f7204000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f720c000 f7275000 r-xp /lib/libm-2.13.so
f727e000 f7312000 r-xp /usr/lib/libstdc++.so.6.0.16
f7325000 f732a000 r-xp /usr/lib/libctx-client.so.0.8.3
f7332000 f7339000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7341000 f736b000 r-xp /usr/lib/libsensor.so.1.9.6
f7374000 f7440000 r-xp /usr/lib/libxml2.so.2.7.8
f744d000 f744f000 r-xp /usr/lib/libiniparser.so.0
f7458000 f745b000 r-xp /usr/lib/libbundle.so.0.1.22
f7463000 f7469000 r-xp /usr/lib/libappsvc.so.0.1.0
f7471000 f7494000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f749c000 f74dd000 r-xp /usr/lib/libeina.so.1.7.99
f74e6000 f74fd000 r-xp /usr/lib/libecore.so.1.7.99
f7514000 f751d000 r-xp /usr/lib/libvconf.so.0.2.45
f7525000 f7539000 r-xp /lib/libpthread-2.13.so
f7544000 f7551000 r-xp /usr/lib/libaul.so.0.1.0
f755b000 f755d000 r-xp /lib/libdl-2.13.so
f7566000 f7571000 r-xp /lib/libunwind.so.8.0.1
f759e000 f75a6000 r-xp /lib/libgcc_s-4.6.so.1
f75a7000 f76cb000 r-xp /lib/libc-2.13.so
f76d9000 f76db000 r-xp /usr/lib/libdlog.so.0.0.0
f76e3000 f76ef000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76f8000 f76fd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7705000 f7709000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7712000 f7714000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f771d000 f7720000 r-xp /usr/lib/libappcore-agent.so.1.1
f773e000 f775b000 r-xp /lib/ld-2.13.so
f7764000 f7767000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7767000 f776b000 r-xp /usr/lib/libsys-assert.so
f7a1f000 f7ab1000 rw-p [heap]
ffdcf000 ffdf0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:32450)
Call Stack Count: 1
 0: (0xf76159fc) [/lib/libc.so.6] + 0x6e9fc
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
_start_app(1782) > caller pid : 30617
04-23 13:24:45.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7330
04-23 13:24:45.331+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7330)
04-23 13:24:45.331+0200 I/servicemanager(30617): es.ugr.frailty.heartrate launch request sent!
04-23 13:24:45.331+0200 I/servicemanager(30617): App control destroyed.
04-23 13:24:45.351+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 13:24:45.351+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:45.351+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(7330), cmd(0)
04-23 13:24:45.371+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 13:24:45.371+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:45.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(7330), cmd(0)
04-23 13:24:45.371+0200 I/servicemanager(30617): es.ugr.frailty.heartrate sleep timeout
04-23 13:24:45.371+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 13:24:45.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:45.381+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30617
04-23 13:24:45.391+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 13:24:45.391+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 13:24:45.401+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 7345
04-23 13:24:45.401+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:24:45.401+0200 W/AUL     ( 7344): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 13:24:45.451+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7345
04-23 13:24:45.451+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(7345) type(svcapp) bg(0)
04-23 13:24:45.451+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7345]
04-23 13:24:45.451+0200 E/CAPI_APPFW_APPLICATION( 7345): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:24:45.451+0200 E/CAPI_APPFW_APPLICATION( 7345): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:24:45.451+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7345)
04-23 13:24:45.451+0200 I/servicemanager(30617): es.ugr.frailty.heartrate stop request sent!
04-23 13:24:45.451+0200 I/servicemanager(30617): App control destroyed.
04-23 13:24:45.451+0200 I/utils   ( 7345): trying to start service: es.ugr.frailty.heartrate
04-23 13:24:45.471+0200 I/utils   ( 7345): es.ugr.frailty.heartrate sensor supported
04-23 13:24:45.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:24:45.471+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:24:45.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6257
04-23 13:24:45.471+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:24:45.471+0200 E/AUL     ( 7344): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:24:45.481+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 13:24:45.481+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:45.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(7330), cmd(0)
04-23 13:24:45.481+0200 I/utils   ( 7345): es.ugr.frailty.heartrate listener started
04-23 13:24:45.481+0200 I/heartrate( 7345): stopping es.ugr.frailty.heartrate service
04-23 13:24:45.481+0200 E/CAPI_APPFW_APP_CONTROL( 7345): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:24:45.481+0200 E/heartrate( 7345): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:24:45.481+0200 I/CAPI_APPFW_APPLICATION( 7345): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:24:45.481+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 13:24:45.481+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:45.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(21), pid(7330), cmd(0)
04-23 13:24:45.481+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 13:24:45.481+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:45.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(21), pid(7330), cmd(0)
04-23 13:24:45.481+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (7345) was created
04-23 13:24:45.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:24:45.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7345
04-23 13:24:45.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:24:45.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:24:45.501+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6257
04-23 13:24:45.501+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6257)
04-23 13:24:45.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:24:45.541+0200 I/servicemanager(30617): es.ugr.frailty.heartrate alive timeout
04-23 13:24:45.551+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 13:24:45.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:24:45.561+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7345
04-23 13:24:45.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:24:45.581+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:24:45.591+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 13:24:45.591+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 13:24:45.591+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:24:45.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:45.591+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30617
04-23 13:24:45.601+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7345
04-23 13:24:45.611+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7345)
04-23 13:24:45.611+0200 I/servicemanager(30617): es.ugr.frailty.heartrate launch request sent!
04-23 13:24:45.611+0200 I/servicemanager(30617): App control destroyed.
04-23 13:24:45.631+0200 I/heartrate( 7345): es.ugr.frailty.heartrate listener destroyed
04-23 13:24:45.681+0200 I/servicemanager(30617): es.ugr.frailty.heartrate sleep timeout
04-23 13:24:45.681+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 13:24:45.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:45.681+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30617
04-23 13:24:45.701+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7345
04-23 13:24:45.701+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7345)
04-23 13:24:45.701+0200 I/servicemanager(30617): es.ugr.frailty.heartrate stop request sent!
04-23 13:24:45.711+0200 I/servicemanager(30617): App control destroyed.
04-23 13:24:45.731+0200 I/servicemanager(30617): es.ugr.frailty.heartrate alive timeout
04-23 13:24:45.731+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 13:24:45.751+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 13:24:45.751+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:45.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(7345), cmd(0)
04-23 13:24:45.751+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 13:24:45.751+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:45.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(7345), cmd(0)
04-23 13:24:45.751+0200 W/AUL     ( 7359): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 13:24:45.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:24:45.761+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:24:45.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6274
04-23 13:24:45.761+0200 E/AUL     ( 7359): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:24:45.761+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:24:45.791+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 13:24:45.791+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 13:24:45.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:45.801+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30617
04-23 13:24:45.811+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:24:45.811+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 7360
04-23 13:24:45.871+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7360
04-23 13:24:45.871+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.heartrate) pid(7360) type(svcapp) bg(0)
04-23 13:24:45.871+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7360)
04-23 13:24:45.871+0200 I/servicemanager(30617): es.ugr.frailty.heartrate launch request sent!
04-23 13:24:45.871+0200 I/servicemanager(30617): App control destroyed.
04-23 13:24:45.881+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7360]
04-23 13:24:45.891+0200 E/CAPI_APPFW_APPLICATION( 7360): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:24:45.891+0200 E/CAPI_APPFW_APPLICATION( 7360): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:24:45.901+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6274
04-23 13:24:45.901+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6274)
04-23 13:24:45.911+0200 I/utils   ( 7360): trying to start service: es.ugr.frailty.heartrate
04-23 13:24:45.911+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (7360) was created
04-23 13:24:45.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:24:45.931+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7360
04-23 13:24:45.941+0200 I/utils   ( 7360): es.ugr.frailty.heartrate sensor supported
04-23 13:24:45.941+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:24:45.951+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7360
04-23 13:24:45.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:24:45.951+0200 I/utils   ( 7360): es.ugr.frailty.heartrate listener started
04-23 13:24:45.961+0200 W/CAPI_APPFW_APP_CONTROL( 7360): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:24:45.961+0200 I/utils   ( 7360): specific action
04-23 13:24:45.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:24:45.991+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 13:24:45.991+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 13:24:46.011+0200 I/servicemanager(30617): es.ugr.frailty.heartrate sleep timeout
04-23 13:24:46.011+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 13:24:46.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:46.021+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30617
04-23 13:24:46.031+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7360
04-23 13:24:46.031+0200 I/heartrate( 7360): stopping es.ugr.frailty.heartrate service
04-23 13:24:46.031+0200 E/CAPI_APPFW_APP_CONTROL( 7360): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:24:46.031+0200 E/heartrate( 7360): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:24:46.031+0200 I/CAPI_APPFW_APPLICATION( 7360): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:24:46.031+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7360)
04-23 13:24:46.031+0200 I/servicemanager(30617): es.ugr.frailty.heartrate stop request sent!
04-23 13:24:46.031+0200 I/servicemanager(30617): App control destroyed.
04-23 13:24:46.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:24:46.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:24:46.051+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:46.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(7360), cmd(0)
04-23 13:24:46.051+0200 I/servicemanager(30617): es.ugr.frailty.heartrate alive timeout
04-23 13:24:46.051+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 13:24:46.061+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:46.061+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30617
04-23 13:24:46.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7360
04-23 13:24:46.071+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7360)
04-23 13:24:46.071+0200 I/servicemanager(30617): es.ugr.frailty.heartrate launch request sent!
04-23 13:24:46.071+0200 I/servicemanager(30617): App control destroyed.
04-23 13:24:46.091+0200 I/servicemanager(30617): es.ugr.frailty.heartrate sleep timeout
04-23 13:24:46.091+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 13:24:46.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:46.101+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30617
04-23 13:24:46.101+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:24:46.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7360
04-23 13:24:46.121+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7360)
04-23 13:24:46.121+0200 I/servicemanager(30617): es.ugr.frailty.heartrate stop request sent!
04-23 13:24:46.121+0200 I/servicemanager(30617): App control destroyed.
04-23 13:24:46.121+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:24:46.141+0200 I/servicemanager(30617): es.ugr.frailty.heartrate alive timeout
04-23 13:24:46.141+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 13:24:46.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:46.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30617
04-23 13:24:46.151+0200 I/heartrate( 7360): es.ugr.frailty.heartrate listener destroyed
04-23 13:24:46.151+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7360
04-23 13:24:46.151+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7360)
04-23 13:24:46.151+0200 I/servicemanager(30617): es.ugr.frailty.heartrate launch request sent!
04-23 13:24:46.151+0200 I/servicemanager(30617): App control destroyed.
04-23 13:24:46.161+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:24:46.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:46.161+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30617
04-23 13:24:46.171+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30620
04-23 13:24:46.171+0200 I/utils   (30620): specific action
04-23 13:24:46.171+0200 I/httppostreq(30620): internet connection check received
04-23 13:24:46.171+0200 I/httppostreq(30620): internet connection != null
04-23 13:24:46.171+0200 I/CAPI_NETWORK_CONNECTION(30620): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:24:46.171+0200 I/httppostreq(30620): internet connection type...
04-23 13:24:46.171+0200 I/httppostreq(30620): internet connection type 1
04-23 13:24:46.171+0200 I/httppostreq(30620): internet available
04-23 13:24:46.171+0200 W/AUL     (30620): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:24:46.171+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30620)
04-23 13:24:46.171+0200 I/servicemanager(30617): request sent to service es.ugr.frailty.httppostreq
04-23 13:24:46.171+0200 I/servicemanager(30617): es.ugr.frailty.heartrate sleep timeout
04-23 13:24:46.171+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
04-23 13:24:46.181+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:46.181+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30620
04-23 13:24:46.191+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 13:24:46.191+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 13:24:46.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30617
04-23 13:24:46.191+0200 W/AUL     (30620): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30617)
04-23 13:24:46.191+0200 I/httppostreq(30620): request sent to service es.ugr.frailty.servicemanager
04-23 13:24:46.191+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:46.191+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(21), pid(30620), cmd(0)
04-23 13:24:46.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:46.201+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30617
04-23 13:24:46.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7360
04-23 13:24:46.211+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7360)
04-23 13:24:46.211+0200 I/servicemanager(30617): es.ugr.frailty.heartrate stop request sent!
04-23 13:24:46.211+0200 I/servicemanager(30617): App control destroyed.
04-23 13:24:46.211+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:46.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(21), pid(30617), cmd(0)
04-23 13:24:46.221+0200 W/CAPI_APPFW_APP_CONTROL(30617): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:24:46.221+0200 I/utils   (30617): specific action
04-23 13:24:46.221+0200 W/CAPI_APPFW_APP_CONTROL(30617): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:24:46.221+0200 W/CAPI_APPFW_APP_CONTROL(30617): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:24:46.221+0200 W/CAPI_APPFW_APP_CONTROL(30617): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:24:46.221+0200 I/servicemanager(30617): internet connection available. stop all sensors
04-23 13:24:46.221+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:24:46.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:46.221+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30617
04-23 13:24:46.231+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:24:46.231+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 7374
04-23 13:24:46.281+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7374
04-23 13:24:46.281+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(7374) type(svcapp) bg(0)
04-23 13:24:46.311+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7374]
04-23 13:24:46.321+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 13:24:46.321+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:46.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(7360), cmd(0)
04-23 13:24:46.321+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 13:24:46.321+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:46.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(7360), cmd(0)
04-23 13:24:46.321+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7374)
04-23 13:24:46.321+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 13:24:46.321+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:46.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(21), pid(7360), cmd(0)
04-23 13:24:46.321+0200 I/servicemanager(30617): es.ugr.frailty.accelerometer stop request sent!
04-23 13:24:46.321+0200 I/servicemanager(30617): App control destroyed.
04-23 13:24:46.321+0200 E/EFL     (30617): ecore<30617> ecore.c:573 _ecore_magic_fail() 
04-23 13:24:46.321+0200 E/EFL     (30617): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:24:46.321+0200 E/EFL     (30617): *** IN FUNCTION: ecore_timer_del()
04-23 13:24:46.321+0200 E/EFL     (30617): ecore<30617> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:24:46.331+0200 E/EFL     (30617): ecore<30617> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** SPANK SPANK SPANK!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** Now go fix your code. Tut tut tut!
04-23 13:24:46.331+0200 E/servicemanager(30617): deleting timer 0
04-23 13:24:46.331+0200 E/servicemanager(30617): deleting timer 1
04-23 13:24:46.331+0200 E/servicemanager(30617): deleting timer 2
04-23 13:24:46.331+0200 E/EFL     (30617): ecore<30617> ecore.c:573 _ecore_magic_fail() 
04-23 13:24:46.331+0200 E/EFL     (30617): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** IN FUNCTION: ecore_timer_del()
04-23 13:24:46.331+0200 E/EFL     (30617): ecore<30617> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:24:46.331+0200 E/EFL     (30617): ecore<30617> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** SPANK SPANK SPANK!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** Now go fix your code. Tut tut tut!
04-23 13:24:46.331+0200 E/servicemanager(30617): deleting timer 3
04-23 13:24:46.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 13:24:46.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:46.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(21), pid(7360), cmd(0)
04-23 13:24:46.331+0200 E/EFL     (30617): ecore<30617> ecore.c:573 _ecore_magic_fail() 
04-23 13:24:46.331+0200 E/EFL     (30617): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** IN FUNCTION: ecore_timer_del()
04-23 13:24:46.331+0200 E/EFL     (30617): ecore<30617> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:24:46.331+0200 E/EFL     (30617): ecore<30617> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** SPANK SPANK SPANK!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** Now go fix your code. Tut tut tut!
04-23 13:24:46.331+0200 E/servicemanager(30617): deleting timer 4
04-23 13:24:46.331+0200 E/servicemanager(30617): deleting timer 5
04-23 13:24:46.331+0200 E/EFL     (30617): ecore<30617> ecore.c:573 _ecore_magic_fail() 
04-23 13:24:46.331+0200 E/EFL     (30617): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** IN FUNCTION: ecore_timer_del()
04-23 13:24:46.331+0200 E/EFL     (30617): ecore<30617> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:24:46.331+0200 E/EFL     (30617): ecore<30617> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** SPANK SPANK SPANK!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** Now go fix your code. Tut tut tut!
04-23 13:24:46.331+0200 E/servicemanager(30617): deleting timer 6
04-23 13:24:46.331+0200 E/EFL     (30617): ecore<30617> ecore.c:573 _ecore_magic_fail() 
04-23 13:24:46.331+0200 E/EFL     (30617): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** IN FUNCTION: ecore_timer_del()
04-23 13:24:46.331+0200 E/EFL     (30617): ecore<30617> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:24:46.331+0200 E/EFL     (30617): ecore<30617> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** SPANK SPANK SPANK!!!
04-23 13:24:46.331+0200 E/EFL     (30617): *** Now go fix your code. Tut tut tut!
04-23 13:24:46.331+0200 E/servicemanager(30617): deleting timer 7
04-23 13:24:46.331+0200 E/EFL     (30617): <30617> ecore_timer.c:559 _ecore_timer_del() safety check failed: timer->delete_me is true
04-23 13:24:46.331+0200 E/servicemanager(30617): deleting timer 8
04-23 13:24:46.331+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:24:46.331+0200 W/AUL     ( 7375): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 13:24:46.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:46.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30617
04-23 13:24:46.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 32450
04-23 13:24:46.361+0200 I/utils   (32450): specific action
04-23 13:24:46.361+0200 I/recorder(32450): obteniendo datos locales...
04-23 13:24:46.361+0200 I/recorder(32450): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:28:927,9.487542,-1.392623,1.198804
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:116,9.162118,-1.014557,2.553142
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:316,9.269794,-1.581656,3.036492
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:529,4.744967,-3.160919,0.689133
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:726,7.326823,6.326623,7.405786
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:925,2.557927,-1.868794,10.518847
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:127,2.105684,-3.110669,9.676575
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:337,1.641476,-3.962514,9.379865
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:535,1.313660,-4.878965,8.999406
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:745,1.375873,-4.522435,9.018548
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:938,1.464408,-4.472186,8.930015
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:138,1.552942,-4.390830,8.669197
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:341,1.567299,-4.139583,8.908479
04-23 13:24:46.361+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:545,1.550549,-4.630112,9.030513
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:774,1.581656,-4.424329,8.965906
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:954,1.648655,-4.319045,8.733803
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:32:145,1.452443,-4.524827,8.853443
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:32:346,1.526621,-4.402793,8.688338
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:32:544,1.507478,-4.474578,8.836694
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:32:744,1.576870,-4.309474,8.915657
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:32:945,1.557728,-4.319045,8.819944
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:33:142,1.576870,-4.357330,8.659625
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:33:347,1.543371,-4.304688,8.810372
04-23 13:24:46.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:24:46.371+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:24:46.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6289
04-23 13:24:46.371+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:24:46.371+0200 E/AUL     ( 7375): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:33:545,1.691726,-3.811767,9.059227
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:33:746,1.799403,-3.280560,9.389436
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:33:944,1.586441,-3.201597,9.432507
04-23 13:24:46.371+0200 I/recorder(32450): obteniendo datos locales es.ugr.frailty.accelerometer
04-23 13:24:46.371+0200 I/recorder(32450): obteniendo datos locales, DATA: SM-R760,23/04/2018,13:24:28:927,9.487542,-1.392623,1.198804
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:116,9.162118,-1.014557,2.553142
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:316,9.269794,-1.581656,3.036492
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:529,4.744967,-3.160919,0.689133
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:726,7.326823,6.326623,7.405786
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:925,2.557927,-1.868794,10.518847
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:127,2.105684,-3.110669,9.676575
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:337,1.641476,-3.962514,9.379865
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:535,1.313660,-4.878965,8.999406
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:745,1.375873,-4.522435,9.018548
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:938,1.464408,-4.472186,8.930015
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:138,1.552942,-4.390830,8.669197
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:341,1.567299,-4.139583,8.908479
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:545,1.550549,-4.630112,9.030513
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:774,1.581656,-4.424329,8.965906
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:954,1.648655,-4.319045,8.733803
04-23 13:24:46.371+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:32:145
04-23 13:24:46.371+0200 W/AUL     (32450): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:24:46.371+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(32450)
04-23 13:24:46.371+0200 I/servicemanager(30617): request sent to service es.ugr.frailty.recorder
04-23 13:24:46.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:46.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(32450), cmd(0)
04-23 13:24:46.381+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:46.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 32450
04-23 13:24:46.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30617
04-23 13:24:46.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:24:46.411+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 13:24:46.411+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 13:24:46.421+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7374
04-23 13:24:46.421+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6289
04-23 13:24:46.421+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6289)
04-23 13:24:46.421+0200 E/RESOURCED( 2551): proc-main.c: proc_app_list_remove_app_info(669) > Failed to remove appinfo 'es.ugr.frailty.heartrate': Not a directory
04-23 13:24:46.421+0200 W/AUL     (32450): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30617)
04-23 13:24:46.421+0200 I/recorder(32450): request sent to service es.ugr.frailty.servicemanager
04-23 13:24:46.431+0200 E/CAPI_APPFW_APPLICATION( 7374): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:24:46.431+0200 E/CAPI_APPFW_APPLICATION( 7374): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:24:46.431+0200 I/recorder(32450): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 13:24:46.431+0200 I/utils   ( 7374): trying to start service: es.ugr.frailty.accelerometer
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:115,37.450001,-13.930000,-0.980000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:316,10.990000,0.140000,18.620001
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:589,44.240002,104.019997,206.500000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:729,684.599976,114.800003,-22.260000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:29:932,-36.750000,17.430000,2.380000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:126,-97.720001,-2.380000,11.900000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:339,-30.380001,3.780000,4.410000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:528,-22.540001,1.190000,5.530000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:739,-2.730000,-0.910000,0.490000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:30:937,4.900000,-3.290000,-0.700000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:138,2.940000,0.350000,-2.100000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:380,1.330000,-3.430000,-2.380000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:541,-16.590000,0.490000,0.980000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:774,-2.870000,-1.680000,0.700000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:31:969,0.980000,-0.770000,0.210000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:32:140,1.260000,0.840000,0.770000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:32:341,1.330000,0.700000,-0.560000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:32:544,0.070000,0.280000,-0.490000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:32:744,0.350000,0.280000,-0.350000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:32:945,-2.310000,0.210000,-0.770000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:33:142,0.140000,0.490000,-0.770000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:33:342,0.140000,0.070000,0.420000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:33:544,48.299999,0.630000,-5.810000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:33:751,12.880000,-0.350000,-3.500000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:33:933,-3.570000,1.540000,0.350000
04-23 13:24:46.431+0200 I/recorder(32450): SM-R760,23/04/2018,13:24:34:133,-0.210000,0.140000,-0.140000
04-23 13:24:46.431+0200 W/CAPI_APPFW_APP_CONTROL(30617): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:24:46.431+0200 I/utils   ( 7374): es.ugr.frailty.accelerometer sensor supported
04-23 13:24:46.431+0200 I/utils   (30617): specific action
04-23 13:24:46.441+0200 W/CAPI_APPFW_APP_CONTROL(30617): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:24:46.441+0200 W/CAPI_APPFW_APP_CONTROL(30617): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:24:46.441+0200 W/CAPI_APPFW_APP_CONTROL(30617): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:24:46.441+0200 W/CAPI_APPFW_APP_CONTROL(30617): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:24:46.441+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:24:46.451+0200 I/utils   ( 7374): es.ugr.frailty.accelerometer listener started
04-23 13:24:46.451+0200 I/accelerometer( 7374): stopping es.ugr.frailty.accelerometer service
04-23 13:24:46.451+0200 E/CAPI_APPFW_APP_CONTROL( 7374): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:24:46.451+0200 E/accelerometer( 7374): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:24:46.451+0200 I/CAPI_APPFW_APPLICATION( 7374): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:24:46.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:24:46.471+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:46.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30617), cmd(0)
04-23 13:24:46.471+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (7374) was created
04-23 13:24:46.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:24:46.481+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7374
04-23 13:24:46.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:24:46.491+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 30617
04-23 13:24:46.501+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 30620
04-23 13:24:46.501+0200 W/CAPI_APPFW_APP_CONTROL(30620): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:24:46.501+0200 I/utils   (30620): specific action
04-23 13:24:46.501+0200 W/CAPI_APPFW_APP_CONTROL(30620): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:24:46.501+0200 I/httppostreq(30620): requesting HTTP POST Request Service. Service ID: es.ugr.frailty.accelerometer Data received: SM-R760,23/04/2018,13:24:28:927,9.487542,-1.392623,1.198804
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:29:116,9.162118,-1.014557,2.553142
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:29:316,9.269794,-1.581656,3.036492
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:29:529,4.744967,-3.160919,0.689133
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:29:726,7.326823,6.326623,7.405786
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:29:925,2.557927,-1.868794,10.518847
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:30:127,2.105684,-3.110669,9.676575
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:30:337,1.641476,-3.962514,9.379865
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:30:535,1.313660,-4.878965,8.999406
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:30:745,1.375873,-4.522435,9.018548
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:30:938,1.464408,-4.472186,8.930015
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:31:138,1.552942,-4.390830,8.669197
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:31:341,1.567299,-4.139583,8.908479
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:31:545,1.550549,-4.630112,9.030513
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:31:774,1.581656,-4.424329,8.965906
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:31:9
04-23 13:24:46.501+0200 I/httppostreq(30620): HTTP POST data service=es.ugr.frailty.accelerometer&data=SM-R760,23/04/2018,13:24:28:927,9.487542,-1.392623,1.198804
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:29:116,9.162118,-1.014557,2.553142
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:29:316,9.269794,-1.581656,3.036492
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:29:529,4.744967,-3.160919,0.689133
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:29:726,7.326823,6.326623,7.405786
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:29:925,2.557927,-1.868794,10.518847
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:30:127,2.105684,-3.110669,9.676575
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:30:337,1.641476,-3.962514,9.379865
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:30:535,1.313660,-4.878965,8.999406
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:30:745,1.375873,-4.522435,9.018548
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:30:938,1.464408,-4.472186,8.930015
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:31:138,1.552942,-4.390830,8.669197
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:31:341,1.567299,-4.139583,8.908479
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:31:545,1.550549,-4.630112,9.030513
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:31:774,1.581656,-4.424329,8.965906
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R760,23/04/2018,13:24:31:954,1.648655,-4.319045,8.733803
04-23 13:24:46.501+0200 I/httppostreq(30620): SM-R76
04-23 13:24:46.501+0200 W/AUL     (30617): launch.c: app_request_to_launchpad(298) > request cmd(0) result(30620)
04-23 13:24:46.501+0200 I/servicemanager(30617): request sent to service es.ugr.frailty.httppostreq
04-23 13:24:46.501+0200 I/servicemanager(30617): obteniendo datos locales. Datos recibidos
04-23 13:24:46.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:24:46.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:24:46.511+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:24:46.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(30620), cmd(0)
04-23 13:24:46.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:24:46.591+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 13:24:46.591+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 13:24:46.601+0200 W/AUL     ( 7391): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 13:24:46.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:24:46.621+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 13:24:46.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 32450
04-23 13:24:46.621+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:24:46.621+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 32450
04-23 13:24:46.621+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(32450)
04-23 13:24:46.681+0200 W/AUL     (30620): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:24:46.681+0200 W/CRASH_MANAGER( 7390): worker.c: worker_job(1205) > 1132450726563152448268
