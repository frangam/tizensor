S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20877
Date: 2018-06-07 17:23:52+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf735052d, r5   = 0xf789f958
r6   = 0xffeda080, r7   = 0xffed9f30
r8   = 0xf78b2c18, r9   = 0x00000000
r10  = 0xffeda00c, fp   = 0xffeda080
ip   = 0x00000001, sp   = 0xffed9f08
lr   = 0xf7350539, pc   = 0xf73b9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    277396 KB
Buffers:     15140 KB
Cached:     107708 KB
VmPeak:      52416 KB
VmSize:      52412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11700 KB
VmRSS:       11696 KB
VmData:      10140 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20877 TID = 20877
20877 20979 

Maps Information
f421b000 f4a1a000 rw-p [stack:20979]
f4a21000 f4a23000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a2b000 f4a2f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a38000 f4a3a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a42000 f4a45000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a54000 f4a59000 r-xp /usr/lib/libsystem.so.0.0.0
f4a64000 f4a67000 r-xp /lib/libattr.so.1.1.0
f4a6f000 f4a7f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a87000 f4a90000 r-xp /usr/lib/libedbus.so.1.7.99
f4a98000 f4a99000 r-xp /usr/lib/libresponse.so.0.2.96
f4aa2000 f4aa7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6349000 f644f000 r-xp /usr/lib/libicuuc.so.57.1
f6465000 f65ed000 r-xp /usr/lib/libicui18n.so.57.1
f65fd000 f660a000 r-xp /usr/lib/libail.so.0.1.0
f6613000 f661a000 r-xp /usr/lib/libminizip.so.1.0.0
f6623000 f67cc000 r-xp /usr/lib/libcrypto.so.1.0.0
f67ec000 f6833000 r-xp /usr/lib/libssl.so.1.0.0
f683f000 f6841000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6849000 f6850000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6859000 f6860000 r-xp /lib/libcrypt-2.13.so
f6891000 f6894000 r-xp /lib/libcap.so.2.21
f689c000 f689e000 r-xp /usr/lib/libiri.so
f68a6000 f68ef000 r-xp /usr/lib/libmdm.so.1.2.69
f68f7000 f68fd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6905000 f6928000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6932000 f6934000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f693c000 f6959000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6962000 f6966000 r-xp /usr/lib/libsmack.so.1.0.0
f696f000 f6988000 r-xp /usr/lib/libnetwork.so.0.0.0
f6991000 f6999000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f69a1000 f69a7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69b0000 f69b2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f69bb000 f69cb000 r-xp /lib/libresolv-2.13.so
f69cf000 f69e7000 r-xp /usr/lib/liblzma.so.5.0.3
f69f0000 f69f2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69fa000 f6a14000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a1c000 f6a4b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a54000 f6a63000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a6d000 f6a77000 r-xp /usr/lib/libsensord-shared.so
f6a80000 f6b53000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b5e000 f6b74000 r-xp /lib/libz.so.1.2.5
f6b7c000 f6b81000 r-xp /usr/lib/libffi.so.5.0.10
f6b89000 f6b8a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b92000 f6ba2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6baa000 f6bc3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6bcb000 f6bcd000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bd5000 f6c4a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c54000 f6c5a000 r-xp /lib/librt-2.13.so
f6c63000 f6c81000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c8b000 f6c8c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c94000 f6cb7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6cbf000 f6cc4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ccc000 f6cf6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cff000 f6d16000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d1e000 f6d87000 r-xp /lib/libm-2.13.so
f6d90000 f6e24000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e37000 f6e3c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e44000 f6e4b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e53000 f6e7d000 r-xp /usr/lib/libsensor.so.1.9.6
f6e86000 f6f52000 r-xp /usr/lib/libxml2.so.2.7.8
f6f5f000 f6f61000 r-xp /usr/lib/libiniparser.so.0
f6f6a000 f6f70000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f79000 f7049000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f704a000 f707e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7087000 f70c3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70cb000 f70ce000 r-xp /usr/lib/libbundle.so.0.1.22
f70d6000 f70dc000 r-xp /usr/lib/libappsvc.so.0.1.0
f70e4000 f7125000 r-xp /usr/lib/libeina.so.1.7.99
f712e000 f7145000 r-xp /usr/lib/libecore.so.1.7.99
f715c000 f7165000 r-xp /usr/lib/libvconf.so.0.2.45
f716d000 f7181000 r-xp /lib/libpthread-2.13.so
f718c000 f7199000 r-xp /usr/lib/libaul.so.0.1.0
f71a3000 f71a5000 r-xp /lib/libdl-2.13.so
f71ae000 f71b9000 r-xp /lib/libunwind.so.8.0.1
f71e6000 f71ee000 r-xp /lib/libgcc_s-4.6.so.1
f71ef000 f7313000 r-xp /lib/libc-2.13.so
f7321000 f7323000 r-xp /usr/lib/libdlog.so.0.0.0
f732b000 f7337000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7340000 f7345000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f734d000 f735c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7364000 f7368000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7371000 f7374000 r-xp /usr/lib/libappcore-agent.so.1.1
f737c000 f737e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7386000 f738a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7392000 f73af000 r-xp /lib/ld-2.13.so
f73b8000 f73bb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f73bb000 f73bf000 r-xp /usr/lib/libsys-assert.so
f7882000 f78f4000 rw-p [heap]
ffebb000 ffedc000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20877)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf73b9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7350539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70573f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7055c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7061e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7067be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7067dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf709c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70971f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7055c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7061e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7067be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7067dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7099e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf709a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70a1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a391fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a2c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6aff663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6facfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6fae7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf713eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7139b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf713a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf713a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7372183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73727fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73b95c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf720685c) [/lib/libc.so.6] + 0x1785c
29: (0xf73b8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
equest sending failed!
06-07 17:26:00.451+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:00.451+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:26:00.451+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:26:00.461+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:00.461+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:00.471+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:468,0.140000,0.070000,0.140000
06-07 17:26:00.471+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.481+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:485,0.070000,0.070000,0.070000
06-07 17:26:00.491+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:00.491+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:00.491+0200 E/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sending failed!
06-07 17:26:00.491+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:00.491+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:26:00.491+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:26:00.491+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.491+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:499,0.140000,0.070000,0.070000
06-07 17:26:00.501+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.511+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:508,0.140000,-0.070000,0.070000
06-07 17:26:00.511+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.521+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:00.521+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:518,0.140000,-0.070000,0.070000
06-07 17:26:00.531+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:00.531+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:00.531+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:00.531+0200 E/servicemanager(20992): es.ugr.frailty.gravity launch request sending failed!
06-07 17:26:00.531+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:00.531+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:26:00.531+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:26:00.531+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.531+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:00.531+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:00.541+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:539,0.070000,-0.070000,0.070000
06-07 17:26:00.541+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.541+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:00.551+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:550,0.070000,-0.070000,0.070000
06-07 17:26:00.551+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:00.551+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:00.551+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:00.551+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.551+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:00.551+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:00.551+0200 E/servicemanager(20992): es.ugr.frailty.pressure launch request sending failed!
06-07 17:26:00.551+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:00.551+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:26:00.551+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:26:00.561+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:564,0.070000,-0.070000,0.070000
06-07 17:26:00.561+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.571+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:581,0.140000,-0.070000,0.070000
06-07 17:26:00.571+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.581+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:00.581+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:00.591+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:00.591+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:00.591+0200 E/servicemanager(20992): es.ugr.frailty.light launch request sending failed!
06-07 17:26:00.591+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:00.591+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:26:00.591+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:26:00.591+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:585,0.140000,-0.070000,0.140000
06-07 17:26:00.591+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.591+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:598,0.070000,-0.070000,0.070000
06-07 17:26:00.601+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:00.601+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:00.601+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.611+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:613,0.070000,-0.070000,0.140000
06-07 17:26:00.611+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.611+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:00.611+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:00.611+0200 E/servicemanager(20992): es.ugr.frailty.pedometer launch request sending failed!
06-07 17:26:00.611+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:00.621+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:620,0.070000,-0.070000,0.140000
06-07 17:26:00.621+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.631+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:634,0.070000,-0.070000,0.140000
06-07 17:26:00.631+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.641+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:643,0.140000,-0.070000,0.070000
06-07 17:26:00.641+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.661+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:00.661+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:00.661+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:00:670,741.000000
06-07 17:26:00.661+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:650,0.070000,-0.070000,0.070000
06-07 17:26:00.671+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.671+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:00.701+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:706,0.070000,-0.070000,0.140000
06-07 17:26:00.731+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.731+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:736,0.140000,-0.070000,0.070000
06-07 17:26:00.731+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.741+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:750,0.070000,-0.070000,0.070000
06-07 17:26:00.741+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.751+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:755,-0.070000,-0.070000,0.140000
06-07 17:26:00.751+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.761+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:764,0.140000,-0.070000,0.070000
06-07 17:26:00.771+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.771+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:00.781+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:00.791+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:776,0.140000,-0.070000,0.070000
06-07 17:26:00.801+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:00.801+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:00.861+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:00.861+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:00.861+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:00:865,0.070000,-0.070000,0.070000
06-07 17:26:00.871+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:00:866,739.000000
06-07 17:26:00.891+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:00.891+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:01.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:01.011+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:01.041+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:01.041+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:01.051+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:01.051+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:01.051+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:01:55,741.000000
06-07 17:26:01.061+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:01:56,0.070000,-0.070000,0.070000
06-07 17:26:01.111+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:01.121+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:01.151+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:01.151+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:01.221+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:01.231+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:01.231+0200 E/PKGMGR_SERVER(21495): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:26:01.241+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:01.251+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:01.251+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:01:255,741.000000
06-07 17:26:01.261+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:01:256,0.140000,-0.070000,-0.070000
06-07 17:26:01.331+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:01.341+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:01.351+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:01.351+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:01.441+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:01.451+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:01.451+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:01.461+0200 I/AUL     (21515): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
06-07 17:26:01.491+0200 I/AUL     (21515): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:01.501+0200 E/CAPI_APPFW_APPLICATION(21515): app_error.c: app_error(64) > [app_get_id] INVALID_CONTEXT(0xfef00001) : failed to get the application ID
06-07 17:26:01.511+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:01.521+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:01:521,0.140000,-0.070000,-0.070000
06-07 17:26:01.541+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:01:461,742.000000
06-07 17:26:01.551+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:01.551+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:01.561+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:01.571+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:01.651+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:01.651+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:01.661+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:01:661,0.070000,-0.070000,-0.070000
06-07 17:26:01.661+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:01:656,742.000000
06-07 17:26:01.671+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:01.681+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:01.691+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:01.711+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:01.711+0200 E/AUL     (20785): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-07 17:26:01.711+0200 E/AUL     (20785): aul_path.c: __get_path(169) > root_path is NULL!
06-07 17:26:01.731+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:01.751+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:01.751+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:01.751+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:01.761+0200 E/AUL     (20785): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-07 17:26:01.761+0200 E/AUL     (20785): aul_path.c: __get_path(169) > root_path is NULL!
06-07 17:26:01.781+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:01.791+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:01.791+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:01.801+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:01.811+0200 E/AUL     (20785): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-07 17:26:01.811+0200 E/AUL     (20785): aul_path.c: __get_path(169) > root_path is NULL!
06-07 17:26:01.831+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:01.851+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:01.851+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:01.851+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:01:860,743.000000
06-07 17:26:01.851+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:01:857,0.140000,-0.070000,-0.070000
06-07 17:26:01.881+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:01.881+0200 E/AUL     (20785): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-07 17:26:01.881+0200 E/AUL     (20785): aul_path.c: __get_path(169) > root_path is NULL!
06-07 17:26:01.891+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:01.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:01.911+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:01.921+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:01.931+0200 E/AUL     (20785): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-07 17:26:01.931+0200 E/AUL     (20785): aul_path.c: __get_path(169) > root_path is NULL!
06-07 17:26:01.941+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:01.971+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:01.971+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:01.971+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:01.971+0200 E/AUL     (20785): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-07 17:26:01.971+0200 E/AUL     (20785): aul_path.c: __get_path(169) > root_path is NULL!
06-07 17:26:01.981+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:02.001+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:02.001+0200 E/AUL     (20785): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-07 17:26:02.001+0200 E/AUL     (20785): aul_path.c: __get_path(169) > root_path is NULL!
06-07 17:26:02.011+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:02.021+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:02.041+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:02.051+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:02.051+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:02.061+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:02:60,0.140000,-0.070000,0.140000
06-07 17:26:02.061+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:02:62,743.000000
06-07 17:26:02.081+0200 I/AUL     (20785): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
06-07 17:26:02.101+0200 E/AUL     (20785): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
06-07 17:26:02.101+0200 E/AUL     (20785): aul_path.c: __get_path(169) > root_path is NULL!
06-07 17:26:02.121+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:02.131+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:02.151+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:02.151+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:02.241+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:02.251+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:02.251+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:02.251+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:02.261+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:02:262,744.000000
06-07 17:26:02.271+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:02:261,0.070000,-0.070000,0.070000
06-07 17:26:02.291+0200 I/UXT     (20785): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
06-07 17:26:02.351+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:02.361+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:02.381+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:02.381+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:02.441+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer alive timeout
06-07 17:26:02.441+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:26:02.441+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:02.441+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:02.441+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:02.441+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:02.441+0200 E/servicemanager(20992): es.ugr.frailty.accelerometer launch request sending failed!
06-07 17:26:02.441+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:02.441+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope alive timeout
06-07 17:26:02.441+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:26:02.441+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:02.451+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:02.451+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:02.451+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:02.451+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:02:460,0.070000,-0.070000,0.070000
06-07 17:26:02.461+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:02.461+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:02.461+0200 E/servicemanager(20992): es.ugr.frailty.gyroscope launch request sending failed!
06-07 17:26:02.461+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:02.461+0200 I/servicemanager(20992): es.ugr.frailty.heartrate alive timeout
06-07 17:26:02.461+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:26:02.461+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:02.461+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:02.471+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:02.481+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:02.481+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:02.481+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:02.481+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:02:465,744.000000
06-07 17:26:02.481+0200 E/servicemanager(20992): es.ugr.frailty.heartrate launch request sending failed!
06-07 17:26:02.481+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:02.481+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:26:02.481+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:26:02.491+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:02.491+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:02.491+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:02.491+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:02.491+0200 E/servicemanager(20992): es.ugr.frailty.location launch request sending failed!
06-07 17:26:02.491+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:02.491+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:26:02.491+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:26:02.491+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:02.501+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:02.501+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:02.501+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:02.501+0200 E/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sending failed!
06-07 17:26:02.501+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:02.501+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:26:02.501+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:26:02.501+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:02.501+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:02.511+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:02.511+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:02.511+0200 E/servicemanager(20992): es.ugr.frailty.gravity launch request sending failed!
06-07 17:26:02.511+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:02.511+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:26:02.511+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:26:02.511+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:02.511+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:02.521+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:02.521+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:02.521+0200 E/servicemanager(20992): es.ugr.frailty.pressure launch request sending failed!
06-07 17:26:02.521+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:02.521+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:26:02.521+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:26:02.531+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:02.531+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:02.531+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:02.531+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:02.531+0200 E/servicemanager(20992): es.ugr.frailty.light launch request sending failed!
06-07 17:26:02.531+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:02.531+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:26:02.531+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:26:02.531+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:02.541+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:02.541+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:02.541+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:02.541+0200 E/servicemanager(20992): es.ugr.frailty.pedometer launch request sending failed!
06-07 17:26:02.541+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:02.551+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:02.551+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:02.581+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:02.591+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:02.661+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:02.661+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:02.661+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:02:667,744.000000
06-07 17:26:02.661+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:02:667,0.070000,-0.070000,0.070000
06-07 17:26:02.691+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:02.701+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:02.751+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:02.751+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:02.811+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:02.811+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:02.851+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:02.851+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:02.861+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:02:858,0.070000,-0.070000,0.070000
06-07 17:26:02.861+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:02:858,745.000000
06-07 17:26:02.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:02.931+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:02.951+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:02.951+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:03.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:03.041+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:03.051+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:03.051+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:03.061+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:03:58,746.000000
06-07 17:26:03.071+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:03:58,0.070000,-0.070000,0.070000
06-07 17:26:03.151+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:03.161+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:03.161+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:03.161+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:03.231+0200 E/PKGMGR_SERVER(21495): pkgmgr-server.c: exit_server(1619) > exit_server Start [backend_status=0, queue_status=1] 
06-07 17:26:03.251+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:03.251+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:03.251+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:03:258,0.070000,-0.070000,0.070000
06-07 17:26:03.261+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:03.271+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:03.281+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:03:265,746.000000
06-07 17:26:03.351+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:03.351+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:03.371+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:03.381+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:03.451+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:03.451+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:03.451+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:03:457,746.000000
06-07 17:26:03.461+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:03:457,0.070000,-0.070000,0.140000
06-07 17:26:03.491+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:03.501+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:03.551+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:03.551+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:03.601+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:03.611+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:03.651+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:03.651+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:03.671+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:03:662,748.000000
06-07 17:26:03.671+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:03:662,0.070000,-0.070000,0.070000
06-07 17:26:03.711+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:03.721+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:03.751+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:03.751+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:03.821+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:03.831+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:03.851+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:03.851+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:03.861+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:03:863,750.000000
06-07 17:26:03.861+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:03:863,0.210000,-0.070000,0.070000
06-07 17:26:03.941+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:03.951+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:03.951+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:03.951+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:04.051+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:04.051+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:04.061+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:04.061+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:04.061+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:04:72,763.000000
06-07 17:26:04.071+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:04:76,0.210000,-0.070000,0.070000
06-07 17:26:04.151+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:04.151+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:04.161+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:04.171+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:04.251+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:04.251+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:04.261+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:04:262,0.070000,-0.070000,0.070000
06-07 17:26:04.261+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:04:263,756.000000
06-07 17:26:04.271+0200 I/servicemanager(20992): es.ugr.frailty.accelerometer alive timeout
06-07 17:26:04.271+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:26:04.281+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:04.291+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:04.291+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:04.291+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:04.291+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:04.291+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:04.291+0200 E/servicemanager(20992): es.ugr.frailty.accelerometer launch request sending failed!
06-07 17:26:04.291+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:04.291+0200 I/servicemanager(20992): es.ugr.frailty.gyroscope alive timeout
06-07 17:26:04.291+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:26:04.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:04.301+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:04.301+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:04.301+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:04.301+0200 E/servicemanager(20992): es.ugr.frailty.gyroscope launch request sending failed!
06-07 17:26:04.301+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:04.301+0200 I/servicemanager(20992): es.ugr.frailty.heartrate alive timeout
06-07 17:26:04.301+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:26:04.301+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:04.311+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:04.311+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:04.311+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:04.311+0200 E/servicemanager(20992): es.ugr.frailty.heartrate launch request sending failed!
06-07 17:26:04.311+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:04.311+0200 I/servicemanager(20992): es.ugr.frailty.location alive timeout
06-07 17:26:04.311+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:26:04.311+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:04.311+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:04.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:04.321+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:04.321+0200 E/servicemanager(20992): es.ugr.frailty.location launch request sending failed!
06-07 17:26:04.321+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:04.321+0200 I/servicemanager(20992): es.ugr.frailty.linearacceleration alive timeout
06-07 17:26:04.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:26:04.321+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:04.321+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:04.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:04.321+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:04.321+0200 E/servicemanager(20992): es.ugr.frailty.linearacceleration launch request sending failed!
06-07 17:26:04.321+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:04.321+0200 I/servicemanager(20992): es.ugr.frailty.gravity alive timeout
06-07 17:26:04.321+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:26:04.331+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:04.331+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:04.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:04.331+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:04.331+0200 E/servicemanager(20992): es.ugr.frailty.gravity launch request sending failed!
06-07 17:26:04.331+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:04.331+0200 I/servicemanager(20992): es.ugr.frailty.pressure alive timeout
06-07 17:26:04.331+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:26:04.331+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:04.331+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:04.341+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:04.341+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:04.341+0200 E/servicemanager(20992): es.ugr.frailty.pressure launch request sending failed!
06-07 17:26:04.341+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:04.341+0200 I/servicemanager(20992): es.ugr.frailty.light alive timeout
06-07 17:26:04.341+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:26:04.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:04.341+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:04.341+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:04.341+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:04.341+0200 E/servicemanager(20992): es.ugr.frailty.light launch request sending failed!
06-07 17:26:04.341+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:04.341+0200 I/servicemanager(20992): es.ugr.frailty.pedometer alive timeout
06-07 17:26:04.341+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:26:04.341+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:26:04.341+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 20992
06-07 17:26:04.351+0200 W/AUL     (20992): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-14)
06-07 17:26:04.351+0200 E/CAPI_APPFW_APP_CONTROL(20992): app_control.c: app_control_error(138) > [app_control_send_launch_request] LAUNCH_REJECTED(0xfef00023)
06-07 17:26:04.351+0200 E/servicemanager(20992): es.ugr.frailty.pedometer launch request sending failed!
06-07 17:26:04.351+0200 I/servicemanager(20992): App control destroyed.
06-07 17:26:04.351+0200 I/heartrate(21023): es.ugr.frailty.heartrate - capturing data
06-07 17:26:04.351+0200 I/heartrate(21023): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:26:04.391+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 14
06-07 17:26:04.401+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21418
06-07 17:26:04.451+0200 I/light   (21071): es.ugr.frailty.light - capturing data
06-07 17:26:04.461+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope - capturing data
06-07 17:26:04.461+0200 I/light   (21071): es.ugr.frailty.light: SM-R760,07/06/2018,17:26:04:461,694.000000
06-07 17:26:04.461+0200 I/gyroscope(21418): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:26:04:465,0.140000,-0.070000,0.070000
06-07 17:26:04.481+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11208776c6f63152838503
