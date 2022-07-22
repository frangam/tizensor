S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 12344
Date: 2018-04-23 20:41:05+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf722e52d, r5   = 0xf77a7958
r6   = 0xffbf62f0, r7   = 0xffbf61a0
r8   = 0xf77bac18, r9   = 0x00000000
r10  = 0xffbf627c, fp   = 0xffbf62f0
ip   = 0x00000001, sp   = 0xffbf6178
lr   = 0xf722e539, pc   = 0xf7297228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     61228 KB
Buffers:     40316 KB
Cached:     161280 KB
VmPeak:      52400 KB
VmSize:      52396 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11860 KB
VmRSS:       11860 KB
VmData:      10124 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12344 TID = 12344
12344 12347 

Maps Information
f40f9000 f48f8000 rw-p [stack:12347]
f48ff000 f4901000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4909000 f490d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4916000 f4918000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4920000 f4923000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4932000 f4937000 r-xp /usr/lib/libsystem.so.0.0.0
f4942000 f4945000 r-xp /lib/libattr.so.1.1.0
f494d000 f495d000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4965000 f496e000 r-xp /usr/lib/libedbus.so.1.7.99
f4976000 f4977000 r-xp /usr/lib/libresponse.so.0.2.96
f4980000 f4985000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6227000 f632d000 r-xp /usr/lib/libicuuc.so.57.1
f6343000 f64cb000 r-xp /usr/lib/libicui18n.so.57.1
f64db000 f64e8000 r-xp /usr/lib/libail.so.0.1.0
f64f1000 f64f8000 r-xp /usr/lib/libminizip.so.1.0.0
f6501000 f66aa000 r-xp /usr/lib/libcrypto.so.1.0.0
f66ca000 f6711000 r-xp /usr/lib/libssl.so.1.0.0
f671d000 f671f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6727000 f672e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6737000 f673e000 r-xp /lib/libcrypt-2.13.so
f676f000 f6772000 r-xp /lib/libcap.so.2.21
f677a000 f677c000 r-xp /usr/lib/libiri.so
f6784000 f67cd000 r-xp /usr/lib/libmdm.so.1.2.69
f67d5000 f67db000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f67e3000 f6806000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6810000 f6812000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f681a000 f6837000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6840000 f6844000 r-xp /usr/lib/libsmack.so.1.0.0
f684d000 f6866000 r-xp /usr/lib/libnetwork.so.0.0.0
f686f000 f6877000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f687f000 f6885000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f688e000 f6890000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6899000 f68a9000 r-xp /lib/libresolv-2.13.so
f68ad000 f68c5000 r-xp /usr/lib/liblzma.so.5.0.3
f68ce000 f68d0000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f68d8000 f68f2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f68fa000 f6929000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6932000 f6941000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f694b000 f6955000 r-xp /usr/lib/libsensord-shared.so
f695e000 f6a31000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a3c000 f6a52000 r-xp /lib/libz.so.1.2.5
f6a5a000 f6a5f000 r-xp /usr/lib/libffi.so.5.0.10
f6a67000 f6a68000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a70000 f6a80000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6a88000 f6aa1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6aa9000 f6aab000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ab3000 f6b28000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b32000 f6b38000 r-xp /lib/librt-2.13.so
f6b41000 f6b5f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b69000 f6b6a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b72000 f6b95000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b9d000 f6ba2000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6baa000 f6bd4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6bdd000 f6bf4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6bfc000 f6c65000 r-xp /lib/libm-2.13.so
f6c6e000 f6d02000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d15000 f6d1a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d22000 f6d29000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d31000 f6d5b000 r-xp /usr/lib/libsensor.so.1.9.6
f6d64000 f6e30000 r-xp /usr/lib/libxml2.so.2.7.8
f6e3d000 f6e3f000 r-xp /usr/lib/libiniparser.so.0
f6e48000 f6e4e000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e57000 f6f27000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f28000 f6f5c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6f65000 f6fa1000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6fa9000 f6fac000 r-xp /usr/lib/libbundle.so.0.1.22
f6fb4000 f6fba000 r-xp /usr/lib/libappsvc.so.0.1.0
f6fc2000 f7003000 r-xp /usr/lib/libeina.so.1.7.99
f700c000 f7023000 r-xp /usr/lib/libecore.so.1.7.99
f703a000 f7043000 r-xp /usr/lib/libvconf.so.0.2.45
f704b000 f705f000 r-xp /lib/libpthread-2.13.so
f706a000 f7077000 r-xp /usr/lib/libaul.so.0.1.0
f7081000 f7083000 r-xp /lib/libdl-2.13.so
f708c000 f7097000 r-xp /lib/libunwind.so.8.0.1
f70c4000 f70cc000 r-xp /lib/libgcc_s-4.6.so.1
f70cd000 f71f1000 r-xp /lib/libc-2.13.so
f71ff000 f7201000 r-xp /usr/lib/libdlog.so.0.0.0
f7209000 f7215000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f721e000 f7223000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f722b000 f723a000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7242000 f7246000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f724f000 f7252000 r-xp /usr/lib/libappcore-agent.so.1.1
f725a000 f725c000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7264000 f7268000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7270000 f728d000 r-xp /lib/ld-2.13.so
f7296000 f7299000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7299000 f729d000 r-xp /usr/lib/libsys-assert.so
f778a000 f77f8000 rw-p [heap]
ffbd7000 ffbf8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12344)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7297228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf722e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f353f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f33c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f3fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f45be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f45dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6f7a75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6f751f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f33c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f3fe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f45be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f45dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6f77e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6f78017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6f7ff93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49171fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf490a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf69dd663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6e8afcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6e8c7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf701cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7017b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70185a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7018879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7250183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72507fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72975c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf70e485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7296f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
accelerometer: SM-R760,23/04/2018,20:41:04:975,0.059821,9.741181,0.815953
04-23 20:41:04.999+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:04.999+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:04:988,0.043749,9.772506,0.816453
04-23 20:41:04.999+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:04:979,0.018035,-0.031757,0.004587
04-23 20:41:05.049+0200 E/CAPI_TELEPHONY(12139): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:41:05.059+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.059+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:63,0.017017,0.018624,0.046116
04-23 20:41:05.059+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.059+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.059+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:69,-0.070000,-0.070000,0.070000
04-23 20:41:05.069+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:50,0.059821,9.791430,0.859023
04-23 20:41:05.069+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.069+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.069+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:74,0.042860,9.772338,0.818507
04-23 20:41:05.079+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.089+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.089+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:84,0.021535,9.805787,0.823131
04-23 20:41:05.089+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:85,-0.022214,0.033281,0.006678
04-23 20:41:05.089+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:93,0.041753,9.772407,0.817751
04-23 20:41:05.099+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.099+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:89,-0.070000,-0.070000,0.070000
04-23 20:41:05.099+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.099+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.099+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:107,0.016750,9.824929,0.751346
04-23 20:41:05.109+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.109+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:118,0.042543,9.772411,0.817645
04-23 20:41:05.119+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:110,-0.026110,0.052591,-0.067161
04-23 20:41:05.119+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.119+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.119+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:114,-0.070000,-0.070000,0.070000
04-23 20:41:05.119+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:05.119+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:05.119+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.119+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:128,0.055035,9.786645,0.794417
04-23 20:41:05.119+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.129+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:133,0.013282,0.014238,-0.023334
04-23 20:41:05.129+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:137,-0.070000,-0.070000,0.070000
04-23 20:41:05.139+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:142,0.041345,9.772414,0.817675
04-23 20:41:05.139+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.139+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.139+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.139+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:148,0.014357,9.805787,0.765703
04-23 20:41:05.149+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:153,-0.028186,0.033376,-0.051942
04-23 20:41:05.149+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.159+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:157,-0.070000,-0.140000,0.070000
04-23 20:41:05.159+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.159+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:160,0.041816,9.772453,0.817182
04-23 20:41:05.159+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.159+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.169+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:173,0.047856,9.808180,0.787239
04-23 20:41:05.169+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.179+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:185,0.042161,9.772533,0.816210
04-23 20:41:05.179+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:176,0.006511,0.035766,-0.030437
04-23 20:41:05.179+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.179+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:179,-0.070000,-0.140000,0.070000
04-23 20:41:05.179+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.179+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.189+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:193,0.045464,9.769895,0.772882
04-23 20:41:05.199+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.199+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:203,0.042583,9.772417,0.817574
04-23 20:41:05.199+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:202,-0.070000,-0.070000,0.070000
04-23 20:41:05.199+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.199+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:198,0.003648,-0.002559,-0.044300
04-23 20:41:05.199+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.209+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:213,0.047856,9.801002,0.818345
04-23 20:41:05.209+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.209+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.219+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:225,0.043215,9.772435,0.817328
04-23 20:41:05.219+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:223,-0.070000,-0.070000,0.070000
04-23 20:41:05.219+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:220,0.005696,0.028468,0.002136
04-23 20:41:05.219+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.219+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.229+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.239+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.239+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:237,0.052642,9.810574,0.792024
04-23 20:41:05.249+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:243,0.042556,9.772545,0.816054
04-23 20:41:05.249+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:241,-0.070000,-0.070000,0.070000
04-23 20:41:05.249+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:238,0.010059,0.038157,-0.025550
04-23 20:41:05.249+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.249+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.249+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.259+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.259+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:263,-0.070000,-0.070000,0.070000
04-23 20:41:05.259+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:267,-0.016894,0.040530,-0.068374
04-23 20:41:05.269+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:261,0.026321,9.812965,0.748954
04-23 20:41:05.269+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:271,0.042505,9.772488,0.816739
04-23 20:41:05.269+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.269+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.269+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.269+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.279+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:283,0.038285,9.824929,0.801596
04-23 20:41:05.279+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:287,-0.004271,0.052384,-0.014458
04-23 20:41:05.289+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:282,-0.070000,-0.070000,0.070000
04-23 20:41:05.289+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:290,0.042692,9.772532,0.816203
04-23 20:41:05.289+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.289+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.289+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.299+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:303,0.043071,9.786645,0.777667
04-23 20:41:05.299+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:307,-0.070000,-0.070000,0.070000
04-23 20:41:05.309+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.309+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:313,0.042869,9.772659,0.814662
04-23 20:41:05.309+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:310,0.000566,0.014157,-0.039072
04-23 20:41:05.319+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.319+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.319+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.319+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:05.319+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:05.319+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.319+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:328,0.043071,9.801002,0.758525
04-23 20:41:05.329+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:327,-0.070000,-0.070000,0.070000
04-23 20:41:05.339+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.339+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:332,0.000379,0.028470,-0.057678
04-23 20:41:05.339+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.339+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.339+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:342,0.041342,9.772489,0.816788
04-23 20:41:05.339+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.359+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:360,0.041582,9.772330,0.818664
04-23 20:41:05.359+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:352,-0.070000,-0.070000,0.070000
04-23 20:41:05.359+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:357,-0.035691,0.033128,-0.001102
04-23 20:41:05.359+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:353,0.007178,9.805787,0.813560
04-23 20:41:05.359+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.359+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.369+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.369+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.379+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:379,0.001729,0.009370,0.008736
04-23 20:41:05.379+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:380,0.041050,9.772178,0.820518
04-23 20:41:05.389+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:374,-0.070000,-0.070000,0.140000
04-23 20:41:05.389+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.389+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:376,0.043071,9.781858,0.825524
04-23 20:41:05.389+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.429+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.469+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.479+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:485,-0.070000,-0.070000,0.070000
04-23 20:41:05.479+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:489,0.023928,9.769895,0.780060
04-23 20:41:05.489+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:493,-0.017653,-0.002436,-0.038604
04-23 20:41:05.499+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.499+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.499+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.499+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:496,0.042083,9.772171,0.820535
04-23 20:41:05.499+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.499+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:507,-0.070000,-0.070000,0.070000
04-23 20:41:05.509+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:516,0.042285,9.772025,0.822270
04-23 20:41:05.519+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:511,0.059821,9.834501,0.806381
04-23 20:41:05.519+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.519+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.519+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:513,0.018771,0.062324,-0.014137
04-23 20:41:05.519+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:05.519+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:05.519+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.519+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:528,-0.070000,-0.070000,0.070000
04-23 20:41:05.519+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.529+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:533,0.043071,9.798609,0.827917
04-23 20:41:05.539+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:536,0.041333,9.772047,0.822050
04-23 20:41:05.539+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:539,0.000987,0.026438,0.007381
04-23 20:41:05.539+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.539+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.539+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.539+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.549+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:554,0.041498,9.771849,0.824401
04-23 20:41:05.559+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:553,0.019143,9.767502,0.765703
04-23 20:41:05.559+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:549,-0.070000,-0.070000,0.140000
04-23 20:41:05.559+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.559+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.559+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.559+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:558,-0.023142,-0.004523,-0.056567
04-23 20:41:05.569+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:573,-0.070000,-0.070000,0.070000
04-23 20:41:05.569+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.569+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:577,0.041044,9.771853,0.824365
04-23 20:41:05.579+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:582,0.038285,9.784252,0.806381
04-23 20:41:05.579+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:586,-0.003048,0.012205,-0.015669
04-23 20:41:05.579+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.579+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.579+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.589+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:593,-0.070000,0.070000,0.070000
04-23 20:41:05.599+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.599+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:603,-0.012785,0.036331,-0.039555
04-23 20:41:05.599+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:602,0.028714,9.808180,0.784846
04-23 20:41:05.599+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.599+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:599,0.041965,9.771950,0.823176
04-23 20:41:05.599+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.609+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:613,-0.070000,0.070000,0.070000
04-23 20:41:05.609+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.609+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.619+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:625,0.016384,0.050684,-0.041912
04-23 20:41:05.619+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:623,0.057428,9.822537,0.782453
04-23 20:41:05.619+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.619+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:619,0.044093,9.772103,0.821238
04-23 20:41:05.619+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.629+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.629+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:634,-0.070000,0.070000,0.140000
04-23 20:41:05.629+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.639+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:643,0.041784,0.050588,-0.038330
04-23 20:41:05.639+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.649+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:640,0.044110,9.772091,0.821386
04-23 20:41:05.649+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.649+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:645,0.083749,9.822537,0.784846
04-23 20:41:05.649+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.649+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.659+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:666,0.038285,9.805787,0.758525
04-23 20:41:05.659+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:655,-0.070000,-0.070000,0.070000
04-23 20:41:05.669+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:661,0.042287,9.771957,0.823073
04-23 20:41:05.669+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.669+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:663,-0.005807,0.033684,-0.062713
04-23 20:41:05.679+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:41:05.679+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:41:05.679+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:41:05.679+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.689+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.689+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.699+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:697,0.042936,9.772080,0.821572
04-23 20:41:05.699+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:679,-0.070000,0.070000,0.070000
04-23 20:41:05.709+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:702,0.002393,9.793823,0.799203
04-23 20:41:05.709+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.709+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:699,-0.041717,0.021732,-0.022183
04-23 20:41:05.709+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.709+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.709+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.719+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:05.719+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:05.739+0200 W/LOCATION(12344): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:41:05.749+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:728,0.052642,9.774680,0.768096
04-23 20:41:05.759+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:717,-0.070000,-0.070000,0.070000
04-23 20:41:05.759+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:723,0.044124,9.772172,0.820426
04-23 20:41:05.759+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:726,0.010355,0.002723,-0.054977
04-23 20:41:05.759+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.759+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.769+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.769+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.779+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:780,0.021670,0.026528,-0.034334
04-23 20:41:05.779+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:771,-0.070000,-0.070000,0.070000
04-23 20:41:05.779+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:775,0.043654,9.772205,0.820049
04-23 20:41:05.789+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:780,0.064606,9.798609,0.787239
04-23 20:41:05.789+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.789+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.799+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.799+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:804,0.042989,9.772104,0.821292
04-23 20:41:05.799+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.809+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:800,-0.070000,-0.070000,0.070000
04-23 20:41:05.819+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.819+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:810,0.031107,9.829715,0.777667
04-23 20:41:05.819+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.819+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:809,-0.013018,0.057543,-0.042758
04-23 20:41:05.819+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.819+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.839+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:826,-0.070000,0.070000,0.070000
04-23 20:41:05.839+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:839,-0.017333,0.040760,-0.011275
04-23 20:41:05.839+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:831,0.042335,9.772174,0.820497
04-23 20:41:05.849+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.849+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.849+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:840,0.026321,9.812965,0.808774
04-23 20:41:05.859+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.859+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.859+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:864,-0.016667,0.002576,-0.067552
04-23 20:41:05.859+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:868,0.026321,9.774680,0.753739
04-23 20:41:05.869+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:861,0.041955,9.772361,0.818287
04-23 20:41:05.869+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:856,-0.070000,-0.070000,0.070000
04-23 20:41:05.879+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.879+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.879+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:885,-0.070000,-0.070000,0.140000
04-23 20:41:05.879+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.879+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.889+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:891,0.042197,9.772120,0.821146
04-23 20:41:05.899+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:896,0.031107,9.777073,0.734596
04-23 20:41:05.899+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:893,-0.011228,0.004899,-0.085900
04-23 20:41:05.899+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.899+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.899+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:908,-0.070000,-0.070000,0.070000
04-23 20:41:05.909+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:913,0.041586,9.772169,0.820593
04-23 20:41:05.909+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.909+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.919+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:05.919+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:05.929+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.929+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.929+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:928,0.040678,9.822537,0.818345
04-23 20:41:05.939+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:923,-0.001277,0.050177,0.000058
04-23 20:41:05.939+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.939+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:942,-0.070000,-0.070000,0.140000
04-23 20:41:05.939+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.959+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:953,-0.015875,0.079132,-0.050657
04-23 20:41:05.959+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.959+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:944,0.039719,9.771790,0.825190
04-23 20:41:05.959+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:954,0.026321,9.851252,0.770489
04-23 20:41:05.959+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.959+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:969,-0.070000,0.070000,0.070000
04-23 20:41:05.969+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:973,0.040252,9.771889,0.823988
04-23 20:41:05.969+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.969+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.979+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:05:982,-0.046372,0.033618,0.007324
04-23 20:41:05.989+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:05.989+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:05.989+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:05:983,-0.004786,9.805787,0.827917
04-23 20:41:05.989+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:05.989+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:05.999+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:05:999,0.038052,9.771625,0.827218
04-23 20:41:06.009+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:13,0.047856,9.805787,0.775275
04-23 20:41:06.009+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:05:995,-0.070000,0.070000,0.070000
04-23 20:41:06.009+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.009+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:11,0.008137,0.033998,-0.049915
04-23 20:41:06.009+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.019+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:23,-0.070000,0.070000,0.070000
04-23 20:41:06.019+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:27,0.038776,9.771626,0.827162
04-23 20:41:06.019+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.019+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.029+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:39,-0.049823,0.053041,-0.003250
04-23 20:41:06.039+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:33,-0.009571,9.824929,0.820738
04-23 20:41:06.039+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.039+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.039+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:49,-0.070000,0.070000,0.070000
04-23 20:41:06.049+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:52,0.038553,9.771650,0.826890
04-23 20:41:06.049+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.049+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.089+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.089+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.089+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:58,0.012197,0.017413,-0.028016
04-23 20:41:06.099+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:60,0.050249,9.789038,0.799203
04-23 20:41:06.099+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.099+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.109+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:95,-0.070000,-0.070000,0.070000
04-23 20:41:06.109+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:103,0.039144,9.771632,0.827079
04-23 20:41:06.109+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.119+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.119+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:06.119+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:06.129+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:133,0.038952,9.771530,0.828289
04-23 20:41:06.129+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:110,-0.007669,0.034161,-0.049495
04-23 20:41:06.129+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:115,0.031107,9.805787,0.777667
04-23 20:41:06.129+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.129+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.139+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:124,-0.070000,-0.070000,0.140000
04-23 20:41:06.139+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:143,0.047856,9.812965,0.808774
04-23 20:41:06.139+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:141,0.009304,0.041315,-0.018116
04-23 20:41:06.139+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.139+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.149+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:153,0.039188,9.771568,0.827833
04-23 20:41:06.149+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.159+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.159+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:169,-0.010430,0.038941,-0.049412
04-23 20:41:06.169+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:172,0.028714,9.810574,0.777667
04-23 20:41:06.169+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:152,-0.070000,-0.070000,0.070000
04-23 20:41:06.169+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.169+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.179+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.179+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.179+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:187,0.001726,0.041435,-0.036265
04-23 20:41:06.189+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:180,-0.070000,-0.070000,0.070000
04-23 20:41:06.189+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:183,0.039418,9.771797,0.825110
04-23 20:41:06.189+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.189+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.199+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:203,-0.070000,0.070000,0.070000
04-23 20:41:06.199+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:206,0.038040,9.771604,0.827463
04-23 20:41:06.199+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:191,0.040678,9.812965,0.792024
04-23 20:41:06.199+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.209+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.219+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:222,0.040678,9.820145,0.748954
04-23 20:41:06.219+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.219+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:219,0.001490,0.048576,-0.078880
04-23 20:41:06.229+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.229+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:233,0.037403,9.771318,0.830850
04-23 20:41:06.229+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.239+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.239+0200 I/servicemanager(12059): es.ugr.frailty.location sleep timeout
04-23 20:41:06.239+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:41:06.239+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:41:06.239+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 12059
04-23 20:41:06.249+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12344
04-23 20:41:06.249+0200 W/AUL     (12059): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12344)
04-23 20:41:06.249+0200 I/servicemanager(12059): es.ugr.frailty.location stop request sent!
04-23 20:41:06.249+0200 I/servicemanager(12059): App control destroyed.
04-23 20:41:06.259+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:230,-0.070000,0.140000,0.070000
04-23 20:41:06.259+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.259+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.259+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:245,-0.032239,0.007669,-0.016336
04-23 20:41:06.269+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:273,-0.070000,0.140000,0.070000
04-23 20:41:06.269+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:259,0.007178,9.779467,0.808774
04-23 20:41:06.269+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.279+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.279+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:284,-0.016504,0.062898,0.021989
04-23 20:41:06.279+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:288,0.021535,9.834501,0.849452
04-23 20:41:06.279+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:276,0.036683,9.771097,0.833481
04-23 20:41:06.289+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.289+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.299+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:299,-0.070000,0.070000,0.070000
04-23 20:41:06.299+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.299+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.299+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:309,-0.018261,0.020112,-0.002934
04-23 20:41:06.309+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:300,0.037917,9.771129,0.833066
04-23 20:41:06.309+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.319+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.319+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:313,0.019143,9.791430,0.827917
04-23 20:41:06.319+0200 I/heartrate(12076): capturing data from es.ugr.frailty.heartrate
04-23 20:41:06.319+0200 I/heartrate(12076): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:41:06.329+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.339+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:323,-0.070000,0.070000,0.070000
04-23 20:41:06.339+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.339+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:326,0.037851,9.771155,0.832752
04-23 20:41:06.339+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.349+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.359+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:354,-0.070000,-0.070000,0.140000
04-23 20:41:06.359+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:347,0.059821,9.808180,0.808774
04-23 20:41:06.359+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:339,0.023138,0.037083,-0.024707
04-23 20:41:06.359+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.359+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.369+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.369+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:356,0.037144,9.771031,0.834240
04-23 20:41:06.369+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.389+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:374,0.033500,9.801002,0.784846
04-23 20:41:06.389+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:371,-0.004418,0.029873,-0.048220
04-23 20:41:06.389+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.389+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.399+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:383,-0.070000,-0.070000,0.140000
04-23 20:41:06.399+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:386,0.036366,9.770822,0.836719
04-23 20:41:06.399+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:402,-0.021101,0.051382,-0.062263
04-23 20:41:06.399+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.409+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.409+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:413,-0.070000,-0.070000,0.070000
04-23 20:41:06.419+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:405,0.016750,9.822537,0.770489
04-23 20:41:06.419+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.419+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.419+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:417,0.037079,9.770944,0.835270
04-23 20:41:06.429+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:429,-0.022787,0.015614,-0.047001
04-23 20:41:06.429+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.429+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.439+0200 I/gyroscope(12073): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:41:06:444,-0.070000,-0.070000,0.140000
04-23 20:41:06.439+0200 I/gravity (12110): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:41:06:448,0.038714,9.771220,0.831949
04-23 20:41:06.449+0200 I/linearacceleration(12097): capturing data from es.ugr.frailty.linearacceleration
04-23 20:41:06.479+0200 I/accelerometer(12070): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:41:06:431,0.014357,9.786645,0.787239
04-23 20:41:06.489+0200 I/accelerometer(12070): capturing data from es.ugr.frailty.accelerometer
04-23 20:41:06.509+0200 I/gyroscope(12073): capturing data from es.ugr.frailty.gyroscope
04-23 20:41:06.519+0200 I/gravity (12110): capturing data from es.ugr.frailty.gravity
04-23 20:41:06.519+0200 I/linearacceleration(12097): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:41:06:517,0.011491,-0.012892,-0.049480
04-23 20:41:06.519+0200 W/CRASH_MANAGER(12149): worker.c: worker_job(1205) > 11123446c6f63152450886
