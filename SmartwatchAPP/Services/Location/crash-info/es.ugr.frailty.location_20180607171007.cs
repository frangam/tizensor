S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 17022
Date: 2018-06-07 17:10:07+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf6f7a52d, r5   = 0xf77e8f98
r6   = 0xffda64c0, r7   = 0xffda6370
r8   = 0xf77e5c18, r9   = 0x00000000
r10  = 0xffda644c, fp   = 0xffda64c0
ip   = 0x00000001, sp   = 0xffda6348
lr   = 0xf6f7a539, pc   = 0xf6fe3228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    253576 KB
Buffers:     11616 KB
Cached:      58020 KB
VmPeak:      53576 KB
VmSize:      53572 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11964 KB
VmRSS:       11964 KB
VmData:      11300 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 17022 TID = 17022
17022 17026 

Maps Information
f3e45000 f4644000 rw-p [stack:17026]
f464b000 f464d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4655000 f4659000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4662000 f4664000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f466c000 f466f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f467e000 f4683000 r-xp /usr/lib/libsystem.so.0.0.0
f468e000 f4691000 r-xp /lib/libattr.so.1.1.0
f4699000 f46a9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f46b1000 f46ba000 r-xp /usr/lib/libedbus.so.1.7.99
f46c2000 f46c3000 r-xp /usr/lib/libresponse.so.0.2.96
f46cc000 f46d1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f5f73000 f6079000 r-xp /usr/lib/libicuuc.so.57.1
f608f000 f6217000 r-xp /usr/lib/libicui18n.so.57.1
f6227000 f6234000 r-xp /usr/lib/libail.so.0.1.0
f623d000 f6244000 r-xp /usr/lib/libminizip.so.1.0.0
f624d000 f63f6000 r-xp /usr/lib/libcrypto.so.1.0.0
f6416000 f645d000 r-xp /usr/lib/libssl.so.1.0.0
f6469000 f646b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6473000 f647a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6483000 f648a000 r-xp /lib/libcrypt-2.13.so
f64bb000 f64be000 r-xp /lib/libcap.so.2.21
f64c6000 f64c8000 r-xp /usr/lib/libiri.so
f64d0000 f6519000 r-xp /usr/lib/libmdm.so.1.2.69
f6521000 f6527000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f652f000 f6552000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f655c000 f655e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6566000 f6583000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f658c000 f6590000 r-xp /usr/lib/libsmack.so.1.0.0
f6599000 f65b2000 r-xp /usr/lib/libnetwork.so.0.0.0
f65bb000 f65c3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f65cb000 f65d1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f65da000 f65dc000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f65e5000 f65f5000 r-xp /lib/libresolv-2.13.so
f65f9000 f6611000 r-xp /usr/lib/liblzma.so.5.0.3
f661a000 f661c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6624000 f663e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6646000 f6675000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f667e000 f668d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6697000 f66a1000 r-xp /usr/lib/libsensord-shared.so
f66aa000 f677d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6788000 f679e000 r-xp /lib/libz.so.1.2.5
f67a6000 f67ab000 r-xp /usr/lib/libffi.so.5.0.10
f67b3000 f67b4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f67bc000 f67cc000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f67d4000 f67ed000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f67f5000 f67f7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f67ff000 f6874000 r-xp /usr/lib/libsqlite3.so.0.8.6
f687e000 f6884000 r-xp /lib/librt-2.13.so
f688d000 f68ab000 r-xp /usr/lib/libsystemd.so.0.4.0
f68b5000 f68b6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f68be000 f68e1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f68e9000 f68ee000 r-xp /usr/lib/libxdgmime.so.1.1.0
f68f6000 f6920000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6929000 f6940000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6948000 f69b1000 r-xp /lib/libm-2.13.so
f69ba000 f6a4e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6a61000 f6a66000 r-xp /usr/lib/libctx-client.so.0.8.3
f6a6e000 f6a75000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6a7d000 f6aa7000 r-xp /usr/lib/libsensor.so.1.9.6
f6ab0000 f6b7c000 r-xp /usr/lib/libxml2.so.2.7.8
f6b89000 f6b8b000 r-xp /usr/lib/libiniparser.so.0
f6b94000 f6b9a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ba3000 f6c73000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6c74000 f6ca8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cb1000 f6ced000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6cf5000 f6cf8000 r-xp /usr/lib/libbundle.so.0.1.22
f6d00000 f6d06000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d0e000 f6d4f000 r-xp /usr/lib/libeina.so.1.7.99
f6d58000 f6d6f000 r-xp /usr/lib/libecore.so.1.7.99
f6d86000 f6d8f000 r-xp /usr/lib/libvconf.so.0.2.45
f6d97000 f6dab000 r-xp /lib/libpthread-2.13.so
f6db6000 f6dc3000 r-xp /usr/lib/libaul.so.0.1.0
f6dcd000 f6dcf000 r-xp /lib/libdl-2.13.so
f6dd8000 f6de3000 r-xp /lib/libunwind.so.8.0.1
f6e10000 f6e18000 r-xp /lib/libgcc_s-4.6.so.1
f6e19000 f6f3d000 r-xp /lib/libc-2.13.so
f6f4b000 f6f4d000 r-xp /usr/lib/libdlog.so.0.0.0
f6f55000 f6f61000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6f6a000 f6f6f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6f77000 f6f86000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f6f8e000 f6f92000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6f9b000 f6f9e000 r-xp /usr/lib/libappcore-agent.so.1.1
f6fa6000 f6fa8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f6fb0000 f6fb4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f6fbc000 f6fd9000 r-xp /lib/ld-2.13.so
f6fe2000 f6fe5000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f6fe5000 f6fe9000 r-xp /usr/lib/libsys-assert.so
f77b5000 f7843000 rw-p [heap]
ffd87000 ffda8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17022)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf6fe3228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf6f7a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6c813f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6c7fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6c8be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6c91be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6c91dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6cc675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6cc11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6c7fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6c8be57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6c91be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6c91dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6cc3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6cc4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ccbf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf46631fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4656171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6729663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6bd6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6bd87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6d68ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6d63b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6d645a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6d64879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf6f9c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf6f9c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf6fe35c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf6e3085c) [/lib/libc.so.6] + 0x1785c
29: (0xf6fe2f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
06-07 17:10:06.651+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:06.651+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:06:648,-0.983450,-4.402793,8.793623
06-07 17:10:06.651+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:655,-0.977118,-4.291732,8.763371
06-07 17:10:06.651+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:06.651+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.651+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:06.651+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:644,0.248479,-0.601805,-0.191987
06-07 17:10:06.651+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.661+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:06:661,79
06-07 17:10:06.661+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:659,-0.977663,-4.290154,8.764082
06-07 17:10:06.661+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.661+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:668,-0.977022,-4.288958,8.764739
06-07 17:10:06.661+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.671+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:06:669,3.920000,0.700000,0.420000
06-07 17:10:06.671+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:665,0.282705,-0.624387,-0.103717
06-07 17:10:06.671+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:06:659,-0.947558,-4.421937,8.810372
06-07 17:10:06.671+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.671+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:06.671+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:681,0.269126,-0.595309,-0.147723
06-07 17:10:06.671+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:06.681+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:672,-0.975199,-4.286177,8.766302
06-07 17:10:06.681+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.681+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:687,-0.975110,-4.282763,8.767981
06-07 17:10:06.681+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.681+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.691+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:06:685,-0.964308,-4.366901,8.851050
06-07 17:10:06.691+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:694,0.312422,-0.691592,-0.142914
06-07 17:10:06.691+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:06:686,3.500000,1.050000,0.420000
06-07 17:10:06.691+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.691+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:06.691+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:699,0.252332,-0.682905,-0.118037
06-07 17:10:06.691+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.701+0200 W/CAPI_APPFW_APP_CONTROL(16876): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:10:06.701+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:10:06.701+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(16876), cmd(0)
06-07 17:10:06.701+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:690,-0.974382,-4.281814,8.768525
06-07 17:10:06.701+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.701+0200 I/utils   (16876): specific action
06-07 17:10:06.701+0200 W/CAPI_APPFW_APP_CONTROL(16876): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:10:06.701+0200 I/utils   (16876): specific action
06-07 17:10:06.701+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:06.701+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:10:06.701+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(16876), cmd(0)
06-07 17:10:06.711+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:710,-0.974344,-4.282695,8.768099
06-07 17:10:06.711+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.731+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:704,0.181137,-0.575108,-0.172216
06-07 17:10:06.741+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:720,-0.975130,-4.284479,8.767140
06-07 17:10:06.741+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.741+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.751+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:751,0.154156,-0.429519,-0.129035
06-07 17:10:06.761+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:747,-0.976413,-4.286458,8.766030
06-07 17:10:06.761+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:06:704,-1.016950,-4.364508,8.774480
06-07 17:10:06.761+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.781+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.781+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:06.791+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:06:715,2.450000,0.700000,0.420000
06-07 17:10:06.801+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:779,-0.978317,-4.285825,8.766128
06-07 17:10:06.801+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.801+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:06:790,-0.978664,-4.400401,8.805587
06-07 17:10:06.801+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:06.801+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:06.811+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:06:815,806.000000
06-07 17:10:06.811+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:793,0.196428,-0.503553,-0.119902
06-07 17:10:06.811+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.811+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:06.821+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:811,-0.978894,-4.285181,8.766377
06-07 17:10:06.831+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:831,0.209853,-0.492150,-0.110314
06-07 17:10:06.831+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:06:814,1.260000,0.140000,0.210000
06-07 17:10:06.831+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.831+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:06:826,-0.993021,-4.388437,8.791230
06-07 17:10:06.841+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:06.841+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.841+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:06.851+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:06:851,-1.004985,-4.407579,8.793623
06-07 17:10:06.851+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:06:855,0.350000,0.140000,0.140000
06-07 17:10:06.851+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:06.861+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:845,-0.980979,-4.284091,8.766678
06-07 17:10:06.861+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:06:864,78
06-07 17:10:06.861+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.871+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:06.871+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:06.871+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:865,0.250054,-0.482742,-0.059775
06-07 17:10:06.881+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.881+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:870,-0.981597,-4.282937,8.767172
06-07 17:10:06.881+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.881+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:06:879,-0.978664,-4.407579,8.853443
06-07 17:10:06.891+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:890,0.177728,-0.470550,-0.133457
06-07 17:10:06.891+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:893,-0.983903,-4.280792,8.767962
06-07 17:10:06.891+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:06:885,0.280000,0.350000,0.210000
06-07 17:10:06.891+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:06.901+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.901+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.901+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:06:905,-0.952343,-4.424329,8.841480
06-07 17:10:06.901+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:06.901+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:06.911+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:914,0.143377,-0.514531,-0.150929
06-07 17:10:06.911+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:06:913,0.910000,0.350000,0.210000
06-07 17:10:06.911+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:910,-0.983002,-4.280602,8.768154
06-07 17:10:06.921+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:06.921+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.931+0200 W/LOCATION(17022): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:10:06.931+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.951+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:950,0.116401,-0.458618,-0.099223
06-07 17:10:06.951+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:06:909,-0.971486,-4.347759,8.788837
06-07 17:10:06.951+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:06.951+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.951+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:960,0.127629,-0.396041,-0.083419
06-07 17:10:06.961+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:943,-0.981196,-4.282877,8.767245
06-07 17:10:06.961+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.961+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:968,0.059656,-0.316779,-0.054398
06-07 17:10:06.961+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.971+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.971+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:06:948,1.330000,0.350000,0.210000
06-07 17:10:06.971+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:06.971+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:974,0.120031,-0.271682,-0.063467
06-07 17:10:06.971+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.971+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:977,-0.979056,-4.285539,8.766184
06-07 17:10:06.971+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:06.981+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:984,0.093513,-0.299003,-0.080391
06-07 17:10:06.981+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:06:981,1.890000,-0.560000,-0.210000
06-07 17:10:06.981+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:06.981+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.991+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:06:991,0.132063,-0.299850,-0.045828
06-07 17:10:06.991+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:06.991+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:06:959,-1.012164,-4.371687,8.793623
06-07 17:10:06.991+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.001+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:0,0.075478,-0.304389,-0.073185
06-07 17:10:07.001+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.011+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:07.011+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:2,-0.995414,-4.398008,8.784052
06-07 17:10:07.011+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:06:985,-0.978979,-4.287759,8.765107
06-07 17:10:07.011+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:07:17,806.000000
06-07 17:10:07.021+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.021+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.021+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:12,0.070001,-0.355009,-0.049052
06-07 17:10:07.021+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.031+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:06:990,1.680000,-0.840000,-0.210000
06-07 17:10:07.031+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:34,0.064467,-0.333646,-0.079848
06-07 17:10:07.031+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:26,-0.973879,-4.438686,8.788837
06-07 17:10:07.031+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.031+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.041+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:43,0.049711,-0.265305,-0.070314
06-07 17:10:07.041+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.051+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:07.051+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:26,-0.980632,-4.292113,8.762792
06-07 17:10:07.051+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.061+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:07.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:10:07.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:10:07.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:10:07.061+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:07:67,78
06-07 17:10:07.061+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:49,0.127003,-0.262398,-0.013301
06-07 17:10:07.061+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.071+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:73,0.154468,-0.294946,-0.034297
06-07 17:10:07.071+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.071+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:07:58,1.400000,-0.840000,-0.210000
06-07 17:10:07.071+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:07.081+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:82,0.125734,-0.227479,-0.032992
06-07 17:10:07.081+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.081+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:63,-0.980836,-4.296113,8.760808
06-07 17:10:07.081+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.091+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:42,-0.923629,-4.424329,8.817552
06-07 17:10:07.091+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.091+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:91,0.086179,-0.243234,-0.042970
06-07 17:10:07.091+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.091+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:100,0.093263,-0.263147,-0.003235
06-07 17:10:07.101+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.101+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:106,0.023746,-0.188872,0.005810
06-07 17:10:07.101+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.101+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:95,-0.979569,-4.299821,8.759130
06-07 17:10:07.101+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.111+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:112,-0.023697,-0.186848,-0.022029
06-07 17:10:07.111+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:96,-0.949951,-4.376472,8.784052
06-07 17:10:07.111+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.111+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.111+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:119,-1.009771,-4.381258,8.793623
06-07 17:10:07.111+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:120,0.037438,-0.233668,-0.040650
06-07 17:10:07.121+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.121+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:126,0.089298,-0.168473,-0.026514
06-07 17:10:07.121+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.121+0200 I/gyroscope(16876): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:07:85,1.190000,0.140000,0.280000
06-07 17:10:07.131+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:131,0.138475,-0.146920,-0.018888
06-07 17:10:07.131+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.131+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:139,0.043634,-0.135637,-0.012896
06-07 17:10:07.131+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.141+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:113,-0.981440,-4.302712,8.757502
06-07 17:10:07.141+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.141+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:145,0.012894,-0.169117,0.002539
06-07 17:10:07.141+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.151+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:152,0.004300,-0.161761,0.003771
06-07 17:10:07.151+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.151+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.151+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:160,-0.971486,-4.398008,8.815158
06-07 17:10:07.151+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:160,0.056868,-0.193607,0.002054
06-07 17:10:07.161+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.161+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:166,0.039012,-0.166522,0.009087
06-07 17:10:07.161+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.171+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:172,0.051069,-0.135321,0.059012
06-07 17:10:07.171+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.171+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:178,0.031722,-0.093451,0.010180
06-07 17:10:07.171+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.181+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:185,0.042341,-0.089929,0.047607
06-07 17:10:07.181+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:149,-0.983501,-4.305075,8.756108
06-07 17:10:07.181+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.181+0200 E/RESOURCED( 2560): lowmem-limit.c: lowmem_limit_cb(305) > some application was crashed by kernel when it exceeded the threshold (104857600)
06-07 17:10:07.181+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.191+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:195,0.003816,-0.123231,0.017439
06-07 17:10:07.191+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.201+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:202,0.039093,-0.086300,0.046494
06-07 17:10:07.201+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.201+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:07.211+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:07:215,806.000000
06-07 17:10:07.211+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:210,0.036674,-0.201872,0.057747
06-07 17:10:07.211+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.221+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:222,0.054568,-0.173916,-0.004182
06-07 17:10:07.221+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:191,-0.983771,-4.305045,8.756093
06-07 17:10:07.231+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.231+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.241+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.241+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:239,-0.937986,-4.388437,8.815158
06-07 17:10:07.241+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:245,-0.980765,-4.304644,8.756627
06-07 17:10:07.241+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.251+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.251+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:07:236,0.063825,-0.140445,0.026243
06-07 17:10:07.251+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:253,-0.978752,-4.304913,8.756721
06-07 17:10:07.251+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.251+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:07.261+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:07:261,78
06-07 17:10:07.261+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:259,-0.981234,-4.309440,8.754215
06-07 17:10:07.261+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.261+0200 I/linearacceleration(16891): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:07.261+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:269,-0.984333,-4.315147,8.751056
06-07 17:10:07.261+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.271+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:274,-0.986703,-4.318322,8.749223
06-07 17:10:07.271+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.271+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:279,-0.988245,-4.324647,8.745924
06-07 17:10:07.271+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.281+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:265,-0.947558,-4.395615,8.800802
06-07 17:10:07.281+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:285,-0.986918,-4.326509,8.745153
06-07 17:10:07.281+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.281+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:289,-0.984437,-4.329373,8.744015
06-07 17:10:07.281+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.291+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:293,-0.983176,-4.329505,8.744091
06-07 17:10:07.291+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.291+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:300,-0.984559,-4.330801,8.743295
06-07 17:10:07.301+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.301+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.311+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:306,-0.983765,-4.332767,8.742410
06-07 17:10:07.311+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.311+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:308,-0.988236,-4.390830,8.807980
06-07 17:10:07.311+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:316,-0.983535,-4.334180,8.741735
06-07 17:10:07.311+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.321+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:320,-0.983569,-4.335580,8.741036
06-07 17:10:07.321+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.321+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:326,-0.981668,-4.335374,8.741353
06-07 17:10:07.321+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.331+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:334,-0.979012,-4.336105,8.741288
06-07 17:10:07.331+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.331+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:339,-0.978272,-4.336229,8.741309
06-07 17:10:07.331+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.341+0200 E/RESOURCED( 2560): lowmem-limit.c: lowmem_limit_cb(305) > some application was crashed by kernel when it exceeded the threshold (104857600)
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:07.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391407348,000000, pattern:[H:mm][0;m
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:07.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:07.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:10:07.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:10][0;m
06-07 17:10:07.351+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.371+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:363,-1.019342,-4.350152,8.791230
06-07 17:10:07.381+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.391+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:394,-0.959522,-4.354938,8.841480
06-07 17:10:07.401+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:343,-0.979352,-4.337092,8.740760
06-07 17:10:07.401+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.401+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:406,-0.979033,-4.338070,8.740311
06-07 17:10:07.401+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.411+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:07.411+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.411+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:07:416,807.000000
06-07 17:10:07.421+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:421,-0.976966,-4.339395,8.739884
06-07 17:10:07.421+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.421+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:421,-0.995414,-4.383651,8.851050
06-07 17:10:07.431+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:430,-0.973282,-4.340363,8.739815
06-07 17:10:07.431+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.431+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.441+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:440,-0.972325,-4.342114,8.739051
06-07 17:10:07.451+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.451+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:456,-0.973801,-4.342971,8.738461
06-07 17:10:07.451+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.451+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:07.451+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:07:461,78
06-07 17:10:07.461+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:460,-0.972615,-4.342690,8.738732
06-07 17:10:07.461+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.471+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:474,-0.970269,-4.342435,8.739120
06-07 17:10:07.471+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.471+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:447,-0.990629,-4.369294,8.829515
06-07 17:10:07.481+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.481+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:482,-0.969119,-4.343646,8.738646
06-07 17:10:07.481+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.491+0200 E/AUL_AMD ( 2479): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
06-07 17:10:07.491+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:10:07.491+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(16891), cmd(0)
06-07 17:10:07.511+0200 W/AUL     (17084): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.linearacceleration]
06-07 17:10:07.511+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:492,-0.970134,-4.344005,8.738355
06-07 17:10:07.511+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.511+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:10:07.511+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 17:10:07.511+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 16891
06-07 17:10:07.511+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:10:07.521+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16891
06-07 17:10:07.521+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(16891)
06-07 17:10:07.521+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:502,-0.926022,-4.376472,8.822337
06-07 17:10:07.531+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:523,-0.972639,-4.343346,8.738404
06-07 17:10:07.531+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.541+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:538,-0.971062,-4.340758,8.739865
06-07 17:10:07.541+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.551+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:549,-0.970353,-4.338343,8.741143
06-07 17:10:07.551+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.551+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.551+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:557,-0.970395,-4.337096,8.741757
06-07 17:10:07.551+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.561+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:560,-0.971486,-4.376472,8.834301
06-07 17:10:07.561+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.571+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:568,-1.000200,-4.359723,8.841480
06-07 17:10:07.581+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.581+0200 W/AUL     (17085): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
06-07 17:10:07.591+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:10:07.591+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 17:10:07.591+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 16604
06-07 17:10:07.591+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:10:07.591+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 16604
06-07 17:10:07.591+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(16604)
06-07 17:10:07.591+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:589,-1.007378,-4.393222,8.781659
06-07 17:10:07.601+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.601+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:07.611+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:608,-1.000200,-4.388437,8.817552
06-07 17:10:07.611+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.611+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:617,-1.004985,-4.364508,8.810372
06-07 17:10:07.611+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.611+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:07:615,806.000000
06-07 17:10:07.611+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:561,-0.967424,-4.336439,8.742413
06-07 17:10:07.621+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.621+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:623,-0.990629,-4.352544,8.805587
06-07 17:10:07.621+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.621+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:628,-0.967460,-4.336865,8.742197
06-07 17:10:07.631+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:629,-0.990629,-4.388437,8.803195
06-07 17:10:07.631+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.631+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:637,-0.918844,-4.369294,8.822337
06-07 17:10:07.631+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.631+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:641,-0.911665,-4.400401,8.853443
06-07 17:10:07.641+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.641+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.641+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:646,-0.973879,-4.366901,8.786445
06-07 17:10:07.641+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.651+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:647,-0.968853,-4.336577,8.742186
06-07 17:10:07.651+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.651+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:651,-0.949951,-4.357330,8.815158
06-07 17:10:07.651+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.651+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:07.651+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:658,-0.981057,-4.390830,8.812766
06-07 17:10:07.651+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.661+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:07:662,78
06-07 17:10:07.661+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:664,-0.937986,-4.412365,8.817552
06-07 17:10:07.661+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.661+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:669,-1.019342,-4.359723,8.755339
06-07 17:10:07.661+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.671+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:673,-0.964308,-4.398008,8.784052
06-07 17:10:07.671+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:657,-0.970218,-4.337867,8.741394
06-07 17:10:07.671+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.671+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.671+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:680,-0.970933,-4.338232,8.741134
06-07 17:10:07.671+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:680,-1.000200,-4.400401,8.853443
06-07 17:10:07.671+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.681+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.681+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:684,-0.959522,-4.455436,8.831908
06-07 17:10:07.681+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:689,-0.972344,-4.339189,8.740501
06-07 17:10:07.681+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.681+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.691+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:693,-0.972695,-4.339038,8.740538
06-07 17:10:07.691+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:695,-0.978664,-4.438686,8.791230
06-07 17:10:07.691+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.691+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.701+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:702,-0.972177,-4.339526,8.740353
06-07 17:10:07.701+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.711+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:705,-0.988236,-4.364508,8.791230
06-07 17:10:07.711+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.711+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:714,-0.967870,-4.337913,8.741632
06-07 17:10:07.711+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.721+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:718,-0.959522,-4.376472,8.796017
06-07 17:10:07.721+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:723,-0.964178,-4.338133,8.741930
06-07 17:10:07.721+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.721+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.731+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:731,-0.952343,-4.386044,8.827123
06-07 17:10:07.731+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:731,-0.964956,-4.339624,8.741104
06-07 17:10:07.731+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.731+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.751+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:741,-0.964463,-4.340057,8.740944
06-07 17:10:07.751+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.751+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:757,-0.964595,-4.340800,8.740561
06-07 17:10:07.751+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.761+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:765,-0.962768,-4.342537,8.739899
06-07 17:10:07.761+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.771+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:774,-0.965600,-4.344238,8.738741
06-07 17:10:07.781+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.781+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:786,-0.965661,-4.346739,8.737491
06-07 17:10:07.781+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.791+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:743,-0.947558,-4.402793,8.793623
06-07 17:10:07.791+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.791+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:793,-0.966468,-4.347044,8.737249
06-07 17:10:07.791+0200 I/gravity (17060): es.ugr.frailty.gravity - capturing data
06-07 17:10:07.801+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:799,-0.969093,-4.386044,8.796017
06-07 17:10:07.801+0200 I/gravity (17060): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:07:803,-0.965522,-4.349806,8.735980
06-07 17:10:07.801+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:07.801+0200 I/accelerometer(16997): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:07:810,-0.949951,-4.419543,8.831908
06-07 17:10:07.801+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:07.811+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11170226c6f63152838420
