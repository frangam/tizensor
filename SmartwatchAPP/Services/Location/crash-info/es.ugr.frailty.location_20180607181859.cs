S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 27001
Date: 2018-06-07 18:18:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73ec52d, r5   = 0xf7bda958
r6   = 0xffbaee80, r7   = 0xffbaed30
r8   = 0xf7bedc18, r9   = 0x00000000
r10  = 0xffbaee0c, fp   = 0xffbaee80
ip   = 0x00000001, sp   = 0xffbaed08
lr   = 0xf73ec539, pc   = 0xf7455228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    270328 KB
Buffers:      5808 KB
Cached:      96764 KB
VmPeak:      53440 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11912 KB
VmRSS:       11908 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 27001 TID = 27001
27001 27080 

Maps Information
f42b7000 f4ab6000 rw-p [stack:27080]
f4abd000 f4abf000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ac7000 f4acb000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ad4000 f4ad6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4ade000 f4ae1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4af0000 f4af5000 r-xp /usr/lib/libsystem.so.0.0.0
f4b00000 f4b03000 r-xp /lib/libattr.so.1.1.0
f4b0b000 f4b1b000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b23000 f4b2c000 r-xp /usr/lib/libedbus.so.1.7.99
f4b34000 f4b35000 r-xp /usr/lib/libresponse.so.0.2.96
f4b3e000 f4b43000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63e5000 f64eb000 r-xp /usr/lib/libicuuc.so.57.1
f6501000 f6689000 r-xp /usr/lib/libicui18n.so.57.1
f6699000 f66a6000 r-xp /usr/lib/libail.so.0.1.0
f66af000 f66b6000 r-xp /usr/lib/libminizip.so.1.0.0
f66bf000 f6868000 r-xp /usr/lib/libcrypto.so.1.0.0
f6888000 f68cf000 r-xp /usr/lib/libssl.so.1.0.0
f68db000 f68dd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68e5000 f68ec000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68f5000 f68fc000 r-xp /lib/libcrypt-2.13.so
f692d000 f6930000 r-xp /lib/libcap.so.2.21
f6938000 f693a000 r-xp /usr/lib/libiri.so
f6942000 f698b000 r-xp /usr/lib/libmdm.so.1.2.69
f6993000 f6999000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69a1000 f69c4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69ce000 f69d0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69d8000 f69f5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69fe000 f6a02000 r-xp /usr/lib/libsmack.so.1.0.0
f6a0b000 f6a24000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a2d000 f6a35000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a3d000 f6a43000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a4c000 f6a4e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a57000 f6a67000 r-xp /lib/libresolv-2.13.so
f6a6b000 f6a83000 r-xp /usr/lib/liblzma.so.5.0.3
f6a8c000 f6a8e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a96000 f6ab0000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ab8000 f6ae7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6af0000 f6aff000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b09000 f6b13000 r-xp /usr/lib/libsensord-shared.so
f6b1c000 f6bef000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bfa000 f6c10000 r-xp /lib/libz.so.1.2.5
f6c18000 f6c1d000 r-xp /usr/lib/libffi.so.5.0.10
f6c25000 f6c26000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c2e000 f6c3e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c46000 f6c5f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c67000 f6c69000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c71000 f6ce6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cf0000 f6cf6000 r-xp /lib/librt-2.13.so
f6cff000 f6d1d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d27000 f6d28000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d30000 f6d53000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d5b000 f6d60000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d68000 f6d92000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d9b000 f6db2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6dba000 f6e23000 r-xp /lib/libm-2.13.so
f6e2c000 f6ec0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ed3000 f6ed8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ee0000 f6ee7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6eef000 f6f19000 r-xp /usr/lib/libsensor.so.1.9.6
f6f22000 f6fee000 r-xp /usr/lib/libxml2.so.2.7.8
f6ffb000 f6ffd000 r-xp /usr/lib/libiniparser.so.0
f7006000 f700c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7015000 f70e5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70e6000 f711a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7123000 f715f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7167000 f716a000 r-xp /usr/lib/libbundle.so.0.1.22
f7172000 f7178000 r-xp /usr/lib/libappsvc.so.0.1.0
f7180000 f71c1000 r-xp /usr/lib/libeina.so.1.7.99
f71ca000 f71e1000 r-xp /usr/lib/libecore.so.1.7.99
f71f8000 f7201000 r-xp /usr/lib/libvconf.so.0.2.45
f7209000 f721d000 r-xp /lib/libpthread-2.13.so
f7228000 f7235000 r-xp /usr/lib/libaul.so.0.1.0
f723f000 f7241000 r-xp /lib/libdl-2.13.so
f724a000 f7255000 r-xp /lib/libunwind.so.8.0.1
f7282000 f728a000 r-xp /lib/libgcc_s-4.6.so.1
f728b000 f73af000 r-xp /lib/libc-2.13.so
f73bd000 f73bf000 r-xp /usr/lib/libdlog.so.0.0.0
f73c7000 f73d3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73dc000 f73e1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73e9000 f73f8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7400000 f7404000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f740d000 f7410000 r-xp /usr/lib/libappcore-agent.so.1.1
f7418000 f741a000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7422000 f7426000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f742e000 f744b000 r-xp /lib/ld-2.13.so
f7454000 f7457000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7457000 f745b000 r-xp /usr/lib/libsys-assert.so
f7bbd000 f7c2b000 rw-p [heap]
ffb90000 ffbb1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:27001)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7455228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73ec539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70f33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70f1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70fde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7103be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7103dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf713875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71331f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70f1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70fde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7103be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7103dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7135e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7136017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf713df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ad51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ac8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b9b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7048fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf704a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71daca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71d5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71d65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71d6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf740e183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf740e7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74555c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf72a285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7454f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
402,0.070000,0.070000,0.140000
06-07 18:18:58.401+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:402,0.308103,-0.081561,9.801470
06-07 18:18:58.401+0200 I/heartrate(26989): es.ugr.frailty.heartrate - capturing data
06-07 18:18:58.401+0200 I/heartrate(26989): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:18:58.401+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.401+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.411+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:411,0.315853,-0.076570,9.844072
06-07 18:18:58.411+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:411,0.007572,0.005433,0.042612
06-07 18:18:58.411+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.411+0200 I/light   (27041): es.ugr.frailty.light - capturing data
06-07 18:18:58.411+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.421+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:424,0.308739,-0.079521,9.801466
06-07 18:18:58.421+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.421+0200 I/light   (27041): es.ugr.frailty.light: SM-R760,07/06/2018,18:18:58:422,1541.000000
06-07 18:18:58.421+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:424,-0.140000,0.070000,0.070000
06-07 18:18:58.431+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:431,0.315853,-0.033500,9.877571
06-07 18:18:58.431+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.431+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.431+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.441+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:442,0.312104,-0.081643,9.801342
06-07 18:18:58.441+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.441+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:438,0.007749,0.048062,0.076101
06-07 18:18:58.441+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.441+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:441,-0.140000,0.070000,0.070000
06-07 18:18:58.451+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:449,0.366102,-0.119641,9.820145
06-07 18:18:58.451+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:453,0.057363,-0.040120,0.018679
06-07 18:18:58.451+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.451+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.461+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:462,0.070000,0.070000,0.070000
06-07 18:18:58.461+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:463,0.311573,-0.083487,9.801344
06-07 18:18:58.461+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.461+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.461+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:469,-0.003430,-0.042784,0.016409
06-07 18:18:58.461+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:470,0.308674,-0.124427,9.817751
06-07 18:18:58.471+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.471+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.481+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:481,0.070000,0.070000,0.070000
06-07 18:18:58.481+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.481+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:482,0.312488,-0.083193,9.801317
06-07 18:18:58.481+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.481+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:486,0.032993,0.002131,0.090585
06-07 18:18:58.481+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:488,0.344566,-0.081356,9.891929
06-07 18:18:58.491+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.491+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.501+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:502,0.070000,0.070000,0.070000
06-07 18:18:58.501+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:503,0.312436,-0.083467,9.801316
06-07 18:18:58.501+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.501+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.501+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:509,0.010543,-0.010127,0.081040
06-07 18:18:58.501+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:509,0.323031,-0.093320,9.882358
06-07 18:18:58.511+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.511+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.521+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:524,0.313264,-0.083076,9.801293
06-07 18:18:58.521+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.521+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.521+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:526,0.070000,0.070000,0.070000
06-07 18:18:58.531+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:532,0.342174,-0.078963,9.848858
06-07 18:18:58.531+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:531,0.029737,0.004503,0.047542
06-07 18:18:58.531+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.531+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.531+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.541+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:543,-0.026125,-0.003065,0.073886
06-07 18:18:58.541+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:543,0.070000,0.070000,0.070000
06-07 18:18:58.541+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:543,0.311439,-0.083036,9.801352
06-07 18:18:58.541+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.551+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:554,0.287139,-0.086142,9.875179
06-07 18:18:58.551+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.551+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.561+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.561+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:563,0.070000,0.070000,0.070000
06-07 18:18:58.561+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.561+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:565,0.299103,-0.117248,9.870394
06-07 18:18:58.561+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:563,-0.012337,-0.034212,0.069042
06-07 18:18:58.571+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:571,0.310327,-0.084468,9.801374
06-07 18:18:58.571+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.571+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.581+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.581+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:581,0.070000,0.070000,0.070000
06-07 18:18:58.581+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.581+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:582,0.036632,0.005505,0.064234
06-07 18:18:58.581+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:586,0.346959,-0.078963,9.865608
06-07 18:18:58.591+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:590,0.311428,-0.084030,9.801344
06-07 18:18:58.591+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.591+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.601+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.601+0200 I/heartrate(26989): es.ugr.frailty.heartrate - capturing data
06-07 18:18:58.601+0200 I/heartrate(26989): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:18:58.601+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:603,0.070000,0.070000,0.070000
06-07 18:18:58.601+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.601+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:606,0.320638,-0.076570,9.918249
06-07 18:18:58.611+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:603,0.009211,0.007460,0.116905
06-07 18:18:58.611+0200 I/light   (27041): es.ugr.frailty.light - capturing data
06-07 18:18:58.611+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.611+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.621+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.621+0200 I/light   (27041): es.ugr.frailty.light: SM-R760,07/06/2018,18:18:58:624,1545.000000
06-07 18:18:58.631+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:623,0.004625,-0.017037,0.037931
06-07 18:18:58.631+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:625,0.315853,-0.100499,9.839286
06-07 18:18:58.631+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.631+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:615,0.311228,-0.083462,9.801354
06-07 18:18:58.641+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.641+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:632,0.210000,0.070000,0.070000
06-07 18:18:58.641+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.641+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:646,0.313460,-0.117248,9.786645
06-07 18:18:58.641+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.651+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:643,0.003031,-0.033471,-0.014732
06-07 18:18:58.651+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.661+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.661+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:649,0.310429,-0.083777,9.801377
06-07 18:18:58.661+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.661+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:654,0.210000,0.070000,0.070000
06-07 18:18:58.661+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:666,0.010918,-0.006034,0.006789
06-07 18:18:58.661+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:662,0.320638,-0.090927,9.808180
06-07 18:18:58.661+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.671+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:670,0.309720,-0.084893,9.801391
06-07 18:18:58.671+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.671+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.671+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.681+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:682,0.315853,-0.088534,9.820145
06-07 18:18:58.681+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:681,0.006598,-0.003832,0.018738
06-07 18:18:58.681+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:678,0.309254,-0.084702,9.801407
06-07 18:18:58.681+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:675,0.210000,0.070000,0.070000
06-07 18:18:58.681+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.681+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.691+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:691,0.309107,-0.084706,9.801412
06-07 18:18:58.691+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:692,0.070000,0.070000,0.070000
06-07 18:18:58.691+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.691+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.701+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:702,0.339781,-0.057428,9.841680
06-07 18:18:58.701+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:703,0.030674,0.027278,0.040268
06-07 18:18:58.701+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.701+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.701+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:709,0.070000,0.070000,0.070000
06-07 18:18:58.701+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:709,0.309870,-0.083255,9.801399
06-07 18:18:58.711+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.711+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.721+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:724,0.029911,-0.029207,0.035494
06-07 18:18:58.721+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:724,0.339781,-0.112463,9.836893
06-07 18:18:58.721+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.721+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.721+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:730,0.070000,0.070000,0.070000
06-07 18:18:58.721+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:730,0.310934,-0.084431,9.801355
06-07 18:18:58.731+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.731+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.741+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:742,0.306281,-0.071785,9.887143
06-07 18:18:58.741+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:743,-0.004653,0.012646,0.085788
06-07 18:18:58.741+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.741+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.741+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:749,0.310149,-0.083618,9.801388
06-07 18:18:58.741+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:749,0.070000,0.070000,0.070000
06-07 18:18:58.751+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.751+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.761+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:763,0.327817,-0.102891,9.839286
06-07 18:18:58.761+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.761+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:763,0.017668,-0.019273,0.037898
06-07 18:18:58.761+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.771+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:771,0.310556,-0.084338,9.801369
06-07 18:18:58.771+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.771+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.781+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:782,0.299103,-0.062213,9.877571
06-07 18:18:58.781+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.781+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:784,-0.011453,0.022124,0.076202
06-07 18:18:58.791+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:774,0.070000,0.070000,0.070000
06-07 18:18:58.791+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.791+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:794,0.309494,-0.083064,9.801414
06-07 18:18:58.801+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.801+0200 I/heartrate(26989): es.ugr.frailty.heartrate - capturing data
06-07 18:18:58.801+0200 I/heartrate(26989): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:18:58.811+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:809,0.030287,0.035208,0.049838
06-07 18:18:58.811+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.851+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:849,0.339781,-0.047856,9.851252
06-07 18:18:58.851+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.861+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:859,0.303888,-0.095713,9.801002
06-07 18:18:58.861+0200 I/light   (27041): es.ugr.frailty.light - capturing data
06-07 18:18:58.861+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.871+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:872,0.318245,-0.102891,9.891929
06-07 18:18:58.881+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.891+0200 I/light   (27041): es.ugr.frailty.light: SM-R760,07/06/2018,18:18:58:880,1526.000000
06-07 18:18:58.901+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.901+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:800,0.070000,0.070000,0.070000
06-07 18:18:58.911+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.911+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.921+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:916,0.070000,0.070000,0.070000
06-07 18:18:58.931+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:909,0.310183,-0.081240,9.801407
06-07 18:18:58.931+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:886,0.311067,-0.136391,9.829715
06-07 18:18:58.931+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.931+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.931+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:921,-0.006295,-0.014472,-0.000405
06-07 18:18:58.931+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.931+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.951+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:937,0.309457,-0.081767,9.801425
06-07 18:18:58.951+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:943,0.346959,-0.100499,9.846465
06-07 18:18:58.951+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.961+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:942,0.070000,0.070000,0.070000
06-07 18:18:58.961+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.961+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:955,0.008788,-0.021125,0.090504
06-07 18:18:58.971+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.971+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:967,0.313460,-0.078963,9.868000
06-07 18:18:58.971+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:58.971+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.971+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:970,0.309916,-0.082855,9.801401
06-07 18:18:58.981+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:976,-0.070000,0.070000,0.070000
06-07 18:18:58.981+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:58.981+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:982,0.342174,-0.090927,9.824929
06-07 18:18:58.981+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:58.991+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:58.991+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:58:980,0.001151,-0.053536,0.028314
06-07 18:18:58.991+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:58:990,0.309711,-0.085186,9.801388
06-07 18:18:58.991+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.001+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:58:995,0.325424,-0.062213,9.824929
06-07 18:18:59.001+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.001+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.001+0200 I/heartrate(26989): es.ugr.frailty.heartrate - capturing data
06-07 18:18:59.001+0200 I/heartrate(26989): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:18:59.001+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:4,0.037249,-0.015313,0.045077
06-07 18:18:59.001+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:58:997,0.070000,0.070000,0.070000
06-07 18:18:59.011+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.011+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:11,0.330210,-0.078963,9.856036
06-07 18:18:59.011+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.011+0200 I/light   (27041): es.ugr.frailty.light - capturing data
06-07 18:18:59.021+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.021+0200 I/light   (27041): es.ugr.frailty.light: SM-R760,07/06/2018,18:18:59:23,1500.000000
06-07 18:18:59.021+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:8,0.311001,-0.085717,9.801343
06-07 18:18:59.021+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:21,0.002459,0.006753,0.066657
06-07 18:18:59.021+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:17,0.070000,0.070000,0.070000
06-07 18:18:59.021+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.031+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.031+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.031+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:29,0.327817,-0.110070,9.832108
06-07 18:18:59.031+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.041+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:35,0.311121,-0.085501,9.801341
06-07 18:18:59.041+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.041+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:40,-0.070000,0.070000,0.070000
06-07 18:18:59.041+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:44,0.334995,-0.066999,9.848858
06-07 18:18:59.041+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.041+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.051+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:43,0.031053,-0.005427,0.023588
06-07 18:18:59.051+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.061+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:55,0.315853,-0.064606,9.848858
06-07 18:18:59.061+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:52,0.312101,-0.085583,9.801309
06-07 18:18:59.061+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.061+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.061+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:57,0.070000,0.070000,0.070000
06-07 18:18:59.061+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.061+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:64,0.013323,0.023369,0.023621
06-07 18:18:59.071+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:69,0.312750,-0.084600,9.801296
06-07 18:18:59.071+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.071+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:69,0.306281,-0.083749,9.853643
06-07 18:18:59.071+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.081+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:84,0.366102,-0.066999,9.863215
06-07 18:18:59.091+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.091+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:74,-0.070000,0.070000,0.070000
06-07 18:18:59.091+0200 W/LOCATION(27001): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 18:18:59.101+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:96,0.346959,-0.114855,9.865608
06-07 18:18:59.101+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.101+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:110,0.301496,-0.083749,9.877571
06-07 18:18:59.101+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.111+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.111+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:114,0.313576,-0.084450,9.801271
06-07 18:18:59.111+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:80,0.017459,0.005637,0.054740
06-07 18:18:59.111+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.111+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.121+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:123,0.327817,-0.083749,9.839286
06-07 18:18:59.121+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.121+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:119,-0.070000,0.070000,0.070000
06-07 18:18:59.121+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:125,0.014241,-0.025620,0.030837
06-07 18:18:59.121+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:131,0.313574,-0.085316,9.801264
06-07 18:18:59.121+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.131+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:135,0.140000,0.070000,0.070000
06-07 18:18:59.131+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.131+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.131+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.141+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:141,0.296710,-0.083749,9.872787
06-07 18:18:59.141+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.141+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:144,0.313558,-0.084098,9.801275
06-07 18:18:59.141+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:140,0.021422,0.018317,0.047594
06-07 18:18:59.151+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.151+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.151+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:147,0.140000,0.140000,0.070000
06-07 18:18:59.151+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.161+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.161+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:162,0.320638,-0.081356,9.860823
06-07 18:18:59.161+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:161,0.312985,-0.082953,9.801303
06-07 18:18:59.161+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:156,0.002295,0.019491,0.047583
06-07 18:18:59.161+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.161+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:166,0.070000,0.140000,0.070000
06-07 18:18:59.161+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.171+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.171+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.171+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:177,-0.070000,0.070000,0.070000
06-07 18:18:59.171+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:173,0.312711,-0.083105,9.801311
06-07 18:18:59.171+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.171+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.181+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:181,0.279960,-0.086142,9.832108
06-07 18:18:59.181+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:174,-0.006704,-0.000796,0.052341
06-07 18:18:59.181+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.181+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:185,0.314158,-0.082050,9.801273
06-07 18:18:59.181+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:189,0.140000,0.070000,0.070000
06-07 18:18:59.191+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.191+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.191+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.191+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:197,0.315043,-0.083221,9.801235
06-07 18:18:59.201+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:198,0.140000,0.070000,0.070000
06-07 18:18:59.201+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.201+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:203,0.296710,-0.114855,9.851252
06-07 18:18:59.201+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.201+0200 I/heartrate(26989): es.ugr.frailty.heartrate - capturing data
06-07 18:18:59.201+0200 I/heartrate(26989): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:18:59.201+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:194,0.053391,0.016106,0.061905
06-07 18:18:59.201+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.211+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:209,0.070000,0.140000,0.070000
06-07 18:18:59.211+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:208,0.313684,-0.083029,9.801280
06-07 18:18:59.211+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.211+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.211+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:212,0.032801,-0.032806,0.064335
06-07 18:18:59.211+0200 I/light   (27041): es.ugr.frailty.light - capturing data
06-07 18:18:59.211+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.221+0200 I/light   (27041): es.ugr.frailty.light: SM-R760,07/06/2018,18:18:59:223,1485.000000
06-07 18:18:59.221+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:223,0.337388,-0.093320,9.858429
06-07 18:18:59.221+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.241+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.241+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 18:18:59.241+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 18:18:59.241+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 18:18:59.241+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:246,0.354138,-0.124427,9.810574
06-07 18:18:59.241+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:220,0.314246,-0.083166,9.801261
06-07 18:18:59.241+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.251+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:222,-0.070000,0.140000,0.140000
06-07 18:18:59.251+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:254,0.312693,-0.082983,9.801312
06-07 18:18:59.251+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.251+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.261+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:232,-0.013547,-0.000527,0.076336
06-07 18:18:59.261+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:260,0.312524,-0.082712,9.801320
06-07 18:18:59.261+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.261+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.261+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.261+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:262,0.287139,-0.076570,9.844072
06-07 18:18:59.261+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:267,0.310738,-0.082755,9.801376
06-07 18:18:59.261+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.271+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:272,0.310427,-0.084447,9.801372
06-07 18:18:59.271+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.271+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:272,0.014132,-0.000720,0.038006
06-07 18:18:59.271+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:277,0.310906,-0.084520,9.801356
06-07 18:18:59.271+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.271+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.271+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:266,0.070000,0.140000,0.140000
06-07 18:18:59.281+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:282,0.313292,-0.086495,9.801263
06-07 18:18:59.281+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.281+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:287,0.312116,-0.086135,9.801304
06-07 18:18:59.281+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.281+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:285,0.320638,-0.074178,9.824929
06-07 18:18:59.281+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.291+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.291+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:292,0.312579,-0.085692,9.801292
06-07 18:18:59.291+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:296,0.070000,0.070000,0.070000
06-07 18:18:59.291+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.291+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.301+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.301+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:303,0.070000,-0.070000,0.070000
06-07 18:18:59.301+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.301+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:303,0.313861,-0.086508,9.801245
06-07 18:18:59.301+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:309,0.337388,-0.100499,9.829715
06-07 18:18:59.301+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:310,-0.070000,-0.070000,0.070000
06-07 18:18:59.311+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.311+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:316,0.140000,0.070000,0.070000
06-07 18:18:59.311+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:298,-0.017536,-0.000583,0.071526
06-07 18:18:59.311+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.311+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.321+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:322,-0.070000,0.070000,0.070000
06-07 18:18:59.321+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.321+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:324,0.314892,-0.086317,9.801213
06-07 18:18:59.321+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.321+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:328,-0.070000,0.070000,0.070000
06-07 18:18:59.321+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.321+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.331+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:334,-0.070000,0.070000,0.070000
06-07 18:18:59.331+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.331+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.331+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:339,-0.070000,0.070000,0.070000
06-07 18:18:59.331+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.341+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:344,0.070000,0.070000,0.070000
06-07 18:18:59.341+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.341+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:330,0.346959,-0.086142,9.836893
06-07 18:18:59.341+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.341+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:349,0.070000,0.070000,0.070000
06-07 18:18:59.341+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:342,0.315123,-0.086895,9.801201
06-07 18:18:59.341+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:335,0.007945,0.001627,0.059510
06-07 18:18:59.351+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:354,0.330210,-0.102891,9.863215
06-07 18:18:59.351+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.351+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.351+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.361+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:362,0.070000,0.070000,0.070000
06-07 18:18:59.361+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:364,0.313948,-0.086550,9.801241
06-07 18:18:59.371+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:359,-0.032564,-0.003429,0.030788
06-07 18:18:59.371+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.371+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.381+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.381+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:386,0.314143,-0.087020,9.801230
06-07 18:18:59.381+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:382,0.070000,0.070000,0.070000
06-07 18:18:59.381+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.391+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:377,0.301496,-0.083749,9.863215
06-07 18:18:59.391+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:393,-0.014028,-0.032101,0.049875
06-07 18:18:59.391+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.391+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.401+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.401+0200 I/heartrate(26989): es.ugr.frailty.heartrate - capturing data
06-07 18:18:59.401+0200 I/heartrate(26989): es.ugr.frailty.heartrate: waiting for rigth values
06-07 18:18:59.401+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:406,0.314902,-0.088216,9.801196
06-07 18:18:59.401+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:404,-0.070000,0.070000,0.070000
06-07 18:18:59.411+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.411+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:400,0.327817,-0.100499,9.839286
06-07 18:18:59.411+0200 I/light   (27041): es.ugr.frailty.light - capturing data
06-07 18:18:59.411+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.421+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.421+0200 I/light   (27041): es.ugr.frailty.light: SM-R760,07/06/2018,18:18:59:423,1652.000000
06-07 18:18:59.421+0200 I/gravity (27020): es.ugr.frailty.gravity: SM-R760,07/06/2018,18:18:59:428,0.313455,-0.087943,9.801245
06-07 18:18:59.421+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.431+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:425,0.070000,0.070000,0.070000
06-07 18:18:59.431+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,18:18:59:420,0.026961,-0.008874,0.057057
06-07 18:18:59.471+0200 W/libgps_d( 3131): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
06-07 18:18:59.471+0200 W/libgps  ( 3131): [proxy__gps_stop][line = 1067]: called.
06-07 18:18:59.471+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
06-07 18:18:59.471+0200 W/libgps_d( 3131): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
06-07 18:18:59.471+0200 W/libgps_d( 3131): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
06-07 18:18:59.471+0200 W/libgps_d( 3131): GpsiHookStateGps              : EXIT
06-07 18:18:59.471+0200 W/libgps_d( 3131): GpsiHookStateIdle             : ENTRY
06-07 18:18:59.471+0200 E/CAPI_LOCATION_MANAGER( 3823): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
06-07 18:18:59.471+0200 W/gpsd    ( 3111): HandleIncomingMessage() dest id:0, msg id:2
06-07 18:18:59.481+0200 W/AUL     (27108): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
06-07 18:18:59.481+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 18:18:59.481+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 18:18:59.481+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26371
06-07 18:18:59.481+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 18:18:59.491+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26371
06-07 18:18:59.491+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26371)
06-07 18:18:59.541+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope - capturing data
06-07 18:18:59.541+0200 I/linearacceleration(27012): es.ugr.frailty.linearacceleration - capturing data
06-07 18:18:59.541+0200 I/gravity (27020): es.ugr.frailty.gravity - capturing data
06-07 18:18:59.551+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,18:18:59:441,0.327817,-0.110070,9.841680
06-07 18:18:59.551+0200 I/gyroscope(26976): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,18:18:59:551,-0.070000,0.070000,0.070000
06-07 18:18:59.561+0200 I/accelerometer(26973): es.ugr.frailty.accelerometer - capturing data
06-07 18:18:59.561+0200 W/CRASH_MANAGER(27109): worker.c: worker_job(1205) > 11270016c6f63152838833
