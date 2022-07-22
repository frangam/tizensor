S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 17250
Date: 2018-06-07 17:10:55+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf72e252d, r5   = 0xf7a39f98
r6   = 0xfff7b430, r7   = 0xfff7b2e0
r8   = 0xf7a36c18, r9   = 0x00000000
r10  = 0xfff7b3bc, fp   = 0xfff7b430
ip   = 0x00000001, sp   = 0xfff7b2b8
lr   = 0xf72e2539, pc   = 0xf734b228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    209184 KB
Buffers:     13188 KB
Cached:      58324 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11484 KB
VmRSS:       11484 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 17250 TID = 17250
17250 17254 

Maps Information
f41ad000 f49ac000 rw-p [stack:17254]
f49b3000 f49b5000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f49bd000 f49c1000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f49ca000 f49cc000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f49d4000 f49d7000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f49e6000 f49eb000 r-xp /usr/lib/libsystem.so.0.0.0
f49f6000 f49f9000 r-xp /lib/libattr.so.1.1.0
f4a01000 f4a11000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a19000 f4a22000 r-xp /usr/lib/libedbus.so.1.7.99
f4a2a000 f4a2b000 r-xp /usr/lib/libresponse.so.0.2.96
f4a34000 f4a39000 r-xp /usr/lib/libproc-stat.so.0.2.96
f62db000 f63e1000 r-xp /usr/lib/libicuuc.so.57.1
f63f7000 f657f000 r-xp /usr/lib/libicui18n.so.57.1
f658f000 f659c000 r-xp /usr/lib/libail.so.0.1.0
f65a5000 f65ac000 r-xp /usr/lib/libminizip.so.1.0.0
f65b5000 f675e000 r-xp /usr/lib/libcrypto.so.1.0.0
f677e000 f67c5000 r-xp /usr/lib/libssl.so.1.0.0
f67d1000 f67d3000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f67db000 f67e2000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f67eb000 f67f2000 r-xp /lib/libcrypt-2.13.so
f6823000 f6826000 r-xp /lib/libcap.so.2.21
f682e000 f6830000 r-xp /usr/lib/libiri.so
f6838000 f6881000 r-xp /usr/lib/libmdm.so.1.2.69
f6889000 f688f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6897000 f68ba000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f68c4000 f68c6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f68ce000 f68eb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f68f4000 f68f8000 r-xp /usr/lib/libsmack.so.1.0.0
f6901000 f691a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6923000 f692b000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6933000 f6939000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6942000 f6944000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f694d000 f695d000 r-xp /lib/libresolv-2.13.so
f6961000 f6979000 r-xp /usr/lib/liblzma.so.5.0.3
f6982000 f6984000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f698c000 f69a6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69ae000 f69dd000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f69e6000 f69f5000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69ff000 f6a09000 r-xp /usr/lib/libsensord-shared.so
f6a12000 f6ae5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6af0000 f6b06000 r-xp /lib/libz.so.1.2.5
f6b0e000 f6b13000 r-xp /usr/lib/libffi.so.5.0.10
f6b1b000 f6b1c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b24000 f6b34000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b3c000 f6b55000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b5d000 f6b5f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b67000 f6bdc000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6be6000 f6bec000 r-xp /lib/librt-2.13.so
f6bf5000 f6c13000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c1d000 f6c1e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c26000 f6c49000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c51000 f6c56000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c5e000 f6c88000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c91000 f6ca8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cb0000 f6d19000 r-xp /lib/libm-2.13.so
f6d22000 f6db6000 r-xp /usr/lib/libstdc++.so.6.0.16
f6dc9000 f6dce000 r-xp /usr/lib/libctx-client.so.0.8.3
f6dd6000 f6ddd000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6de5000 f6e0f000 r-xp /usr/lib/libsensor.so.1.9.6
f6e18000 f6ee4000 r-xp /usr/lib/libxml2.so.2.7.8
f6ef1000 f6ef3000 r-xp /usr/lib/libiniparser.so.0
f6efc000 f6f02000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f0b000 f6fdb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6fdc000 f7010000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7019000 f7055000 r-xp /usr/lib/libSLP-location.so.0.9.24
f705d000 f7060000 r-xp /usr/lib/libbundle.so.0.1.22
f7068000 f706e000 r-xp /usr/lib/libappsvc.so.0.1.0
f7076000 f70b7000 r-xp /usr/lib/libeina.so.1.7.99
f70c0000 f70d7000 r-xp /usr/lib/libecore.so.1.7.99
f70ee000 f70f7000 r-xp /usr/lib/libvconf.so.0.2.45
f70ff000 f7113000 r-xp /lib/libpthread-2.13.so
f711e000 f712b000 r-xp /usr/lib/libaul.so.0.1.0
f7135000 f7137000 r-xp /lib/libdl-2.13.so
f7140000 f714b000 r-xp /lib/libunwind.so.8.0.1
f7178000 f7180000 r-xp /lib/libgcc_s-4.6.so.1
f7181000 f72a5000 r-xp /lib/libc-2.13.so
f72b3000 f72b5000 r-xp /usr/lib/libdlog.so.0.0.0
f72bd000 f72c9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f72d2000 f72d7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f72df000 f72ee000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f72f6000 f72fa000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7303000 f7306000 r-xp /usr/lib/libappcore-agent.so.1.1
f730e000 f7310000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7318000 f731c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7324000 f7341000 r-xp /lib/ld-2.13.so
f734a000 f734d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f734d000 f7351000 r-xp /usr/lib/libsys-assert.so
f7a06000 f7a77000 rw-p [heap]
fff5c000 fff7d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17250)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf734b228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf72e2539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6fe93f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6fe7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ff3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6ff9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6ff9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf702e75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70291f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6fe7c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ff3e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6ff9be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6ff9dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf702be5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf702c017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7033f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49cb1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf49be171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a91663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f3efcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f407a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf70d0ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf70cbb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70cc5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf70cc879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7304183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73047fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf734b5c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf719885c) [/lib/libc.so.6] + 0x1785c
29: (0xf734af2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
R760,07/06/2018,17:10:54:946,-0.072557,0.002289,0.032694
06-07 17:10:54.961+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:54.961+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:54.971+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:54.971+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:54:975,-1.744368,-3.493521,9.047262
06-07 17:10:54.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:10:54.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(17219), cmd(0)
06-07 17:10:54.981+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:54:968,-0.041208,-0.022399,0.020488
06-07 17:10:54.981+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:54.981+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:54:980,0.280000,0.980000,0.210000
06-07 17:10:54.981+0200 W/CAPI_APPFW_APP_CONTROL(17219): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:10:54.981+0200 I/utils   (17219): specific action
06-07 17:10:54.991+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:54:969,-1.750761,-3.430342,9.018757
06-07 17:10:54.991+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:54.991+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.001+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:4,-0.010356,0.018177,0.093112
06-07 17:10:55.001+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.001+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:54:996,-1.753939,-3.512664,9.064013
06-07 17:10:55.011+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.011+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:11,0.140000,1.050000,0.210000
06-07 17:10:55.011+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:8,-1.751952,-3.430412,9.018499
06-07 17:10:55.011+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.021+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.021+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.021+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:19,-1.756332,-3.450450,9.075976
06-07 17:10:55.021+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:25,0.084155,-0.015253,0.047905
06-07 17:10:55.021+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.041+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:55.041+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:31,-1.752245,-3.428262,9.019259
06-07 17:10:55.041+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.041+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:35,0.070000,0.560000,0.280000
06-07 17:10:55.041+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:55:48,814.000000
06-07 17:10:55.041+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:35,-1.741975,-3.500700,9.059227
06-07 17:10:55.051+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.051+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:10:55.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:10:55.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:10:55.071+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.071+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:51,0.017449,-0.012617,0.030396
06-07 17:10:55.071+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.081+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:57,0.140000,0.280000,0.070000
06-07 17:10:55.081+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:62,-1.749618,-3.429001,9.019488
06-07 17:10:55.081+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.091+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.091+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:96,0.140000,-0.420000,0.070000
06-07 17:10:55.091+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:55.101+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:78,-1.758725,-3.450450,9.087940
06-07 17:10:55.101+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.101+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:55:106,77
06-07 17:10:55.101+0200 W/LOCATION(17250): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:10:55.111+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:117,-1.744368,-3.462414,9.054441
06-07 17:10:55.111+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.111+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:86,-0.009106,0.033586,0.054094
06-07 17:10:55.121+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.121+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:123,-1.768296,-3.457629,9.049655
06-07 17:10:55.121+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.131+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.131+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:132,-1.720440,-3.498307,9.054441
06-07 17:10:55.131+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.131+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:105,-1.750502,-3.429977,9.018946
06-07 17:10:55.131+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:133,-0.032151,-0.027652,0.061816
06-07 17:10:55.131+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:140,-1.703690,-3.443272,9.135797
06-07 17:10:55.141+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.141+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.141+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:140,0.210000,-0.910000,-0.140000
06-07 17:10:55.141+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:150,-1.749153,-3.426522,9.066404
06-07 17:10:55.151+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.151+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:155,-1.752586,-3.428945,9.018933
06-07 17:10:55.151+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:157,-1.730011,-3.450450,9.066404
06-07 17:10:55.151+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.161+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.161+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.161+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:163,-1.703690,-3.491128,9.035298
06-07 17:10:55.161+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.161+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:171,-0.056388,0.007209,-0.014742
06-07 17:10:55.161+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:171,-1.725225,-3.469593,9.066404
06-07 17:10:55.171+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.171+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:176,0.070000,0.070000,0.210000
06-07 17:10:55.171+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:176,-1.782653,-3.433701,9.006584
06-07 17:10:55.171+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.171+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:182,-1.737189,-3.479164,9.104690
06-07 17:10:55.181+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.181+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.181+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:189,-1.722832,-3.481557,9.080762
06-07 17:10:55.181+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.191+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.191+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.191+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:196,-1.732404,-3.440879,9.104690
06-07 17:10:55.191+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.201+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:187,-1.754564,-3.429650,9.018281
06-07 17:10:55.201+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:202,-1.715654,-3.419343,9.037691
06-07 17:10:55.201+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.201+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.201+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:196,-0.490000,0.630000,0.070000
06-07 17:10:55.211+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:208,-1.806581,-3.455236,9.030513
06-07 17:10:55.211+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.211+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:197,-0.028089,-0.027979,0.000267
06-07 17:10:55.211+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:217,-1.727618,-3.495914,9.090333
06-07 17:10:55.211+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.221+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.221+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:216,-1.757701,-3.429490,9.017731
06-07 17:10:55.221+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.221+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:224,-1.780260,-3.431308,9.042477
06-07 17:10:55.221+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.231+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:234,-1.773082,-3.443272,9.035298
06-07 17:10:55.231+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.231+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:231,-0.077594,-0.001818,-0.006361
06-07 17:10:55.231+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.231+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:239,-1.761117,-3.457629,9.056834
06-07 17:10:55.231+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.241+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:231,-0.420000,-0.280000,-0.210000
06-07 17:10:55.241+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:55.241+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:55:248,813.000000
06-07 17:10:55.251+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.251+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.251+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:245,-1.727618,-3.464807,9.054441
06-07 17:10:55.251+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.251+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:260,-1.718047,-3.436093,9.078369
06-07 17:10:55.261+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:246,-1.757943,-3.429547,9.017662
06-07 17:10:55.261+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.261+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:258,0.023147,0.012596,0.060707
06-07 17:10:55.261+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:269,-1.751546,-3.402594,9.032906
06-07 17:10:55.261+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.271+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.271+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:275,-1.777867,-3.460021,9.061620
06-07 17:10:55.271+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.271+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:257,-0.210000,-1.120000,-0.280000
06-07 17:10:55.271+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.281+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.281+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:282,-1.751546,-3.431308,9.066404
06-07 17:10:55.281+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.281+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:55.291+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:277,-1.759659,-3.427691,9.018033
06-07 17:10:55.291+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:55:295,77
06-07 17:10:55.291+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:291,-1.758725,-3.471986,9.075976
06-07 17:10:55.291+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.291+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.301+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:285,-0.140000,-0.910000,-0.280000
06-07 17:10:55.301+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:287,0.024863,0.039454,0.050764
06-07 17:10:55.301+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:305,-1.727618,-3.457629,9.047262
06-07 17:10:55.301+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.311+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.311+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:315,-1.732404,-3.467200,9.099905
06-07 17:10:55.311+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.311+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.321+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:321,-1.746760,-3.460021,9.095119
06-07 17:10:55.321+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.321+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:311,-1.758290,-3.426203,9.018866
06-07 17:10:55.331+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:330,-1.739582,-3.448057,9.056834
06-07 17:10:55.331+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:321,-0.065041,0.035573,0.011647
06-07 17:10:55.331+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.331+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:319,0.140000,-0.350000,0.070000
06-07 17:10:55.331+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.331+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.341+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:339,-1.787439,-3.414558,9.030513
06-07 17:10:55.341+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:55.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391455354,000000, pattern:[H:mm][0;m
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:10:55.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:10:55.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:10:55.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:10][0;m
06-07 17:10:55.341+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.351+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:349,-1.756332,-3.450450,9.087940
06-07 17:10:55.351+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.361+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:366,-1.749153,-3.431308,9.087940
06-07 17:10:55.361+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.371+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:372,-1.732404,-3.443272,9.085547
06-07 17:10:55.371+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.371+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:348,0.140000,0.070000,0.140000
06-07 17:10:55.371+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:379,-1.741975,-3.440879,9.071191
06-07 17:10:55.371+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:345,-1.758364,-3.425874,9.018976
06-07 17:10:55.381+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.381+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:364,-0.064967,-0.012612,0.013929
06-07 17:10:55.381+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.381+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:388,-1.756332,-3.445665,9.018548
06-07 17:10:55.381+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.381+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.391+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.391+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:395,-1.751546,-3.479164,9.052048
06-07 17:10:55.391+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.401+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:402,-1.744368,-3.433701,9.083155
06-07 17:10:55.401+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.401+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:393,-1.760902,-3.424556,9.018981
06-07 17:10:55.401+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:396,0.070000,-0.140000,0.140000
06-07 17:10:55.401+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.401+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.401+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:398,-0.007394,-0.001966,0.011532
06-07 17:10:55.411+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:408,-1.763510,-3.383451,9.092726
06-07 17:10:55.411+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.411+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:415,-1.761446,-3.423552,9.019257
06-07 17:10:55.411+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.421+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:417,-1.773082,-3.433701,8.989835
06-07 17:10:55.421+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.421+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:426,0.038614,-0.060398,0.066291
06-07 17:10:55.421+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:429,-1.715654,-3.491128,9.116654
06-07 17:10:55.431+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.431+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:416,-0.070000,-0.350000,0.070000
06-07 17:10:55.431+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:436,-1.768296,-3.416951,9.066404
06-07 17:10:55.431+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.431+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.441+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.441+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.441+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:55.441+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:55:449,813.000000
06-07 17:10:55.451+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:442,-1.734797,-3.483950,9.066404
06-07 17:10:55.451+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.451+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:447,-0.070000,-0.560000,0.070000
06-07 17:10:55.451+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:458,-1.741975,-3.486342,9.056834
06-07 17:10:55.451+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:443,-1.759864,-3.422501,9.019964
06-07 17:10:55.451+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:449,0.015496,0.000764,0.034477
06-07 17:10:55.461+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.461+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.461+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.461+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.461+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:467,-1.741975,-3.400201,9.097511
06-07 17:10:55.461+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.471+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:474,-1.703690,-3.505485,9.102298
06-07 17:10:55.471+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.471+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:474,-0.350000,0.560000,0.140000
06-07 17:10:55.471+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:481,-1.696511,-3.395415,9.111869
06-07 17:10:55.481+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:469,-1.756796,-3.423254,9.020276
06-07 17:10:55.481+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.481+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:473,0.022000,-0.041553,0.082022
06-07 17:10:55.481+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.481+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.481+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.491+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:55.491+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:55:496,76
06-07 17:10:55.501+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:493,-1.756107,-3.422429,9.020723
06-07 17:10:55.511+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:493,-1.818545,-3.428915,9.052048
06-07 17:10:55.511+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:494,-0.560000,0.490000,0.140000
06-07 17:10:55.511+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.511+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:495,-0.007403,-0.030414,0.072002
06-07 17:10:55.511+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.511+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.511+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:518,-1.787439,-3.452843,9.040084
06-07 17:10:55.511+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.511+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.531+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:527,-1.761117,-3.412165,9.111869
06-07 17:10:55.531+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.531+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:521,0.210000,0.210000,0.070000
06-07 17:10:55.531+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:525,-1.754153,-3.422529,9.021066
06-07 17:10:55.531+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:525,-0.002179,-0.032707,0.045339
06-07 17:10:55.531+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:538,-1.667797,-3.445665,9.066404
06-07 17:10:55.531+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.541+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.541+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.541+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:547,-1.734797,-3.440879,9.049655
06-07 17:10:55.541+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.541+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.551+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:552,-1.758725,-3.395415,9.073583
06-07 17:10:55.551+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.551+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:559,-1.782653,-3.457629,9.080762
06-07 17:10:55.561+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:553,0.006581,-0.004350,0.033083
06-07 17:10:55.561+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.561+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:545,1.120000,1.190000,0.350000
06-07 17:10:55.571+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:571,-1.808974,-3.421736,9.004191
06-07 17:10:55.571+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.571+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:555,-1.753341,-3.422172,9.021358
06-07 17:10:55.581+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.581+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.581+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.581+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:586,0.093816,0.036163,0.047123
06-07 17:10:55.591+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:588,-1.782653,-3.457629,9.018548
06-07 17:10:55.591+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:583,0.910000,1.190000,0.420000
06-07 17:10:55.591+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.591+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.591+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.591+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:587,-1.752042,-3.422007,9.021674
06-07 17:10:55.591+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.611+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:603,0.013224,-0.032027,0.021407
06-07 17:10:55.611+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:601,-1.835295,-3.431308,9.011370
06-07 17:10:55.611+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.611+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:601,0.630000,-0.490000,0.140000
06-07 17:10:55.611+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.621+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.621+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:607,-1.752806,-3.423209,9.021070
06-07 17:10:55.631+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.631+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:624,0.840000,-0.210000,0.210000
06-07 17:10:55.641+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:55.641+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.651+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:630,0.040925,-0.082434,0.058971
06-07 17:10:55.651+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.651+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:55:649,812.000000
06-07 17:10:55.651+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:641,-1.749400,-3.423051,9.021791
06-07 17:10:55.651+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.651+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:630,-1.734797,-3.416951,9.078369
06-07 17:10:55.661+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.661+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:661,-0.007295,-0.016900,0.061646
06-07 17:10:55.661+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:656,0.560000,0.910000,0.350000
06-07 17:10:55.661+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.671+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:675,-0.070000,0.770000,0.210000
06-07 17:10:55.671+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:670,-1.734797,-3.388237,9.068797
06-07 17:10:55.671+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:665,-1.749037,-3.423979,9.021509
06-07 17:10:55.671+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.681+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.681+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.681+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:683,-0.082072,-0.022023,0.021631
06-07 17:10:55.681+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.691+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:695,-0.420000,0.350000,0.210000
06-07 17:10:55.691+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:55.691+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.691+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:688,-1.748437,-3.426034,9.020845
06-07 17:10:55.701+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:55:700,76
06-07 17:10:55.701+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.711+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.711+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:704,-0.032307,-0.036919,0.009833
06-07 17:10:55.711+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:689,-1.823331,-3.390630,9.030513
06-07 17:10:55.721+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.721+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.721+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:711,-1.750346,-3.425496,9.020679
06-07 17:10:55.721+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:717,0.140000,-0.280000,-0.140000
06-07 17:10:55.731+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.731+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.741+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:729,-1.823331,-3.438486,9.032906
06-07 17:10:55.741+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.741+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:726,0.046578,-0.014782,0.078995
06-07 17:10:55.741+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.751+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:743,-1.752661,-3.423704,9.020910
06-07 17:10:55.751+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:745,0.560000,-0.140000,-0.070000
06-07 17:10:55.751+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.751+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:750,-1.768296,-3.426522,9.030513
06-07 17:10:55.751+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.761+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:753,-0.000732,0.010737,0.050082
06-07 17:10:55.761+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.761+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.771+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:772,-1.722832,-3.483950,9.085547
06-07 17:10:55.771+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.781+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:766,-1.753207,-3.422902,9.021109
06-07 17:10:55.781+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:765,0.490000,0.210000,0.210000
06-07 17:10:55.781+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.791+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.791+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:784,-1.744368,-3.421736,9.054441
06-07 17:10:55.791+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:776,-0.035395,-0.027838,0.064103
06-07 17:10:55.791+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.791+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:797,0.350000,0.210000,0.210000
06-07 17:10:55.801+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.801+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:796,-1.752044,-3.422612,9.021444
06-07 17:10:55.801+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.811+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.811+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:803,-1.734797,-3.464807,9.102298
06-07 17:10:55.811+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.811+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:818,0.210000,-0.140000,0.210000
06-07 17:10:55.811+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:809,-0.031682,-0.013452,0.021300
06-07 17:10:55.821+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.821+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:821,-1.753364,-3.422642,9.021176
06-07 17:10:55.821+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:829,0.042023,-0.021721,0.058061
06-07 17:10:55.821+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:821,-1.763510,-3.452843,9.092726
06-07 17:10:55.821+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.831+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.831+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.831+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.841+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:10:55.841+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:838,-1.755284,-3.423944,9.020308
06-07 17:10:55.841+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:837,0.350000,-0.700000,0.070000
06-07 17:10:55.841+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.851+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.851+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:10:55:849,844.000000
06-07 17:10:55.851+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:835,-1.756332,-3.455236,9.066404
06-07 17:10:55.851+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:847,0.052091,-0.029439,0.038810
06-07 17:10:55.851+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.861+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.861+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:855,0.700000,-0.700000,0.350000
06-07 17:10:55.871+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:864,-1.755781,-3.423404,9.020417
06-07 17:10:55.871+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.871+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:872,-1.746760,-3.426522,9.054441
06-07 17:10:55.871+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:872,0.029941,-0.028139,0.042596
06-07 17:10:55.871+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.871+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.881+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.881+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:885,-1.752773,-3.422311,9.021417
06-07 17:10:55.881+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:878,2.170000,0.560000,1.050000
06-07 17:10:55.881+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.891+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:10:55.891+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:890,-0.037010,-0.037657,0.025411
06-07 17:10:55.891+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:10:55:896,76
06-07 17:10:55.891+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.901+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.901+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:895,3.570000,1.400000,2.100000
06-07 17:10:55.901+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.911+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:884,-1.658226,-3.385844,9.068797
06-07 17:10:55.911+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.911+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:915,2.800000,0.350000,2.170000
06-07 17:10:55.921+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:905,-1.750429,-3.422364,9.021852
06-07 17:10:55.921+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.921+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:920,-1.739582,-3.455236,9.042477
06-07 17:10:55.931+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:911,-0.057474,-0.016029,0.008440
06-07 17:10:55.931+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.941+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.941+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:941,-1.708475,-3.505485,9.080762
06-07 17:10:55.951+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.961+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.971+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:932,-1.749107,-3.422457,9.022073
06-07 17:10:55.971+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:964,-1.756332,-3.440879,9.083155
06-07 17:10:55.971+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.971+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:973,2.450000,-0.210000,1.890000
06-07 17:10:55.971+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:55.971+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:971,-0.041910,-0.020570,0.085338
06-07 17:10:55.981+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:55.981+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:55.991+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:55:982,-1.830509,-3.448057,9.042477
06-07 17:10:55.991+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:55:990,0.050053,-0.093900,0.082559
06-07 17:10:55.991+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:55.991+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:55:984,-1.750314,-3.422702,9.021746
06-07 17:10:55.991+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:10:56.001+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:10:55:990,6.580000,1.190000,2.100000
06-07 17:10:56.001+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:10:56.001+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:10:56.011+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:10:56:1,-1.782653,-3.462414,9.030513
06-07 17:10:56.011+0200 I/accelerometer(17219): es.ugr.frailty.accelerometer - capturing data
06-07 17:10:56.011+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:10:56:7,-1.751350,-3.421157,9.022131
06-07 17:10:56.011+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:10:56:11,0.064120,-0.135517,0.069276
06-07 17:10:56.021+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11172506c6f63152838425
