S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12906
Date: 2018-06-07 16:55:58+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf729a52d, r5   = 0xf75cef98
r6   = 0xffdbad30, r7   = 0xffdbabe0
r8   = 0xf75cbc18, r9   = 0x00000000
r10  = 0xffdbacbc, fp   = 0xffdbad30
ip   = 0x00000001, sp   = 0xffdbabb8
lr   = 0xf729a539, pc   = 0xf7303228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    208220 KB
Buffers:      2928 KB
Cached:      76084 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11628 KB
VmRSS:       11624 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12906 TID = 12906
12906 12910 

Maps Information
f4165000 f4964000 rw-p [stack:12910]
f496b000 f496d000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4975000 f4979000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4982000 f4984000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f498c000 f498f000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f499e000 f49a3000 r-xp /usr/lib/libsystem.so.0.0.0
f49ae000 f49b1000 r-xp /lib/libattr.so.1.1.0
f49b9000 f49c9000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49d1000 f49da000 r-xp /usr/lib/libedbus.so.1.7.99
f49e2000 f49e3000 r-xp /usr/lib/libresponse.so.0.2.96
f49ec000 f49f1000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6293000 f6399000 r-xp /usr/lib/libicuuc.so.57.1
f63af000 f6537000 r-xp /usr/lib/libicui18n.so.57.1
f6547000 f6554000 r-xp /usr/lib/libail.so.0.1.0
f655d000 f6564000 r-xp /usr/lib/libminizip.so.1.0.0
f656d000 f6716000 r-xp /usr/lib/libcrypto.so.1.0.0
f6736000 f677d000 r-xp /usr/lib/libssl.so.1.0.0
f6789000 f678b000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6793000 f679a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67a3000 f67aa000 r-xp /lib/libcrypt-2.13.so
f67db000 f67de000 r-xp /lib/libcap.so.2.21
f67e6000 f67e8000 r-xp /usr/lib/libiri.so
f67f0000 f6839000 r-xp /usr/lib/libmdm.so.1.2.69
f6841000 f6847000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f684f000 f6872000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f687c000 f687e000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6886000 f68a3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68ac000 f68b0000 r-xp /usr/lib/libsmack.so.1.0.0
f68b9000 f68d2000 r-xp /usr/lib/libnetwork.so.0.0.0
f68db000 f68e3000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68eb000 f68f1000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68fa000 f68fc000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6905000 f6915000 r-xp /lib/libresolv-2.13.so
f6919000 f6931000 r-xp /usr/lib/liblzma.so.5.0.3
f693a000 f693c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6944000 f695e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6966000 f6995000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f699e000 f69ad000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69b7000 f69c1000 r-xp /usr/lib/libsensord-shared.so
f69ca000 f6a9d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6aa8000 f6abe000 r-xp /lib/libz.so.1.2.5
f6ac6000 f6acb000 r-xp /usr/lib/libffi.so.5.0.10
f6ad3000 f6ad4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6adc000 f6aec000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6af4000 f6b0d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b15000 f6b17000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b1f000 f6b94000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b9e000 f6ba4000 r-xp /lib/librt-2.13.so
f6bad000 f6bcb000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bd5000 f6bd6000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bde000 f6c01000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c09000 f6c0e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c16000 f6c40000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c49000 f6c60000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c68000 f6cd1000 r-xp /lib/libm-2.13.so
f6cda000 f6d6e000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d81000 f6d86000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d8e000 f6d95000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d9d000 f6dc7000 r-xp /usr/lib/libsensor.so.1.9.6
f6dd0000 f6e9c000 r-xp /usr/lib/libxml2.so.2.7.8
f6ea9000 f6eab000 r-xp /usr/lib/libiniparser.so.0
f6eb4000 f6eba000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ec3000 f6f93000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f94000 f6fc8000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fd1000 f700d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7015000 f7018000 r-xp /usr/lib/libbundle.so.0.1.22
f7020000 f7026000 r-xp /usr/lib/libappsvc.so.0.1.0
f702e000 f706f000 r-xp /usr/lib/libeina.so.1.7.99
f7078000 f708f000 r-xp /usr/lib/libecore.so.1.7.99
f70a6000 f70af000 r-xp /usr/lib/libvconf.so.0.2.45
f70b7000 f70cb000 r-xp /lib/libpthread-2.13.so
f70d6000 f70e3000 r-xp /usr/lib/libaul.so.0.1.0
f70ed000 f70ef000 r-xp /lib/libdl-2.13.so
f70f8000 f7103000 r-xp /lib/libunwind.so.8.0.1
f7130000 f7138000 r-xp /lib/libgcc_s-4.6.so.1
f7139000 f725d000 r-xp /lib/libc-2.13.so
f726b000 f726d000 r-xp /usr/lib/libdlog.so.0.0.0
f7275000 f7281000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f728a000 f728f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7297000 f72a6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72ae000 f72b2000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72bb000 f72be000 r-xp /usr/lib/libappcore-agent.so.1.1
f72c6000 f72c8000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72d0000 f72d4000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72dc000 f72f9000 r-xp /lib/ld-2.13.so
f7302000 f7305000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7305000 f7309000 r-xp /usr/lib/libsys-assert.so
f759b000 f7629000 rw-p [heap]
ffd9c000 ffdbd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12906)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7303228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf729a539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fa13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f9fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6fabe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6fb1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6fb1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fe675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6fe11f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f9fc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6fabe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6fb1be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6fb1dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fe3e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6fe4017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6febf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49831fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4976171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a49663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ef6fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ef87a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7088ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7083b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70845a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7084879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72bc183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72bc7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73035c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf715085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7302f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
eration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.061+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:59,-4.820070,2.131222,-1.531506
06-07 16:55:58.061+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:55:58.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:55:58.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:55:58.061+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:69,-0.156360,0.435702,-1.033916
06-07 16:55:58.061+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.071+0200 I/utils   (12809): specific action
06-07 16:55:58.071+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.071+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:37,-4.200000,64.120003,15.960000
06-07 16:55:58.071+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:75,-1.274573,-0.563500,-3.324825
06-07 16:55:58.071+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.071+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.081+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:82,-3.039937,-1.679142,-4.600612
06-07 16:55:58.081+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.081+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:55,-4.815160,0.271575,8.538786
06-07 16:55:58.081+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:87,-4.143303,-1.690730,-2.119313
06-07 16:55:58.081+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.091+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:78,-9.695717,-3.084348,20.855844
06-07 16:55:58.091+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:92,-3.090874,0.420274,-0.030111
06-07 16:55:58.091+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.091+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.091+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.091+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:98,-2.578339,-1.334395,-2.771645
06-07 16:55:58.091+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:89,-18.900000,14.770000,4.060000
06-07 16:55:58.091+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.101+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:105,-2.640632,-2.754908,-5.516106
06-07 16:55:58.101+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.101+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:103,-4.794164,0.253020,8.551162
06-07 16:55:58.101+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.101+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:109,-4.760231,-0.329850,-1.729089
06-07 16:55:58.111+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.111+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:116,-2.275160,-1.789435,-1.903777
06-07 16:55:58.111+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.111+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:114,-37.869999,-3.710000,6.370000
06-07 16:55:58.121+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:121,-2.469944,-2.137481,-2.156847
06-07 16:55:58.121+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.121+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:107,-8.535198,0.696311,7.996813
06-07 16:55:58.121+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.121+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.121+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:127,-2.271147,0.194288,-2.461703
06-07 16:55:58.121+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.131+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:132,-2.256114,-1.434149,-1.979521
06-07 16:55:58.131+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.131+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.131+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:137,-2.407699,-0.999983,-1.725770
06-07 16:55:58.131+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:55:58.131+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(12857), cmd(0)
06-07 16:55:58.131+0200 W/CAPI_APPFW_APP_CONTROL(12857): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:55:58.131+0200 I/utils   (12857): specific action
06-07 16:55:58.131+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.141+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:144,-1.965266,0.321757,-2.274461
06-07 16:55:58.141+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.141+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:135,-7.712067,1.859223,5.836094
06-07 16:55:58.141+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:131,-4.865675,0.257429,8.510542
06-07 16:55:58.141+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:150,-3.184829,-0.817252,-3.965883
06-07 16:55:58.141+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.151+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.151+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.151+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:155,-3.754354,-1.147128,-5.509776
06-07 16:55:58.151+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:145,-45.570000,3.710000,-7.770000
06-07 16:55:58.151+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.161+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:162,-3.951642,-4.448730,-7.493004
06-07 16:55:58.161+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.171+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.171+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:175,-5.718846,0.270389,2.902494
06-07 16:55:58.171+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:157,-4.975331,0.295180,8.445669
06-07 16:55:58.181+0200 W/LOCATION(12906): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:55:58.181+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:168,-5.351595,-5.137349,-7.424713
06-07 16:55:58.181+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.181+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:191,-3.111689,-1.739699,-2.590833
06-07 16:55:58.181+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.181+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.191+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:179,-42.560001,26.250000,-9.590000
06-07 16:55:58.191+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:195,-1.816460,-0.153569,-0.120648
06-07 16:55:58.191+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.191+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.191+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.191+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:200,0.843773,-1.034005,-2.646639
06-07 16:55:58.191+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.201+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:204,-3.206959,-2.404730,-2.977897
06-07 16:55:58.201+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.201+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:209,-1.345280,-0.813554,-1.009507
06-07 16:55:58.201+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.201+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:197,-5.081087,0.348552,8.380421
06-07 16:55:58.211+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:205,-3.101098,-1.562513,3.254239
06-07 16:55:58.211+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.211+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:215,-60.270000,55.160000,-16.520000
06-07 16:55:58.211+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.211+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.221+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:220,-1.680000,47.389999,2.730000
06-07 16:55:58.221+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:58.221+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:58:226,82
06-07 16:55:58.221+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.221+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:213,-1.409199,-2.238702,-0.593751
06-07 16:55:58.221+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:217,-5.145613,0.378835,8.339637
06-07 16:55:58.221+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.231+0200 I/Vi::Animations(11356): static void Vi::Animations::_EflNode::nativeSmartObjectDelCB(void *, Evas *, Evas_Object *, void *)(219) > NativeObject(0xee816870) is deleting
06-07 16:55:58.231+0200 I/Vi::Animations(11356): static void Vi::Animations::_EflVisualSurfaceImpl::nativeObjectDelCB(void *, Evas *, Evas_Object *, void *)(121) > NativeObject(0xee816870) is deleting
06-07 16:55:58.231+0200 I/Vi::Animations(11356): static void Vi::Animations::_EflNode::nativeSmartObjectDelCB(void *, Evas *, Evas_Object *, void *)(219) > NativeObject(0xee816290) is deleting
06-07 16:55:58.231+0200 I/Vi::Animations(11356): static void Vi::Animations::_EflVisualSurfaceImpl::nativeObjectDelCB(void *, Evas *, Evas_Object *, void *)(121) > NativeObject(0xee816290) is deleting
06-07 16:55:58.231+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:231,-20.299999,18.340000,0.350000
06-07 16:55:58.231+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.231+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:234,-3.309391,0.531525,-3.513268
06-07 16:55:58.241+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.241+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:58.241+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:241,-60.619999,13.370000,15.120000
06-07 16:55:58.241+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.251+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:58:250,788.000000
06-07 16:55:58.251+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:226,-9.939785,-4.869394,7.434500
06-07 16:55:58.251+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:248,-2.793240,-1.421762,-2.001828
06-07 16:55:58.251+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.251+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.261+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:254,-37.450001,21.280001,21.420000
06-07 16:55:58.261+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.261+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.261+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:261,-5.189126,0.344207,8.314137
06-07 16:55:58.261+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:267,-15.260000,32.619999,15.610000
06-07 16:55:58.261+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.261+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:270,-15.823736,-0.050249,8.908479
06-07 16:55:58.261+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:271,3.360000,43.259998,-2.520000
06-07 16:55:58.271+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:262,-2.039424,-3.267999,-0.517006
06-07 16:55:58.271+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.271+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.271+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:277,-2.791252,-3.825569,-1.921937
06-07 16:55:58.271+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.271+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.281+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.281+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:282,-3.892167,-2.658725,-2.502980
06-07 16:55:58.281+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.281+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:280,-5.312481,0.411169,8.232793
06-07 16:55:58.281+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:289,-2.547143,-3.996754,-1.069523
06-07 16:55:58.281+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.291+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.291+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:286,2.590000,41.650002,-4.900000
06-07 16:55:58.291+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.291+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:287,-9.702895,2.428715,6.967900
06-07 16:55:58.291+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:299,-7.420000,34.020000,-12.880000
06-07 16:55:58.301+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.301+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.301+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:296,-5.328264,0.455327,8.220260
06-07 16:55:58.301+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:294,-1.945403,-3.291864,-1.536720
06-07 16:55:58.301+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.301+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.301+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:305,-11.970000,38.080002,-4.480000
06-07 16:55:58.301+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.311+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:311,-3.525493,-2.987092,-3.308467
06-07 16:55:58.311+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.311+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:314,-5.330850,0.492452,8.216441
06-07 16:55:58.311+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:309,-5.115855,0.756132,7.420143
06-07 16:55:58.321+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.321+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:315,0.770000,41.020000,3.080000
06-07 16:55:58.321+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.321+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:327,-11.620000,21.980000,4.900000
06-07 16:55:58.321+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.321+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.331+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:320,-3.818370,-3.709005,-3.755018
06-07 16:55:58.331+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.331+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:337,-2.692128,-3.607398,-2.119244
06-07 16:55:58.331+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:55:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:55:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:55:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:55:58.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390558342,000000, pattern:[H:mm][0;m
06-07 16:55:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:55:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:55:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:55:58.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:55:58.331+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:55:58.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:55][0;m
06-07 16:55:58.331+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:332,-14.560000,16.309999,6.720000
06-07 16:55:58.331+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.341+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:341,-1.561862,-2.844682,-1.448412
06-07 16:55:58.341+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.341+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:335,-5.408097,0.611018,8.157789
06-07 16:55:58.351+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:328,-6.089733,-0.291924,5.213961
06-07 16:55:58.351+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:344,-6.160000,14.770000,10.500000
06-07 16:55:58.351+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.351+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.351+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:357,-7.834101,-1.426122,3.950550
06-07 16:55:58.351+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:351,-2.311847,-3.442694,-1.534801
06-07 16:55:58.351+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.351+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.361+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:358,-19.389999,5.950000,13.790000
06-07 16:55:58.361+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.361+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.361+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:363,-3.530924,-3.744063,-1.512503
06-07 16:55:58.361+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.361+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:368,-17.780001,1.750000,13.300000
06-07 16:55:58.371+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:369,-5.397688,0.669773,8.160070
06-07 16:55:58.371+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.371+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.371+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:374,-2.963241,-3.531792,-0.376046
06-07 16:55:58.381+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.381+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:379,-5.390271,0.745442,8.158412
06-07 16:55:58.381+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.381+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:379,-8.050000,-2.170000,6.720000
06-07 16:55:58.381+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.381+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:386,-4.618409,-4.752832,-0.188042
06-07 16:55:58.381+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:362,-9.008978,-1.433301,6.391229
06-07 16:55:58.381+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.391+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:392,-3.290000,-7.420000,-1.540000
06-07 16:55:58.391+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.391+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:399,-4.888875,-4.824862,0.163693
06-07 16:55:58.391+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:394,-8.066205,0.715454,8.415558
06-07 16:55:58.391+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.391+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.401+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:389,-5.419762,0.865109,8.127002
06-07 16:55:58.401+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.401+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.401+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:405,7.140000,-7.700000,-7.000000
06-07 16:55:58.401+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:405,-7.659425,-0.985843,5.608776
06-07 16:55:58.411+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.411+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:406,-5.474763,0.977238,8.077274
06-07 16:55:58.411+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:411,-4.038850,-4.071226,1.193638
06-07 16:55:58.411+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.411+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.411+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:417,4.200000,-5.110000,-17.290001
06-07 16:55:58.421+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:58.421+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.421+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:58:427,83
06-07 16:55:58.431+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.431+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:427,-7.786245,-2.376073,2.823531
06-07 16:55:58.431+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:425,-1.589556,-2.791354,5.020507
06-07 16:55:58.431+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.431+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:422,-5.567007,1.101171,7.997890
06-07 16:55:58.431+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.431+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.431+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:58.441+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:58:444,878.000000
06-07 16:55:58.441+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:436,11.550000,9.590000,-24.150000
06-07 16:55:58.441+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.441+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:442,-1.277793,-1.422166,1.863788
06-07 16:55:58.441+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.451+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:450,19.110001,10.150000,-20.230000
06-07 16:55:58.451+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:442,-5.566855,1.002551,8.010955
06-07 16:55:58.451+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.451+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.451+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:438,-9.949356,0.014357,6.585048
06-07 16:55:58.461+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:455,-2.185747,-3.995646,3.773575
06-07 16:55:58.461+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.461+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.461+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:467,-7.587641,-1.378266,6.329016
06-07 16:55:58.461+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.461+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:463,16.309999,-17.920000,-4.550000
06-07 16:55:58.461+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.461+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:461,-5.605364,0.962031,7.989041
06-07 16:55:58.471+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:468,-3.026386,-6.836853,2.931927
06-07 16:55:58.471+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.471+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.481+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:475,0.770000,-41.299999,1.890000
06-07 16:55:58.481+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.481+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:472,-7.798209,-1.682154,6.063413
06-07 16:55:58.481+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:482,-0.578027,-5.798393,4.387753
06-07 16:55:58.481+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:488,6.090000,-34.650002,8.400000
06-07 16:55:58.481+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:480,-5.646754,1.093948,7.942785
06-07 16:55:58.491+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.491+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.491+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.491+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.501+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:496,-1.728977,4.548183,5.373516
06-07 16:55:58.501+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.501+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:504,-7.601997,0.686740,5.754738
06-07 16:55:58.501+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:501,4.620000,-43.400002,14.630000
06-07 16:55:58.501+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:500,-5.607883,1.175181,7.958705
06-07 16:55:58.501+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.501+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.511+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:507,-1.751394,4.968369,3.420374
06-07 16:55:58.511+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.511+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:515,5.740000,-46.270000,7.490000
06-07 16:55:58.511+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.511+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:511,-5.505308,1.213104,8.024360
06-07 16:55:58.511+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.521+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:520,-7.664211,-0.823131,6.178268
06-07 16:55:58.521+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.521+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.521+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:528,24.150000,-38.779999,7.070000
06-07 16:55:58.521+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:522,-0.373540,3.456335,1.989479
06-07 16:55:58.521+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.531+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:535,0.370498,2.272488,1.565301
06-07 16:55:58.531+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:528,-7.805387,-0.330210,6.434300
06-07 16:55:58.531+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.541+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:525,-5.452729,1.313654,8.044405
06-07 16:55:58.541+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.541+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.541+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:547,-5.343347,1.444285,8.095250
06-07 16:55:58.541+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:541,9.030000,-33.950001,-0.280000
06-07 16:55:58.541+0200 W/CAPI_APPFW_APP_CONTROL(12871): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:55:58.541+0200 I/utils   (12871): specific action
06-07 16:55:58.541+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.541+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:55:58.541+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(12871), cmd(0)
06-07 16:55:58.541+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.551+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:547,0.682074,2.962826,0.246360
06-07 16:55:58.551+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.551+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.551+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:554,8.050000,-32.410000,-5.740000
06-07 16:55:58.551+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.551+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:558,0.699763,2.487400,-1.282086
06-07 16:55:58.561+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:559,-7.355537,1.067199,5.883951
06-07 16:55:58.561+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.561+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.561+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:569,-8.604590,0.047856,4.161119
06-07 16:55:58.561+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:565,15.610000,-22.190001,-11.830000
06-07 16:55:58.561+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.571+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:569,1.181981,3.286121,-2.740919
06-07 16:55:58.571+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.571+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:552,-5.204272,1.543052,8.167308
06-07 16:55:58.571+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.581+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.581+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:575,19.530001,-13.160000,-7.070000
06-07 16:55:58.581+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.581+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:580,1.306753,-0.426796,-4.410459
06-07 16:55:58.581+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.581+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:585,-9.229117,-0.169890,2.567499
06-07 16:55:58.591+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:582,-5.222716,1.807007,8.101132
06-07 16:55:58.591+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.591+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:588,8.890000,-16.170000,-14.700000
06-07 16:55:58.591+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.591+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.601+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:593,0.678426,-3.926828,-5.127229
06-07 16:55:58.601+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.601+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:603,10.150000,-17.150000,-8.330000
06-07 16:55:58.601+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:600,-9.518648,-3.347559,0.504886
06-07 16:55:58.601+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.601+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.601+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:597,-5.162972,1.956732,8.104647
06-07 16:55:58.601+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.611+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:607,0.327101,-2.791317,-4.581137
06-07 16:55:58.611+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.611+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:615,-5.042850,2.047702,8.157633
06-07 16:55:58.611+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:613,9.450000,-7.770000,-4.270000
06-07 16:55:58.611+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.621+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:55:58.621+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:611,-10.918450,-4.134798,0.586242
06-07 16:55:58.621+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:55:58:626,83
06-07 16:55:58.621+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.621+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.621+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:622,0.358706,6.457880,-0.943666
06-07 16:55:58.631+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:634,-5.670000,-4.060000,-3.080000
06-07 16:55:58.631+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.631+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:55:58.641+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.641+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:641,0.033036,4.623677,0.941326
06-07 16:55:58.641+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:55:58:644,1036.000000
06-07 16:55:58.641+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:647,-1.190000,-1.750000,-4.760000
06-07 16:55:58.641+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.651+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:624,-4.970849,2.146661,8.176362
06-07 16:55:58.651+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.651+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:631,-8.717053,-0.777667,5.398208
06-07 16:55:58.651+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.651+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.651+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:653,-0.366827,2.652080,0.986244
06-07 16:55:58.651+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.661+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:659,-4.949571,2.316993,8.142707
06-07 16:55:58.661+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:659,6.510000,-3.290000,-4.200000
06-07 16:55:58.661+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.661+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:665,-0.645597,2.966468,0.012649
06-07 16:55:58.661+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.661+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:669,-4.862177,2.413698,8.167232
06-07 16:55:58.661+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:662,-7.463214,0.940379,7.822137
06-07 16:55:58.661+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.671+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.671+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:672,9.310000,-2.310000,-5.250000
06-07 16:55:58.671+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.681+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.681+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:676,-4.764110,0.141177,5.312066
06-07 16:55:58.681+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:676,-0.738437,2.136945,1.912781
06-07 16:55:58.681+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.681+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.681+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:685,16.520000,-3.500000,-1.050000
06-07 16:55:58.691+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.691+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:692,-3.728797,10.478733,8.038513
06-07 16:55:58.691+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:687,-4.772815,2.544420,8.180254
06-07 16:55:58.691+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.691+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.691+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:692,-8.712267,-1.191626,5.046463
06-07 16:55:58.701+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.701+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:699,19.180000,-11.900000,6.090000
06-07 16:55:58.701+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.701+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:705,-5.023777,13.147107,7.555013
06-07 16:55:58.701+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:702,-4.747935,2.718376,8.138669
06-07 16:55:58.701+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.711+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.711+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:711,17.430000,-11.410000,8.470000
06-07 16:55:58.721+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.721+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:717,-4.658772,13.150111,7.371736
06-07 16:55:58.721+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.731+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:729,-8.750000,-18.969999,3.710000
06-07 16:55:58.731+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:734,-4.883621,9.229254,8.924153
06-07 16:55:58.731+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.741+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.741+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:743,-41.230000,-29.889999,-1.330000
06-07 16:55:58.741+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.751+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:747,-4.612952,-10.108222,10.052273
06-07 16:55:58.751+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.751+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:754,-72.239998,-55.930000,3.290000
06-07 16:55:58.761+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:709,-6.798009,0.500100,7.034898
06-07 16:55:58.761+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.761+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.761+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:767,-93.660004,-70.070000,15.960000
06-07 16:55:58.761+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:761,-1.874173,-4.336299,10.522744
06-07 16:55:58.761+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:715,-4.723230,2.841695,8.110872
06-07 16:55:58.761+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.761+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.771+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.781+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:767,-6.752545,-0.794417,7.501499
06-07 16:55:58.781+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:774,-0.208108,-5.817302,9.575744
06-07 16:55:58.781+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.781+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:780,-124.949997,-133.000000,29.400000
06-07 16:55:58.781+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.781+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:55:58:789,0.915640,-8.336550,9.188857
06-07 16:55:58.781+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:55:58:787,-8.513663,2.074577,4.654040
06-07 16:55:58.781+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope - capturing data
06-07 16:55:58.781+0200 I/accelerometer(12809): es.ugr.frailty.accelerometer - capturing data
06-07 16:55:58.791+0200 I/gravity (12871): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:55:58:775,-4.654690,2.981073,8.100459
06-07 16:55:58.791+0200 I/gravity (12871): es.ugr.frailty.gravity - capturing data
06-07 16:55:58.791+0200 I/linearacceleration(12857): es.ugr.frailty.linearacceleration - capturing data
06-07 16:55:58.791+0200 I/gyroscope(12853): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:55:58:794,-127.470001,-164.990005,19.530001
06-07 16:55:58.791+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11129066c6f63152838335
