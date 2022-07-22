S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 8341
Date: 2018-04-23 20:27:24+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74cc52d, r5   = 0xf76c9f98
r6   = 0xffc63840, r7   = 0xffc636f0
r8   = 0xf76c6c18, r9   = 0x00000000
r10  = 0xffc637cc, fp   = 0xffc63840
ip   = 0x00000001, sp   = 0xffc636c8
lr   = 0xf74cc539, pc   = 0xf7535228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     85372 KB
Buffers:     42844 KB
Cached:     192348 KB
VmPeak:      53460 KB
VmSize:      53436 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11936 KB
VmRSS:       11936 KB
VmData:      11164 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 8341 TID = 8341
8341 8344 

Maps Information
f4397000 f4b96000 rw-p [stack:8344]
f4b9d000 f4b9f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ba7000 f4bab000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bb4000 f4bb6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bbe000 f4bc1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bd0000 f4bd5000 r-xp /usr/lib/libsystem.so.0.0.0
f4be0000 f4be3000 r-xp /lib/libattr.so.1.1.0
f4beb000 f4bfb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4c03000 f4c0c000 r-xp /usr/lib/libedbus.so.1.7.99
f4c14000 f4c15000 r-xp /usr/lib/libresponse.so.0.2.96
f4c1e000 f4c23000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64c5000 f65cb000 r-xp /usr/lib/libicuuc.so.57.1
f65e1000 f6769000 r-xp /usr/lib/libicui18n.so.57.1
f6779000 f6786000 r-xp /usr/lib/libail.so.0.1.0
f678f000 f6796000 r-xp /usr/lib/libminizip.so.1.0.0
f679f000 f6948000 r-xp /usr/lib/libcrypto.so.1.0.0
f6968000 f69af000 r-xp /usr/lib/libssl.so.1.0.0
f69bb000 f69bd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69c5000 f69cc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69d5000 f69dc000 r-xp /lib/libcrypt-2.13.so
f6a0d000 f6a10000 r-xp /lib/libcap.so.2.21
f6a18000 f6a1a000 r-xp /usr/lib/libiri.so
f6a22000 f6a6b000 r-xp /usr/lib/libmdm.so.1.2.69
f6a73000 f6a79000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a81000 f6aa4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6aae000 f6ab0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ab8000 f6ad5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ade000 f6ae2000 r-xp /usr/lib/libsmack.so.1.0.0
f6aeb000 f6b04000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b0d000 f6b15000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b1d000 f6b23000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b2c000 f6b2e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b37000 f6b47000 r-xp /lib/libresolv-2.13.so
f6b4b000 f6b63000 r-xp /usr/lib/liblzma.so.5.0.3
f6b6c000 f6b6e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b76000 f6b90000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b98000 f6bc7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bd0000 f6bdf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6be9000 f6bf3000 r-xp /usr/lib/libsensord-shared.so
f6bfc000 f6ccf000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cda000 f6cf0000 r-xp /lib/libz.so.1.2.5
f6cf8000 f6cfd000 r-xp /usr/lib/libffi.so.5.0.10
f6d05000 f6d06000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d0e000 f6d1e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d26000 f6d3f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d47000 f6d49000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d51000 f6dc6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dd0000 f6dd6000 r-xp /lib/librt-2.13.so
f6ddf000 f6dfd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e07000 f6e08000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e10000 f6e33000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e3b000 f6e40000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e48000 f6e72000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e7b000 f6e92000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e9a000 f6f03000 r-xp /lib/libm-2.13.so
f6f0c000 f6fa0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fb3000 f6fb8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fc0000 f6fc7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fcf000 f6ff9000 r-xp /usr/lib/libsensor.so.1.9.6
f7002000 f70ce000 r-xp /usr/lib/libxml2.so.2.7.8
f70db000 f70dd000 r-xp /usr/lib/libiniparser.so.0
f70e6000 f70ec000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70f5000 f71c5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71c6000 f71fa000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7203000 f723f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7247000 f724a000 r-xp /usr/lib/libbundle.so.0.1.22
f7252000 f7258000 r-xp /usr/lib/libappsvc.so.0.1.0
f7260000 f72a1000 r-xp /usr/lib/libeina.so.1.7.99
f72aa000 f72c1000 r-xp /usr/lib/libecore.so.1.7.99
f72d8000 f72e1000 r-xp /usr/lib/libvconf.so.0.2.45
f72e9000 f72fd000 r-xp /lib/libpthread-2.13.so
f7308000 f7315000 r-xp /usr/lib/libaul.so.0.1.0
f731f000 f7321000 r-xp /lib/libdl-2.13.so
f732a000 f7335000 r-xp /lib/libunwind.so.8.0.1
f7362000 f736a000 r-xp /lib/libgcc_s-4.6.so.1
f736b000 f748f000 r-xp /lib/libc-2.13.so
f749d000 f749f000 r-xp /usr/lib/libdlog.so.0.0.0
f74a7000 f74b3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74bc000 f74c1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74c9000 f74d8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74e0000 f74e4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74ed000 f74f0000 r-xp /usr/lib/libappcore-agent.so.1.1
f74f8000 f74fa000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7502000 f7506000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f750e000 f752b000 r-xp /lib/ld-2.13.so
f7534000 f7537000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7537000 f753b000 r-xp /usr/lib/libsys-assert.so
f7696000 f7704000 rw-p [heap]
ffc44000 ffc65000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8341)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7535228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74cc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71d33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71d1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71dde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71e3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71e3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf721875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72131f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71d1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71dde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71e3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71e3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7215e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7216017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf721df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4bb51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ba8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c7b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7128fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf712a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72baca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72b5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72b65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72b6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74ee183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74ee7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75354f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf738285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7534f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
1107,9.810574,0.775275
04-23 20:27:23.399+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.409+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:410,0.002445,0.041302,-0.079642
04-23 20:27:23.409+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.409+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:412,0.016750,9.786645,0.780060
04-23 20:27:23.409+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:414,-0.012187,0.017188,-0.072732
04-23 20:27:23.409+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.409+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.419+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:421,-0.070000,-0.070000,0.070000
04-23 20:27:23.419+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.419+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:421,0.028760,9.769674,0.850301
04-23 20:27:23.419+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.419+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:425,0.033015,0.026564,-0.036979
04-23 20:27:23.419+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:426,0.062213,9.796216,0.813560
04-23 20:27:23.429+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.429+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.439+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:442,-0.070000,-0.070000,0.070000
04-23 20:27:23.439+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:442,0.030498,9.769876,0.847924
04-23 20:27:23.439+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.439+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.439+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:446,0.002347,0.057648,-0.067848
04-23 20:27:23.439+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:447,0.031107,9.827322,0.782453
04-23 20:27:23.449+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.449+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.459+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:461,0.030669,9.769977,0.846758
04-23 20:27:23.459+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.459+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:461,-0.070000,0.070000,0.070000
04-23 20:27:23.459+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.459+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:467,0.026321,9.839286,0.777667
04-23 20:27:23.459+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:469,-0.004177,0.069409,-0.070257
04-23 20:27:23.469+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.469+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.479+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:482,-0.070000,0.070000,0.070000
04-23 20:27:23.479+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:481,0.030601,9.770058,0.845822
04-23 20:27:23.479+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.479+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.479+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:487,0.066999,9.824929,0.806381
04-23 20:27:23.489+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:489,0.036330,0.054953,-0.040377
04-23 20:27:23.489+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.489+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.499+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:501,-0.070000,0.070000,0.070000
04-23 20:27:23.499+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:502,0.032465,9.770257,0.843448
04-23 20:27:23.499+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.499+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.509+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:507,0.004786,9.810574,0.799203
04-23 20:27:23.509+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:509,-0.025816,0.040516,-0.046620
04-23 20:27:23.509+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.509+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.509+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.519+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:521,-0.140000,0.070000,0.070000
04-23 20:27:23.519+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:522,0.031294,9.770073,0.845629
04-23 20:27:23.519+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.519+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:23.519+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:23.529+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:521,0.038285,9.774680,0.789631
04-23 20:27:23.529+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:529,0.005820,0.004423,-0.053816
04-23 20:27:23.529+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.539+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.539+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:542,-0.070000,0.070000,0.070000
04-23 20:27:23.549+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.549+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:545,0.031776,9.770161,0.844591
04-23 20:27:23.549+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.549+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:553,0.011964,9.793823,0.808774
04-23 20:27:23.549+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.549+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.559+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:561,-0.070000,-0.070000,-0.070000
04-23 20:27:23.559+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.569+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:556,-0.019329,0.023750,-0.036855
04-23 20:27:23.569+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:569,0.057428,9.793823,0.784846
04-23 20:27:23.569+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:562,0.030691,9.770410,0.841749
04-23 20:27:23.569+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.569+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.569+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.579+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.579+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:581,-0.070000,0.070000,0.070000
04-23 20:27:23.579+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:582,0.007178,9.777073,0.803988
04-23 20:27:23.589+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:588,0.032116,9.770628,0.839160
04-23 20:27:23.589+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:578,0.025651,0.023663,-0.059745
04-23 20:27:23.589+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.589+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.599+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:602,-0.140000,0.140000,0.070000
04-23 20:27:23.599+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.599+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.609+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:610,-0.023513,0.006663,-0.037761
04-23 20:27:23.609+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:603,0.040678,9.803394,0.813560
04-23 20:27:23.609+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.609+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.619+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.619+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:622,-0.070000,0.140000,0.070000
04-23 20:27:23.619+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:609,0.031073,9.770414,0.841675
04-23 20:27:23.619+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.629+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:619,0.008562,0.032766,-0.025600
04-23 20:27:23.629+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.629+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:635,0.002427,0.064087,-0.044865
04-23 20:27:23.629+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.639+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:624,0.033500,9.834501,0.796810
04-23 20:27:23.639+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.639+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:642,-0.070000,-0.070000,0.070000
04-23 20:27:23.639+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.639+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:645,0.021535,9.801002,0.775275
04-23 20:27:23.639+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:631,0.031663,9.770371,0.842158
04-23 20:27:23.649+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.649+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:648,-0.010128,0.030630,-0.066883
04-23 20:27:23.649+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.649+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.659+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:661,-0.140000,-0.070000,-0.070000
04-23 20:27:23.659+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:661,0.040678,9.757930,0.803988
04-23 20:27:23.659+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:655,0.031902,9.770431,0.841461
04-23 20:27:23.659+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.669+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.669+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:673,0.008776,-0.012501,-0.037473
04-23 20:27:23.669+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:669,0.031263,9.770837,0.836751
04-23 20:27:23.669+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.669+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.679+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:681,0.011964,9.815358,0.772882
04-23 20:27:23.679+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.679+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.679+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:686,0.031555,9.771136,0.833235
04-23 20:27:23.679+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:686,-0.019298,0.044521,-0.063870
04-23 20:27:23.679+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:682,-0.140000,0.140000,-0.070000
04-23 20:27:23.689+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.689+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.699+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:701,0.030747,9.771041,0.834382
04-23 20:27:23.699+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:701,0.031107,9.781858,0.803988
04-23 20:27:23.699+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.699+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.709+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:707,-0.140000,0.210000,0.070000
04-23 20:27:23.709+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:706,-0.000448,0.010722,-0.029247
04-23 20:27:23.709+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.719+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:722,-0.070000,0.070000,0.070000
04-23 20:27:23.719+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.729+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:729,0.021895,0.049104,-0.035180
04-23 20:27:23.729+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:23.729+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:23.729+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.729+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.739+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.739+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:738,0.030910,9.770968,0.835227
04-23 20:27:23.749+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:743,-0.070000,0.070000,0.070000
04-23 20:27:23.749+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:748,-0.004589,0.056354,-0.021667
04-23 20:27:23.749+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.759+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.759+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.769+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:764,0.052642,9.820145,0.799203
04-23 20:27:23.769+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.779+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.779+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:761,-0.070000,0.070000,-0.070000
04-23 20:27:23.779+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:770,0.032083,9.771039,0.834362
04-23 20:27:23.779+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.789+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:777,0.026321,9.827322,0.813560
04-23 20:27:23.789+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:795,-0.140000,0.070000,0.070000
04-23 20:27:23.789+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.799+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.799+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:783,-0.029690,0.046712,-0.013624
04-23 20:27:23.799+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.799+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:800,0.031648,9.771274,0.831626
04-23 20:27:23.809+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.809+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:813,0.030411,9.771016,0.834692
04-23 20:27:23.809+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.809+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.819+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:818,0.030255,9.770818,0.837015
04-23 20:27:23.819+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.819+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:808,0.002393,9.817751,0.820738
04-23 20:27:23.819+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.819+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:811,-0.007720,-0.001379,-0.008495
04-23 20:27:23.819+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:824,0.030669,9.770893,0.836115
04-23 20:27:23.819+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.829+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:820,-0.140000,0.070000,0.070000
04-23 20:27:23.829+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:830,0.005481,0.058699,-0.054632
04-23 20:27:23.829+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.829+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.829+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:836,-0.027862,0.023005,-0.052169
04-23 20:27:23.829+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:829,0.023928,9.769895,0.823131
04-23 20:27:23.829+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.829+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.839+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:842,0.029459,9.770741,0.837929
04-23 20:27:23.839+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:842,0.035892,9.829715,0.780060
04-23 20:27:23.839+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.839+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.839+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:847,-0.013919,0.034894,-0.036913
04-23 20:27:23.839+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:848,0.002393,9.793823,0.784846
04-23 20:27:23.839+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.849+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:838,-0.140000,0.070000,0.070000
04-23 20:27:23.849+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.849+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:853,0.016750,9.805787,0.799203
04-23 20:27:23.849+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:854,-0.070000,0.070000,0.070000
04-23 20:27:23.849+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.849+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.859+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:862,0.028997,9.770629,0.839263
04-23 20:27:23.859+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:862,-0.070000,0.070000,0.070000
04-23 20:27:23.859+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.859+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.859+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:866,0.018397,-0.015203,-0.002834
04-23 20:27:23.859+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:866,0.047856,9.755538,0.835095
04-23 20:27:23.869+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.869+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.869+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.879+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:881,0.030032,9.770488,0.840860
04-23 20:27:23.879+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.889+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:886,-0.014640,0.023194,-0.030489
04-23 20:27:23.889+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:881,-0.070000,0.070000,0.070000
04-23 20:27:23.889+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:881,0.014357,9.793823,0.808774
04-23 20:27:23.889+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.889+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.889+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.899+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:901,0.029578,9.770165,0.844615
04-23 20:27:23.899+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.899+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:901,0.070000,0.070000,0.140000
04-23 20:27:23.899+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:906,-0.003711,0.035299,-0.046443
04-23 20:27:23.899+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:901,0.026321,9.805787,0.794417
04-23 20:27:23.909+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.909+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.909+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.919+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:921,0.029712,9.769985,0.846691
04-23 20:27:23.919+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.919+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:23.919+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:23.919+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:921,0.070000,0.070000,0.140000
04-23 20:27:23.919+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:926,0.008707,0.038014,-0.076519
04-23 20:27:23.929+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:922,0.038285,9.808180,0.768096
04-23 20:27:23.929+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.929+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.929+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.939+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:942,0.030266,9.770228,0.843868
04-23 20:27:23.939+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.939+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:942,0.070000,0.070000,0.070000
04-23 20:27:23.939+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:947,-0.063212,0.023838,-0.059453
04-23 20:27:23.939+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:943,-0.033500,9.793823,0.787239
04-23 20:27:23.949+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.949+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.959+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:961,-0.004786,9.803394,0.811167
04-23 20:27:23.959+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:961,0.027356,9.769781,0.849120
04-23 20:27:23.959+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.959+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:966,-0.035052,0.033166,-0.032702
04-23 20:27:23.959+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.969+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:971,0.070000,0.070000,0.070000
04-23 20:27:23.969+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.969+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.979+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.979+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:23:981,0.070000,0.070000,0.070000
04-23 20:27:23.979+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:23:983,0.025972,9.769485,0.852578
04-23 20:27:23.979+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:23.979+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:23:981,0.028714,9.779467,0.756132
04-23 20:27:23.989+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:23:991,0.001358,0.009686,-0.092988
04-23 20:27:23.989+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:23.989+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:23.999+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:1,-0.070000,0.070000,0.070000
04-23 20:27:23.999+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:23.999+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.009+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:8,-0.004437,0.024339,-0.034233
04-23 20:27:24.009+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:2,0.021535,9.793823,0.818345
04-23 20:27:24.009+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:8,0.026256,9.769709,0.849997
04-23 20:27:24.009+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.009+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.019+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:22,-0.070000,0.070000,-0.070000
04-23 20:27:24.019+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.019+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.019+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:22,0.002458,0.091114,-0.029259
04-23 20:27:24.029+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:28,0.025875,9.770020,0.846414
04-23 20:27:24.029+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:28,0.028714,9.860823,0.820738
04-23 20:27:24.039+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.039+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.039+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:44,-0.070000,0.070000,0.070000
04-23 20:27:24.049+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.059+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.059+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:44,-0.006732,-0.007304,-0.028069
04-23 20:27:24.059+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.059+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.079+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:72,0.019143,9.762716,0.818345
04-23 20:27:24.079+0200 W/LOCATION( 8341): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:27:24.079+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:74,0.028892,0.004747,-0.060180
04-23 20:27:24.079+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.089+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.089+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:63,-0.070000,0.070000,0.070000
04-23 20:27:24.089+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.089+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:95,-0.006817,0.052780,-0.093315
04-23 20:27:24.089+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:90,0.055035,9.774680,0.787239
04-23 20:27:24.089+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.099+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:53,0.026143,9.769933,0.847419
04-23 20:27:24.099+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.099+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:102,0.019143,9.822537,0.756132
04-23 20:27:24.099+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.099+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:105,0.025959,9.769757,0.849447
04-23 20:27:24.099+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.109+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.109+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:109,0.007178,9.817751,0.799203
04-23 20:27:24.109+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:113,-0.020321,0.047714,-0.046968
04-23 20:27:24.109+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:98,-0.070000,0.070000,0.070000
04-23 20:27:24.109+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.109+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.119+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.119+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:122,0.023928,9.796216,0.815953
04-23 20:27:24.119+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:24.119+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:24.129+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:121,-0.003313,0.026083,-0.029118
04-23 20:27:24.129+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:127,-0.070000,0.070000,0.070000
04-23 20:27:24.129+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.129+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:110,0.027500,9.770037,0.846170
04-23 20:27:24.129+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.139+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.139+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:143,-0.009571,9.786645,0.832702
04-23 20:27:24.139+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.139+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:148,0.027241,9.770133,0.845071
04-23 20:27:24.139+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.149+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:143,-0.035697,0.016255,-0.009432
04-23 20:27:24.149+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:138,-0.070000,0.070000,-0.070000
04-23 20:27:24.149+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.149+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.159+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:161,-0.009571,9.786645,0.825524
04-23 20:27:24.159+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.159+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:166,-0.035422,0.015996,-0.013604
04-23 20:27:24.169+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:152,0.026126,9.770390,0.842134
04-23 20:27:24.169+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.169+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:175,0.025851,9.770649,0.839128
04-23 20:27:24.169+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:156,-0.070000,0.210000,-0.070000
04-23 20:27:24.169+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.179+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.179+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:182,0.011964,9.803394,0.842274
04-23 20:27:24.179+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.179+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:187,-0.070000,0.210000,0.070000
04-23 20:27:24.179+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.179+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:183,-0.012353,0.033194,-0.002105
04-23 20:27:24.189+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.189+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:194,0.024317,9.770201,0.844378
04-23 20:27:24.189+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.189+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.189+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.199+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:202,0.013042,0.021697,-0.041038
04-23 20:27:24.199+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:202,0.035892,9.791430,0.808774
04-23 20:27:24.199+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:191,-0.070000,0.210000,0.070000
04-23 20:27:24.199+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.209+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:210,-0.070000,0.070000,0.070000
04-23 20:27:24.209+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:198,0.022850,9.769733,0.849812
04-23 20:27:24.209+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.209+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.209+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.219+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.219+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:223,-0.044018,0.014839,-0.039930
04-23 20:27:24.219+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:222,-0.021535,9.784252,0.813560
04-23 20:27:24.229+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:218,0.022482,9.769413,0.853490
04-23 20:27:24.229+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.229+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:228,-0.070000,0.070000,0.070000
04-23 20:27:24.229+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:235,0.023264,9.769453,0.853009
04-23 20:27:24.239+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.239+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.239+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:244,0.017414,0.029156,-0.058592
04-23 20:27:24.239+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:243,0.040678,9.798609,0.794417
04-23 20:27:24.239+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.249+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:248,-0.070000,0.070000,0.070000
04-23 20:27:24.249+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.249+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:254,0.021283,9.768900,0.859379
04-23 20:27:24.249+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.249+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.259+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.259+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:262,-0.004533,0.034494,-0.000355
04-23 20:27:24.259+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:265,-0.070000,0.070000,0.070000
04-23 20:27:24.259+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:261,0.016750,9.803394,0.859023
04-23 20:27:24.259+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.269+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:270,0.022354,9.769130,0.856736
04-23 20:27:24.279+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.279+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:27:24.279+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:27:24.279+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:27:24.279+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:287,0.014357,9.791430,0.780060
04-23 20:27:24.279+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.289+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.289+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.289+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:293,0.021927,9.769308,0.854702
04-23 20:27:24.289+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:292,-0.007997,0.022301,-0.076676
04-23 20:27:24.289+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.289+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.299+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:301,0.004786,9.796216,0.789631
04-23 20:27:24.299+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:297,-0.070000,0.140000,-0.070000
04-23 20:27:24.299+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.299+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:303,-0.017141,0.026908,-0.065071
04-23 20:27:24.309+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.309+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:311,-0.070000,0.070000,-0.070000
04-23 20:27:24.309+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:313,0.021406,9.769803,0.849038
04-23 20:27:24.309+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.309+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.319+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.319+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:322,-0.057299,0.028806,-0.033086
04-23 20:27:24.319+0200 I/heartrate( 8278): capturing data from es.ugr.frailty.heartrate
04-23 20:27:24.319+0200 I/heartrate( 8278): es.ugr.frailty.heartrate: waiting for rigth values
04-23 20:27:24.319+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:325,-0.035892,9.798609,0.815953
04-23 20:27:24.319+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:322,-0.070000,0.070000,-0.070000
04-23 20:27:24.329+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.329+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:333,0.020453,9.770151,0.845047
04-23 20:27:24.339+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.339+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.339+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.339+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:346,0.017619,9.770061,0.846165
04-23 20:27:24.349+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:350,-0.019143,9.769895,0.794417
04-23 20:27:24.349+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.349+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:345,-0.039596,-0.000257,-0.050630
04-23 20:27:24.359+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.359+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:363,0.015881,0.050084,-0.032605
04-23 20:27:24.359+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.369+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.369+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:368,0.033500,9.820145,0.813560
04-23 20:27:24.369+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:374,0.015698,9.770125,0.845453
04-23 20:27:24.369+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.379+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:355,-0.070000,0.140000,-0.070000
04-23 20:27:24.379+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.379+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:382,0.024980,0.052412,-0.029500
04-23 20:27:24.379+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.379+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:386,-0.140000,0.140000,-0.070000
04-23 20:27:24.379+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.389+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.389+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:392,-0.070000,0.140000,-0.070000
04-23 20:27:24.389+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:387,0.040678,9.822537,0.815953
04-23 20:27:24.389+0200 I/linearacceleration( 8294): capturing data from es.ugr.frailty.linearacceleration
04-23 20:27:24.399+0200 I/accelerometer( 8253): capturing data from es.ugr.frailty.accelerometer
04-23 20:27:24.409+0200 I/linearacceleration( 8294): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,20:27:24:402,-0.006804,0.032674,-0.075226
04-23 20:27:24.409+0200 I/accelerometer( 8253): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,20:27:24:411,0.009571,9.803394,0.763310
04-23 20:27:24.409+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.409+0200 I/gyroscope( 8256): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,20:27:24:417,-0.070000,0.070000,-0.070000
04-23 20:27:24.429+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:27:24.429+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:27:24.429+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:27:24.429+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:27:24.429+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:27:24.429+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:27:24.429+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:27:24.429+0200 E/CAPI_LOCATION_MANAGER( 8322): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:27:24.429+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:27:24.439+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:395,0.016375,9.770720,0.838536
04-23 20:27:24.439+0200 I/gravity ( 8302): capturing data from es.ugr.frailty.gravity
04-23 20:27:24.439+0200 I/gravity ( 8302): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:27:24:446,0.017367,9.771278,0.831982
04-23 20:27:24.439+0200 I/gyroscope( 8256): capturing data from es.ugr.frailty.gyroscope
04-23 20:27:24.479+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:27:24.479+0200 W/CRASH_MANAGER( 8352): worker.c: worker_job(1205) > 11083416c6f63152450804
