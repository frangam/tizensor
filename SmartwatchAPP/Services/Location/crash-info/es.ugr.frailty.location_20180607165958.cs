S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14053
Date: 2018-06-07 16:59:58+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf705052d, r5   = 0xf74e6f98
r6   = 0xff995e40, r7   = 0xff995cf0
r8   = 0xf74e3c18, r9   = 0x00000000
r10  = 0xff995dcc, fp   = 0xff995e40
ip   = 0x00000001, sp   = 0xff995cc8
lr   = 0xf7050539, pc   = 0xf70b9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     84556 KB
Buffers:      7004 KB
Cached:      44748 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11508 KB
VmRSS:       11504 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14053 TID = 14053
14053 14057 

Maps Information
f3f1b000 f471a000 rw-p [stack:14057]
f4721000 f4723000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f472b000 f472f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4738000 f473a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4742000 f4745000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4754000 f4759000 r-xp /usr/lib/libsystem.so.0.0.0
f4764000 f4767000 r-xp /lib/libattr.so.1.1.0
f476f000 f477f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4787000 f4790000 r-xp /usr/lib/libedbus.so.1.7.99
f4798000 f4799000 r-xp /usr/lib/libresponse.so.0.2.96
f47a2000 f47a7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6049000 f614f000 r-xp /usr/lib/libicuuc.so.57.1
f6165000 f62ed000 r-xp /usr/lib/libicui18n.so.57.1
f62fd000 f630a000 r-xp /usr/lib/libail.so.0.1.0
f6313000 f631a000 r-xp /usr/lib/libminizip.so.1.0.0
f6323000 f64cc000 r-xp /usr/lib/libcrypto.so.1.0.0
f64ec000 f6533000 r-xp /usr/lib/libssl.so.1.0.0
f653f000 f6541000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6549000 f6550000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6559000 f6560000 r-xp /lib/libcrypt-2.13.so
f6591000 f6594000 r-xp /lib/libcap.so.2.21
f659c000 f659e000 r-xp /usr/lib/libiri.so
f65a6000 f65ef000 r-xp /usr/lib/libmdm.so.1.2.69
f65f7000 f65fd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6605000 f6628000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6632000 f6634000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f663c000 f6659000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6662000 f6666000 r-xp /usr/lib/libsmack.so.1.0.0
f666f000 f6688000 r-xp /usr/lib/libnetwork.so.0.0.0
f6691000 f6699000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66a1000 f66a7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66b0000 f66b2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66bb000 f66cb000 r-xp /lib/libresolv-2.13.so
f66cf000 f66e7000 r-xp /usr/lib/liblzma.so.5.0.3
f66f0000 f66f2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f66fa000 f6714000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f671c000 f674b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6754000 f6763000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f676d000 f6777000 r-xp /usr/lib/libsensord-shared.so
f6780000 f6853000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f685e000 f6874000 r-xp /lib/libz.so.1.2.5
f687c000 f6881000 r-xp /usr/lib/libffi.so.5.0.10
f6889000 f688a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6892000 f68a2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68aa000 f68c3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f68cb000 f68cd000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f68d5000 f694a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6954000 f695a000 r-xp /lib/librt-2.13.so
f6963000 f6981000 r-xp /usr/lib/libsystemd.so.0.4.0
f698b000 f698c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6994000 f69b7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f69bf000 f69c4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69cc000 f69f6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f69ff000 f6a16000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a1e000 f6a87000 r-xp /lib/libm-2.13.so
f6a90000 f6b24000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b37000 f6b3c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b44000 f6b4b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b53000 f6b7d000 r-xp /usr/lib/libsensor.so.1.9.6
f6b86000 f6c52000 r-xp /usr/lib/libxml2.so.2.7.8
f6c5f000 f6c61000 r-xp /usr/lib/libiniparser.so.0
f6c6a000 f6c70000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c79000 f6d49000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d4a000 f6d7e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d87000 f6dc3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6dcb000 f6dce000 r-xp /usr/lib/libbundle.so.0.1.22
f6dd6000 f6ddc000 r-xp /usr/lib/libappsvc.so.0.1.0
f6de4000 f6e25000 r-xp /usr/lib/libeina.so.1.7.99
f6e2e000 f6e45000 r-xp /usr/lib/libecore.so.1.7.99
f6e5c000 f6e65000 r-xp /usr/lib/libvconf.so.0.2.45
f6e6d000 f6e81000 r-xp /lib/libpthread-2.13.so
f6e8c000 f6e99000 r-xp /usr/lib/libaul.so.0.1.0
f6ea3000 f6ea5000 r-xp /lib/libdl-2.13.so
f6eae000 f6eb9000 r-xp /lib/libunwind.so.8.0.1
f6ee6000 f6eee000 r-xp /lib/libgcc_s-4.6.so.1
f6eef000 f7013000 r-xp /lib/libc-2.13.so
f7021000 f7023000 r-xp /usr/lib/libdlog.so.0.0.0
f702b000 f7037000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7040000 f7045000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f704d000 f705c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7064000 f7068000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7071000 f7074000 r-xp /usr/lib/libappcore-agent.so.1.1
f707c000 f707e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7086000 f708a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7092000 f70af000 r-xp /lib/ld-2.13.so
f70b8000 f70bb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70bb000 f70bf000 r-xp /usr/lib/libsys-assert.so
f74b3000 f7521000 rw-p [heap]
ff977000 ff998000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14053)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf70b9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7050539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d573f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d55c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6d61e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6d67be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6d67dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6d9c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6d971f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d55c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6d61e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6d67be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6d67dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6d99e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6d9a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6da1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47391fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf472c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf67ff663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cacfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6cae7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e3eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e39b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e3a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e3a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7072183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70727fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70b95c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6f0685c) [/lib/libc.so.6] + 0x1785c
29: (0xf70b8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
er)
06-07 16:59:57.711+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:57.711+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:57.711+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:57.721+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:57:724,2.266003,-1.074377,9.521042
06-07 16:59:57.721+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:57.721+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14069
06-07 16:59:57.731+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14069)
06-07 16:59:57.731+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 16:59:57.731+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:57.731+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 16:59:57.731+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:59:57.731+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:57.731+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:57:732,2.450000,6.510000,-1.330000
06-07 16:59:57.731+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:57.731+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:57.741+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:57:745,4.060000,6.300000,-0.350000
06-07 16:59:57.741+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13929
06-07 16:59:57.741+0200 W/CAPI_APPFW_APP_CONTROL(14069): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:57.751+0200 I/utils   (14069): specific action
06-07 16:59:57.751+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:57.751+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13929)
06-07 16:59:57.751+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 16:59:57.751+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:57.751+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:57.751+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14069), cmd(0)
06-07 16:59:57.751+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 16:59:57.751+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:59:57.751+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:57.751+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:712,0.236195,0.222732,-0.344234
06-07 16:59:57.751+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:57.751+0200 W/CAPI_APPFW_APP_CONTROL(13929): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:57.751+0200 I/utils   (13929): specific action
06-07 16:59:57.751+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:57.761+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:761,0.070468,0.125029,0.038877
06-07 16:59:57.761+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:57.761+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12595
06-07 16:59:57.761+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:768,-0.082481,-0.108039,0.100595
06-07 16:59:57.761+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:57.761+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13929), cmd(0)
06-07 16:59:57.761+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12595)
06-07 16:59:57.761+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 16:59:57.761+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:57.761+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 16:59:57.761+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:59:57.771+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:57.771+0200 W/CAPI_APPFW_APP_CONTROL(12595): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:57.771+0200 I/utils   (12595): specific action
06-07 16:59:57.771+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:57.771+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:57.771+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:776,0.095576,-0.079444,0.383525
06-07 16:59:57.771+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:57.781+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:783,0.025790,-0.228436,0.069892
06-07 16:59:57.781+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14053
06-07 16:59:57.781+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:57.781+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:57.781+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12595), cmd(0)
06-07 16:59:57.791+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14053)
06-07 16:59:57.791+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:57.791+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 16:59:57.791+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:57.791+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 16:59:57.791+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:59:57.791+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:57.791+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:57.791+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:57:796,4.130000,4.830000,-1.400000
06-07 16:59:57.791+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:57.801+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:57.801+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 13943
06-07 16:59:57.801+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:57:806,784.000000
06-07 16:59:57.801+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:57.801+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(14053), cmd(0)
06-07 16:59:57.801+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:57:791,84
06-07 16:59:57.811+0200 W/CAPI_APPFW_APP_CONTROL(14053): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:57.811+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(13943)
06-07 16:59:57.811+0200 W/CAPI_APPFW_APP_CONTROL(13943): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:57.811+0200 I/utils   (13943): specific action
06-07 16:59:57.811+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:57.811+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:57.811+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13943), cmd(0)
06-07 16:59:57.811+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:59:57.811+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:57.811+0200 I/utils   (14053): specific action
06-07 16:59:57.811+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:816,0.079937,-0.232191,0.287236
06-07 16:59:57.811+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:57:802,-0.210000,3.710000,-0.980000
06-07 16:59:57.811+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:57.811+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:57:756,2.098505,-1.292124,9.588040
06-07 16:59:57.821+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:57.821+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:57.821+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:57:826,2.251646,-1.256232,9.877571
06-07 16:59:57.821+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 16:59:57.821+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:59:57.821+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:57.821+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:826,0.159474,-0.180998,0.245531
06-07 16:59:57.821+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:57.831+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:57:824,0.490000,3.710000,-0.210000
06-07 16:59:57.831+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:57.831+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:57.841+0200 W/AUL_AMD ( 2479): amd_launch.c: start_process(606) > child process: 14114
06-07 16:59:57.841+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 3
06-07 16:59:57.841+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:57:838,2.800000,-1.400000,-1.190000
06-07 16:59:57.841+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:57.851+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:841,0.000695,-0.052844,0.174639
06-07 16:59:57.851+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:57.851+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:57:858,5.110000,-3.150000,-1.470000
06-07 16:59:57.861+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:57.861+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:867,0.032732,0.027936,0.084397
06-07 16:59:57.861+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:57.871+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:57:873,6.580000,-3.990000,-1.890000
06-07 16:59:57.871+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:57.871+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:881,0.132513,0.133774,-0.054062
06-07 16:59:57.881+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:57.881+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:57:887,7.070000,-3.570000,-2.170000
06-07 16:59:57.881+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:57:851,2.165504,-1.395016,9.568897
06-07 16:59:57.881+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:57.891+0200 E/CAPI_APPFW_APPLICATION(14114): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 16:59:57.891+0200 E/CAPI_APPFW_APPLICATION(14114): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-07 16:59:57.891+0200 W/AUL_AMD ( 2479): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 14114
06-07 16:59:57.891+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(14114) type(svcapp) bg(0)
06-07 16:59:57.891+0200 W/AUL_AMD ( 2479): amd_status.c: __socket_monitor_cb(1277) > (14114) was created
06-07 16:59:57.891+0200 W/STARTER ( 2696): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [14114]
06-07 16:59:57.891+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14114)
06-07 16:59:57.891+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 16:59:57.891+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:57.891+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 16:59:57.891+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:59:57.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:57.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:57.901+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:57.901+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 16:59:57.911+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:57.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12603), cmd(0)
06-07 16:59:57.911+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:57.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 16:59:57.911+0200 I/utils   (12603): specific action
06-07 16:59:57.911+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 16:59:57.911+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 16:59:57.921+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14114
06-07 16:59:57.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 16:59:57.931+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14114
06-07 16:59:57.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 16:59:57.931+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:938,0.080079,0.164485,-0.022440
06-07 16:59:57.941+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:57.941+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14114
06-07 16:59:57.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 16:59:57.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 16:59:57.941+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:57.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 12
06-07 16:59:57.941+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:57:946,6.720000,-2.450000,-1.750000
06-07 16:59:57.941+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:57.941+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 16:59:57.941+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:59:57.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:57.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:57.951+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:57:895,2.213361,-1.406980,9.786645
06-07 16:59:57.951+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:57.951+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:57:957,2.285146,-1.361516,9.745967
06-07 16:59:57.951+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:57.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12614
06-07 16:59:57.961+0200 I/utils   (14114): trying to start service: es.ugr.frailty.gravity
06-07 16:59:57.961+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:57.961+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12614), cmd(0)
06-07 16:59:57.961+0200 W/CAPI_APPFW_APP_CONTROL(12614): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:57.961+0200 I/utils   (12614): specific action
06-07 16:59:57.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12614)
06-07 16:59:57.961+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 16:59:57.961+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:57.961+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 16:59:57.961+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:59:57.961+0200 I/utils   (14114): es.ugr.frailty.gravity sensor supported
06-07 16:59:57.961+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:57.961+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:57.961+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:57:963,5.180000,-1.890000,-2.030000
06-07 16:59:57.971+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:57.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:59:57.971+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:57.971+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:57.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(12618), cmd(0)
06-07 16:59:57.971+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:57.971+0200 I/utils   (12618): specific action
06-07 16:59:57.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:59:57.971+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:59:57.971+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:57.971+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:951,0.144818,0.174589,-0.003965
06-07 16:59:57.981+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:57.981+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:57.981+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:57:988,84
06-07 16:59:57.981+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:57:982,2.129612,-1.234696,9.674182
06-07 16:59:57.991+0200 I/utils   (14114): es.ugr.frailty.gravity listener started
06-07 16:59:57.991+0200 W/CAPI_APPFW_APP_CONTROL(14114): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:57.991+0200 I/utils   (14114): specific action
06-07 16:59:57.991+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:992,0.191184,0.148584,-0.101543
06-07 16:59:57.991+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:57:983,3.500000,-0.070000,-2.170000
06-07 16:59:57.991+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:57.991+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:57.991+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:57:998,0.166085,0.121981,0.115317
06-07 16:59:57.991+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.001+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.001+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:58.001+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:7,2.133764,-1.048959,9.514049
06-07 16:59:58.001+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:3,0.169634,0.167577,0.110001
06-07 16:59:58.001+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:58:8,792.000000
06-07 16:59:58.001+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.001+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.011+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:13,0.104726,0.138256,0.115568
06-07 16:59:58.011+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:57:999,2.158326,-1.146162,9.585647
06-07 16:59:58.011+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.011+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.011+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.011+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:21,2.140378,-1.041026,9.513434
06-07 16:59:58.021+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:19,2.256432,-1.026521,9.449257
06-07 16:59:58.021+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.021+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:28,2.206182,-0.976272,9.482756
06-07 16:59:58.021+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.031+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:33,2.268396,-0.945165,9.504292
06-07 16:59:58.031+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.031+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.041+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:41,2.148061,-1.041736,9.511624
06-07 16:59:58.051+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:41,2.316252,-0.952343,9.408579
06-07 16:59:58.051+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.051+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:59:58.051+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:59:58.051+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:59:58.061+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:63,2.294717,-0.964308,9.626326
06-07 16:59:58.061+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.061+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:68,2.301895,-0.906880,9.621540
06-07 16:59:58.061+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.071+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:73,2.237289,-0.921237,9.628718
06-07 16:59:58.071+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.071+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:78,2.256432,-0.878166,9.492328
06-07 16:59:58.071+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.081+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:83,2.251646,-1.000200,9.473185
06-07 16:59:58.081+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.081+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:87,2.227718,-1.105484,9.609575
06-07 16:59:58.081+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.091+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:92,2.263610,-1.050449,9.585647
06-07 16:59:58.091+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.091+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:14,2.450000,-0.770000,-1.960000
06-07 16:59:58.091+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.101+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:22,0.122668,0.170793,-0.021721
06-07 16:59:58.101+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:103,2.149870,-1.044461,9.510917
06-07 16:59:58.101+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.111+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.121+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.121+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:123,2.277967,-1.055235,9.621540
06-07 16:59:58.121+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:129,0.111268,0.040826,-0.040250
06-07 16:59:58.121+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:113,2.151100,-1.043098,9.510789
06-07 16:59:58.121+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.131+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.141+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:103,2.660000,0.560000,-1.540000
06-07 16:59:58.141+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.151+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:149,1.540000,-0.350000,-0.700000
06-07 16:59:58.151+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:134,0.079657,-0.063748,0.097951
06-07 16:59:58.151+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.151+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.171+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.171+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:160,0.113740,-0.005988,0.074730
06-07 16:59:58.171+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:136,2.152654,-1.041650,9.510595
06-07 16:59:58.171+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.181+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:58.181+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:58:189,84
06-07 16:59:58.181+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:163,-0.140000,-0.420000,-0.630000
06-07 16:59:58.191+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.191+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:197,0.126868,-0.012137,0.110751
06-07 16:59:58.191+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.191+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:202,0.108563,0.017522,0.055910
06-07 16:59:58.201+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:58.201+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:58:208,793.000000
06-07 16:59:58.211+0200 W/LOCATION(14053): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:59:58.221+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:178,2.261217,-1.024128,9.566505
06-07 16:59:58.221+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.221+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:184,2.157421,-1.042094,9.509467
06-07 16:59:58.221+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.231+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:228,2.237289,-1.045663,9.602397
06-07 16:59:58.231+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.241+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:233,-1.400000,0.210000,-0.630000
06-07 16:59:58.241+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.241+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:243,2.160967,-1.043324,9.508527
06-07 16:59:58.241+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.241+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.251+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:248,-0.280000,0.560000,0.070000
06-07 16:59:58.251+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.251+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:253,2.237289,-1.012164,9.595219
06-07 16:59:58.251+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.261+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.261+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:267,0.079868,-0.003569,0.092930
06-07 16:59:58.261+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.261+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:251,2.162121,-1.040911,9.508529
06-07 16:59:58.261+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.271+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:265,2.268396,-0.988236,9.535398
06-07 16:59:58.271+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.271+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:260,0.350000,0.980000,0.210000
06-07 16:59:58.271+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:275,2.167860,-1.039948,9.507328
06-07 16:59:58.281+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.281+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:279,2.287539,-1.057628,9.547362
06-07 16:59:58.281+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.281+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:286,2.174810,-1.043824,9.505315
06-07 16:59:58.281+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.281+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.291+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:272,0.076322,0.031160,0.086692
06-07 16:59:58.291+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.291+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:297,0.106275,0.052675,0.026870
06-07 16:59:58.291+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.291+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:293,2.177418,-1.047640,9.504298
06-07 16:59:58.291+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.301+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:303,2.177528,-1.049534,9.504064
06-07 16:59:58.301+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:293,0.350000,1.050000,-0.280000
06-07 16:59:58.301+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.301+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.301+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:310,-0.980000,0.630000,-0.140000
06-07 16:59:58.301+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.311+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:289,2.232504,-1.093520,9.533006
06-07 16:59:58.311+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.311+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:312,2.178071,-1.051735,9.503696
06-07 16:59:58.311+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.311+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:317,2.206182,-1.069592,9.611969
06-07 16:59:58.311+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.321+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:324,2.191825,-1.076770,9.595219
06-07 16:59:58.321+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:322,2.176905,-1.049716,9.504187
06-07 16:59:58.321+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.321+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.321+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:302,0.119679,-0.017680,0.040034
06-07 16:59:58.331+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.331+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:315,-0.840000,0.280000,0.070000
06-07 16:59:58.331+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:336,0.057693,-0.049696,0.027691
06-07 16:59:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:59:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:59:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:59:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:59:58.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390798343,000000, pattern:[H:mm][0;m
06-07 16:59:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:59:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:59:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:59:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:59:58.331+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:59:58.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:59][0;m
06-07 16:59:58.331+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.341+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:333,2.176863,-1.050035,9.504161
06-07 16:59:58.341+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.341+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:331,2.230111,-1.067199,9.631111
06-07 16:59:58.341+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.341+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:349,0.280000,0.140000,0.700000
06-07 16:59:58.341+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:351,2.246860,-1.134198,9.552148
06-07 16:59:58.341+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.351+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.351+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:357,0.028764,-0.021952,0.107671
06-07 16:59:58.351+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:348,2.176559,-1.048788,9.504369
06-07 16:59:58.351+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.351+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.361+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.361+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:367,0.014297,-0.027236,0.091155
06-07 16:59:58.361+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.361+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:364,2.177262,-1.043677,9.504770
06-07 16:59:58.361+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:365,-0.700000,-0.210000,0.700000
06-07 16:59:58.371+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.371+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:355,2.232504,-1.098306,9.542577
06-07 16:59:58.371+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.371+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.371+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:377,2.277967,-1.043271,9.537791
06-07 16:59:58.371+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.381+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:383,2.222932,-0.983450,9.590433
06-07 16:59:58.381+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.381+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:58.381+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:376,2.173903,-1.035028,9.506484
06-07 16:59:58.381+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.381+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:58:389,84
06-07 16:59:58.381+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:372,0.052039,-0.015464,0.127415
06-07 16:59:58.381+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:385,-1.540000,0.210000,0.910000
06-07 16:59:58.391+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.391+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:390,2.170969,-1.024921,9.508250
06-07 16:59:58.391+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:387,2.227718,-0.928415,9.693325
06-07 16:59:58.391+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.391+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:396,0.069956,-0.084482,0.047961
06-07 16:59:58.401+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:403,-0.770000,0.350000,0.840000
06-07 16:59:58.401+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.401+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:58.401+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:58:408,795.000000
06-07 16:59:58.401+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:409,2.170161,-1.016573,9.509331
06-07 16:59:58.411+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.411+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.411+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:415,2.210968,-0.928415,9.607183
06-07 16:59:58.411+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.421+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:419,-0.770000,0.630000,0.490000
06-07 16:59:58.421+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:422,2.171782,-1.008383,9.509832
06-07 16:59:58.421+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.421+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:427,0.055640,-0.048270,0.038416
06-07 16:59:58.421+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.421+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.431+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.431+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:434,-0.770000,0.350000,-0.070000
06-07 16:59:58.431+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.431+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.441+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:443,2.173528,-1.004715,9.509822
06-07 16:59:58.441+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:434,2.246860,-0.914058,9.513863
06-07 16:59:58.441+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.441+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:445,0.840000,0.350000,-0.490000
06-07 16:59:58.441+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:438,0.101408,0.005517,0.033422
06-07 16:59:58.441+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.451+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.451+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:456,1.400000,0.210000,-1.050000
06-07 16:59:58.451+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.461+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:464,2.174288,-1.003342,9.509793
06-07 16:59:58.461+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.461+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:450,2.234896,-0.983450,9.482756
06-07 16:59:58.461+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.461+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:470,1.330000,0.210000,-1.330000
06-07 16:59:58.461+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:471,2.249253,-1.028914,9.533006
06-07 16:59:58.471+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:458,0.045671,0.060227,0.085663
06-07 16:59:58.471+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.471+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.471+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.481+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:483,2.173316,-1.002820,9.510070
06-07 16:59:58.481+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.481+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:480,1.960000,0.140000,-1.540000
06-07 16:59:58.481+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.481+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:488,2.242075,-1.060020,9.521042
06-07 16:59:58.491+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:478,0.053815,0.106613,0.186841
06-07 16:59:58.491+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.491+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:493,2.310000,0.280000,-1.400000
06-07 16:59:58.491+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:58:498,0.040000,0.096506,0.098933
06-07 16:59:58.491+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.491+0200 I/linearacceleration(13943): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:58.501+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.501+0200 E/RESOURCED( 2560): cgroup.c: cgroup_get_pids(425) > Failed to open '/sys/fs/cgroup/freezer/frozen/cgroup.procs': Not a directory
06-07 16:59:58.501+0200 E/RESOURCED( 2560): freezer-process.c: freezer_check_all_suspend_process(251) > Failed to get cgroup pids: Not a directory
06-07 16:59:58.501+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.511+0200 W/AUL_AMD ( 2479): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-07 16:59:58.511+0200 I/gravity (14114): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:58:511,2.174800,-1.002148,9.509802
06-07 16:59:58.511+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:505,1.750000,0.280000,-1.260000
06-07 16:59:58.511+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.511+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:58:508,2.270789,-1.040878,9.549755
06-07 16:59:58.521+0200 I/gravity (14114): es.ugr.frailty.gravity - capturing data
06-07 16:59:58.521+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:525,1.470000,-0.350000,-1.260000
06-07 16:59:58.521+0200 I/accelerometer(14069): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:58.531+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.541+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:544,1.540000,-0.490000,-0.910000
06-07 16:59:58.541+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:58.551+0200 I/gyroscope(13929): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:58:551,1.190000,-0.350000,-0.840000
06-07 16:59:58.551+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11140536c6f63152838359
