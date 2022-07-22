S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22142
Date: 2018-04-23 16:01:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70fe52d, r5   = 0xf7677f98
r6   = 0xfff34288, r7   = 0xfff34138
r8   = 0xf7674c18, r9   = 0x00000000
r10  = 0xfff34214, fp   = 0xfff34288
ip   = 0x00000001, sp   = 0xfff32fb8
lr   = 0xf70fe539, pc   = 0xf71672b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     13028 KB
Buffers:     59960 KB
Cached:     230616 KB
VmPeak:      53492 KB
VmSize:      53428 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12204 KB
VmRSS:       12204 KB
VmData:      11156 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22142 TID = 22142
22142 22145 

Maps Information
f3fc9000 f47c8000 rw-p [stack:22145]
f47cf000 f47d1000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47d9000 f47dd000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47e6000 f47e8000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47f0000 f47f3000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4802000 f4807000 r-xp /usr/lib/libsystem.so.0.0.0
f4812000 f4815000 r-xp /lib/libattr.so.1.1.0
f481d000 f482d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4835000 f483e000 r-xp /usr/lib/libedbus.so.1.7.99
f4846000 f4847000 r-xp /usr/lib/libresponse.so.0.2.96
f4850000 f4855000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60f7000 f61fd000 r-xp /usr/lib/libicuuc.so.57.1
f6213000 f639b000 r-xp /usr/lib/libicui18n.so.57.1
f63ab000 f63b8000 r-xp /usr/lib/libail.so.0.1.0
f63c1000 f63c8000 r-xp /usr/lib/libminizip.so.1.0.0
f63d1000 f657a000 r-xp /usr/lib/libcrypto.so.1.0.0
f659a000 f65e1000 r-xp /usr/lib/libssl.so.1.0.0
f65ed000 f65ef000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65f7000 f65fe000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6607000 f660e000 r-xp /lib/libcrypt-2.13.so
f663f000 f6642000 r-xp /lib/libcap.so.2.21
f664a000 f664c000 r-xp /usr/lib/libiri.so
f6654000 f669d000 r-xp /usr/lib/libmdm.so.1.2.69
f66a5000 f66ab000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66b3000 f66d6000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66e0000 f66e2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66ea000 f6707000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6710000 f6714000 r-xp /usr/lib/libsmack.so.1.0.0
f671d000 f6736000 r-xp /usr/lib/libnetwork.so.0.0.0
f673f000 f6747000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f674f000 f6755000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f675e000 f6760000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6769000 f6779000 r-xp /lib/libresolv-2.13.so
f677d000 f6795000 r-xp /usr/lib/liblzma.so.5.0.3
f679e000 f67a0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67a8000 f67c2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67ca000 f67f9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6802000 f6811000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f681b000 f6825000 r-xp /usr/lib/libsensord-shared.so
f682e000 f6901000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f690c000 f6922000 r-xp /lib/libz.so.1.2.5
f692a000 f692f000 r-xp /usr/lib/libffi.so.5.0.10
f6937000 f6938000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6940000 f6950000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6958000 f6971000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6979000 f697b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6983000 f69f8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a02000 f6a08000 r-xp /lib/librt-2.13.so
f6a11000 f6a2f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a39000 f6a3a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a42000 f6a65000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a6d000 f6a72000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a7a000 f6aa4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6aad000 f6ac4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6acc000 f6b35000 r-xp /lib/libm-2.13.so
f6b3e000 f6bd2000 r-xp /usr/lib/libstdc++.so.6.0.16
f6be5000 f6bea000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bf2000 f6bf9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c01000 f6c2b000 r-xp /usr/lib/libsensor.so.1.9.6
f6c34000 f6d00000 r-xp /usr/lib/libxml2.so.2.7.8
f6d0d000 f6d0f000 r-xp /usr/lib/libiniparser.so.0
f6d18000 f6d1e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d27000 f6df7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6df8000 f6e2c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e35000 f6e71000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e79000 f6e7c000 r-xp /usr/lib/libbundle.so.0.1.22
f6e84000 f6e8a000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e92000 f6ed3000 r-xp /usr/lib/libeina.so.1.7.99
f6edc000 f6ef3000 r-xp /usr/lib/libecore.so.1.7.99
f6f0a000 f6f13000 r-xp /usr/lib/libvconf.so.0.2.45
f6f1b000 f6f2f000 r-xp /lib/libpthread-2.13.so
f6f3a000 f6f47000 r-xp /usr/lib/libaul.so.0.1.0
f6f51000 f6f53000 r-xp /lib/libdl-2.13.so
f6f5c000 f6f67000 r-xp /lib/libunwind.so.8.0.1
f6f94000 f6f9c000 r-xp /lib/libgcc_s-4.6.so.1
f6f9d000 f70c1000 r-xp /lib/libc-2.13.so
f70cf000 f70d1000 r-xp /usr/lib/libdlog.so.0.0.0
f70d9000 f70e5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70ee000 f70f3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70fb000 f710a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7112000 f7116000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f711f000 f7122000 r-xp /usr/lib/libappcore-agent.so.1.1
f712a000 f712c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7134000 f7138000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7140000 f715d000 r-xp /lib/ld-2.13.so
f7166000 f7169000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7169000 f716d000 r-xp /usr/lib/libsys-assert.so
f7644000 f76ae000 rw-p [heap]
fff15000 fff36000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22142)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf71672b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf70fe539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e053f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e03c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e0fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e15be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e15dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e4a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e451f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e03c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e0fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e15be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e15dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e47e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e48017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e4c8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf71360bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf47da171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf68ad663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d5afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d5c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6eecca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ee7b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ee85a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ee8879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7120183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71207fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71676a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6fb485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7166fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.621+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.621+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:625,0.289532,-8.360522,-4.460221
04-23 16:01:15.621+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.621+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:629,-388.989990,66.779999,64.680000
04-23 16:01:15.621+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:630,-0.897308,-13.466805,-6.766902
04-23 16:01:15.631+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:15.631+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:15.641+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.641+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:649,-247.800003,61.389999,51.029999
04-23 16:01:15.651+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.651+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:655,-1.043271,-17.269001,-5.429315
04-23 16:01:15.661+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.661+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.661+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:668,-94.290001,41.020000,25.340000
04-23 16:01:15.671+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:668,0.686740,-15.175282,-3.306881
04-23 16:01:15.681+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.681+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.681+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:689,1.117448,-11.598011,-1.514657
04-23 16:01:15.691+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:689,-33.670002,39.480000,1.820000
04-23 16:01:15.701+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.701+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.701+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:708,0.569492,-9.635897,-1.763510
04-23 16:01:15.711+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:708,-51.939999,35.420002,-6.720000
04-23 16:01:15.721+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.721+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.721+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:728,0.145962,-9.985250,-2.737389
04-23 16:01:15.731+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:728,-58.590000,29.820000,-7.420000
04-23 16:01:15.741+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.741+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.741+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:751,0.208176,-10.633704,-1.189233
04-23 16:01:15.741+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:751,-28.210001,20.860001,-7.350000
04-23 16:01:15.751+0200 I/LOCATION(22301): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:15.761+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.761+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.761+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:769,0.538385,-10.547562,-0.430708
04-23 16:01:15.771+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:769,5.390000,15.190001,-12.460000
04-23 16:01:15.781+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.781+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.781+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:788,0.485743,-10.578669,0.289532
04-23 16:01:15.791+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:788,26.250000,5.740000,-16.660000
04-23 16:01:15.801+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.801+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.801+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:808,0.533599,-10.346564,-1.272982
04-23 16:01:15.801+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:808,34.930000,-3.500000,-20.580000
04-23 16:01:15.811+0200 W/AUL     (22301): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:15.811+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:15.811+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22301
04-23 16:01:15.821+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:15.821+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:15.821+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:15.831+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.831+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:15.831+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:15.831+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:15.831+0200 I/utils   (19708): specific action
04-23 16:01:15.831+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:15.831+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:15.831+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:15.831+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:15.831+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:15.831+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:15.831+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:836,0.689133,-10.794022,-2.225325
04-23 16:01:15.841+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:15.841+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:15.841+0200 I/utils   (21185): specific action
04-23 16:01:15.841+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:15.841+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:15.841+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:01:15.841+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:15.841+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:15.841+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:15.841+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:01:15.841+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:15.841+0200 I/recorder(21185): guardando datos en local
04-23 16:01:15.841+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:15.841+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:15.841+0200 W/AUL     (22301): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:15.841+0200 I/location(22301): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:15.841+0200 I/location(22301): stopping es.ugr.frailty.location service
04-23 16:01:15.841+0200 E/CAPI_APPFW_APP_CONTROL(22301): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:01:15.841+0200 E/location(22301): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:01:15.841+0200 I/CAPI_APPFW_APPLICATION(22301): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:01:15.841+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.841+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.851+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:852,36.049999,-6.370000,-16.240000
04-23 16:01:15.851+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.851+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:856,44.869999,-5.950000,-20.510000
04-23 16:01:15.851+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:01:15.851+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:01:15.861+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:852,0.751346,-11.375479,-1.347159
04-23 16:01:15.861+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.861+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.861+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:870,35.630001,-1.610000,-21.910000
04-23 16:01:15.871+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:869,0.856631,-11.205588,-0.418744
04-23 16:01:15.881+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.881+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.881+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:888,34.160000,-8.120000,-18.900000
04-23 16:01:15.891+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:888,1.002593,-11.004591,0.780060
04-23 16:01:15.901+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.901+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.901+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:908,76.230003,-12.740000,-21.700001
04-23 16:01:15.911+0200 W/LOCATION(22301): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:15.911+0200 I/LOCATION(22301): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:15.911+0200 I/LOCATION(22301): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:15.911+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:908,1.232304,-11.459228,0.732204
04-23 16:01:15.921+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.921+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.921+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:928,139.789993,-14.140000,-29.190001
04-23 16:01:15.931+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:928,1.239482,-11.935399,0.026321
04-23 16:01:15.941+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.941+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.941+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:950,208.389999,-8.190000,-39.900002
04-23 16:01:15.961+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:950,0.985843,-11.554940,-0.086142
04-23 16:01:15.961+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.961+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.961+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:968,235.410004,-12.390000,-35.349998
04-23 16:01:15.971+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:968,1.033699,-10.018748,0.547956
04-23 16:01:15.981+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:15.981+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:15.981+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:15:989,227.360001,-14.980000,-24.639999
04-23 16:01:15.991+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:15:989,1.392623,-8.635696,0.495314
04-23 16:01:16.001+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.011+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.011+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:10,187.949997,-6.510000,-14.700000
04-23 16:01:16.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:01:16.011+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:01:16.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:01:16.011+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:01:16.011+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:01:16.011+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:01:16.011+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:01:16.011+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:01:16.011+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:01:16.021+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.021+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:28,132.089996,-3.710000,-11.550000
04-23 16:01:16.041+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:16.041+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:16.041+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.041+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:15,1.605584,-7.869993,0.378066
04-23 16:01:16.041+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.041+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:51,65.239998,-8.400000,-7.140000
04-23 16:01:16.051+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:54,1.406980,-7.932207,1.351945
04-23 16:01:16.061+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.061+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:65,1.383051,-7.666604,2.524428
04-23 16:01:16.071+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.071+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.071+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:75,11.480000,-12.460000,-10.430000
04-23 16:01:16.071+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:76,1.689333,-8.592626,3.364309
04-23 16:01:16.081+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.081+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.081+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:89,1.400000,-14.210000,-7.840000
04-23 16:01:16.091+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:89,1.998007,-9.104690,2.914458
04-23 16:01:16.101+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.101+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.101+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:108,-0.700000,-12.180000,-5.740000
04-23 16:01:16.111+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:108,2.074577,-9.056834,2.356930
04-23 16:01:16.121+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.121+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.121+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:128,-4.480000,-9.940000,-3.080000
04-23 16:01:16.131+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:128,2.220540,-8.915657,2.275574
04-23 16:01:16.141+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.151+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.151+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:151,-17.990000,-7.210000,-1.610000
04-23 16:01:16.151+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:155,2.076970,-8.941978,2.531606
04-23 16:01:16.161+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.161+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.161+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:169,-32.619999,-6.020000,-1.750000
04-23 16:01:16.181+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:170,1.995614,-8.925228,2.600998
04-23 16:01:16.181+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.181+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.181+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:16.191+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:191,2.129612,-8.970692,2.431108
04-23 16:01:16.201+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.211+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:208,2.213361,-9.276974,2.251646
04-23 16:01:16.221+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.221+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:229,2.045863,-9.772287,1.521835
04-23 16:01:16.241+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:16.241+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:16.241+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:16.241+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e1a410
04-23 16:01:16.241+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.251+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:16.251+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:16.251+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:189,-40.740002,-5.530000,-0.070000
04-23 16:01:16.251+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.261+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:251,1.887937,-8.970692,1.593620
04-23 16:01:16.271+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:258,-38.290001,-2.310000,0.560000
04-23 16:01:16.271+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.271+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.281+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:284,1.880759,-9.071191,1.198804
04-23 16:01:16.291+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:282,-26.880001,4.130000,2.590000
04-23 16:01:16.291+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.291+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:297,-55.439999,7.560000,2.310000
04-23 16:01:16.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e2d698]
04-23 16:01:16.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:16.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:16.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:16.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:16.301+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.311+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:16.311+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:16.311+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:310,-97.930000,7.420000,8.330000
04-23 16:01:16.311+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.321+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:16.331+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.361+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:16.361+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:16.361+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:16.361+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:16.361+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:16.361+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:16.361+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:16.361+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:16.361+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:16.361+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:16.381+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:16.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:16.391+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:16.401+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:335,1.983650,-10.023535,1.100698
04-23 16:01:16.401+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:16.401+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.411+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:320,-92.050003,7.840000,17.780001
04-23 16:01:16.421+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.421+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:410,1.725225,-10.145569,1.428515
04-23 16:01:16.431+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:16.431+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:16.431+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.431+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:438,1.507478,-9.949356,1.725225
04-23 16:01:16.441+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:425,-41.230000,8.470000,19.879999
04-23 16:01:16.451+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.461+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.461+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:465,1.347159,-9.875179,2.086541
04-23 16:01:16.461+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:455,-3.990000,3.640000,20.160000
04-23 16:01:16.461+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:16.471+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.471+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.491+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:477,10.710000,-2.310000,24.430000
04-23 16:01:16.491+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.501+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:16.501+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:479,0.763310,-8.889337,1.861616
04-23 16:01:16.501+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.511+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:513,0.715454,-10.301102,0.866202
04-23 16:01:16.551+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:502,26.250000,-4.550000,25.900000
04-23 16:01:16.551+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:16.551+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:16.551+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:16.551+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e2d698
04-23 16:01:16.551+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.561+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01e70]
04-23 16:01:16.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:16.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:16.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:16.571+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:16.581+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:563,13.230000,0.910000,15.750000
04-23 16:01:16.581+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:572,0.689133,-9.681360,1.268196
04-23 16:01:16.581+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.581+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:16.581+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:16.581+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:590,41.860001,-5.320000,0.210000
04-23 16:01:16.591+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:16.601+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:16.601+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:16.601+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:16.601+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:16.601+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:16.601+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:16.601+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:16.601+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:16.601+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:16.601+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:16.611+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:16.621+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:16.621+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:16.621+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:16.631+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:16.631+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:16.671+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:16.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:16.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:16.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:16.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01e70
04-23 16:01:16.701+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:01:16.701+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:01:16.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:16.701+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:16.711+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22301
04-23 16:01:16.711+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22301)
04-23 16:01:16.711+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:01:16.711+0200 I/servicemanager(19708): App control destroyed.
04-23 16:01:16.761+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.771+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:772,0.370888,-6.654440,1.938186
04-23 16:01:16.771+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.771+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:777,-250.040009,-6.160000,37.939999
04-23 16:01:16.831+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:16.831+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:16.861+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 16:01:16.861+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:16.861+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22301), cmd(0)
04-23 16:01:16.871+0200 W/AUL     (22314): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:01:16.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:01:16.871+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:01:16.871+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22271
04-23 16:01:16.871+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:01:16.881+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22271
04-23 16:01:16.881+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22271)
04-23 16:01:16.971+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:16.971+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:16:975,-1.167697,-8.922836,-0.650848
04-23 16:01:16.971+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:16.971+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:16:979,-67.690002,1.330000,41.650002
04-23 16:01:17.031+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:17.031+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:17.161+0200 I/accelerometer(22235): capturing data from es.ugr.frailty.accelerometer
04-23 16:01:17.171+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:01:17:169,-1.629512,-9.722038,-4.974678
04-23 16:01:17.171+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:17.171+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:17:178,-38.009998,7.630000,29.610001
04-23 16:01:17.231+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:17.231+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:17.301+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer sleep timeout
04-23 16:01:17.301+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 16:01:17.301+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:17.301+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:17.311+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22235
04-23 16:01:17.321+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22235)
04-23 16:01:17.321+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer stop request sent!
04-23 16:01:17.321+0200 I/servicemanager(19708): App control destroyed.
04-23 16:01:17.321+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:17.321+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22235), cmd(0)
04-23 16:01:17.321+0200 I/accelerometer(22235): stopping es.ugr.frailty.accelerometer service
04-23 16:01:17.321+0200 W/AUL     (22235): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:17.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:17.321+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22235
04-23 16:01:17.331+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:17.341+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:17.341+0200 I/utils   (19708): specific action
04-23 16:01:17.341+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:17.341+0200 W/AUL     (22235): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:17.341+0200 I/accelerometer(22235): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:17.341+0200 I/CAPI_APPFW_APPLICATION(22235): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:01:17.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:17.351+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:17.361+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:17.371+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:17.371+0200 I/utils   (21185): specific action
04-23 16:01:17.371+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:17.371+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 16:01:17.371+0200 I/recorder(21185): guardando datos en local
04-23 16:01:17.371+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:17.371+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:17.371+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:17.391+0200 I/gyroscope(22250): capturing data from es.ugr.frailty.gyroscope
04-23 16:01:17.391+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:17.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:17.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:01:17.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:01:17.401+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:17.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(21185), cmd(0)
04-23 16:01:17.391+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope sleep timeout
04-23 16:01:17.401+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:01:17:397,235.339996,3.430000,9.100000
04-23 16:01:17.411+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 16:01:17.411+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:17.411+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:17.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22250
04-23 16:01:17.421+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22250)
04-23 16:01:17.421+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope stop request sent!
04-23 16:01:17.421+0200 I/servicemanager(19708): App control destroyed.
04-23 16:01:17.421+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:17.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22250), cmd(0)
04-23 16:01:17.421+0200 I/gyroscope(22250): stopping es.ugr.frailty.gyroscope service
04-23 16:01:17.421+0200 W/AUL     (22250): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:17.431+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:17.431+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:17.431+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22250
04-23 16:01:17.431+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:01:17.441+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:17.441+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:17.441+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:17.441+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:17.441+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:17.441+0200 I/utils   (19708): specific action
04-23 16:01:17.441+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:17.441+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:17.441+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:17.441+0200 W/AUL     (22250): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:17.441+0200 I/gyroscope(22250): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:17.441+0200 I/CAPI_APPFW_APPLICATION(22250): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:01:17.441+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:17.451+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:17.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:01:17.451+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:01:17.451+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:17.451+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:01:17.461+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:17.461+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:01:17.461+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:17.461+0200 I/utils   (21185): specific action
04-23 16:01:17.461+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:17.461+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:17.461+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 16:01:17.461+0200 I/recorder(21185): guardando datos en local
04-23 16:01:17.471+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:17.471+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:17.501+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:01:17.511+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:01:17.521+0200 I/accelerometer(22235): es.ugr.frailty.accelerometer listener destroyed
04-23 16:01:17.541+0200 I/gyroscope(22250): es.ugr.frailty.gyroscope listener destroyed
04-23 16:01:17.641+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:17.641+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:17.691+0200 W/AUL     (22320): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 16:01:17.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:01:17.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:01:17.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22235
04-23 16:01:17.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:01:17.701+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22235
04-23 16:01:17.701+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22235)
04-23 16:01:17.701+0200 W/AUL     (22321): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 16:01:17.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:01:17.711+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:01:17.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22250
04-23 16:01:17.711+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:01:17.711+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22250
04-23 16:01:17.711+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22250)
04-23 16:01:17.841+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:17.841+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:17.851+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:01:18.041+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:18.041+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:18.241+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:18.241+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:18.431+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:18.431+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:18.481+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11221426c6f63152449206
