S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 13825
Date: 2018-06-07 16:59:10+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf725052d, r5   = 0xf7871f98
r6   = 0xffbf6f30, r7   = 0xffbf6de0
r8   = 0xf786ec18, r9   = 0x00000000
r10  = 0xffbf6ebc, fp   = 0xffbf6f30
ip   = 0x00000001, sp   = 0xffbf6db8
lr   = 0xf7250539, pc   = 0xf72b9228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     56224 KB
Buffers:      7532 KB
Cached:      49688 KB
VmPeak:      52416 KB
VmSize:      52412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11524 KB
VmRSS:       11520 KB
VmData:      10140 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 13825 TID = 13825
13825 13829 

Maps Information
f411b000 f491a000 rw-p [stack:13829]
f4921000 f4923000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f492b000 f492f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4938000 f493a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4942000 f4945000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4954000 f4959000 r-xp /usr/lib/libsystem.so.0.0.0
f4964000 f4967000 r-xp /lib/libattr.so.1.1.0
f496f000 f497f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4987000 f4990000 r-xp /usr/lib/libedbus.so.1.7.99
f4998000 f4999000 r-xp /usr/lib/libresponse.so.0.2.96
f49a2000 f49a7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6249000 f634f000 r-xp /usr/lib/libicuuc.so.57.1
f6365000 f64ed000 r-xp /usr/lib/libicui18n.so.57.1
f64fd000 f650a000 r-xp /usr/lib/libail.so.0.1.0
f6513000 f651a000 r-xp /usr/lib/libminizip.so.1.0.0
f6523000 f66cc000 r-xp /usr/lib/libcrypto.so.1.0.0
f66ec000 f6733000 r-xp /usr/lib/libssl.so.1.0.0
f673f000 f6741000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6749000 f6750000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6759000 f6760000 r-xp /lib/libcrypt-2.13.so
f6791000 f6794000 r-xp /lib/libcap.so.2.21
f679c000 f679e000 r-xp /usr/lib/libiri.so
f67a6000 f67ef000 r-xp /usr/lib/libmdm.so.1.2.69
f67f7000 f67fd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6805000 f6828000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6832000 f6834000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f683c000 f6859000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6862000 f6866000 r-xp /usr/lib/libsmack.so.1.0.0
f686f000 f6888000 r-xp /usr/lib/libnetwork.so.0.0.0
f6891000 f6899000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68a1000 f68a7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68b0000 f68b2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68bb000 f68cb000 r-xp /lib/libresolv-2.13.so
f68cf000 f68e7000 r-xp /usr/lib/liblzma.so.5.0.3
f68f0000 f68f2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68fa000 f6914000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f691c000 f694b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6954000 f6963000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f696d000 f6977000 r-xp /usr/lib/libsensord-shared.so
f6980000 f6a53000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a5e000 f6a74000 r-xp /lib/libz.so.1.2.5
f6a7c000 f6a81000 r-xp /usr/lib/libffi.so.5.0.10
f6a89000 f6a8a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a92000 f6aa2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6aaa000 f6ac3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6acb000 f6acd000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ad5000 f6b4a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b54000 f6b5a000 r-xp /lib/librt-2.13.so
f6b63000 f6b81000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b8b000 f6b8c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b94000 f6bb7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bbf000 f6bc4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6bcc000 f6bf6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6bff000 f6c16000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c1e000 f6c87000 r-xp /lib/libm-2.13.so
f6c90000 f6d24000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d37000 f6d3c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d44000 f6d4b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d53000 f6d7d000 r-xp /usr/lib/libsensor.so.1.9.6
f6d86000 f6e52000 r-xp /usr/lib/libxml2.so.2.7.8
f6e5f000 f6e61000 r-xp /usr/lib/libiniparser.so.0
f6e6a000 f6e70000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e79000 f6f49000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f4a000 f6f7e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f87000 f6fc3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fcb000 f6fce000 r-xp /usr/lib/libbundle.so.0.1.22
f6fd6000 f6fdc000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fe4000 f7025000 r-xp /usr/lib/libeina.so.1.7.99
f702e000 f7045000 r-xp /usr/lib/libecore.so.1.7.99
f705c000 f7065000 r-xp /usr/lib/libvconf.so.0.2.45
f706d000 f7081000 r-xp /lib/libpthread-2.13.so
f708c000 f7099000 r-xp /usr/lib/libaul.so.0.1.0
f70a3000 f70a5000 r-xp /lib/libdl-2.13.so
f70ae000 f70b9000 r-xp /lib/libunwind.so.8.0.1
f70e6000 f70ee000 r-xp /lib/libgcc_s-4.6.so.1
f70ef000 f7213000 r-xp /lib/libc-2.13.so
f7221000 f7223000 r-xp /usr/lib/libdlog.so.0.0.0
f722b000 f7237000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7240000 f7245000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f724d000 f725c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7264000 f7268000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7271000 f7274000 r-xp /usr/lib/libappcore-agent.so.1.1
f727c000 f727e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7286000 f728a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7292000 f72af000 r-xp /lib/ld-2.13.so
f72b8000 f72bb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72bb000 f72bf000 r-xp /usr/lib/libsys-assert.so
f783e000 f78b0000 rw-p [heap]
ffbd8000 ffbf9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:13825)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf72b9228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7250539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f573f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f55c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f61e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f67be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f67dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f9c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f971f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f55c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f61e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f67be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f67dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f99e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f9a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6fa1f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49391fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf492c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69ff663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6eacfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6eae7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf703eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7039b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf703a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf703a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7272183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72727fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72b95c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf710685c) [/lib/libc.so.6] + 0x1785c
29: (0xf72b8f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
pedometer alive timeout
06-07 16:59:10.031+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:59:10.031+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:59:10.031+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 16:59:10.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 16:59:10.041+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:10.041+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(12618), cmd(0)
06-07 16:59:10.041+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:10.051+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:59:10.051+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:59:10.051+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:59:10.051+0200 I/utils   (12618): specific action
06-07 16:59:10.051+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 16:59:10.051+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 16:59:10.051+0200 I/servicemanager(12566): App control destroyed.
06-07 16:59:10.061+0200 I/utils   (12603): specific action
06-07 16:59:10.061+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:10.061+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(13728), cmd(0)
06-07 16:59:10.061+0200 W/CAPI_APPFW_APP_CONTROL(13728): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:10.061+0200 I/utils   (13728): specific action
06-07 16:59:10.061+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.061+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:69,0.069567,-0.161853,0.192904
06-07 16:59:10.071+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.071+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:76,-0.013672,-0.126597,-0.083964
06-07 16:59:10.071+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.081+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:85,-0.047902,-0.050786,0.095937
06-07 16:59:10.081+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.081+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:91,-0.057333,-0.107496,0.100304
06-07 16:59:10.091+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.091+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:96,0.029430,-0.058638,0.107139
06-07 16:59:10.091+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.101+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:103,-0.037886,0.029953,0.169248
06-07 16:59:10.101+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.101+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:110,-0.059166,-0.037001,0.087585
06-07 16:59:10.121+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.131+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:136,0.098678,-0.097105,0.098363
06-07 16:59:10.131+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:09:968,0.210000,-0.140000,0.770000
06-07 16:59:10.131+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.131+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:24,2.349752,-0.727418,9.580862
06-07 16:59:10.141+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.141+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.151+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:10.171+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:10.171+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:10:176,792.000000
06-07 16:59:10.171+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:10:157,83
06-07 16:59:10.181+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:188,0.024284,-0.120699,0.167125
06-07 16:59:10.181+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:143,-1.330000,-0.560000,0.910000
06-07 16:59:10.181+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.191+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:25,2.428777,-0.659356,9.478221
06-07 16:59:10.191+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:153,2.337788,-0.787239,9.585647
06-07 16:59:10.191+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.201+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.211+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.211+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:213,2.423984,-0.658200,9.479528
06-07 16:59:10.211+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.211+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:216,0.076564,0.072023,-0.056849
06-07 16:59:10.211+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:194,-1.610000,-0.210000,0.840000
06-07 16:59:10.211+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:219,2.425396,-0.666446,9.478591
06-07 16:59:10.211+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:10.211+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(13724), cmd(0)
06-07 16:59:10.221+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.221+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:204,2.421536,-0.744168,9.592826
06-07 16:59:10.221+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.231+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:227,2.426918,-0.678317,9.477360
06-07 16:59:10.231+0200 W/CAPI_APPFW_APP_CONTROL(13685): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:10.231+0200 I/utils   (13685): specific action
06-07 16:59:10.231+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:59:10.231+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(24) , send fd(15), pid(13685), cmd(0)
06-07 16:59:10.231+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.231+0200 W/CAPI_APPFW_APP_CONTROL(13724): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:59:10.231+0200 I/utils   (13724): specific action
06-07 16:59:10.231+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.231+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:239,2.421178,-0.683759,9.478436
06-07 16:59:10.231+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.231+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:241,0.140000,-0.630000,0.700000
06-07 16:59:10.241+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:245,2.411128,-0.676551,9.481515
06-07 16:59:10.241+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.241+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.251+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:252,2.399263,-0.665802,9.485285
06-07 16:59:10.251+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:230,2.344966,-0.653241,9.657433
06-07 16:59:10.251+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.251+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.251+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:259,2.395081,-0.655097,9.487087
06-07 16:59:10.251+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.261+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:251,0.086307,0.102196,-0.096784
06-07 16:59:10.261+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.261+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:264,2.397433,-0.661278,9.486064
06-07 16:59:10.261+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.261+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:268,-0.019970,0.080284,-0.054600
06-07 16:59:10.261+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.261+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.271+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:270,2.406495,-0.672606,9.482972
06-07 16:59:10.271+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.271+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:274,2.030000,1.260000,0.070000
06-07 16:59:10.271+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.271+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:277,2.397654,-0.676632,9.484925
06-07 16:59:10.271+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:279,2.730000,0.140000,0.140000
06-07 16:59:10.271+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.271+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.281+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:283,2.395121,-0.679743,9.485343
06-07 16:59:10.281+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:257,2.297110,-0.708275,9.583255
06-07 16:59:10.281+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.281+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.281+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:288,2.450250,-0.768096,9.595219
06-07 16:59:10.281+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.281+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:290,2.392106,-0.685530,9.485687
06-07 16:59:10.281+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.291+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:295,2.382852,-0.683194,9.488185
06-07 16:59:10.291+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.291+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:300,2.356276,-0.671274,9.495669
06-07 16:59:10.301+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.301+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:293,2.390430,-0.799203,9.659825
06-07 16:59:10.301+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.301+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:306,2.351572,-0.670991,9.496856
06-07 16:59:10.301+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.301+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:272,-0.016679,0.073683,0.102480
06-07 16:59:10.301+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.311+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:312,2.366146,-0.678504,9.492701
06-07 16:59:10.311+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.311+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:307,2.445465,-0.610170,9.434900
06-07 16:59:10.311+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.311+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:317,2.368901,-0.682193,9.491750
06-07 16:59:10.311+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:319,2.459821,-0.574277,9.394222
06-07 16:59:10.311+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.311+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.321+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:323,2.373514,-0.676474,9.491006
06-07 16:59:10.321+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:284,1.610000,-0.910000,0.560000
06-07 16:59:10.321+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.321+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:330,2.372115,-0.668918,9.491892
06-07 16:59:10.331+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:59:10.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:59:10.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:59:10.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:59:10.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390750344,000000, pattern:[H:mm][0;m
06-07 16:59:10.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:59:10.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:59:10.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:59:10.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:59:10.331+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:59:10.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:59][0;m
06-07 16:59:10.341+0200 W/LOCATION(13825): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:59:10.341+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:338,2.361645,-0.659924,9.495131
06-07 16:59:10.341+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.351+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:10.351+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:314,0.015955,0.023278,0.173397
06-07 16:59:10.351+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.351+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:10:356,83
06-07 16:59:10.351+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:354,2.350547,-0.652590,9.498391
06-07 16:59:10.351+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:359,-0.051181,-0.065528,0.118378
06-07 16:59:10.351+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.351+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.361+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.361+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:365,2.350684,-0.652319,9.498376
06-07 16:59:10.361+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:366,-2.100000,-1.120000,1.540000
06-07 16:59:10.361+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.361+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.361+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:370,2.348518,-0.656345,9.498634
06-07 16:59:10.361+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:10.371+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:10:375,793.000000
06-07 16:59:10.371+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.371+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:381,2.350558,-0.658713,9.497966
06-07 16:59:10.381+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:322,2.352145,-0.588634,9.437292
06-07 16:59:10.381+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.381+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.381+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:371,-1.820000,-1.540000,1.400000
06-07 16:59:10.381+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.381+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:387,2.351414,-0.663515,9.497419
06-07 16:59:10.381+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.381+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:364,0.099340,-0.080644,0.096584
06-07 16:59:10.391+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:386,2.344966,-0.586242,9.597611
06-07 16:59:10.391+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.391+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:394,2.349099,-0.664574,9.497919
06-07 16:59:10.391+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.391+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:397,2.366502,-0.629312,9.671788
06-07 16:59:10.391+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.391+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:401,2.299503,-0.717847,9.616754
06-07 16:59:10.391+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.391+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:401,2.352298,-0.664496,9.497132
06-07 16:59:10.401+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.401+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.401+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:407,2.357374,-0.665197,9.495825
06-07 16:59:10.401+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.411+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:391,0.980000,2.100000,1.120000
06-07 16:59:10.411+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:414,2.358148,-0.663918,9.495722
06-07 16:59:10.411+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.411+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.421+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:412,0.099692,-0.106990,-0.043923
06-07 16:59:10.421+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:421,2.357443,-0.656814,9.496391
06-07 16:59:10.421+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.421+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.421+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:428,2.350050,-0.657926,9.498146
06-07 16:59:10.431+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.431+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:420,-0.280000,-0.420000,0.980000
06-07 16:59:10.431+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.431+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:436,2.352979,-0.654296,9.497672
06-07 16:59:10.431+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:438,-0.280000,-0.490000,0.980000
06-07 16:59:10.431+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.431+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:404,2.447858,-0.736989,9.595219
06-07 16:59:10.441+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.441+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:427,-0.008841,-0.025618,0.112156
06-07 16:59:10.441+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.441+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.441+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:449,2.373856,-0.660719,9.492030
06-07 16:59:10.451+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:446,2.450250,-0.765703,9.454042
06-07 16:59:10.451+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.451+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:458,2.342573,-0.689133,9.609575
06-07 16:59:10.451+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.461+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:463,2.438286,-0.672383,9.705289
06-07 16:59:10.461+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.461+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:469,2.428715,-0.679562,9.542577
06-07 16:59:10.461+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.471+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.471+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:452,0.089188,-0.007809,0.207370
06-07 16:59:10.471+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.471+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:479,2.388533,-0.677225,9.487185
06-07 16:59:10.481+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:475,2.294717,-0.622134,9.544970
06-07 16:59:10.481+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.481+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.481+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:442,2.310000,0.420000,0.420000
06-07 16:59:10.481+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.491+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:489,2.394984,-0.691599,9.484520
06-07 16:59:10.491+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:487,2.409572,-0.531207,9.432507
06-07 16:59:10.491+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.491+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:483,0.076417,-0.015066,0.045444
06-07 16:59:10.491+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.491+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:500,2.299503,-0.662812,9.430114
06-07 16:59:10.491+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.501+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.501+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:493,4.620000,3.010000,0.840000
06-07 16:59:10.501+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.501+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:510,2.394045,-0.692698,9.484677
06-07 16:59:10.511+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:505,2.361716,-0.504886,9.700503
06-07 16:59:10.511+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.511+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:517,2.469393,-0.579063,9.681360
06-07 16:59:10.511+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.511+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:503,-0.062657,0.043063,0.049145
06-07 16:59:10.521+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:522,2.421536,-0.837488,9.482756
06-07 16:59:10.521+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.521+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.521+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:512,1.120000,-1.470000,0.210000
06-07 16:59:10.521+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.521+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.521+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:530,2.415282,-0.693942,9.479200
06-07 16:59:10.531+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:527,0.051424,0.132712,-0.063215
06-07 16:59:10.531+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:527,2.340181,-0.808774,9.427721
06-07 16:59:10.531+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.531+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.531+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:540,2.445465,-0.691526,9.621540
06-07 16:59:10.531+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.541+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:544,2.514857,-0.437887,9.585647
06-07 16:59:10.541+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.541+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.541+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:549,2.445525,-0.717012,9.469725
06-07 16:59:10.541+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:550,2.261217,-0.669990,9.363115
06-07 16:59:10.541+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:531,-1.260000,-3.150000,-0.280000
06-07 16:59:10.551+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:10.551+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:540,-0.057940,-0.005998,-0.066278
06-07 16:59:10.551+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:10:557,83
06-07 16:59:10.551+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.551+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.561+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:563,1.120000,-3.430000,-0.210000
06-07 16:59:10.561+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.561+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:562,0.011666,0.153041,0.202357
06-07 16:59:10.561+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:569,1.540000,-2.730000,-0.210000
06-07 16:59:10.561+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.561+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:10.571+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.571+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:575,2.468549,-0.740941,9.461905
06-07 16:59:10.571+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.571+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:10:575,790.000000
06-07 16:59:10.571+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:576,2.608176,-0.971486,9.930215
06-07 16:59:10.581+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.581+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.581+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.581+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:590,2.605784,-0.930808,9.552148
06-07 16:59:10.581+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:589,2.451348,-0.744625,9.466087
06-07 16:59:10.591+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:587,1.330000,0.770000,-0.070000
06-07 16:59:10.591+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:583,0.116413,0.075233,0.183688
06-07 16:59:10.591+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.591+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.591+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:600,2.380000,1.120000,-0.490000
06-07 16:59:10.601+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.601+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.601+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.601+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:609,2.402394,-0.631705,10.152746
06-07 16:59:10.611+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:609,2.447283,-0.741326,9.467398
06-07 16:59:10.611+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:606,1.400000,2.170000,-0.210000
06-07 16:59:10.611+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.611+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:620,-0.770000,0.700000,-0.070000
06-07 16:59:10.621+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:600,0.047680,-0.176769,-0.009274
06-07 16:59:10.621+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.631+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.631+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:631,2.471517,-0.757157,9.459846
06-07 16:59:10.631+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.631+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:638,2.443072,-0.813560,9.765109
06-07 16:59:10.631+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.641+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.651+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:642,-0.048352,-0.131549,-0.059464
06-07 16:59:10.651+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.651+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.651+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:650,2.316252,-1.177269,9.353544
06-07 16:59:10.661+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:657,2.497157,-0.793952,9.450091
06-07 16:59:10.661+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:644,-0.770000,0.770000,-0.420000
06-07 16:59:10.671+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.671+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.671+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:662,0.050480,0.000074,0.137020
06-07 16:59:10.671+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:677,2.409572,-1.311267,9.317651
06-07 16:59:10.671+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.671+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.681+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.681+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:677,2.496580,-0.816794,9.448298
06-07 16:59:10.691+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.691+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:683,0.120811,0.254812,0.100969
06-07 16:59:10.691+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.701+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:700,2.478029,-0.806719,9.454045
06-07 16:59:10.701+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:707,-0.154065,0.023952,-0.116085
06-07 16:59:10.711+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:683,0.420000,0.140000,-0.420000
06-07 16:59:10.711+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.711+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.711+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.731+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:718,2.470388,-0.800578,9.456566
06-07 16:59:10.731+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.731+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:738,2.481152,-0.808320,9.453089
06-07 16:59:10.741+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:725,0.162651,-0.254474,0.460490
06-07 16:59:10.741+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.751+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.751+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:747,0.137235,-0.189867,0.090242
06-07 16:59:10.761+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.761+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:757,2.467115,-0.801985,9.457301
06-07 16:59:10.761+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:768,-0.048954,0.112919,0.686659
06-07 16:59:10.761+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:10.771+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:10:774,83
06-07 16:59:10.781+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:690,2.727818,-0.983450,9.415757
06-07 16:59:10.781+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.781+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.791+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.791+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:789,2.390886,-0.760950,9.480243
06-07 16:59:10.801+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:791,2.569891,-0.813560,9.257831
06-07 16:59:10.801+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.801+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:811,2.531606,-0.878166,9.403792
06-07 16:59:10.811+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.811+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:801,-0.004211,-0.072234,0.297711
06-07 16:59:10.811+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.821+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:10.831+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.831+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:10:829,788.000000
06-07 16:59:10.831+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:819,2.291764,-0.674599,9.511210
06-07 16:59:10.831+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:718,-0.210000,2.450000,-0.140000
06-07 16:59:10.831+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.831+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:825,-0.155264,-0.420112,-0.106302
06-07 16:59:10.831+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:835,2.754139,-1.036092,9.425328
06-07 16:59:10.841+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:841,-0.140000,0.490000,0.140000
06-07 16:59:10.841+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.841+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.841+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:848,-0.070000,-0.560000,-0.140000
06-07 16:59:10.841+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.841+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.851+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:854,0.140000,-1.400000,0.280000
06-07 16:59:10.851+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.851+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.851+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:859,-0.140000,-1.820000,0.280000
06-07 16:59:10.851+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.851+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:849,2.200192,-0.597278,9.537966
06-07 16:59:10.861+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.861+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:864,0.350000,1.050000,0.210000
06-07 16:59:10.861+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.861+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:855,-0.087584,-0.517315,-0.132441
06-07 16:59:10.871+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:870,-0.630000,3.360000,0.700000
06-07 16:59:10.871+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:862,2.529213,-0.973879,9.547362
06-07 16:59:10.871+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.871+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.871+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.871+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:877,-1.960000,0.700000,1.260000
06-07 16:59:10.871+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.881+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:882,-4.830000,-0.910000,1.400000
06-07 16:59:10.881+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.881+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:875,2.169909,-0.582969,9.545786
06-07 16:59:10.881+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:888,-3.780000,-0.280000,1.540000
06-07 16:59:10.881+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.891+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:882,2.488536,-0.224925,9.561719
06-07 16:59:10.891+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:884,0.231238,-0.166656,-0.032540
06-07 16:59:10.891+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:895,-3.780000,1.400000,1.960000
06-07 16:59:10.891+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.891+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:900,-0.910000,1.890000,0.840000
06-07 16:59:10.901+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.901+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.901+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.901+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:906,-6.440000,1.540000,2.730000
06-07 16:59:10.901+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.901+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.911+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:912,-12.040000,2.730000,-0.070000
06-07 16:59:10.911+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.911+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:909,2.161855,-0.573631,9.548179
06-07 16:59:10.911+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:918,-6.790000,-0.280000,1.680000
06-07 16:59:10.911+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.921+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:906,2.103291,0.014357,9.410972
06-07 16:59:10.921+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.921+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:923,1.470000,7.210000,1.680000
06-07 16:59:10.931+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.931+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:935,-1.680000,-0.280000,1.540000
06-07 16:59:10.931+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.931+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:940,-5.810000,-4.970000,1.260000
06-07 16:59:10.931+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.941+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.941+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:915,0.091863,-0.006841,-0.196215
06-07 16:59:10.951+0200 I/heartrate(12595): es.ugr.frailty.heartrate - capturing data
06-07 16:59:10.951+0200 I/heartrate(12595): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:59:10:957,83
06-07 16:59:10.951+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.951+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:931,2.067399,-0.538385,9.745967
06-07 16:59:10.951+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.961+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:945,-6.930000,-6.720000,2.380000
06-07 16:59:10.961+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.961+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:963,2.675175,-0.674776,9.726824
06-07 16:59:10.961+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.971+0200 I/light   (12614): es.ugr.frailty.light - capturing data
06-07 16:59:10.971+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:971,0.061219,-0.077588,-0.052773
06-07 16:59:10.971+0200 I/light   (12614): es.ugr.frailty.light: SM-R760,07/06/2018,16:59:10:976,841.000000
06-07 16:59:10.971+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:968,2.137439,-0.559059,9.554538
06-07 16:59:10.971+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:968,2.240000,-6.510000,3.360000
06-07 16:59:10.971+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.981+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:10.981+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:972,2.730211,-0.842274,9.824929
06-07 16:59:10.981+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.981+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:10.981+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:990,2.261217,-0.787239,9.848858
06-07 16:59:10.981+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:10.991+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:59:10:993,0.272987,-0.227772,-0.027761
06-07 16:59:10.991+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:987,9.100000,-0.350000,2.240000
06-07 16:59:10.991+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:10.991+0200 I/gravity (13685): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:59:10:988,2.063577,-0.524797,9.572702
06-07 16:59:10.991+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:59:10:999,3.150000,2.240000,-0.210000
06-07 16:59:10.991+0200 I/gyroscope(13724): es.ugr.frailty.gyroscope - capturing data
06-07 16:59:11.001+0200 I/linearacceleration(13728): es.ugr.frailty.linearacceleration - capturing data
06-07 16:59:11.001+0200 I/gravity (13685): es.ugr.frailty.gravity - capturing data
06-07 16:59:11.001+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:59:10:993,1.923829,-0.471386,9.702895
06-07 16:59:11.001+0200 I/accelerometer(13850): es.ugr.frailty.accelerometer - capturing data
06-07 16:59:11.001+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11138256c6f63152838355
