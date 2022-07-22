S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 3945
Date: 2018-04-23 18:54:47+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf76b652d, r5   = 0xf7def958
r6   = 0xffa33850, r7   = 0xffa33700
r8   = 0xf7e02c18, r9   = 0x00000000
r10  = 0xffa337dc, fp   = 0xffa33850
ip   = 0x00000001, sp   = 0xffa336d8
lr   = 0xf76b6539, pc   = 0xf771f228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     74176 KB
Buffers:     31840 KB
Cached:     219872 KB
VmPeak:      53444 KB
VmSize:      53440 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11712 KB
VmRSS:       11712 KB
VmData:      11168 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3945 TID = 3945
3945 3962 

Maps Information
f4581000 f4d80000 rw-p [stack:3962]
f4d87000 f4d89000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d91000 f4d95000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d9e000 f4da0000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4da8000 f4dab000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4dba000 f4dbf000 r-xp /usr/lib/libsystem.so.0.0.0
f4dca000 f4dcd000 r-xp /lib/libattr.so.1.1.0
f4dd5000 f4de5000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4ded000 f4df6000 r-xp /usr/lib/libedbus.so.1.7.99
f4dfe000 f4dff000 r-xp /usr/lib/libresponse.so.0.2.96
f4e08000 f4e0d000 r-xp /usr/lib/libproc-stat.so.0.2.96
f66af000 f67b5000 r-xp /usr/lib/libicuuc.so.57.1
f67cb000 f6953000 r-xp /usr/lib/libicui18n.so.57.1
f6963000 f6970000 r-xp /usr/lib/libail.so.0.1.0
f6979000 f6980000 r-xp /usr/lib/libminizip.so.1.0.0
f6989000 f6b32000 r-xp /usr/lib/libcrypto.so.1.0.0
f6b52000 f6b99000 r-xp /usr/lib/libssl.so.1.0.0
f6ba5000 f6ba7000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6baf000 f6bb6000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6bbf000 f6bc6000 r-xp /lib/libcrypt-2.13.so
f6bf7000 f6bfa000 r-xp /lib/libcap.so.2.21
f6c02000 f6c04000 r-xp /usr/lib/libiri.so
f6c0c000 f6c55000 r-xp /usr/lib/libmdm.so.1.2.69
f6c5d000 f6c63000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c6b000 f6c8e000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c98000 f6c9a000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ca2000 f6cbf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cc8000 f6ccc000 r-xp /usr/lib/libsmack.so.1.0.0
f6cd5000 f6cee000 r-xp /usr/lib/libnetwork.so.0.0.0
f6cf7000 f6cff000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6d07000 f6d0d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6d16000 f6d18000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d21000 f6d31000 r-xp /lib/libresolv-2.13.so
f6d35000 f6d4d000 r-xp /usr/lib/liblzma.so.5.0.3
f6d56000 f6d58000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d60000 f6d7a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d82000 f6db1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6dba000 f6dc9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6dd3000 f6ddd000 r-xp /usr/lib/libsensord-shared.so
f6de6000 f6eb9000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ec4000 f6eda000 r-xp /lib/libz.so.1.2.5
f6ee2000 f6ee7000 r-xp /usr/lib/libffi.so.5.0.10
f6eef000 f6ef0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ef8000 f6f08000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6f10000 f6f29000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6f31000 f6f33000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6f3b000 f6fb0000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fba000 f6fc0000 r-xp /lib/librt-2.13.so
f6fc9000 f6fe7000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ff1000 f6ff2000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ffa000 f701d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7025000 f702a000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7032000 f705c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7065000 f707c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7084000 f70ed000 r-xp /lib/libm-2.13.so
f70f6000 f718a000 r-xp /usr/lib/libstdc++.so.6.0.16
f719d000 f71a2000 r-xp /usr/lib/libctx-client.so.0.8.3
f71aa000 f71b1000 r-xp /usr/lib/libctx-shared.so.0.8.3
f71b9000 f71e3000 r-xp /usr/lib/libsensor.so.1.9.6
f71ec000 f72b8000 r-xp /usr/lib/libxml2.so.2.7.8
f72c5000 f72c7000 r-xp /usr/lib/libiniparser.so.0
f72d0000 f72d6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f72df000 f73af000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f73b0000 f73e4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f73ed000 f7429000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7431000 f7434000 r-xp /usr/lib/libbundle.so.0.1.22
f743c000 f7442000 r-xp /usr/lib/libappsvc.so.0.1.0
f744a000 f748b000 r-xp /usr/lib/libeina.so.1.7.99
f7494000 f74ab000 r-xp /usr/lib/libecore.so.1.7.99
f74c2000 f74cb000 r-xp /usr/lib/libvconf.so.0.2.45
f74d3000 f74e7000 r-xp /lib/libpthread-2.13.so
f74f2000 f74ff000 r-xp /usr/lib/libaul.so.0.1.0
f7509000 f750b000 r-xp /lib/libdl-2.13.so
f7514000 f751f000 r-xp /lib/libunwind.so.8.0.1
f754c000 f7554000 r-xp /lib/libgcc_s-4.6.so.1
f7555000 f7679000 r-xp /lib/libc-2.13.so
f7687000 f7689000 r-xp /usr/lib/libdlog.so.0.0.0
f7691000 f769d000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76a6000 f76ab000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76b3000 f76c2000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f76ca000 f76ce000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f76d7000 f76da000 r-xp /usr/lib/libappcore-agent.so.1.1
f76e2000 f76e4000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f76ec000 f76f0000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76f8000 f7715000 r-xp /lib/ld-2.13.so
f771e000 f7721000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7721000 f7725000 r-xp /usr/lib/libsys-assert.so
f7dd2000 f7e41000 rw-p [heap]
ffa14000 ffa35000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3945)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf771f228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf76b6539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73bd3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf73bbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf73c7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf73cdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf73cddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf740275b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73fd1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf73bbc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf73c7e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf73cdbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf73cddc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73ffe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7400017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7407f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4d9f1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4d92171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e65663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7312fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf73147a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf74a4ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf749fb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf74a05a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf74a0879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf76d8183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76d87fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf771f4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf756c85c) [/lib/libc.so.6] + 0x1785c
29: (0xf771ef2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:566,22.820000,25.200001,-44.170002
04-23 18:54:46.569+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.569+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:568,-2.122421,2.816251,-0.397024
04-23 18:54:46.569+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:573,6.116055,1.237089,4.682754
04-23 18:54:46.579+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.579+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.579+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:586,17.850000,25.340000,-35.000000
04-23 18:54:46.589+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:589,-2.037647,2.124372,-0.162303
04-23 18:54:46.589+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.599+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:597,6.214160,0.698704,4.941179
04-23 18:54:46.599+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.599+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.609+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:607,6.439085,1.194018,4.917251
04-23 18:54:46.619+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.629+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:627,6.910471,1.560120,4.627719
04-23 18:54:46.639+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.659+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:607,-1.818762,2.509180,-0.206096
04-23 18:54:46.669+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.669+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.679+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:673,-1.359778,2.759728,-0.503977
04-23 18:54:46.679+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.679+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:676,18.480000,21.770000,-28.630001
04-23 18:54:46.679+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:684,-0.792799,1.963253,0.127775
04-23 18:54:46.679+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.679+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.689+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:652,7.499106,0.866202,5.247460
04-23 18:54:46.689+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.689+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:692,-0.821371,1.360203,0.984145
04-23 18:54:46.689+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.689+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:697,7.515855,0.368495,6.051448
04-23 18:54:46.689+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.699+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:698,-0.302923,1.738873,0.689544
04-23 18:54:46.709+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:702,8.066205,0.825524,5.718846
04-23 18:54:46.709+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.709+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.709+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:706,0.120274,2.279751,0.689986
04-23 18:54:46.709+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:715,8.539984,1.497907,5.656632
04-23 18:54:46.739+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:46.739+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.739+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.739+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:745,0.078133,2.762381,0.528347
04-23 18:54:46.739+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:54:46:743,83
04-23 18:54:46.749+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.749+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:691,2.660000,17.430000,-22.190001
04-23 18:54:46.759+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:756,-0.275970,2.031714,0.507624
04-23 18:54:46.759+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.759+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:749,8.566305,2.163112,5.402994
04-23 18:54:46.759+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.759+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.759+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:767,0.035923,1.759004,0.438818
04-23 18:54:46.769+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:770,8.286345,1.627119,5.271388
04-23 18:54:46.769+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.769+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:770,-7.840000,13.860000,-18.129999
04-23 18:54:46.769+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:777,8.664411,1.497907,5.091926
04-23 18:54:46.769+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.779+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.779+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:783,-2.940000,13.090000,-17.219999
04-23 18:54:46.779+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.779+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:786,0.297378,1.695089,0.725552
04-23 18:54:46.779+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.779+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:789,16.450001,9.520000,-16.450001
04-23 18:54:46.789+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:791,8.994620,1.569692,5.254639
04-23 18:54:46.789+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.789+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:796,29.049999,3.080000,-16.030001
04-23 18:54:46.789+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.799+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.799+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.799+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:806,0.323609,1.605663,1.637455
04-23 18:54:46.799+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:806,9.087940,1.615155,6.037091
04-23 18:54:46.809+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:802,16.520000,2.240000,-13.930000
04-23 18:54:46.809+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.809+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:814,-2.100000,0.980000,-10.430000
04-23 18:54:46.809+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.819+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:819,1.050000,-0.070000,-8.400000
04-23 18:54:46.819+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.819+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.819+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.819+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:826,8.566305,1.916651,6.357729
04-23 18:54:46.829+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:826,-0.227472,1.833459,2.018036
04-23 18:54:46.829+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:824,9.520000,0.070000,-5.950000
04-23 18:54:46.829+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.839+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:840,12.250000,2.940000,-4.830000
04-23 18:54:46.839+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.839+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:845,4.270000,4.480000,-3.290000
04-23 18:54:46.839+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.839+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.849+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:851,-0.374939,1.257135,1.365668
04-23 18:54:46.849+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:851,8.441878,1.404587,5.656632
04-23 18:54:46.849+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.859+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:860,-14.280000,-3.640000,-1.330000
04-23 18:54:46.859+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.859+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.859+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:866,-0.003356,0.749806,0.960773
04-23 18:54:46.859+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.869+0200 E/CAPI_TELEPHONY( 3701): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:54:46.869+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:872,-13.930000,-5.250000,-1.610000
04-23 18:54:46.869+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:866,8.865408,0.976272,5.139783
04-23 18:54:46.879+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.879+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.879+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:885,-10.080000,-1.190000,-2.520000
04-23 18:54:46.879+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:885,-0.299058,0.741879,0.974208
04-23 18:54:46.879+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.879+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:889,8.626125,1.031307,5.027320
04-23 18:54:46.899+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.899+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.899+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:908,-0.773709,0.593490,1.225612
04-23 18:54:46.899+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:908,8.202596,0.947558,5.158926
04-23 18:54:46.899+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.909+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:912,-10.360000,0.490000,-1.680000
04-23 18:54:46.919+0200 I/DOWNLOAD_PROVIDER( 3003): download-provider-client-manager.c: dp_client_manager(738) > client-manager's working is done
04-23 18:54:46.919+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.919+0200 W/WIFI_DIRECT( 3003): wifi-direct-client-proxy.c: __wfd_client_write_socket(589) > Write [32] bytes to socket [8].
04-23 18:54:46.929+0200 W/WIFI_DIRECT_MANAGER( 3066): wifi-direct-client.c: _wfd_client_check_socket(310) > POLLIN from socket [13]
04-23 18:54:46.929+0200 W/WIFI_DIRECT_MANAGER( 3066): wifi-direct-client.c: wfd_client_process_request(930) > Client request [3:WIFI_DIRECT_CMD_DEREGISTER], 32 bytes read from socket[13]
04-23 18:54:46.929+0200 W/WIFI_DIRECT( 3003): wifi-direct-client-proxy.c: __wfd_client_send_request(667) > Succeeded to send request [3: WIFI_DIRECT_CMD_DEREGISTER]
04-23 18:54:46.929+0200 W/WIFI_DIRECT_MANAGER( 3066): wifi-direct-client.c: _wfd_check_client_privilege(886) > Security Server: API Access Validation Success
04-23 18:54:46.929+0200 W/WIFI_DIRECT_MANAGER( 3066): wifi-direct-client.c: _wfd_client_check_socket(313) > POLLOUT from socket [13]
04-23 18:54:46.929+0200 W/WIFI_DIRECT_MANAGER( 3066): wifi-direct-client.c: _wfd_send_to_client(355) > Succeeded to write data[116 bytes] into socket [13]
04-23 18:54:46.929+0200 W/WIFI_DIRECT_MANAGER( 3066): wifi-direct-client.c: _wfd_client_find_by_id(272) > Client found. [13]
04-23 18:54:46.929+0200 W/WIFI_DIRECT_MANAGER( 3066): wifi-direct-client.c: _wfd_deregister_client(586) > Client [13] is removed. 0 client left
04-23 18:54:46.929+0200 W/WIFI_DIRECT_MANAGER( 3066): wifi-direct-client.c: _wfd_remove_event_source(561) > Succeeded to remove GSource
04-23 18:54:46.929+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:46.929+0200 E/WIFI_DIRECT( 3003): wifi-direct-client-proxy.c: __wfd_client_check_socket(563) > Error! POLLHUP from socket[8]
04-23 18:54:46.929+0200 E/WIFI_DIRECT( 3003): wifi-direct-client-proxy.c: __wfd_client_read_socket(623) > Socket error
04-23 18:54:46.929+0200 E/WIFI_DIRECT( 3003): wifi-direct-client-proxy.c: __wfd_client_send_request(672) > Failed to read socket [-29753342]
04-23 18:54:46.929+0200 W/WIFI_DIRECT( 3003): wifi-direct-client-proxy.c: wifi_direct_deinitialize(1144) > Failed to deinitialize. But continue deinitialization
04-23 18:54:46.929+0200 I/CAPI_NETWORK_CONNECTION( 3003): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 18:54:46.929+0200 I/CAPI_NETWORK_CONNECTION( 3003): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 18:54:46.929+0200 I/CAPI_NETWORK_CONNECTION( 3003): connection.c: connection_destroy(471) > Destroy handle: 0xf79cb928
04-23 18:54:46.929+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:929,-0.784639,0.535953,1.004923
04-23 18:54:46.929+0200 I/DOWNLOAD_PROVIDER( 3003): download-provider-main.c: main(64) > download-provider's working is done
04-23 18:54:46.939+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.939+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.959+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:945,-9.030000,0.700000,-0.560000
04-23 18:54:46.959+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:945,8.233703,0.940379,4.835894
04-23 18:54:46.959+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.959+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.969+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:54:46:933,83
04-23 18:54:46.969+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.979+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:970,7.953743,0.949951,5.099105
04-23 18:54:46.979+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:977,-1.108501,0.496515,1.378818
04-23 18:54:46.989+0200 E/RESOURCED( 2577): file-helper.c: fread_uint(105) > Fail to open /sys/fs/cgroup/memory/system.slice/download-provider.service/memory.memsw.usage_in_bytes file.
04-23 18:54:46.989+0200 E/RESOURCED( 2577): file-helper.c: fread_uint(105) > errno -2, errmsg No such file or directory
04-23 18:54:46.989+0200 E/RESOURCED( 2577): file-helper.c: fread_uint(105) > Fail to open /sys/fs/cgroup/memory/system.slice/download-provider.service/memory.usage_in_bytes file.
04-23 18:54:46.989+0200 E/RESOURCED( 2577): file-helper.c: fread_uint(105) > errno -2, errmsg No such file or directory
04-23 18:54:46.989+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:968,-11.060000,5.250000,1.400000
04-23 18:54:46.989+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:46.989+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.989+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.989+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:46:997,-1.217448,0.109002,1.561102
04-23 18:54:46.999+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.999+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:46:995,-8.610000,2.520000,1.890000
04-23 18:54:46.999+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:3,-0.836723,0.432987,1.969931
04-23 18:54:46.999+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:46.999+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:46:996,7.877172,0.595813,5.197211
04-23 18:54:46.999+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:46.999+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.009+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:9,-0.878723,0.504712,1.965943
04-23 18:54:47.009+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:9,-2.520000,3.990000,3.010000
04-23 18:54:47.009+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.009+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:10,8.286345,0.933201,5.532206
04-23 18:54:47.009+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.019+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.019+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:20,-7.280000,4.830000,4.200000
04-23 18:54:47.019+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.019+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:26,-0.859818,0.261575,2.161961
04-23 18:54:47.029+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:22,8.274381,1.033699,5.446064
04-23 18:54:47.029+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.029+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:31,-6.440000,3.780000,5.600000
04-23 18:54:47.029+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:36,8.322237,0.815953,5.560920
04-23 18:54:47.039+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.039+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.049+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:51,-1.890000,4.970000,6.930000
04-23 18:54:47.049+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:51,-0.956840,0.390671,2.292379
04-23 18:54:47.049+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.049+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:56,8.250452,0.954736,5.620740
04-23 18:54:47.059+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.059+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.059+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:66,-0.826528,0.203301,2.095253
04-23 18:54:47.059+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.059+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:66,8.405986,0.782453,5.350351
04-23 18:54:47.069+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:71,3.080000,3.430000,7.630000
04-23 18:54:47.079+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.079+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.079+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:86,-1.005842,0.006124,2.320557
04-23 18:54:47.079+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:86,8.255238,0.595813,5.491528
04-23 18:54:47.079+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.089+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:91,8.190000,5.180000,7.350000
04-23 18:54:47.099+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.109+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:111,-1.287778,0.049771,2.428703
04-23 18:54:47.109+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.119+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.119+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.129+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:47.129+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:54:47:133,83
04-23 18:54:47.149+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:118,7.996813,0.641276,5.529813
04-23 18:54:47.149+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.149+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 18:54:47.149+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 18:54:47.149+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 18:54:47.149+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:124,14.490000,5.460000,7.140000
04-23 18:54:47.149+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.149+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:126,-1.130174,0.173806,2.515729
04-23 18:54:47.159+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.169+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:157,8.178668,0.772882,5.541777
04-23 18:54:47.179+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:159,14.490000,1.960000,6.440000
04-23 18:54:47.179+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.179+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:168,-0.928216,0.344883,2.462564
04-23 18:54:47.179+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.189+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.189+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:189,8.410772,0.959522,5.391029
04-23 18:54:47.199+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:187,5.530000,-0.700000,6.160000
04-23 18:54:47.199+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.199+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:194,-1.122591,0.156360,2.608702
04-23 18:54:47.199+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.199+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.209+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:210,-1.219443,0.141071,2.621128
04-23 18:54:47.209+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:209,4.340000,-1.820000,5.810000
04-23 18:54:47.219+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:207,8.250452,0.789631,5.422136
04-23 18:54:47.219+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.219+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.219+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.219+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:228,8.183454,0.782453,5.331209
04-23 18:54:47.229+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:227,12.880000,-2.310000,5.110000
04-23 18:54:47.229+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:226,-1.136125,0.201399,2.580110
04-23 18:54:47.229+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.239+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.239+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.249+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:245,-1.273041,0.426821,2.658151
04-23 18:54:47.249+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.249+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:242,8.300702,0.856631,5.166104
04-23 18:54:47.249+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.249+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:254,-1.551325,0.198285,3.147810
04-23 18:54:47.249+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:244,22.049999,-2.800000,4.200000
04-23 18:54:47.249+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.259+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:258,8.204988,1.105484,5.082355
04-23 18:54:47.259+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.259+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:259,22.190001,-1.260000,3.570000
04-23 18:54:47.259+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.259+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:264,7.970492,0.909273,5.383851
04-23 18:54:47.259+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.259+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:267,-1.561378,0.076633,3.501402
04-23 18:54:47.259+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.269+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:269,7.992027,0.799203,5.594419
04-23 18:54:47.269+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:273,14.770000,-1.820000,4.550000
04-23 18:54:47.269+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.269+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:278,15.470000,-3.290000,4.970000
04-23 18:54:47.279+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.279+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.279+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.279+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:286,-1.500619,0.226833,3.513916
04-23 18:54:47.289+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:286,8.080563,0.952343,5.474778
04-23 18:54:47.289+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:286,17.710001,-5.600000,5.390000
04-23 18:54:47.299+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.299+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.299+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:307,-1.555820,0.300085,3.408749
04-23 18:54:47.299+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:306,17.290001,-7.210000,5.810000
04-23 18:54:47.299+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.309+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:311,8.056634,1.033699,5.206782
04-23 18:54:47.319+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.319+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.329+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:47.329+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:327,15.890000,-8.610000,6.510000
04-23 18:54:47.329+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:54:47:334,83
04-23 18:54:47.329+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.329+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:328,-1.716210,0.275100,3.367876
04-23 18:54:47.339+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:341,7.927422,1.016950,4.986642
04-23 18:54:47.339+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.339+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.349+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.349+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:351,8.013563,0.959522,5.039285
04-23 18:54:47.359+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.359+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:358,-1.657410,0.214611,3.594373
04-23 18:54:47.359+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:351,15.960000,-9.170000,7.630000
04-23 18:54:47.369+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.369+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.369+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:367,8.219346,0.983450,4.819145
04-23 18:54:47.369+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:373,-1.473338,0.243544,3.525004
04-23 18:54:47.379+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.379+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.389+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:387,-1.365656,0.620889,3.568012
04-23 18:54:47.389+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:374,18.690001,-11.550000,7.630000
04-23 18:54:47.389+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.389+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:387,8.346166,1.354338,4.713861
04-23 18:54:47.399+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:395,17.010000,-12.950000,7.280000
04-23 18:54:47.399+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.399+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.409+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:407,2.520000,-13.020000,6.860000
04-23 18:54:47.409+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:407,-1.480512,0.532098,3.805517
04-23 18:54:47.409+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.409+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:413,8.243275,1.268196,4.843073
04-23 18:54:47.419+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.419+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.419+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:426,2.254841,0.397721,-2.733301
04-23 18:54:47.419+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.429+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:426,2.100000,-15.400000,6.090000
04-23 18:54:47.429+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:432,8.197811,0.861416,5.053641
04-23 18:54:47.439+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.439+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.449+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:451,12.600000,-18.200001,4.620000
04-23 18:54:47.449+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:452,2.214725,0.316899,-2.668432
04-23 18:54:47.449+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.459+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:459,8.338986,0.813560,4.974678
04-23 18:54:47.459+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.459+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.459+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:467,21.629999,-19.250000,3.080000
04-23 18:54:47.469+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.469+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:467,2.116516,0.276049,-2.696131
04-23 18:54:47.469+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:473,8.475377,0.818345,4.749753
04-23 18:54:47.479+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.479+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.479+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.499+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:490,21.700001,-17.430000,2.450000
04-23 18:54:47.499+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.519+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:512,9.240000,-18.340000,4.340000
04-23 18:54:47.519+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.529+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:527,1.470000,-19.460001,5.180000
04-23 18:54:47.529+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:47.529+0200 W/LOCATION( 3945): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 18:54:47.529+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:54:47:533,83
04-23 18:54:47.539+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:491,1.712276,0.479531,-2.484079
04-23 18:54:47.539+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.539+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:490,8.353344,1.079163,4.706682
04-23 18:54:47.549+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.549+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:551,13.440001,-17.080000,5.320000
04-23 18:54:47.549+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:554,8.350951,1.186840,4.407579
04-23 18:54:47.549+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.559+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.559+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.559+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:560,8.575876,0.902094,4.543970
04-23 18:54:47.559+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.569+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:564,1.426229,0.521498,-2.504435
04-23 18:54:47.569+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:569,8.678767,0.569492,4.953143
04-23 18:54:47.569+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.569+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.569+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:577,1.423793,0.188714,-2.127550
04-23 18:54:47.569+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.579+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:567,32.759998,-14.420000,4.620000
04-23 18:54:47.579+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:578,8.468199,0.387637,5.111069
04-23 18:54:47.579+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.579+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.579+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:586,36.610001,-16.590000,5.670000
04-23 18:54:47.589+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:587,8.645268,1.287339,4.565506
04-23 18:54:47.589+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:582,1.377038,-0.158274,-1.552661
04-23 18:54:47.599+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.599+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.599+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.599+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:606,16.520000,-17.219999,8.470000
04-23 18:54:47.609+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:607,9.030513,1.529014,4.292724
04-23 18:54:47.609+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:603,1.021603,-0.345307,-1.227809
04-23 18:54:47.609+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.619+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:618,1.016589,0.539706,-1.551249
04-23 18:54:47.619+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.619+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.619+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.619+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:627,16.520000,-13.440001,9.730000
04-23 18:54:47.629+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:628,8.922836,0.935594,4.491328
04-23 18:54:47.629+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:625,1.165851,0.722520,-1.509607
04-23 18:54:47.629+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.639+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:640,0.887436,0.088722,-1.066147
04-23 18:54:47.639+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.639+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.649+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:651,12.250000,-10.990000,9.450000
04-23 18:54:47.649+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:652,8.726624,0.277567,4.783253
04-23 18:54:47.649+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.659+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:658,0.570477,-0.573560,-0.594779
04-23 18:54:47.659+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.659+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.659+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:666,42.490002,-13.230000,8.680000
04-23 18:54:47.659+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:667,8.968300,0.267996,4.445865
04-23 18:54:47.659+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.669+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:672,0.735836,-0.550643,-0.819756
04-23 18:54:47.679+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.679+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.679+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:686,59.220001,-9.940000,8.330000
04-23 18:54:47.679+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:687,9.298509,1.043271,4.003192
04-23 18:54:47.679+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.689+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:692,0.928132,0.233720,-1.041786
04-23 18:54:47.699+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.699+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.699+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:706,53.060001,-3.570000,8.680000
04-23 18:54:47.699+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:707,9.279366,1.153341,3.862016
04-23 18:54:47.699+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.709+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:712,0.751575,0.305884,-0.905475
04-23 18:54:47.719+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.719+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.719+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:726,60.410000,-1.190000,8.470000
04-23 18:54:47.719+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:726,9.135797,0.813560,4.098906
04-23 18:54:47.719+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.729+0200 I/heartrate( 3654): capturing data from es.ugr.frailty.heartrate
04-23 18:54:47.729+0200 I/heartrate( 3654): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:54:47:733,83
04-23 18:54:47.729+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:731,0.495864,-0.067870,-0.455766
04-23 18:54:47.739+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.739+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.749+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:751,82.809998,-1.260000,7.910000
04-23 18:54:47.749+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:751,9.020942,0.710668,3.988836
04-23 18:54:47.749+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.749+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:757,0.294106,-0.189260,-0.393269
04-23 18:54:47.759+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.759+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.759+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:766,90.650002,0.280000,7.280000
04-23 18:54:47.759+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:767,9.138189,1.497907,3.601198
04-23 18:54:47.759+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.769+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:771,0.325968,0.572274,-0.600985
04-23 18:54:47.779+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.779+0200 I/accelerometer( 3903): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:54:47:786,9.061620,2.129612,3.407379
04-23 18:54:47.779+0200 I/linearacceleration( 3946): capturing data from es.ugr.frailty.linearacceleration
04-23 18:54:47.779+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.789+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:792,62.790001,4.690000,8.540000
04-23 18:54:47.789+0200 I/linearacceleration( 3946): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,18:54:47:791,0.180926,1.136106,-0.632004
04-23 18:54:47.799+0200 I/gyroscope( 3916): capturing data from es.ugr.frailty.gyroscope
04-23 18:54:47.799+0200 I/gyroscope( 3916): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:54:47:807,32.060001,4.130000,10.990000
04-23 18:54:47.799+0200 I/accelerometer( 3903): capturing data from es.ugr.frailty.accelerometer
04-23 18:54:47.809+0200 W/CRASH_MANAGER( 3712): worker.c: worker_job(1205) > 11039456c6f63152450248
