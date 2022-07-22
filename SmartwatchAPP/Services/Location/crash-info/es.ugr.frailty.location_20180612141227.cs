S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11456
Date: 2018-06-12 14:12:27+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf756c52d, r5   = 0xf782c150
r6   = 0xffa80f60, r7   = 0xffa80e10
r8   = 0xf783ec18, r9   = 0x00000000
r10  = 0xffa80eec, fp   = 0xffa80f60
ip   = 0x00000001, sp   = 0xffa80de8
lr   = 0xf756c539, pc   = 0xf75d5228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    167080 KB
Buffers:     32024 KB
Cached:     144204 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11756 KB
VmRSS:       11752 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11456 TID = 11456
11456 11459 

Maps Information
f4437000 f4c36000 rw-p [stack:11459]
f4c3d000 f4c3f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c47000 f4c4b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c54000 f4c56000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c5e000 f4c61000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4c70000 f4c75000 r-xp /usr/lib/libsystem.so.0.0.0
f4c80000 f4c83000 r-xp /lib/libattr.so.1.1.0
f4c8b000 f4c9b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4ca3000 f4cac000 r-xp /usr/lib/libedbus.so.1.7.99
f4cb4000 f4cb5000 r-xp /usr/lib/libresponse.so.0.2.96
f4cbe000 f4cc3000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6565000 f666b000 r-xp /usr/lib/libicuuc.so.57.1
f6681000 f6809000 r-xp /usr/lib/libicui18n.so.57.1
f6819000 f6826000 r-xp /usr/lib/libail.so.0.1.0
f682f000 f6836000 r-xp /usr/lib/libminizip.so.1.0.0
f683f000 f69e8000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a08000 f6a4f000 r-xp /usr/lib/libssl.so.1.0.0
f6a5b000 f6a5d000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a65000 f6a6c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6a75000 f6a7c000 r-xp /lib/libcrypt-2.13.so
f6aad000 f6ab0000 r-xp /lib/libcap.so.2.21
f6ab8000 f6aba000 r-xp /usr/lib/libiri.so
f6ac2000 f6b0b000 r-xp /usr/lib/libmdm.so.1.2.69
f6b13000 f6b19000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b21000 f6b44000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b4e000 f6b50000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b58000 f6b75000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b7e000 f6b82000 r-xp /usr/lib/libsmack.so.1.0.0
f6b8b000 f6ba4000 r-xp /usr/lib/libnetwork.so.0.0.0
f6bad000 f6bb5000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bbd000 f6bc3000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6bcc000 f6bce000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bd7000 f6be7000 r-xp /lib/libresolv-2.13.so
f6beb000 f6c03000 r-xp /usr/lib/liblzma.so.5.0.3
f6c0c000 f6c0e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c16000 f6c30000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c38000 f6c67000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c70000 f6c7f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c89000 f6c93000 r-xp /usr/lib/libsensord-shared.so
f6c9c000 f6d6f000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d7a000 f6d90000 r-xp /lib/libz.so.1.2.5
f6d98000 f6d9d000 r-xp /usr/lib/libffi.so.5.0.10
f6da5000 f6da6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6dae000 f6dbe000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6dc6000 f6ddf000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6de7000 f6de9000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6df1000 f6e66000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e70000 f6e76000 r-xp /lib/librt-2.13.so
f6e7f000 f6e9d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ea7000 f6ea8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6eb0000 f6ed3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6edb000 f6ee0000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ee8000 f6f12000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f1b000 f6f32000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f3a000 f6fa3000 r-xp /lib/libm-2.13.so
f6fac000 f7040000 r-xp /usr/lib/libstdc++.so.6.0.16
f7053000 f7058000 r-xp /usr/lib/libctx-client.so.0.8.3
f7060000 f7067000 r-xp /usr/lib/libctx-shared.so.0.8.3
f706f000 f7099000 r-xp /usr/lib/libsensor.so.1.9.6
f70a2000 f716e000 r-xp /usr/lib/libxml2.so.2.7.8
f717b000 f717d000 r-xp /usr/lib/libiniparser.so.0
f7186000 f718c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7195000 f7265000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7266000 f729a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72a3000 f72df000 r-xp /usr/lib/libSLP-location.so.0.9.24
f72e7000 f72ea000 r-xp /usr/lib/libbundle.so.0.1.22
f72f2000 f72f8000 r-xp /usr/lib/libappsvc.so.0.1.0
f7300000 f7341000 r-xp /usr/lib/libeina.so.1.7.99
f734a000 f7361000 r-xp /usr/lib/libecore.so.1.7.99
f7378000 f7381000 r-xp /usr/lib/libvconf.so.0.2.45
f7389000 f739d000 r-xp /lib/libpthread-2.13.so
f73a8000 f73b5000 r-xp /usr/lib/libaul.so.0.1.0
f73bf000 f73c1000 r-xp /lib/libdl-2.13.so
f73ca000 f73d5000 r-xp /lib/libunwind.so.8.0.1
f7402000 f740a000 r-xp /lib/libgcc_s-4.6.so.1
f740b000 f752f000 r-xp /lib/libc-2.13.so
f753d000 f753f000 r-xp /usr/lib/libdlog.so.0.0.0
f7547000 f7553000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f755c000 f7561000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7569000 f7578000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7580000 f7584000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f758d000 f7590000 r-xp /usr/lib/libappcore-agent.so.1.1
f7598000 f759a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75a2000 f75a6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75ae000 f75cb000 r-xp /lib/ld-2.13.so
f75d4000 f75d7000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f75d7000 f75db000 r-xp /usr/lib/libsys-assert.so
f780e000 f787c000 rw-p [heap]
ffa62000 ffa83000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11456)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf75d5228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf756c539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72733f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7271c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf727de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7283be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7283dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72b875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72b31f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7271c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf727de57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7283be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7283dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72b5e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72b6017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72bdf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4c551fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c48171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d1b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71c8fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71ca7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf735aca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7355b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73565a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7356879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf758e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf758e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75d55c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf742285c) [/lib/libc.so.6] + 0x1785c
29: (0xf75d4f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.gyroscope - capturing data
06-12 14:12:25.861+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:12:25:862,-0.140000,-0.210000,-0.070000
06-12 14:12:25.861+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:25.861+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:25.861+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:12:25.861+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(62) , send fd(15), pid(9470), cmd(0)
06-12 14:12:25.881+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:25.881+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:12:25.881+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:25.891+0200 I/heartrate(11440): es.ugr.frailty.heartrate - capturing data
06-12 14:12:25.891+0200 I/heartrate(11440): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:25.901+0200 I/LOCATION(11456): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
06-12 14:12:25.901+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:25.901+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:25.901+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:12:25.901+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:12:25:904,0.083749,-0.009571,9.779467
06-12 14:12:25.901+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:25.901+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:25.921+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:25.921+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:12:25.931+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:25.941+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:25.941+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:25.941+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:12:25.941+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:12:25:948,0.019328,-0.131438,0.194014
06-12 14:12:25.941+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:25.951+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:25.961+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:25.961+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:12:25.971+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:25.971+0200 I/location(11456): es.ugr.frailty.location: waiting for rigth values
06-12 14:12:25.981+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:25.981+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:25.981+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:12:25.981+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:12:25:988,0.153205,0.032202,9.805400
06-12 14:12:25.981+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:25.991+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.001+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:12:26.011+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 10554
06-12 14:12:26.021+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(10554)
06-12 14:12:26.021+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.gravity
06-12 14:12:26.021+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:26.021+0200 I/servicemanager( 9467): es.ugr.frailty.pressure alive timeout
06-12 14:12:26.021+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-12 14:12:26.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.041+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:12:26.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:26.071+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:26.071+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:26.071+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:12:26.071+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:12:26:75,-0.140000,-0.210000,-0.070000
06-12 14:12:26.071+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:26.091+0200 I/heartrate(11440): es.ugr.frailty.heartrate - capturing data
06-12 14:12:26.091+0200 I/heartrate(11440): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:26.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.091+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:12:26.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:26.131+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:26.131+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:26.131+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:12:26.131+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:12:26.131+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:12:26.131+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:12:26.131+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.131+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:12:26:134,0.174676,0.016750,9.997212
06-12 14:12:26.131+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:26.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.151+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:12:26.161+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:26.181+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:26.181+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:26.181+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:12:26.181+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.181+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:12:26:184,0.027575,0.084703,0.035965
06-12 14:12:26.181+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:26.211+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.211+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:12:26.231+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:26.261+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.261+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.261+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:26.261+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:26.261+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:12:26.271+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:12:26:270,0.156885,0.037102,9.805325
06-12 14:12:26.271+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:26.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:12:26.291+0200 I/heartrate(11440): es.ugr.frailty.heartrate - capturing data
06-12 14:12:26.291+0200 I/heartrate(11440): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:26.291+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:12:26.291+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 11477
06-12 14:12:26.341+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11477
06-12 14:12:26.341+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pressure) pid(11477) type(svcapp) bg(0)
06-12 14:12:26.341+0200 E/CAPI_APPFW_APPLICATION(11477): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:12:26.341+0200 E/CAPI_APPFW_APPLICATION(11477): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:12:26.341+0200 I/utils   (11477): trying to start service: es.ugr.frailty.pressure
06-12 14:12:26.351+0200 I/utils   (11477): es.ugr.frailty.pressure sensor supported
06-12 14:12:26.351+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.371+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11477]
06-12 14:12:26.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:12:26.371+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11477)
06-12 14:12:26.371+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.pressure
06-12 14:12:26.371+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:26.371+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:26.381+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:26.381+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:26.381+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:26.381+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:26.381+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:26.381+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:26.381+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:26.381+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.381+0200 I/utils   ( 9467): specific action
06-12 14:12:26.381+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.381+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.381+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.381+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:26.391+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.391+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.391+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.391+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.light
06-12 14:12:26.391+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:12:26.391+0200 I/utils   (11477): es.ugr.frailty.pressure listener started
06-12 14:12:26.411+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:26.411+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:26.411+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:12:26.411+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (11477) was created
06-12 14:12:26.411+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
06-12 14:12:26.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.431+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:12:26.431+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:12:26:416,-0.140000,-0.350000,-0.070000
06-12 14:12:26.431+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:26.441+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:26.451+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:26.451+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:26.451+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:12:26.461+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:12:26:461,0.133998,0.021535,9.695717
06-12 14:12:26.461+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:26.461+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.481+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:12:26.491+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:26.501+0200 I/heartrate(11440): es.ugr.frailty.heartrate - capturing data
06-12 14:12:26.511+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.531+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:26.531+0200 I/heartrate(11440): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:26.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.531+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:12:26.541+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:26.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:26.541+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:12:26.551+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:26.561+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:26.561+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:12:26.561+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.571+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:12:26:553,-0.015166,-0.048525,0.205990
06-12 14:12:26.571+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:12:26:564,0.156271,0.038365,9.805329
06-12 14:12:26.571+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:26.571+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:26.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:12:26.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11477
06-12 14:12:26.591+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.611+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:12:26.621+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:12:26.641+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.641+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:12:26.641+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:12:26.641+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:12:26.641+0200 I/servicemanager( 9467): es.ugr.frailty.light alive timeout
06-12 14:12:26.641+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-12 14:12:26.641+0200 I/utils   ( 9470): specific action
06-12 14:12:26.641+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.641+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.651+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.651+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.651+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.651+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.651+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.651+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.651+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:26.651+0200 I/recorder( 9470): saving local data for es.ugr.frailty.light
06-12 14:12:26.651+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
06-12 14:12:26.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:12:26.671+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11477
06-12 14:12:26.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:12:26.681+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(38) , send fd(15), pid(9470), cmd(0)
06-12 14:12:26.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:12:26.711+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:26.731+0200 E/CAPI_TELEPHONY( 9545): telephony_common.c: telephony_init(358) > telephony feature is disabled
06-12 14:12:26.731+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:26.741+0200 I/heartrate(11440): es.ugr.frailty.heartrate - capturing data
06-12 14:12:26.741+0200 I/heartrate(11440): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:26.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.741+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:26.741+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:12:26.741+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:12:26.751+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:12:26:750,-0.140000,-0.140000,-0.070000
06-12 14:12:26.751+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:26.751+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:26.761+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:26.761+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:26.761+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:12:26.771+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:12:26:772,0.100499,0.088534,9.937392
06-12 14:12:26.771+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:26.771+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.791+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:12:26.801+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:26.811+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:26.811+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:26.811+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:12:26.811+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.811+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:12:26:817,0.156345,0.035292,9.805340
06-12 14:12:26.821+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:26.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.831+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:12:26.841+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:26.851+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:26.851+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:26.851+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:12:26.861+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:12:26:860,0.006619,0.042258,-0.050047
06-12 14:12:26.861+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:26.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:12:26.881+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.891+0200 I/heartrate(11440): es.ugr.frailty.heartrate - capturing data
06-12 14:12:26.891+0200 I/heartrate(11440): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:26.891+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:26.891+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:12:26.901+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:12:26.901+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 11502
06-12 14:12:26.951+0200 E/CAPI_APPFW_APPLICATION(11502): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:12:26.951+0200 E/CAPI_APPFW_APPLICATION(11502): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:12:26.951+0200 I/utils   (11502): trying to start service: es.ugr.frailty.light
06-12 14:12:26.951+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11502
06-12 14:12:26.951+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.light) pid(11502) type(svcapp) bg(0)
06-12 14:12:26.961+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11502)
06-12 14:12:26.961+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.light
06-12 14:12:26.961+0200 I/servicemanager( 9467): es.ugr.frailty.pedometer alive timeout
06-12 14:12:26.961+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-12 14:12:26.961+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11502]
06-12 14:12:26.961+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:26.961+0200 I/utils   (11502): es.ugr.frailty.light sensor supported
06-12 14:12:26.971+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:12:26.981+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:27.001+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (11502) was created
06-12 14:12:27.011+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:27.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:12:27.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:27.071+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:27.071+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:12:27.081+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:27.101+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:27.101+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:27.111+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:27.121+0200 I/heartrate(11440): es.ugr.frailty.heartrate - capturing data
06-12 14:12:27.121+0200 I/heartrate(11440): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:27.121+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:27.121+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:27.121+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:27.121+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:27.121+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:12:27.131+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:12:27.131+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf7586cb0), size(2752)
06-12 14:12:27.131+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-12 14:12:27.131+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
06-12 14:12:27.131+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:12:27.151+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:27.171+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:27.171+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:27.171+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:12:27.171+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:12:27:176,0.155946,0.032496,9.805356
06-12 14:12:27.171+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:27.181+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:12:27:139,-0.140000,-0.280000,-0.070000
06-12 14:12:27.181+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:12:27:134,0.186640,0.028714,9.717253
06-12 14:12:27.181+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:27.191+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:27.191+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:27.191+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:12:27.201+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:27.211+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:27.211+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:27.211+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:12:27.221+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9514) cmd(0)
06-12 14:12:27.221+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:27.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:27.251+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:12:27.261+0200 E/RESOURCED( 2582): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
06-12 14:12:27.261+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 11523
06-12 14:12:27.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 11523
06-12 14:12:27.311+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.pedometer) pid(11523) type(svcapp) bg(0)
06-12 14:12:27.321+0200 W/STARTER ( 2679): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [11523]
06-12 14:12:27.321+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:27.341+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11523)
06-12 14:12:27.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:12:27.351+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11502
06-12 14:12:27.351+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:27.351+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:27.351+0200 I/heartrate(11440): es.ugr.frailty.heartrate - capturing data
06-12 14:12:27.361+0200 I/heartrate(11440): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:27.361+0200 E/CAPI_APPFW_APPLICATION(11523): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:12:27.361+0200 E/CAPI_APPFW_APPLICATION(11523): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
06-12 14:12:27.361+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.pedometer
06-12 14:12:27.361+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.361+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.361+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.361+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.361+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.361+0200 I/utils   (11523): trying to start service: es.ugr.frailty.pedometer
06-12 14:12:27.371+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.371+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.371+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.371+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.371+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.371+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.371+0200 I/utils   (11523): es.ugr.frailty.pedometer sensor supported
06-12 14:12:27.371+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.381+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.381+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.381+0200 E/AUL     ( 9467): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-12 14:12:27.381+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:27.381+0200 I/utils   ( 9467): specific action
06-12 14:12:27.381+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:27.381+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:27.391+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:27.391+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:12:27.401+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:27.401+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:27.401+0200 W/CAPI_APPFW_APP_CONTROL( 9467): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:27.401+0200 I/servicemanager( 9467): requesting to save local data for es.ugr.frailty.gravity
06-12 14:12:27.401+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
06-12 14:12:27.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:27.411+0200 W/LOCATION(11456): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-12 14:12:27.421+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:27.421+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:27.421+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:27.421+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:12:27.431+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:12:27:223,-0.031180,0.052327,0.186872
06-12 14:12:27.431+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:27.431+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (11523) was created
06-12 14:12:27.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:27.451+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:12:27.451+0200 I/utils   (11502): es.ugr.frailty.light listener started
06-12 14:12:27.451+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:12:27:431,0.153317,0.025969,9.805417
06-12 14:12:27.451+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:27.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:27.461+0200 I/utils   (11523): es.ugr.frailty.pedometer listener started
06-12 14:12:27.471+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:27.471+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:27.471+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:12:27.481+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:12:27:481,0.184247,-0.035892,9.856036
06-12 14:12:27.481+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:27.481+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9477) cmd(0)
06-12 14:12:27.491+0200 I/heartrate(11440): es.ugr.frailty.heartrate - capturing data
06-12 14:12:27.491+0200 I/heartrate(11440): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:27.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
06-12 14:12:27.501+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:27.501+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:27.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:27.521+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9467
06-12 14:12:27.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9470
06-12 14:12:27.541+0200 I/light   (11502): es.ugr.frailty.light - capturing data
06-12 14:12:27.551+0200 I/light   (11502): es.ugr.frailty.light: SM-R760,12/06/2018,14:12:27:548,75.000000
06-12 14:12:27.551+0200 W/AUL     (11502): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:27.551+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9470)
06-12 14:12:27.551+0200 I/servicemanager( 9467): request sent to service es.ugr.frailty.recorder
06-12 14:12:27.551+0200 I/servicemanager( 9467): requesting to save local data
06-12 14:12:27.551+0200 I/servicemanager( 9467): es.ugr.frailty.gyroscope sleep timeout
06-12 14:12:27.551+0200 W/AUL     ( 9467): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-12 14:12:27.551+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:27.551+0200 I/utils   ( 9470): specific action
06-12 14:12:27.551+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:27.561+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:27.561+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:27.561+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:27.561+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:27.561+0200 W/CAPI_APPFW_APP_CONTROL( 9470): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-12 14:12:27.561+0200 I/recorder( 9470): saving local data for es.ugr.frailty.gravity
06-12 14:12:27.561+0200 I/recorder( 9470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
06-12 14:12:27.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
06-12 14:12:27.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 11502
06-12 14:12:27.591+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:27.601+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
06-12 14:12:27.601+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(65) , send fd(15), pid(9470), cmd(0)
06-12 14:12:27.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:27.621+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9477
06-12 14:12:27.621+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:27.631+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:27.631+0200 I/gyroscope( 9477): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:27.631+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope - capturing data
06-12 14:12:27.641+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:27.641+0200 I/gyroscope( 9477): es.ugr.frailty.gyroscope: SM-R760,12/06/2018,14:12:27:644,-0.070000,-0.280000,-0.070000
06-12 14:12:27.641+0200 W/AUL     ( 9477): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:27.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:27.651+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9514
06-12 14:12:27.661+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:27.671+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:27.671+0200 I/linearacceleration( 9514): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:27.671+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration - capturing data
06-12 14:12:27.681+0200 I/linearacceleration( 9514): es.ugr.frailty.linearacceleration: SM-R760,12/06/2018,14:12:27:682,0.073343,0.020658,0.107925
06-12 14:12:27.681+0200 W/AUL     ( 9514): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:27.681+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(9467) cmd(0)
06-12 14:12:27.691+0200 I/heartrate(11440): es.ugr.frailty.heartrate - capturing data
06-12 14:12:27.691+0200 I/heartrate(11440): es.ugr.frailty.heartrate: waiting for rigth values
06-12 14:12:27.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:27.701+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 10554
06-12 14:12:27.711+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:27.721+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:27.721+0200 I/gravity (10554): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:27.721+0200 I/gravity (10554): es.ugr.frailty.gravity - capturing data
06-12 14:12:27.721+0200 I/gravity (10554): es.ugr.frailty.gravity: SM-R760,12/06/2018,14:12:27:729,0.150444,0.026471,9.805460
06-12 14:12:27.721+0200 W/AUL     (10554): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:27.731+0200 E/AUL_AMD ( 2478): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(10554) cmd(0)
06-12 14:12:27.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
06-12 14:12:27.751+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 9474
06-12 14:12:27.761+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 9467
06-12 14:12:27.771+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(298) > request cmd(0) result(9467)
06-12 14:12:27.771+0200 I/accelerometer( 9474): request sent to service es.ugr.frailty.servicemanager
06-12 14:12:27.771+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer - capturing data
06-12 14:12:27.781+0200 I/accelerometer( 9474): es.ugr.frailty.accelerometer: SM-R760,12/06/2018,14:12:27:783,0.143569,0.019143,9.992428
06-12 14:12:27.781+0200 W/AUL     ( 9474): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
06-12 14:12:27.801+0200 W/CRASH_MANAGER(10805): worker.c: worker_job(1205) > 11114566c6f63152880554
