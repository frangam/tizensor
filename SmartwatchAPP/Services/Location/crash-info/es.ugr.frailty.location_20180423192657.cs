S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14401
Date: 2018-04-23 19:26:57+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf766852d, r5   = 0xf7e24f98
r6   = 0xffaade00, r7   = 0xffaadcb0
r8   = 0xf7e21c18, r9   = 0x00000000
r10  = 0xffaadd8c, fp   = 0xffaade00
ip   = 0x00000001, sp   = 0xffaadc88
lr   = 0xf7668539, pc   = 0xf76d1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     17140 KB
Buffers:     51856 KB
Cached:     236652 KB
VmPeak:      53488 KB
VmSize:      53424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12112 KB
VmRSS:       12108 KB
VmData:      11152 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14401 TID = 14401
14401 14430 

Maps Information
f4533000 f4d32000 rw-p [stack:14430]
f4d39000 f4d3b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d43000 f4d47000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d50000 f4d52000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d5a000 f4d5d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d6c000 f4d71000 r-xp /usr/lib/libsystem.so.0.0.0
f4d7c000 f4d7f000 r-xp /lib/libattr.so.1.1.0
f4d87000 f4d97000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d9f000 f4da8000 r-xp /usr/lib/libedbus.so.1.7.99
f4db0000 f4db1000 r-xp /usr/lib/libresponse.so.0.2.96
f4dba000 f4dbf000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6661000 f6767000 r-xp /usr/lib/libicuuc.so.57.1
f677d000 f6905000 r-xp /usr/lib/libicui18n.so.57.1
f6915000 f6922000 r-xp /usr/lib/libail.so.0.1.0
f692b000 f6932000 r-xp /usr/lib/libminizip.so.1.0.0
f693b000 f6ae4000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b04000 f6b4b000 r-xp /usr/lib/libssl.so.1.0.0
f6b57000 f6b59000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b61000 f6b68000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b71000 f6b78000 r-xp /lib/libcrypt-2.13.so
f6ba9000 f6bac000 r-xp /lib/libcap.so.2.21
f6bb4000 f6bb6000 r-xp /usr/lib/libiri.so
f6bbe000 f6c07000 r-xp /usr/lib/libmdm.so.1.2.69
f6c0f000 f6c15000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c1d000 f6c40000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c4a000 f6c4c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c54000 f6c71000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c7a000 f6c7e000 r-xp /usr/lib/libsmack.so.1.0.0
f6c87000 f6ca0000 r-xp /usr/lib/libnetwork.so.0.0.0
f6ca9000 f6cb1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6cb9000 f6cbf000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cc8000 f6cca000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cd3000 f6ce3000 r-xp /lib/libresolv-2.13.so
f6ce7000 f6cff000 r-xp /usr/lib/liblzma.so.5.0.3
f6d08000 f6d0a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d12000 f6d2c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d34000 f6d63000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d6c000 f6d7b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d85000 f6d8f000 r-xp /usr/lib/libsensord-shared.so
f6d98000 f6e6b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e76000 f6e8c000 r-xp /lib/libz.so.1.2.5
f6e94000 f6e99000 r-xp /usr/lib/libffi.so.5.0.10
f6ea1000 f6ea2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6eaa000 f6eba000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ec2000 f6edb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6ee3000 f6ee5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6eed000 f6f62000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f6c000 f6f72000 r-xp /lib/librt-2.13.so
f6f7b000 f6f99000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fa3000 f6fa4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fac000 f6fcf000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fd7000 f6fdc000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fe4000 f700e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7017000 f702e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7036000 f709f000 r-xp /lib/libm-2.13.so
f70a8000 f713c000 r-xp /usr/lib/libstdc++.so.6.0.16
f714f000 f7154000 r-xp /usr/lib/libctx-client.so.0.8.3
f715c000 f7163000 r-xp /usr/lib/libctx-shared.so.0.8.3
f716b000 f7195000 r-xp /usr/lib/libsensor.so.1.9.6
f719e000 f726a000 r-xp /usr/lib/libxml2.so.2.7.8
f7277000 f7279000 r-xp /usr/lib/libiniparser.so.0
f7282000 f7288000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7291000 f7361000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7362000 f7396000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f739f000 f73db000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73e3000 f73e6000 r-xp /usr/lib/libbundle.so.0.1.22
f73ee000 f73f4000 r-xp /usr/lib/libappsvc.so.0.1.0
f73fc000 f743d000 r-xp /usr/lib/libeina.so.1.7.99
f7446000 f745d000 r-xp /usr/lib/libecore.so.1.7.99
f7474000 f747d000 r-xp /usr/lib/libvconf.so.0.2.45
f7485000 f7499000 r-xp /lib/libpthread-2.13.so
f74a4000 f74b1000 r-xp /usr/lib/libaul.so.0.1.0
f74bb000 f74bd000 r-xp /lib/libdl-2.13.so
f74c6000 f74d1000 r-xp /lib/libunwind.so.8.0.1
f74fe000 f7506000 r-xp /lib/libgcc_s-4.6.so.1
f7507000 f762b000 r-xp /lib/libc-2.13.so
f7639000 f763b000 r-xp /usr/lib/libdlog.so.0.0.0
f7643000 f764f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7658000 f765d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7665000 f7674000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f767c000 f7680000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7689000 f768c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7694000 f7696000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f769e000 f76a2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76aa000 f76c7000 r-xp /lib/ld-2.13.so
f76d0000 f76d3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76d3000 f76d7000 r-xp /usr/lib/libsys-assert.so
f7df1000 f7e5a000 rw-p [heap]
ffa8f000 ffab0000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14401)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76d1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7668539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf736f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf736dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7379e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf737fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf737fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73b475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73af1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf736dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7379e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf737fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf737fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73b1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73b2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73b9f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d511fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d44171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e17663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72c4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72c67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7456ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7451b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74525a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7452879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf768a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf768a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76d14f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf751e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf76d0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
celeration
04-23 19:26:57.039+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.039+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.039+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:46,-0.977463,-4.981015,8.390736
04-23 19:26:57.039+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:45,-0.264982,0.532220,0.443962
04-23 19:26:57.049+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.049+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:45,0.560000,0.630000,0.280000
04-23 19:26:57.049+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.049+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:50,-1.167697,-4.500899,8.760124
04-23 19:26:57.049+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:53,-0.213384,0.540378,0.402781
04-23 19:26:57.049+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.049+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.049+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:57,-0.213961,0.502624,0.362751
04-23 19:26:57.059+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:55,-0.840000,0.770000,0.280000
04-23 19:26:57.059+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:58,-1.179662,-4.505685,8.738588
04-23 19:26:57.059+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.059+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.059+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.059+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:65,-0.985779,-4.958930,8.402835
04-23 19:26:57.059+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.059+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:26:57.059+0200 I/heartrate(14276): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:26:57.069+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:69,-0.163913,0.432260,0.271282
04-23 19:26:57.069+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:66,-1.141376,-4.548756,8.662018
04-23 19:26:57.069+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:69,-0.980000,0.210000,-0.140000
04-23 19:26:57.079+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.079+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.089+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:91,-0.991789,-4.939572,8.413523
04-23 19:26:57.089+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:90,0.140000,0.700000,-0.210000
04-23 19:26:57.089+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.089+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:95,-1.093520,-4.582255,8.690732
04-23 19:26:57.089+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.089+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:98,-0.107741,0.376675,0.287897
04-23 19:26:57.099+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.099+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.099+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:106,-1.006436,-4.917324,8.424809
04-23 19:26:57.099+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:107,0.910000,1.820000,0.280000
04-23 19:26:57.099+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.099+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.109+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:110,-1.232304,-4.500899,8.676375
04-23 19:26:57.109+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:112,-0.240515,0.438673,0.262853
04-23 19:26:57.119+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.119+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.119+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:126,-1.022691,-4.896412,8.435024
04-23 19:26:57.119+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:126,0.070000,1.540000,0.490000
04-23 19:26:57.119+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.119+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.129+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:131,-1.287339,-4.510471,8.671589
04-23 19:26:57.129+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:131,-0.280903,0.406853,0.246780
04-23 19:26:57.139+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.139+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.139+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:148,-1.036514,-4.879674,8.443033
04-23 19:26:57.149+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.149+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:146,-0.420000,1.050000,0.490000
04-23 19:26:57.149+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.159+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.159+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:166,-1.048217,-4.864043,8.450604
04-23 19:26:57.169+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:160,-1.272982,-4.579862,8.657232
04-23 19:26:57.169+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.169+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:176,-1.251446,-4.589434,8.628519
04-23 19:26:57.179+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:153,-0.250291,0.316550,0.222208
04-23 19:26:57.179+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.179+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:184,-0.214932,0.290240,0.185486
04-23 19:26:57.179+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.189+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:192,-1.058933,-4.848727,8.458067
04-23 19:26:57.189+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.199+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.199+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.199+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:207,-1.261017,-4.615755,8.621340
04-23 19:26:57.209+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.209+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:213,-1.070803,-4.827127,8.468921
04-23 19:26:57.209+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:204,-0.140000,0.770000,0.420000
04-23 19:26:57.219+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:199,-0.212800,0.248288,0.170735
04-23 19:26:57.219+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.219+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:228,-0.230799,0.316720,0.211130
04-23 19:26:57.219+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.229+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.229+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:233,-1.081118,-4.809268,8.477766
04-23 19:26:57.229+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.229+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:238,0.490000,0.420000,0.210000
04-23 19:26:57.239+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.239+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:243,-1.289732,-4.532006,8.669197
04-23 19:26:57.239+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.239+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.249+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.249+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:253,-1.086377,-4.795990,8.484612
04-23 19:26:57.249+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:233,-0.178250,0.342977,0.164383
04-23 19:26:57.259+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:250,-1.249053,-4.484150,8.633304
04-23 19:26:57.259+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.259+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:26:57.259+0200 I/heartrate(14276): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:26:57.269+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:263,2.030000,0.630000,0.350000
04-23 19:26:57.269+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.269+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.269+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.269+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:278,0.560000,0.840000,0.420000
04-23 19:26:57.279+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:277,-1.084823,-4.780998,8.493268
04-23 19:26:57.289+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:269,-1.210768,-4.608576,8.683553
04-23 19:26:57.289+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:283,-0.129650,0.200691,0.205787
04-23 19:26:57.289+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.289+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.289+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.289+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.339+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:345,-1.074377,-4.565506,8.683553
04-23 19:26:57.339+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.339+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:304,0.012000,0.230485,0.198940
04-23 19:26:57.339+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.349+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:303,-1.260000,-0.560000,0.420000
04-23 19:26:57.349+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.349+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:356,0.840000,-0.350000,-0.140000
04-23 19:26:57.349+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.359+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:299,-1.086277,-4.763258,8.503044
04-23 19:26:57.359+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.359+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:349,-1.069592,-4.431508,8.659625
04-23 19:26:57.359+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.359+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:368,-1.205983,-4.445865,8.743374
04-23 19:26:57.359+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.369+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:364,-1.094861,-4.747832,8.510568
04-23 19:26:57.369+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.369+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:376,-1.104061,-4.734359,8.516882
04-23 19:26:57.369+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.369+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:379,-1.113884,-4.724972,8.520815
04-23 19:26:57.379+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:353,0.015232,0.349490,0.166357
04-23 19:26:57.379+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.379+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:385,-0.119706,0.317394,0.240330
04-23 19:26:57.379+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.389+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:389,-0.151800,0.261289,0.271091
04-23 19:26:57.389+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.389+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:396,-0.156957,0.195175,0.152315
04-23 19:26:57.389+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:360,2.730000,1.330000,0.070000
04-23 19:26:57.389+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.399+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.399+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:372,-1.246661,-4.486543,8.781659
04-23 19:26:57.399+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.399+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:404,-0.142348,0.178609,0.160345
04-23 19:26:57.399+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.399+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.399+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:400,1.400000,1.890000,0.210000
04-23 19:26:57.399+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.409+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:410,-0.152598,0.142146,0.127183
04-23 19:26:57.409+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.409+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:413,-1.122777,-4.714830,8.525264
04-23 19:26:57.409+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.409+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:415,-0.108024,0.189606,0.125216
04-23 19:26:57.409+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:411,-0.140000,1.330000,0.490000
04-23 19:26:57.409+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.409+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:407,-1.261017,-4.539185,8.669197
04-23 19:26:57.409+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.419+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.419+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:422,-1.256232,-4.546363,8.681160
04-23 19:26:57.419+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.419+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:426,-0.091084,0.162179,0.201673
04-23 19:26:57.419+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:427,-1.275374,-4.572684,8.652447
04-23 19:26:57.419+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.419+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:422,-0.070000,1.260000,0.770000
04-23 19:26:57.419+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.429+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:417,-1.131458,-4.704862,8.529623
04-23 19:26:57.429+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.429+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:433,0.490000,1.190000,0.840000
04-23 19:26:57.429+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:434,-1.138827,-4.694185,8.534523
04-23 19:26:57.429+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.429+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.429+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:437,-1.145579,-4.683872,8.539285
04-23 19:26:57.429+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:438,1.260000,0.910000,0.630000
04-23 19:26:57.429+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:430,-1.239482,-4.515256,8.654840
04-23 19:26:57.429+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.429+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.439+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:442,-1.229911,-4.532006,8.736196
04-23 19:26:57.439+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.439+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.439+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:447,-1.153690,-4.676178,8.542408
04-23 19:26:57.439+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.439+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:447,-0.096296,0.173401,0.223232
04-23 19:26:57.439+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:442,1.820000,1.400000,0.420000
04-23 19:26:57.439+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.449+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:450,-1.241875,-4.510471,8.762517
04-23 19:26:57.449+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:453,2.380000,1.890000,0.280000
04-23 19:26:57.449+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.449+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:457,1.470000,2.520000,0.280000
04-23 19:26:57.459+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.459+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.459+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.459+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:466,-1.325624,-4.584648,8.640482
04-23 19:26:57.459+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:466,-0.171933,0.091530,0.098074
04-23 19:26:57.459+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:26:57.459+0200 I/heartrate(14276): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:26:57.459+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.469+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:470,-1.164235,-4.674697,8.541788
04-23 19:26:57.469+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:473,-0.070000,1.680000,-0.070000
04-23 19:26:57.479+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.479+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.479+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.489+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:491,-1.168841,-4.674169,8.541449
04-23 19:26:57.489+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.489+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:491,-1.253839,-4.644469,8.561519
04-23 19:26:57.489+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:495,0.140000,0.420000,-0.350000
04-23 19:26:57.489+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:491,-0.089604,0.030229,0.019731
04-23 19:26:57.499+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.499+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.499+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.499+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:508,-1.171986,-4.663085,8.547073
04-23 19:26:57.499+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.509+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:512,2.590000,0.630000,-0.210000
04-23 19:26:57.509+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:509,-0.058678,0.149341,0.113391
04-23 19:26:57.509+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:508,-1.227518,-4.524827,8.654840
04-23 19:26:57.519+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.519+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.519+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.519+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:528,-1.180290,-4.644605,8.555989
04-23 19:26:57.529+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.529+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:533,3.570000,1.260000,0.210000
04-23 19:26:57.529+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:528,-0.141674,0.267470,0.174765
04-23 19:26:57.529+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:527,-1.313660,-4.395615,8.721838
04-23 19:26:57.539+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.539+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.539+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.549+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.549+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:548,-0.092691,0.251382,0.204135
04-23 19:26:57.549+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:548,-1.185169,-4.627283,8.564696
04-23 19:26:57.559+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.559+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:547,-1.272982,-4.393222,8.760124
04-23 19:26:57.559+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.559+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.559+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:557,1.680000,0.420000,0.490000
04-23 19:26:57.559+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.569+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:566,-1.187152,-4.613750,8.571718
04-23 19:26:57.569+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:568,-0.044742,0.181418,0.140392
04-23 19:26:57.579+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:572,0.560000,-0.280000,0.910000
04-23 19:26:57.579+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:569,-1.229911,-4.445865,8.705089
04-23 19:26:57.579+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.579+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.589+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.599+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.599+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:603,-0.042759,0.151136,0.178834
04-23 19:26:57.599+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:26:57.609+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:26:57.609+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:26:57.609+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:592,-1.188661,-4.601399,8.578146
04-23 19:26:57.609+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.609+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:591,-1.229911,-4.462614,8.750552
04-23 19:26:57.619+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.619+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:598,-0.070000,-0.420000,0.980000
04-23 19:26:57.619+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:623,-1.241875,-4.601398,8.697910
04-23 19:26:57.619+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.629+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.629+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:631,-1.225125,-4.572684,8.719445
04-23 19:26:57.629+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.629+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:622,-1.191332,-4.597765,8.579724
04-23 19:26:57.639+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.639+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:639,-0.053214,0.000001,0.119764
04-23 19:26:57.639+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.639+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.639+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:636,-0.280000,0.070000,0.980000
04-23 19:26:57.649+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:649,-1.232304,-4.558327,8.645268
04-23 19:26:57.649+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.659+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:644,-1.193727,-4.594158,8.581324
04-23 19:26:57.659+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:646,-0.033794,0.025081,0.139721
04-23 19:26:57.659+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.659+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.669+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:26:57.669+0200 I/heartrate(14276): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:26:57.669+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:667,-0.038576,0.035830,0.063945
04-23 19:26:57.669+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.669+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:669,-1.239482,-4.570292,8.678767
04-23 19:26:57.679+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.679+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:679,-0.042661,0.020164,0.095894
04-23 19:26:57.679+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:660,0.210000,0.630000,0.630000
04-23 19:26:57.679+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.679+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:685,-1.196821,-4.590456,8.582873
04-23 19:26:57.679+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.679+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.689+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:692,-1.239482,-4.646862,8.633304
04-23 19:26:57.689+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:692,-0.039052,-0.056896,0.050672
04-23 19:26:57.689+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.689+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:687,1.260000,0.840000,0.490000
04-23 19:26:57.689+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.689+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:698,0.140000,1.120000,0.280000
04-23 19:26:57.699+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.699+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:699,-1.200430,-4.589965,8.582632
04-23 19:26:57.699+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.699+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.699+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.699+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:707,0.095765,-0.111411,0.062422
04-23 19:26:57.699+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:707,-1.107877,-4.709075,8.640482
04-23 19:26:57.709+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:703,-1.470000,1.120000,-0.490000
04-23 19:26:57.709+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.709+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:715,0.910000,0.140000,-1.050000
04-23 19:26:57.709+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:705,-1.203642,-4.597664,8.578060
04-23 19:26:57.709+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.719+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:722,-1.197989,-4.601451,8.576820
04-23 19:26:57.719+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.729+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.729+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:729,0.056612,0.141230,0.097162
04-23 19:26:57.729+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.729+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:734,3.570000,1.820000,-0.770000
04-23 19:26:57.729+0200 W/LOCATION(14401): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:26:57.729+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:737,-1.197227,-4.594211,8.580808
04-23 19:26:57.729+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.739+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.739+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.739+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:746,-0.135575,0.189024,0.148209
04-23 19:26:57.749+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.749+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:744,-1.141376,-4.460221,8.673983
04-23 19:26:57.749+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.749+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:753,-1.205976,-4.584769,8.584632
04-23 19:26:57.749+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:756,-1.332802,-4.405186,8.729016
04-23 19:26:57.749+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:749,2.240000,1.890000,-0.350000
04-23 19:26:57.759+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.759+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.759+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:766,-1.216028,-4.575734,8.588034
04-23 19:26:57.759+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:766,-0.203396,0.141297,0.163527
04-23 19:26:57.759+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.769+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.769+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:771,-1.409373,-4.443472,8.748159
04-23 19:26:57.769+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:773,-0.210000,0.420000,0.420000
04-23 19:26:57.789+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.789+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.789+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:793,-0.700000,-0.980000,1.050000
04-23 19:26:57.789+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.789+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:794,-0.171809,0.120298,0.059628
04-23 19:26:57.789+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.789+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:798,-1.223237,-4.565842,8.592274
04-23 19:26:57.799+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:799,-1.387837,-4.455436,8.647661
04-23 19:26:57.799+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.799+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.799+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:807,-1.190000,-1.680000,1.470000
04-23 19:26:57.799+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.799+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:807,-0.004281,0.064943,0.067351
04-23 19:26:57.799+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.809+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:811,-1.221591,-4.557220,8.597083
04-23 19:26:57.809+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:813,-1.227518,-4.500899,8.659625
04-23 19:26:57.819+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.819+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.819+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.819+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:827,0.082607,-0.070498,0.146291
04-23 19:26:57.819+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.829+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:827,-1.260000,-1.540000,1.120000
04-23 19:26:57.829+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:830,-1.215170,-4.553676,8.599872
04-23 19:26:57.829+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:832,-1.138984,-4.627719,8.743374
04-23 19:26:57.839+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.839+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.839+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.839+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:847,0.078580,-0.076436,0.188966
04-23 19:26:57.839+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.849+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:846,-1.211193,-4.552678,8.600960
04-23 19:26:57.849+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:848,0.210000,0.280000,0.560000
04-23 19:26:57.849+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:852,-1.136591,-4.630112,8.788837
04-23 19:26:57.859+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.859+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.859+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.859+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:866,-0.006753,-0.075041,0.161557
04-23 19:26:57.859+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.859+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:26:57.859+0200 I/heartrate(14276): es.ugr.frailty.heartrate: waiting for rigth values
04-23 19:26:57.869+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:867,0.980000,1.610000,-0.140000
04-23 19:26:57.869+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:866,-1.212959,-4.555161,8.599397
04-23 19:26:57.869+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:872,-1.217947,-4.627719,8.762517
04-23 19:26:57.879+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.879+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.879+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.889+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:892,0.490000,0.560000,-0.490000
04-23 19:26:57.889+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:891,0.038083,-0.029487,0.038692
04-23 19:26:57.889+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.889+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:891,-1.211452,-4.557096,8.598583
04-23 19:26:57.889+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:896,-1.174876,-4.584648,8.638089
04-23 19:26:57.899+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.899+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.899+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:907,-1.207752,-4.557839,8.598710
04-23 19:26:57.899+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:907,0.089218,-0.008409,-0.041850
04-23 19:26:57.899+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.909+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.909+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:911,1.470000,0.490000,-0.420000
04-23 19:26:57.909+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:913,-1.122234,-4.565506,8.556733
04-23 19:26:57.919+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.919+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.919+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:926,-1.209781,-4.552893,8.601046
04-23 19:26:57.919+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:927,0.013734,0.164617,-0.027619
04-23 19:26:57.919+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.919+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.929+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:930,2.310000,1.610000,-0.420000
04-23 19:26:57.929+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:931,-1.194018,-4.393222,8.571091
04-23 19:26:57.939+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.939+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.939+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:946,-0.063201,0.068743,0.101650
04-23 19:26:57.939+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:946,-1.214881,-4.550457,8.601616
04-23 19:26:57.939+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.939+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.949+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:950,0.490000,1.400000,0.280000
04-23 19:26:57.949+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:951,-1.272982,-4.484150,8.702696
04-23 19:26:57.959+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.959+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.959+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:966,-0.280000,0.700000,0.350000
04-23 19:26:57.959+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.959+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:967,-0.091600,-0.048549,0.199186
04-23 19:26:57.959+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.969+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:970,-1.219408,-4.549917,8.601260
04-23 19:26:57.969+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:57:972,-1.306481,-4.599005,8.800802
04-23 19:26:57.979+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:57.989+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:57.989+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:57:993,0.910000,0.560000,0.420000
04-23 19:26:57.989+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:57.989+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:57:999,-0.053573,-0.039516,0.154078
04-23 19:26:57.999+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:57.999+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:58:4,-1.272982,-4.589434,8.755339
04-23 19:26:57.999+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:57:993,-1.222046,-4.547307,8.602266
04-23 19:26:58.009+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:58.009+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:58:13,-0.103577,0.044014,0.014288
04-23 19:26:58.009+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:58.019+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:58.019+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:58.019+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:58:26,-0.050220,0.027086,0.024413
04-23 19:26:58.019+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:58.019+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:58:24,-1.227547,-4.542343,8.604106
04-23 19:26:58.029+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:58.029+0200 I/gravity (14415): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:26:58:33,-1.229611,-4.535930,8.607193
04-23 19:26:58.029+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:58:32,-1.325624,-4.503292,8.616554
04-23 19:26:58.029+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:58.029+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:58:37,-1.277767,-4.515256,8.628519
04-23 19:26:58.029+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:58:20,1.260000,0.280000,0.560000
04-23 19:26:58.029+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:58.039+0200 I/linearacceleration(14404): capturing data from es.ugr.frailty.linearacceleration
04-23 19:26:58.039+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:58:43,1.400000,-0.280000,0.770000
04-23 19:26:58.039+0200 I/gyroscope(14388): capturing data from es.ugr.frailty.gyroscope
04-23 19:26:58.039+0200 I/linearacceleration(14404): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:26:58:46,-0.033800,0.044602,0.078753
04-23 19:26:58.039+0200 I/accelerometer(14373): capturing data from es.ugr.frailty.accelerometer
04-23 19:26:58.049+0200 I/gyroscope(14388): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:26:58:49,0.630000,0.210000,0.980000
04-23 19:26:58.049+0200 I/gravity (14415): capturing data from es.ugr.frailty.gravity
04-23 19:26:58.049+0200 I/accelerometer(14373): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:26:58:51,-1.263410,-4.491328,8.685946
04-23 19:26:58.049+0200 W/CRASH_MANAGER(14336): worker.c: worker_job(1205) > 11144016c6f63152450441
