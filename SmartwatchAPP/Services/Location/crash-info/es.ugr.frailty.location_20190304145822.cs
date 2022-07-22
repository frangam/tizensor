S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 4317
Date: 2019-03-04 14:58:22+0100
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf740452d, r5   = 0xf7595150
r6   = 0xfffd5628, r7   = 0xfffd54a8
r8   = 0xf75a7c18, r9   = 0x00000000
r10  = 0xfffd55b4, fp   = 0xfffd5628
ip   = 0x00000001, sp   = 0xfffd4318
lr   = 0xf746d279, pc   = 0xf746d2d0
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    167196 KB
Buffers:     15320 KB
Cached:     120932 KB
VmPeak:      52388 KB
VmSize:      52384 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11404 KB
VmRSS:       11404 KB
VmData:      10112 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4317 TID = 4317
4317 4401 

Maps Information
f42cf000 f4ace000 rw-p [stack:4401]
f4ad5000 f4ad7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4adf000 f4ae3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4aec000 f4aee000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4af6000 f4af9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b08000 f4b0d000 r-xp /usr/lib/libsystem.so.0.0.0
f4b18000 f4b1b000 r-xp /lib/libattr.so.1.1.0
f4b23000 f4b33000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b3b000 f4b44000 r-xp /usr/lib/libedbus.so.1.7.99
f4b4c000 f4b4d000 r-xp /usr/lib/libresponse.so.0.2.96
f4b56000 f4b5b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63fd000 f6503000 r-xp /usr/lib/libicuuc.so.57.1
f6519000 f66a1000 r-xp /usr/lib/libicui18n.so.57.1
f66b1000 f66be000 r-xp /usr/lib/libail.so.0.1.0
f66c7000 f66ce000 r-xp /usr/lib/libminizip.so.1.0.0
f66d7000 f6880000 r-xp /usr/lib/libcrypto.so.1.0.0
f68a0000 f68e7000 r-xp /usr/lib/libssl.so.1.0.0
f68f3000 f68f5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68fd000 f6904000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f690d000 f6914000 r-xp /lib/libcrypt-2.13.so
f6945000 f6948000 r-xp /lib/libcap.so.2.21
f6950000 f6952000 r-xp /usr/lib/libiri.so
f695a000 f69a3000 r-xp /usr/lib/libmdm.so.1.2.69
f69ab000 f69b1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69b9000 f69dc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69e6000 f69e8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69f0000 f6a0d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a16000 f6a1a000 r-xp /usr/lib/libsmack.so.1.0.0
f6a23000 f6a3c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a45000 f6a4d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a55000 f6a5b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a64000 f6a66000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a6f000 f6a7f000 r-xp /lib/libresolv-2.13.so
f6a83000 f6a9b000 r-xp /usr/lib/liblzma.so.5.0.3
f6aa4000 f6aa6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6aae000 f6ac8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ad0000 f6aff000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b08000 f6b17000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b21000 f6b2b000 r-xp /usr/lib/libsensord-shared.so
f6b34000 f6c07000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c12000 f6c28000 r-xp /lib/libz.so.1.2.5
f6c30000 f6c35000 r-xp /usr/lib/libffi.so.5.0.10
f6c3d000 f6c3e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c46000 f6c56000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c5e000 f6c77000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c7f000 f6c81000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c89000 f6cfe000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d08000 f6d26000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d30000 f6d31000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d39000 f6d5c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d64000 f6d69000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d71000 f6d9b000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6da4000 f6dbb000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dc3000 f6dc9000 r-xp /lib/librt-2.13.so
f6dd2000 f6e3b000 r-xp /lib/libm-2.13.so
f6e44000 f6ed8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6eeb000 f6ef0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ef8000 f6eff000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f07000 f6f31000 r-xp /usr/lib/libsensor.so.1.9.6
f6f3a000 f7006000 r-xp /usr/lib/libxml2.so.2.7.8
f7013000 f7015000 r-xp /usr/lib/libiniparser.so.0
f701e000 f7024000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f702d000 f70fd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70fe000 f7132000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f713b000 f7177000 r-xp /usr/lib/libSLP-location.so.0.9.24
f717f000 f7182000 r-xp /usr/lib/libbundle.so.0.1.22
f718a000 f7190000 r-xp /usr/lib/libappsvc.so.0.1.0
f7198000 f71d9000 r-xp /usr/lib/libeina.so.1.7.99
f71e2000 f71eb000 r-xp /usr/lib/libvconf.so.0.2.45
f71f3000 f7207000 r-xp /lib/libpthread-2.13.so
f7212000 f721f000 r-xp /usr/lib/libaul.so.0.1.0
f7229000 f722b000 r-xp /lib/libdl-2.13.so
f7234000 f723f000 r-xp /lib/libunwind.so.8.0.1
f726c000 f7274000 r-xp /lib/libgcc_s-4.6.so.1
f7275000 f7399000 r-xp /lib/libc-2.13.so
f73a7000 f73be000 r-xp /usr/lib/libecore.so.1.7.99
f73d5000 f73d7000 r-xp /usr/lib/libdlog.so.0.0.0
f73df000 f73eb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73f4000 f73f9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7401000 f7410000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7418000 f741c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7425000 f7428000 r-xp /usr/lib/libappcore-agent.so.1.1
f7430000 f7432000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f743a000 f743e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7446000 f7463000 r-xp /lib/ld-2.13.so
f746c000 f746f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f746f000 f7473000 r-xp /usr/lib/libsys-assert.so
f7577000 f75e2000 rw-p [heap]
fffb6000 fffd7000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4317)
Call Stack Count: 31
 0: get_last_location + 0x13 (0xf746d2d0) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12d0
 1: state_changed_cb + 0x24 (0xf746d279) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1279
 2: (0xf7404539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 3: g_cclosure_marshal_VOID__UINT + 0x48 (0xf710b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 4: g_closure_invoke + 0x108 (0xf7109c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 5: (0xf7115e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 6: g_signal_emit_valist + 0x85e (0xf711bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 7: g_signal_emit + 0x14 (0xf711bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 8: (0xf715075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 9: (0xf714b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
10: g_closure_invoke + 0x108 (0xf7109c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
11: (0xf7115e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
12: g_signal_emit_valist + 0x85e (0xf711bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
13: g_signal_emit + 0x14 (0xf711bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
14: (0xf714de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
15: (0xf714e017) [/usr/lib/libSLP-location.so.0] + 0x13017
16: (0xf71528d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
17: (0xf743c0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
18: (0xf4ae0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
19: (0xf6bb3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
20: (0xf7060fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
21: g_main_context_dispatch + 0xbc (0xf70627a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
22: (0xf73b7ca7) [/usr/lib/libecore.so.1] + 0x10ca7
23: (0xf73b2b4f) [/usr/lib/libecore.so.1] + 0xbb4f
24: (0xf73b35a7) [/usr/lib/libecore.so.1] + 0xc5a7
25: ecore_main_loop_begin + 0x30 (0xf73b3879) [/usr/lib/libecore.so.1] + 0xc879
26: appcore_agent_main + 0x56 (0xf7426183) [/usr/lib/libappcore-agent.so.1] + 0x1183
27: service_app_main + 0x54 (0xf74267fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
28: main + 0xda (0xf746d723) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1723
29: __libc_start_main + 0x114 (0xf728c85c) [/lib/libc.so.6] + 0x1785c
30: (0xf746cf74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
21.796,104
03-04 14:58:21.799+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:21.799+0100 I/utils   ( 4290): specific action
03-04 14:58:21.799+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:21.799+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:21.799+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:21.799+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:21.799+0100 I/recorder( 4290): saving local data for es.ugr.frailty.heartrate
03-04 14:58:21.799+0100 I/recorder( 4290): es.ugr.frailty.heartrate file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.heartrate.csv
03-04 14:58:21.799+0100 W/AUL     ( 4287): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4290)
03-04 14:58:21.809+0100 I/servicemanager( 4287): request sent to service es.ugr.frailty.recorder
03-04 14:58:21.809+0100 I/servicemanager( 4287): requesting to save local data
03-04 14:58:21.809+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:21.801,0.280000,-0.350000,-0.630000
03-04 14:58:21.809+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:21.809+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:21.808,2.481357,-9.348758,2.206182
03-04 14:58:21.809+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:21.809+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:21.809,0.032084,-0.058781,-0.023670
03-04 14:58:21.809+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:21.816,2.424031,-9.237326,2.228513
03-04 14:58:21.819+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:21.819+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:21.819+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:21.812,-0.070000,-0.210000,0.280000
03-04 14:58:21.819+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:21.819+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:21.822,2.471786,-9.485149,2.356930
03-04 14:58:21.819+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:21.829+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:21.823,0.058230,-0.111893,-0.025221
03-04 14:58:21.829+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:21.828,2.423254,-9.236373,2.233302
03-04 14:58:21.829+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:21.829+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:21.834,0.047755,-0.247824,0.128418
03-04 14:58:21.829+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:21.826,0.840000,0.490000,0.210000
03-04 14:58:21.839+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:21.839+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:21.839+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:21.839+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:21.842,2.390430,-9.358330,2.407180
03-04 14:58:21.839+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:21.839+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:21.842,1.680000,0.350000,-0.280000
03-04 14:58:21.849+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:21.845,-0.032824,-0.121957,0.173878
03-04 14:58:21.849+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:21.848,2.422060,-9.234189,2.243606
03-04 14:58:21.859+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:21.859+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:21.859+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:21.859+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:21.861,2.428715,-9.346365,2.254039
03-04 14:58:21.859+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:21.859+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:21.861,0.006655,-0.112176,0.010433
03-04 14:58:21.869+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:21.864,-0.210000,-0.980000,-0.210000
03-04 14:58:21.869+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:21.866,2.421836,-9.234592,2.242185
03-04 14:58:21.869+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:21.869+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:21.879+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:21.889+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:21.881,-1.960000,-1.260000,-0.210000
03-04 14:58:21.889+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:21.882,0.078664,-0.123737,-0.019253
03-04 14:58:21.889+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:21.899+0100 I/light   ( 4363): es.ugr.frailty.light - capturing data
03-04 14:58:21.899+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:21.899+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:21.909+0100 I/light   ( 4363): es.ugr.frailty.light: SM-R760,04/03/2019,14:58:21.902,1281.000000
03-04 14:58:21.909+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:21.880,2.500499,-9.358330,2.222932
03-04 14:58:21.909+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:21.919+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:21.903,1.260000,-0.070000,-0.210000
03-04 14:58:21.919+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:21.900,2.423177,-9.235857,2.235519
03-04 14:58:21.929+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:21.923,2.469393,-9.432507,2.225325
03-04 14:58:21.929+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:21.929+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:21.904,0.046216,-0.196650,-0.010195
03-04 14:58:21.939+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:21.939+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:21.949+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:21.946,-0.008047,-0.077457,-0.077286
03-04 14:58:21.949+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:21.937,2.030000,-0.140000,-0.420000
03-04 14:58:21.949+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 14:58:21.949+0100 W/libgps_d( 3110): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
03-04 14:58:21.949+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:21.949+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:21.944,2.424798,-9.235409,2.235612
03-04 14:58:21.959+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:21.959+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:21.959+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
03-04 14:58:21.959+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 14:58:21.959+0100 E/CAPI_LOCATION_MANAGER( 4402): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
03-04 14:58:21.959+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:21.959,-0.210000,-0.210000,0.420000
03-04 14:58:21.969+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:21.965,0.059407,-0.140193,0.087761
03-04 14:58:21.969+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:21.969+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:21.969+0100 I/AUL     ( 4402): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
03-04 14:58:21.979+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:21.961,2.416751,-9.312866,2.158326
03-04 14:58:21.979+0100 I/heartrate( 4303): es.ugr.frailty.heartrate - capturing data
03-04 14:58:21.989+0100 I/AUL     ( 4402): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
03-04 14:58:21.989+0100 E/LOCATION( 4402): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
03-04 14:58:21.989+0100 I/LOCATION( 4402): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
03-04 14:58:21.989+0100 I/LOCATION( 4402): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
03-04 14:58:21.989+0100 I/heartrate( 4303): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:58:21.988,104
03-04 14:58:21.989+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:21.999+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:21.999+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:21.974,-0.140000,-0.420000,-0.140000
03-04 14:58:22.009+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.009+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.11,0.140000,0.280000,-0.140000
03-04 14:58:22.009+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:21.980,0.083410,-0.171632,0.052809
03-04 14:58:22.009+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.7,2.486143,-9.375079,2.323431
03-04 14:58:22.009+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:21.993,2.426736,-9.234886,2.235670
03-04 14:58:22.019+0100 W/AUL     ( 4326): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
03-04 14:58:22.019+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.019+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:58:22.019+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 4326
03-04 14:58:22.029+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4287
03-04 14:58:22.029+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:58:22.029+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(4287), cmd(0)
03-04 14:58:22.029+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.029+0100 I/utils   ( 4287): specific action
03-04 14:58:22.029+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.029+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.029+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.029+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.029+0100 I/servicemanager( 4287): requesting to save local data for es.ugr.frailty.linearacceleration
03-04 14:58:22.029+0100 W/AUL     ( 4287): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
03-04 14:58:22.029+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:58:22.039+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 4287
03-04 14:58:22.039+0100 I/LOCATION( 4317): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
03-04 14:58:22.039+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4290
03-04 14:58:22.049+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:58:22.049+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(4290), cmd(0)
03-04 14:58:22.049+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.049+0100 I/utils   ( 4290): specific action
03-04 14:58:22.049+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.049+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.049+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.049+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.049+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.049+0100 I/recorder( 4290): saving local data for es.ugr.frailty.linearacceleration
03-04 14:58:22.049+0100 I/recorder( 4290): es.ugr.frailty.linearacceleration file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.linearacceleration.csv
03-04 14:58:22.049+0100 W/AUL     ( 4287): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4290)
03-04 14:58:22.049+0100 I/servicemanager( 4287): request sent to service es.ugr.frailty.recorder
03-04 14:58:22.049+0100 I/servicemanager( 4287): requesting to save local data
03-04 14:58:22.049+0100 W/AUL     ( 4326): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4287)
03-04 14:58:22.049+0100 I/linearacceleration( 4326): request sent to service es.ugr.frailty.servicemanager
03-04 14:58:22.049+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.059+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.59,0.000040,-0.205668,0.026461
03-04 14:58:22.059+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.059+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.059+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.65,2.510071,-9.406186,2.289931
03-04 14:58:22.069+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.24,2.426661,-9.234554,2.237122
03-04 14:58:22.069+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.069+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.71,0.490000,0.210000,-0.420000
03-04 14:58:22.069+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.069+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.72,2.428675,-9.234017,2.237150
03-04 14:58:22.069+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.069+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.74,-0.560000,-0.280000,0.070000
03-04 14:58:22.069+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.079+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.77,2.426625,-9.234642,2.236799
03-04 14:58:22.079+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.079+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.82,2.425038,-9.234018,2.241090
03-04 14:58:22.079+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.079+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.86,2.422582,-9.235451,2.237843
03-04 14:58:22.079+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.089+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.089+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.90,2.428198,-9.232721,2.243009
03-04 14:58:22.089+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.91,-0.038588,-0.078224,0.079453
03-04 14:58:22.089+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.089+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.089+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.95,0.020427,-0.255917,0.015342
03-04 14:58:22.089+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.089+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.96,2.433159,-9.230395,2.247204
03-04 14:58:22.089+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.099+0100 W/AUL     ( 4294): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
03-04 14:58:22.099+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:58:22.099+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 4294
03-04 14:58:22.099+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.78,1.120000,0.140000,-0.700000
03-04 14:58:22.099+0100 I/light   ( 4363): es.ugr.frailty.light - capturing data
03-04 14:58:22.109+0100 I/light   ( 4363): es.ugr.frailty.light: SM-R760,04/03/2019,14:58:22.108,1282.000000
03-04 14:58:22.109+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4287
03-04 14:58:22.109+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:58:22.109+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(4287), cmd(0)
03-04 14:58:22.109+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.109+0100 I/utils   ( 4287): specific action
03-04 14:58:22.109+0100 I/servicemanager( 4287): requesting to save local data for es.ugr.frailty.accelerometer
03-04 14:58:22.109+0100 W/AUL     ( 4287): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
03-04 14:58:22.109+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.109+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:58:22.109+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 4287
03-04 14:58:22.119+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.98,0.118596,-0.161163,0.095160
03-04 14:58:22.119+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4290
03-04 14:58:22.119+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:58:22.119+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(4290), cmd(0)
03-04 14:58:22.119+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.119+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.119+0100 I/utils   ( 4290): specific action
03-04 14:58:22.119+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.119+0100 I/recorder( 4290): saving local data for es.ugr.frailty.accelerometer
03-04 14:58:22.119+0100 I/recorder( 4290): es.ugr.frailty.accelerometer file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
03-04 14:58:22.119+0100 W/AUL     ( 4287): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4290)
03-04 14:58:22.119+0100 I/servicemanager( 4287): request sent to service es.ugr.frailty.recorder
03-04 14:58:22.119+0100 I/servicemanager( 4287): requesting to save local data
03-04 14:58:22.129+0100 W/AUL     ( 4294): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4287)
03-04 14:58:22.129+0100 I/accelerometer( 4294): request sent to service es.ugr.frailty.servicemanager
03-04 14:58:22.129+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.129+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.131,2.428715,-9.439686,2.263610
03-04 14:58:22.129+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.129,0.105802,-0.092109,0.070850
03-04 14:58:22.129+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.129+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.118,1.120000,-0.210000,-0.140000
03-04 14:58:22.129+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.134,2.388037,-9.312866,2.316252
03-04 14:58:22.129+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.129+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.139+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.138,2.445465,-9.489935,2.256432
03-04 14:58:22.139+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.139+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.139,0.420000,-0.630000,-0.070000
03-04 14:58:22.139+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.142,2.541178,-9.396614,2.333002
03-04 14:58:22.139+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.139+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.100,2.433343,-9.230438,2.246828
03-04 14:58:22.139+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.139+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.146,2.533999,-9.324830,2.313859
03-04 14:58:22.149+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.149+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.151,2.452643,-9.370294,2.258825
03-04 14:58:22.149+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.149+0100 W/AUL     ( 4345): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
03-04 14:58:22.149+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.149+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:58:22.149+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 4345
03-04 14:58:22.159+0100 E/CAPI_APPFW_APP_CONTROL( 4348): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
03-04 14:58:22.159+0100 E/pressure( 4348): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.pressure; data: 
03-04 14:58:22.159+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.158,0.700000,-0.560000,0.350000
03-04 14:58:22.159+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.148,0.019485,-0.139898,0.011621
03-04 14:58:22.159+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4287
03-04 14:58:22.159+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.159+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:58:22.159+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(4287), cmd(0)
03-04 14:58:22.159+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.159+0100 I/utils   ( 4287): specific action
03-04 14:58:22.159+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.159+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.159+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.159+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.159+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.159+0100 I/servicemanager( 4287): requesting to save local data for es.ugr.frailty.gravity
03-04 14:58:22.159+0100 W/AUL     ( 4287): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
03-04 14:58:22.169+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:58:22.169+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 4287
03-04 14:58:22.169+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.169+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.168,0.079120,-0.185319,0.021568
03-04 14:58:22.169+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.176,0.210000,-0.210000,-0.070000
03-04 14:58:22.179+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4290
03-04 14:58:22.179+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:58:22.179+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(4290), cmd(0)
03-04 14:58:22.179+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.179+0100 I/utils   ( 4290): specific action
03-04 14:58:22.179+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.179+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.179+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.179+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.179+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.179+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.179+0100 I/recorder( 4290): saving local data for es.ugr.frailty.gravity
03-04 14:58:22.179+0100 I/recorder( 4290): es.ugr.frailty.gravity file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
03-04 14:58:22.179+0100 W/AUL     ( 4287): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4290)
03-04 14:58:22.179+0100 I/servicemanager( 4287): request sent to service es.ugr.frailty.recorder
03-04 14:58:22.179+0100 I/servicemanager( 4287): requesting to save local data
03-04 14:58:22.179+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.154,2.512464,-9.415757,2.268396
03-04 14:58:22.179+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.179+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.179+0100 I/heartrate( 4303): es.ugr.frailty.heartrate - capturing data
03-04 14:58:22.189+0100 I/heartrate( 4303): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:58:22.188,104
03-04 14:58:22.189+0100 W/AUL     ( 4345): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4287)
03-04 14:58:22.189+0100 I/gravity ( 4345): request sent to service es.ugr.frailty.servicemanager
03-04 14:58:22.189+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.189+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.189+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.192,2.435022,-9.230068,2.246527
03-04 14:58:22.189+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.189+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.196,2.434432,-9.230758,2.244333
03-04 14:58:22.189+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.199+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.188,0.005657,-0.125869,-0.028381
03-04 14:58:22.199+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.199+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.186,2.440679,-9.355937,2.218147
03-04 14:58:22.199+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.199+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.203,2.385644,-9.341579,2.311467
03-04 14:58:22.199+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.209+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.208,2.440679,-9.329616,2.210968
03-04 14:58:22.209+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.196,-0.490000,0.140000,0.070000
03-04 14:58:22.209+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.209+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.209+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.199,2.430154,-9.231630,2.245380
03-04 14:58:22.209+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.219+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.203,-0.048788,-0.110822,0.067133
03-04 14:58:22.219+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.220,2.429928,-9.232285,2.242936
03-04 14:58:22.219+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.219+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.214,2.507678,-9.379865,2.273181
03-04 14:58:22.219+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.219+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.226,2.510071,-9.410972,2.280360
03-04 14:58:22.229+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.229+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.215,0.070000,-0.140000,-0.070000
03-04 14:58:22.229+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.224,2.430833,-9.232124,2.242612
03-04 14:58:22.229+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.229+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.229+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.239+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.234,2.431968,-9.231831,2.242591
03-04 14:58:22.239+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.239+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.242,2.429143,-9.231508,2.246975
03-04 14:58:22.239+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.239+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.234,0.010525,-0.097985,-0.034412
03-04 14:58:22.239+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.239+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.246,2.429446,-9.231464,2.246828
03-04 14:58:22.249+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.238,2.433501,-9.461221,2.395216
03-04 14:58:22.249+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.249+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.239,0.070000,0.350000,0.350000
03-04 14:58:22.249+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.250,0.077750,-0.147580,0.030246
03-04 14:58:22.249+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.252,2.438286,-9.372685,2.263610
03-04 14:58:22.249+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.249+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.249+0100 W/AUL     ( 4363): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
03-04 14:58:22.249+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.256,0.079238,-0.178847,0.037748
03-04 14:58:22.249+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.259+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.259+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.260,0.001533,-0.229390,0.152624
03-04 14:58:22.259+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.259+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.259+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:58:22.259+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 4363
03-04 14:58:22.259+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.262,2.474179,-9.186047,2.072184
03-04 14:58:22.269+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.265,2.432566,-9.232718,2.238290
03-04 14:58:22.269+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4287
03-04 14:58:22.269+0100 W/AUL     ( 4363): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4287)
03-04 14:58:22.269+0100 I/light   ( 4363): request sent to service es.ugr.frailty.servicemanager
03-04 14:58:22.269+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:58:22.269+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(4287), cmd(0)
03-04 14:58:22.269+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.269+0100 I/utils   ( 4287): specific action
03-04 14:58:22.269+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.269+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.269+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.269+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.269+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.269+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.269+0100 W/CAPI_APPFW_APP_CONTROL( 4287): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.269+0100 I/servicemanager( 4287): requesting to save local data for es.ugr.frailty.light
03-04 14:58:22.269+0100 W/AUL     ( 4287): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
03-04 14:58:22.269+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:58:22.269+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 4287
03-04 14:58:22.279+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.279+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.282,2.522035,-9.451650,2.210968
03-04 14:58:22.279+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.279+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4290
03-04 14:58:22.279+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:58:22.279+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(4290), cmd(0)
03-04 14:58:22.279+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.279+0100 I/utils   ( 4290): specific action
03-04 14:58:22.279+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.279+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.279+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.279+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.279+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.279+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.279+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.279+0100 W/CAPI_APPFW_APP_CONTROL( 4290): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:58:22.279+0100 I/recorder( 4290): saving local data for es.ugr.frailty.light
03-04 14:58:22.279+0100 I/recorder( 4290): es.ugr.frailty.light file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
03-04 14:58:22.279+0100 W/AUL     ( 4287): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4290)
03-04 14:58:22.279+0100 I/servicemanager( 4287): request sent to service es.ugr.frailty.recorder
03-04 14:58:22.279+0100 I/servicemanager( 4287): requesting to save local data
03-04 14:58:22.289+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.264,0.009144,-0.141177,0.016635
03-04 14:58:22.289+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.286,2.432680,-9.233952,2.233068
03-04 14:58:22.289+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.289+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.272,0.210000,0.140000,0.210000
03-04 14:58:22.289+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.292,0.044732,0.045418,-0.174643
03-04 14:58:22.289+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.289+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.289+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.296,0.089469,-0.218932,-0.027322
03-04 14:58:22.289+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.296,-0.070000,0.140000,-0.070000
03-04 14:58:22.299+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.299+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.299+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.299+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.299+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.306,0.082177,-0.263162,0.064042
03-04 14:58:22.309+0100 I/light   ( 4363): es.ugr.frailty.light - capturing data
03-04 14:58:22.309+0100 I/light   ( 4363): es.ugr.frailty.light: SM-R760,04/03/2019,14:58:22.311,1283.000000
03-04 14:58:22.309+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.309,2.434470,-9.232992,2.235083
03-04 14:58:22.319+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.319+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.319+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.307,2.514857,-9.497113,2.297110
03-04 14:58:22.319+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.321,-0.015327,-0.194729,0.224738
03-04 14:58:22.319+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.319+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.325,2.433185,-9.230870,2.245223
03-04 14:58:22.339+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.349+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.350,-0.014041,-0.046103,0.073422
03-04 14:58:22.359+0100 W/AUL     ( 4416): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
03-04 14:58:22.359+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 23
03-04 14:58:22.359+0100 W/AUL_AMD ( 2470): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
03-04 14:58:22.359+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 4317
03-04 14:58:22.359+0100 W/AUL_AMD ( 2470): amd_request.c: __send_app_termination_signal(528) > send dead signal done
03-04 14:58:22.359+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.369+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.368,0.029372,-0.012075,-0.037303
03-04 14:58:22.369+0100 W/libgps_d( 3110): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
03-04 14:58:22.369+0100 W/libgps  ( 3110): [proxy__gps_stop][line = 1067]: called.
03-04 14:58:22.369+0100 W/libgps_d( 3110): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
03-04 14:58:22.369+0100 W/libgps_d( 3110): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
03-04 14:58:22.369+0100 W/libgps_d( 3110): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
03-04 14:58:22.369+0100 W/libgps_d( 3110): GpsiHookStateGps              : EXIT
03-04 14:58:22.369+0100 W/libgps_d( 3110): GpsiHookStateIdle             : ENTRY
03-04 14:58:22.369+0100 W/gpsd    ( 3094): HandleIncomingMessage() dest id:0, msg id:2
03-04 14:58:22.369+0100 I/AUL_AMD ( 2470): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4317
03-04 14:58:22.369+0100 W/AUL     ( 2470): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4317)
03-04 14:58:22.369+0100 E/CAPI_LOCATION_MANAGER( 4402): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
03-04 14:58:22.379+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.379+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.301,0.350000,-0.840000,-0.350000
03-04 14:58:22.379+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.379+0100 I/heartrate( 4303): es.ugr.frailty.heartrate - capturing data
03-04 14:58:22.389+0100 I/heartrate( 4303): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:58:22.389,104
03-04 14:58:22.389+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.384,0.053813,-0.069320,-0.027333
03-04 14:58:22.389+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.389+0100 E/CAPI_APPFW_APP_CONTROL( 4378): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
03-04 14:58:22.389+0100 E/pedometer( 4378): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.pedometer; data: 
03-04 14:58:22.399+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.386,-0.350000,-0.490000,-0.070000
03-04 14:58:22.399+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.329,2.419144,-9.427721,2.459821
03-04 14:58:22.399+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.399+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.405,2.419144,-9.276974,2.318645
03-04 14:58:22.399+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.409+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.396,2.435235,-9.229005,2.250664
03-04 14:58:22.409+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.409+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.410,-0.700000,0.210000,0.350000
03-04 14:58:22.409+0100 I/gravity ( 4345): es.ugr.frailty.gravity: SM-R760,04/03/2019,14:58:22.415,2.437115,-9.229189,2.247872
03-04 14:58:22.409+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.419+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.419+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.422,0.080902,-0.180247,0.023608
03-04 14:58:22.419+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration - capturing data
03-04 14:58:22.429+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.429+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope: SM-R760,04/03/2019,14:58:22.433,0.770000,0.420000,-0.350000
03-04 14:58:22.429+0100 I/gravity ( 4345): es.ugr.frailty.gravity - capturing data
03-04 14:58:22.429+0100 I/linearacceleration( 4326): es.ugr.frailty.linearacceleration: SM-R760,04/03/2019,14:58:22.427,0.024733,-0.207688,0.027486
03-04 14:58:22.439+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer: SM-R760,04/03/2019,14:58:22.420,2.464607,-9.241080,2.213361
03-04 14:58:22.439+0100 I/accelerometer( 4294): es.ugr.frailty.accelerometer - capturing data
03-04 14:58:22.449+0100 I/gyroscope( 4297): es.ugr.frailty.gyroscope - capturing data
03-04 14:58:22.449+0100 W/CRASH_MANAGER( 4417): worker.c: worker_job(1205) > 11043176c6f63155170790
