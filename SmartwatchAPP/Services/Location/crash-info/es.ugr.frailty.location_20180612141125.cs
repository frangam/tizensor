S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 10763
Date: 2018-06-12 14:11:25+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf733852d, r5   = 0xf7510fe0
r6   = 0xfff31e20, r7   = 0xfff31cd0
r8   = 0xf74e2c18, r9   = 0x00000000
r10  = 0xfff31dac, fp   = 0xfff31e20
ip   = 0x00000001, sp   = 0xfff31ca8
lr   = 0xf7338539, pc   = 0xf73a1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    174080 KB
Buffers:     31668 KB
Cached:     141660 KB
VmPeak:      53504 KB
VmSize:      53440 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11908 KB
VmRSS:       11904 KB
VmData:      11168 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 10763 TID = 10763
10763 10765 

Maps Information
f4203000 f4a02000 rw-p [stack:10765]
f4a09000 f4a0b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a13000 f4a17000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a20000 f4a22000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a2a000 f4a2d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a3c000 f4a41000 r-xp /usr/lib/libsystem.so.0.0.0
f4a4c000 f4a4f000 r-xp /lib/libattr.so.1.1.0
f4a57000 f4a67000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a6f000 f4a78000 r-xp /usr/lib/libedbus.so.1.7.99
f4a80000 f4a81000 r-xp /usr/lib/libresponse.so.0.2.96
f4a8a000 f4a8f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6331000 f6437000 r-xp /usr/lib/libicuuc.so.57.1
f644d000 f65d5000 r-xp /usr/lib/libicui18n.so.57.1
f65e5000 f65f2000 r-xp /usr/lib/libail.so.0.1.0
f65fb000 f6602000 r-xp /usr/lib/libminizip.so.1.0.0
f660b000 f67b4000 r-xp /usr/lib/libcrypto.so.1.0.0
f67d4000 f681b000 r-xp /usr/lib/libssl.so.1.0.0
f6827000 f6829000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6831000 f6838000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6841000 f6848000 r-xp /lib/libcrypt-2.13.so
f6879000 f687c000 r-xp /lib/libcap.so.2.21
f6884000 f6886000 r-xp /usr/lib/libiri.so
f688e000 f68d7000 r-xp /usr/lib/libmdm.so.1.2.69
f68df000 f68e5000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68ed000 f6910000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f691a000 f691c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6924000 f6941000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f694a000 f694e000 r-xp /usr/lib/libsmack.so.1.0.0
f6957000 f6970000 r-xp /usr/lib/libnetwork.so.0.0.0
f6979000 f6981000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6989000 f698f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6998000 f699a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69a3000 f69b3000 r-xp /lib/libresolv-2.13.so
f69b7000 f69cf000 r-xp /usr/lib/liblzma.so.5.0.3
f69d8000 f69da000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69e2000 f69fc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a04000 f6a33000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a3c000 f6a4b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a55000 f6a5f000 r-xp /usr/lib/libsensord-shared.so
f6a68000 f6b3b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b46000 f6b5c000 r-xp /lib/libz.so.1.2.5
f6b64000 f6b69000 r-xp /usr/lib/libffi.so.5.0.10
f6b71000 f6b72000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b7a000 f6b8a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b92000 f6bab000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6bb3000 f6bb5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bbd000 f6c32000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c3c000 f6c42000 r-xp /lib/librt-2.13.so
f6c4b000 f6c69000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c73000 f6c74000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c7c000 f6c9f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ca7000 f6cac000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cb4000 f6cde000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6ce7000 f6cfe000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d06000 f6d6f000 r-xp /lib/libm-2.13.so
f6d78000 f6e0c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e1f000 f6e24000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e2c000 f6e33000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e3b000 f6e65000 r-xp /usr/lib/libsensor.so.1.9.6
f6e6e000 f6f3a000 r-xp /usr/lib/libxml2.so.2.7.8
f6f47000 f6f49000 r-xp /usr/lib/libiniparser.so.0
f6f52000 f6f58000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f61000 f7031000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7032000 f7066000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f706f000 f70ab000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70b3000 f70b6000 r-xp /usr/lib/libbundle.so.0.1.22
f70be000 f70c4000 r-xp /usr/lib/libappsvc.so.0.1.0
f70cc000 f710d000 r-xp /usr/lib/libeina.so.1.7.99
f7116000 f712d000 r-xp /usr/lib/libecore.so.1.7.99
f7144000 f714d000 r-xp /usr/lib/libvconf.so.0.2.45
f7155000 f7169000 r-xp /lib/libpthread-2.13.so
f7174000 f7181000 r-xp /usr/lib/libaul.so.0.1.0
f718b000 f718d000 r-xp /lib/libdl-2.13.so
f7196000 f71a1000 r-xp /lib/libunwind.so.8.0.1
f71ce000 f71d6000 r-xp /lib/libgcc_s-4.6.so.1
f71d7000 f72fb000 r-xp /lib/libc-2.13.so
f7309000 f730b000 r-xp /usr/lib/libdlog.so.0.0.0
f7313000 f731f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7328000 f732d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7335000 f7344000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f734c000 f7350000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7359000 f735c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7364000 f7366000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f736e000 f7372000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f737a000 f7397000 r-xp /lib/ld-2.13.so
f73a0000 f73a3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f73a3000 f73a7000 r-xp /usr/lib/libsys-assert.so
f74dc000 f7549000 rw-p [heap]
fff13000 fff34000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10763)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf73a1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7338539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf703f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf703dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7049e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf704fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf704fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf708475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf707f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf703dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7049e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf704fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf704fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7081e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7082017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7089f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a211fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a14171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6ae7663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f94fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f967a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7126ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7121b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71225a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7122879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf735a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf735a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73a15c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf71ee85c) [/lib/libc.so.6] + 0x1785c
29: (0xf73a0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: location
App ID: es.ugr.frailty.location
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
1:23.651+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:23.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:23.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
06-12 14:11:23.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:11:23.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(58) , send fd(15), pid(10705), cmd(0)
06-12 14:11:23.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:11:23.681+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10769
06-12 14:11:23.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:23.691+0200 I/heartrate(10750): es.ugr.frailty.heartrate - capturing data
06-12 14:11:23.691+0200 I/heartrate(10750): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:23.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:23.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:23.711+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:11:23.711+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 10784
06-12 14:11:23.761+0200 E/CAPI_APPFW_APPLICATION(10784): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:11:23.761+0200 E/CAPI_APPFW_APPLICATION(10784): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:11:23.761+0200 I/utils   (10784): trying to start service: es.ugr.frailty.pedometer
06-12 14:11:23.761+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 10784
06-12 14:11:23.761+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pedometer) pid(10784) type(svcapp) bg(0)
06-12 14:11:23.771+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [10784]
06-12 14:11:23.771+0200 I/utils   (10784): es.ugr.frailty.pedometer sensor supported
06-12 14:11:23.771+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:23.771+0200 I/utils   (10784): es.ugr.frailty.pedometer listener started
06-12 14:11:23.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:23.781+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10784)
06-12 14:11:23.781+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.pedometer
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.781+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.791+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:23.801+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:23.811+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:23.811+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:23.811+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:23.821+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:23:822,-0.070000,-0.280000,-0.070000
06-12 14:11:23.821+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:23.821+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:23.831+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:23.831+0200 I/servicemanager( 9467): es.ugr.frailty.accelerometer sleep timeout
06-12 14:11:23.831+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-12 14:11:23.831+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (10784) was created
06-12 14:11:23.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:11:23.851+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9474) cmd(0)
06-12 14:11:23.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:23.871+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:23.881+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:23.891+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:23.891+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:23.891+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:23.891+0200 I/heartrate(10750): es.ugr.frailty.heartrate - capturing data
06-12 14:11:23.891+0200 I/heartrate(10750): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:23.891+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:23.901+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:23:896,0.031626,0.003361,-0.052186
06-12 14:11:23.901+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:23.911+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:23.911+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:11:23.921+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:23.931+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:23.931+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:23.931+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:11:23.931+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:23.931+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:23:935,0.147611,0.018772,9.805521
06-12 14:11:23.931+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:23.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
06-12 14:11:23.951+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-12 14:11:23.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 10654
06-12 14:11:23.961+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-12 14:11:23.961+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:23.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:23.971+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:23.981+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:23.991+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:23.991+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:23.991+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:11:24.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:11:24.021+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 10654
06-12 14:11:24.021+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(10654)
06-12 14:11:24.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:24.061+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:24.071+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:11:24:2,0.071785,-0.105284,10.104890
06-12 14:11:24.071+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:24.071+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:24.071+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:24.081+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.081+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:24:79,-0.070000,-0.280000,-0.070000
06-12 14:11:24.081+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.091+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.101+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.101+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:24.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9474
06-12 14:11:24.131+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:11:24.131+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:11:24.131+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:11:24.141+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9474)
06-12 14:11:24.141+0200 I/heartrate(10750): es.ugr.frailty.heartrate - capturing data
06-12 14:11:24.141+0200 I/heartrate(10750): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:24.151+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.accelerometer
06-12 14:11:24.151+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.151+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.151+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.151+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.161+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.161+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10784
06-12 14:11:24.181+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.181+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.191+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.191+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.191+0200 I/utils   ( 9467): specific action
06-12 14:11:24.191+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.191+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.gyroscope
06-12 14:11:24.191+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:11:24.201+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.211+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:24.211+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:24.231+0200 E/CAPI_TELEPHONY( 9545): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:11:24.231+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.241+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:24.241+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:24.241+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:24.241+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:24:247,-0.134800,-0.128288,0.251724
06-12 14:11:24.241+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.251+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:11:24.261+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:24.281+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:24.281+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:24.281+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:11:24.281+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.281+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:24:286,0.150600,0.021849,9.805470
06-12 14:11:24.281+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.301+0200 I/heartrate(10750): es.ugr.frailty.heartrate - capturing data
06-12 14:11:24.301+0200 I/heartrate(10750): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:24.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.301+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:24.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:24.321+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:24.321+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:24.321+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:24.331+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:24:332,-0.070000,-0.210000,-0.070000
06-12 14:11:24.331+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:24.361+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:24.371+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:24.371+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:24.381+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:11:24.381+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.381+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:11:24:384,0.157926,0.066999,9.982857
06-12 14:11:24.381+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:11:24.411+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 10784
06-12 14:11:24.411+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9477) cmd(0)
06-12 14:11:24.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:11:24.441+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.461+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:24.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:11:24.481+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.481+0200 I/utils   ( 9470): specific action
06-12 14:11:24.481+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.481+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.481+0200 I/recorder( 9470): saving local data for es.ugr.frailty.gyroscope
06-12 14:11:24.481+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
06-12 14:11:24.501+0200 I/heartrate(10750): es.ugr.frailty.heartrate - capturing data
06-12 14:11:24.501+0200 I/heartrate(10750): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:24.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.511+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:24.521+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:24.541+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.551+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:11:24.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(69) , send fd(15), pid(9470), cmd(0)
06-12 14:11:24.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.571+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:11:24.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:24.591+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.601+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:11:24.601+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:11:24.601+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:11:24.601+0200 I/servicemanager( 9467): es.ugr.frailty.gyroscope sleep timeout
06-12 14:11:24.601+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-12 14:11:24.601+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:24.601+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:24.601+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:11:24.611+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:24.611+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:24.611+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:24.621+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:24:609,0.148901,0.021879,9.805495
06-12 14:11:24.621+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.621+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:24:614,-0.052830,0.232878,-0.308177
06-12 14:11:24.621+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.621+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:24.631+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:24.641+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:24.641+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:24.641+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:24.641+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:24:648,-0.070000,-0.210000,-0.070000
06-12 14:11:24.641+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.661+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:24.671+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:24.681+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:24.681+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:24.681+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:11:24.681+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:11:24:686,0.095713,-0.023928,9.994821
06-12 14:11:24.681+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.691+0200 I/heartrate(10750): es.ugr.frailty.heartrate - capturing data
06-12 14:11:24.691+0200 I/heartrate(10750): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:24.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:11:24.711+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.721+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:24.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9477
06-12 14:11:24.741+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9477)
06-12 14:11:24.741+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.gyroscope
06-12 14:11:24.741+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.741+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.741+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.741+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.741+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.741+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.741+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.741+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.741+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.741+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.741+0200 I/utils   ( 9467): specific action
06-12 14:11:24.741+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.741+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.741+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.741+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.741+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.741+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.741+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.741+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.light
06-12 14:11:24.751+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:11:24.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.761+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:11:24.771+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:24.781+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:24.781+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:24.781+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:11:24.781+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:24:788,0.148511,0.021867,9.805501
06-12 14:11:24.781+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.781+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:11:24.781+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(106) , send fd(15), pid(9467), cmd(0)
06-12 14:11:24.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.811+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:24.821+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:24.831+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:24.831+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:24.831+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:24.841+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:24:837,-0.090405,-0.025756,0.077276
06-12 14:11:24.841+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.851+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.851+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:24.861+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:24.871+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:24.871+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:24.871+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:24.871+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.871+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:11:24:876,-0.070000,-0.280000,-0.070000
06-12 14:11:24.871+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.891+0200 I/heartrate(10750): es.ugr.frailty.heartrate - capturing data
06-12 14:11:24.891+0200 I/heartrate(10750): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:24.891+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:24.901+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:24.911+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:24.911+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:24.911+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:11:24.921+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:24.931+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:11:24:924,0.224925,-0.153141,10.112068
06-12 14:11:24.931+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:24.941+0200 W/LOCATION(10763): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:11:24.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:24.951+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:24.961+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:11:24.961+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.961+0200 I/utils   ( 9470): specific action
06-12 14:11:24.961+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.961+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.961+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.961+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.961+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.961+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.961+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.961+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.961+0200 I/recorder( 9470): saving local data for es.ugr.frailty.light
06-12 14:11:24.961+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 14:11:24.971+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:11:24.971+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:11:24.971+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:11:24.971+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.981+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:11:24.981+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.981+0200 I/utils   ( 9467): specific action
06-12 14:11:24.981+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.981+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.981+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.981+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.981+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:11:24.981+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.gravity
06-12 14:11:24.981+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:11:24.981+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:25.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:25.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:11:25.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:25.031+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:25.031+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:25.031+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:11:25.041+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:11:25:41,0.148346,0.023666,9.805499
06-12 14:11:25.041+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:25.041+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:25.051+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:11:25.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(76) , send fd(15), pid(9470), cmd(0)
06-12 14:11:25.071+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:25.071+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:25.081+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:25.091+0200 I/heartrate(10750): es.ugr.frailty.heartrate - capturing data
06-12 14:11:25.091+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:25.091+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:25.091+0200 I/heartrate(10750): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:11:25.101+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:25.101+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:11:25.111+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:11:25:109,0.073914,-0.079712,0.039003
06-12 14:11:25.111+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:11:25.121+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:11:25.121+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:11:25.121+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:11:25.141+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:25.141+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:11:25.151+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:25.171+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:25.171+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:25.171+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:25.171+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:11:25.181+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-12 14:11:25.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:25.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:11:25.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:25.221+0200 W/AUL     (10804): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-12 14:11:25.221+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:25.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-12 14:11:25.221+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
06-12 14:11:25.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:11:25.221+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-12 14:11:25.221+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-12 14:11:25.221+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
06-12 14:11:25.221+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
06-12 14:11:25.221+0200 E/CAPI_LOCATION_MANAGER( 9545): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-12 14:11:25.221+0200 W/gpsd    ( 3103): HandleIncomingMessage() dest id:0, msg id:2
06-12 14:11:25.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:25.251+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:11:25.251+0200 I/SECURE_STORAGE( 2497): ss_server_ipc.c: SsServerComm(251) > write succeed
06-12 14:11:25.261+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:11:25.281+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:25.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:25.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:11:25.291+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:25.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:25.321+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:11:25.331+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:11:25.331+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:11:25.341+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:25.341+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:11:25.341+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:11:25.351+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:11:25.361+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:11:25.361+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:11:25.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:11:25.391+0200 I/CAPI_NETWORK_CONNECTION( 9545): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
06-12 14:11:25.391+0200 I/CAPI_NETWORK_CONNECTION( 9545): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
06-12 14:11:25.391+0200 I/CAPI_NETWORK_CONNECTION( 9545): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
06-12 14:11:25.391+0200 I/CAPI_NETWORK_CONNECTION( 9545): connection.c: connection_destroy(471) > Destroy handle: 0xf7a294d8
06-12 14:11:25.391+0200 W/CRASH_MANAGER(10805): worker.c: worker_job(1205) > 11107636c6f63152880548
