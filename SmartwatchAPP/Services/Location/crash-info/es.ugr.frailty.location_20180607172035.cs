S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20177
Date: 2018-06-07 17:20:35+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf728852d, r5   = 0xf7b2af98
r6   = 0xff855530, r7   = 0xff8553e0
r8   = 0xf7b27c18, r9   = 0x00000000
r10  = 0xff8554bc, fp   = 0xff855530
ip   = 0x00000001, sp   = 0xff8553b8
lr   = 0xf7288539, pc   = 0xf72f1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    107640 KB
Buffers:      6012 KB
Cached:      61440 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11824 KB
VmRSS:       11824 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20177 TID = 20177
20177 20180 

Maps Information
f4153000 f4952000 rw-p [stack:20180]
f4959000 f495b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4963000 f4967000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4970000 f4972000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f497a000 f497d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f498c000 f4991000 r-xp /usr/lib/libsystem.so.0.0.0
f499c000 f499f000 r-xp /lib/libattr.so.1.1.0
f49a7000 f49b7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f49bf000 f49c8000 r-xp /usr/lib/libedbus.so.1.7.99
f49d0000 f49d1000 r-xp /usr/lib/libresponse.so.0.2.96
f49da000 f49df000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6281000 f6387000 r-xp /usr/lib/libicuuc.so.57.1
f639d000 f6525000 r-xp /usr/lib/libicui18n.so.57.1
f6535000 f6542000 r-xp /usr/lib/libail.so.0.1.0
f654b000 f6552000 r-xp /usr/lib/libminizip.so.1.0.0
f655b000 f6704000 r-xp /usr/lib/libcrypto.so.1.0.0
f6724000 f676b000 r-xp /usr/lib/libssl.so.1.0.0
f6777000 f6779000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6781000 f6788000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6791000 f6798000 r-xp /lib/libcrypt-2.13.so
f67c9000 f67cc000 r-xp /lib/libcap.so.2.21
f67d4000 f67d6000 r-xp /usr/lib/libiri.so
f67de000 f6827000 r-xp /usr/lib/libmdm.so.1.2.69
f682f000 f6835000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f683d000 f6860000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f686a000 f686c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6874000 f6891000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f689a000 f689e000 r-xp /usr/lib/libsmack.so.1.0.0
f68a7000 f68c0000 r-xp /usr/lib/libnetwork.so.0.0.0
f68c9000 f68d1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f68d9000 f68df000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f68e8000 f68ea000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f68f3000 f6903000 r-xp /lib/libresolv-2.13.so
f6907000 f691f000 r-xp /usr/lib/liblzma.so.5.0.3
f6928000 f692a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6932000 f694c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6954000 f6983000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f698c000 f699b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f69a5000 f69af000 r-xp /usr/lib/libsensord-shared.so
f69b8000 f6a8b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a96000 f6aac000 r-xp /lib/libz.so.1.2.5
f6ab4000 f6ab9000 r-xp /usr/lib/libffi.so.5.0.10
f6ac1000 f6ac2000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6aca000 f6ada000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ae2000 f6afb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6b03000 f6b05000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b0d000 f6b82000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6b8c000 f6b92000 r-xp /lib/librt-2.13.so
f6b9b000 f6bb9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6bc3000 f6bc4000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6bcc000 f6bef000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6bf7000 f6bfc000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6c04000 f6c2e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c37000 f6c4e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c56000 f6cbf000 r-xp /lib/libm-2.13.so
f6cc8000 f6d5c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d6f000 f6d74000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d7c000 f6d83000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d8b000 f6db5000 r-xp /usr/lib/libsensor.so.1.9.6
f6dbe000 f6e8a000 r-xp /usr/lib/libxml2.so.2.7.8
f6e97000 f6e99000 r-xp /usr/lib/libiniparser.so.0
f6ea2000 f6ea8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6eb1000 f6f81000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f82000 f6fb6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6fbf000 f6ffb000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7003000 f7006000 r-xp /usr/lib/libbundle.so.0.1.22
f700e000 f7014000 r-xp /usr/lib/libappsvc.so.0.1.0
f701c000 f705d000 r-xp /usr/lib/libeina.so.1.7.99
f7066000 f707d000 r-xp /usr/lib/libecore.so.1.7.99
f7094000 f709d000 r-xp /usr/lib/libvconf.so.0.2.45
f70a5000 f70b9000 r-xp /lib/libpthread-2.13.so
f70c4000 f70d1000 r-xp /usr/lib/libaul.so.0.1.0
f70db000 f70dd000 r-xp /lib/libdl-2.13.so
f70e6000 f70f1000 r-xp /lib/libunwind.so.8.0.1
f711e000 f7126000 r-xp /lib/libgcc_s-4.6.so.1
f7127000 f724b000 r-xp /lib/libc-2.13.so
f7259000 f725b000 r-xp /usr/lib/libdlog.so.0.0.0
f7263000 f726f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7278000 f727d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7285000 f7294000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f729c000 f72a0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f72a9000 f72ac000 r-xp /usr/lib/libappcore-agent.so.1.1
f72b4000 f72b6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f72be000 f72c2000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f72ca000 f72e7000 r-xp /lib/ld-2.13.so
f72f0000 f72f3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f72f3000 f72f7000 r-xp /usr/lib/libsys-assert.so
f7af7000 f7b85000 rw-p [heap]
ff836000 ff857000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20177)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf72f1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7288539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6f8f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6f8dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6f99e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6f9fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6f9fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6fd475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6fcf1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6f8dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6f99e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6f9fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6f9fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6fd1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6fd2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6fd9f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf49711fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4964171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6a37663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ee4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ee67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7076ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7071b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf70725a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7072879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf72aa183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf72aa7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf72f15c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf713e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf72f0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.351+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:32.361+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:32.361+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:32:332,0.140000,0.070000,0.070000
06-07 17:21:32.361+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:32.361+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:32.361+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:32:368,0.309997,-0.088147,9.801353
06-07 17:21:32.371+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:32.371+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.381+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:32:375,0.354138,-0.105284,9.815358
06-07 17:21:32.401+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:32:381,0.140000,0.070000,0.070000
06-07 17:21:32.401+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:32.401+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:32.411+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:385,-0.006411,-0.002861,0.028410
06-07 17:21:32.411+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:32.411+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.441+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:447,0.023040,0.030588,0.066671
06-07 17:21:32.441+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.451+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:453,0.010971,-0.009514,0.116906
06-07 17:21:32.451+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.451+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20358) cmd(0)
06-07 17:21:32.461+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:459,-0.018020,0.000556,-0.005114
06-07 17:21:32.461+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.461+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:468,0.014569,0.014568,0.049872
06-07 17:21:32.461+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.471+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:474,-0.007143,-0.031780,0.023546
06-07 17:21:32.471+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.471+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:479,0.008164,0.026821,0.021136
06-07 17:21:32.471+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.481+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:485,0.030007,-0.005903,-0.007604
06-07 17:21:32.481+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.481+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:491,0.029226,0.003633,-0.005186
06-07 17:21:32.491+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.491+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:496,0.064186,-0.013448,0.061839
06-07 17:21:32.491+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.501+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:501,0.049989,0.027530,0.021234
06-07 17:21:32.501+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.501+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:507,0.029204,0.033282,0.033236
06-07 17:21:32.501+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.511+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:512,-0.043327,0.043504,0.011706
06-07 17:21:32.511+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.511+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:518,-0.055193,0.005112,-0.005145
06-07 17:21:32.511+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.521+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:524,0.019711,0.031053,0.059361
06-07 17:21:32.521+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.521+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:530,0.017672,0.014708,0.059331
06-07 17:21:32.521+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.531+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:535,0.038952,0.025784,0.080866
06-07 17:21:32.531+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.531+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:541,0.047726,-0.021218,0.061735
06-07 17:21:32.541+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.541+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:547,0.069862,-0.025207,0.073762
06-07 17:21:32.541+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:32.551+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:32.551+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:32.551+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:32:554,688.000000
06-07 17:21:32.551+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.571+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:565,0.023987,0.014059,0.009254
06-07 17:21:32.581+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:32:411,0.311243,-0.090844,9.801289
06-07 17:21:32.581+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:32.581+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:32:415,0.349352,-0.117248,9.853643
06-07 17:21:32.581+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:32.581+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:32:564,0.140000,0.070000,0.070000
06-07 17:21:32.581+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.601+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:32.601+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:32:588,0.312517,-0.091809,9.801239
06-07 17:21:32.611+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:607,0.033384,0.025018,0.076248
06-07 17:21:32.621+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:32:596,0.332602,-0.102891,9.879964
06-07 17:21:32.621+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:32.621+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:32.631+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.631+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:32:608,0.140000,0.070000,0.070000
06-07 17:21:32.631+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:32.641+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:32:627,0.311620,-0.092145,9.801265
06-07 17:21:32.651+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:32.661+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:643,-0.027267,-0.014626,0.064300
06-07 17:21:32.661+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:32:638,0.339781,-0.076570,9.829715
06-07 17:21:32.661+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:32:648,0.140000,0.070000,0.070000
06-07 17:21:32.671+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.671+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:32.671+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:32.681+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:32:664,0.310693,-0.092250,9.801293
06-07 17:21:32.691+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:679,-0.032588,-0.011707,0.059460
06-07 17:21:32.691+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:32.701+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:32:681,0.303888,-0.126820,9.858429
06-07 17:21:32.701+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:32:686,0.070000,0.070000,0.070000
06-07 17:21:32.701+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.701+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:32:701,0.309007,-0.091391,9.801354
06-07 17:21:32.711+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:32.711+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:32.711+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:720,-0.020902,-0.006527,0.059396
06-07 17:21:32.721+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:32.721+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:32.721+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:32.731+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:32:729,689.000000
06-07 17:21:32.751+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:32:751,0.140000,0.140000,0.070000
06-07 17:21:32.751+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:32:750,0.284746,-0.126820,9.856036
06-07 17:21:32.761+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:32.771+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.771+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:32.771+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:32.781+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:32:766,0.308641,-0.091470,9.801365
06-07 17:21:32.791+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:32.791+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:32:784,0.140000,-0.070000,0.070000
06-07 17:21:32.791+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:777,0.014116,-0.011185,0.011493
06-07 17:21:32.801+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.811+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:32:786,0.294317,-0.143569,9.824929
06-07 17:21:32.821+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:32.821+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:32.841+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:32:800,0.308905,-0.090994,9.801361
06-07 17:21:32.841+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:32.851+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:812,0.021039,-0.008439,0.135930
06-07 17:21:32.861+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.861+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:32:837,0.294317,-0.093320,9.992428
06-07 17:21:32.871+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:32:836,-0.070000,-0.070000,0.070000
06-07 17:21:32.871+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:32.891+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:32.891+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:32:860,0.308912,-0.089171,9.801378
06-07 17:21:32.891+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:32.901+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:876,0.015886,0.010871,0.004338
06-07 17:21:32.901+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:32:891,0.284746,-0.083749,9.796216
06-07 17:21:32.911+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.921+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:32:901,0.308750,-0.088806,9.801386
06-07 17:21:32.921+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:32:898,0.070000,-0.070000,0.070000
06-07 17:21:32.921+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:32.931+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:32.931+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:32.931+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:32:936,689.000000
06-07 17:21:32.941+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:32.941+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:32.951+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:32.951+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:918,-0.003517,-0.066385,0.023482
06-07 17:21:32.971+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:32:958,0.310303,-0.091371,9.801313
06-07 17:21:32.971+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:32.981+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:32:947,0.315853,-0.074178,9.889536
06-07 17:21:32.981+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:32:958,0.070000,-0.070000,0.070000
06-07 17:21:32.981+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:32.991+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:32:986,0.042515,-0.022917,0.054597
06-07 17:21:32.991+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:33.001+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:33.001+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:33:7,0.310269,-0.093503,9.801294
06-07 17:21:33.021+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:33.041+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:33:6,0.327817,-0.035892,9.810574
06-07 17:21:33.041+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:33.051+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:33:7,0.070000,0.070000,0.070000
06-07 17:21:33.051+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:33.051+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:33.061+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:33:39,0.018340,-0.011975,0.057085
06-07 17:21:33.061+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:33.071+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:33:65,0.140000,0.070000,0.070000
06-07 17:21:33.081+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:33:49,0.308642,-0.093888,9.801342
06-07 17:21:33.081+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:33:56,0.334995,-0.095713,9.839286
06-07 17:21:33.081+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:33.081+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:33.091+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:33:76,0.013165,-0.025965,0.066671
06-07 17:21:33.091+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:33.121+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:33.121+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:33.121+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:33.121+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:33.131+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:33:134,688.000000
06-07 17:21:33.141+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:21:33.151+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:21:33.151+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:21:33.151+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:33:99,0.323031,-0.117248,9.884750
06-07 17:21:33.151+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:33:94,0.308318,-0.092972,9.801361
06-07 17:21:33.151+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:33.161+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:33.171+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:33:116,0.070000,0.070000,0.070000
06-07 17:21:33.171+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:33:126,-0.013098,-0.003567,0.061893
06-07 17:21:33.181+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:33.191+0200 E/AUL     (20358): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:21:33.191+0200 E/AUL     (20358): launch.c: __send_result_to_launchpad(352) > send failed due to EPIPE.
06-07 17:21:33.191+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:33.191+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(20358), cmd(0)
06-07 17:21:33.201+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:33:179,0.351745,-0.110070,9.858429
06-07 17:21:33.201+0200 W/CAPI_APPFW_APP_CONTROL(20358): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:33.201+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:33:186,0.308508,-0.092012,9.801364
06-07 17:21:33.201+0200 I/utils   (20358): specific action
06-07 17:21:33.211+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:33.211+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(33) , send fd(15), pid(20358), cmd(0)
06-07 17:21:33.211+0200 W/CAPI_APPFW_APP_CONTROL(20358): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:33.211+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:33.221+0200 I/utils   (20358): specific action
06-07 17:21:33.221+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:33.221+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:33.231+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:33:192,0.070000,0.070000,0.070000
06-07 17:21:33.241+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:33.251+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:33:227,0.021528,0.025122,0.061857
06-07 17:21:33.261+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:33:239,0.308674,-0.112463,9.839286
06-07 17:21:33.261+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:33:245,0.308107,-0.091235,9.801384
06-07 17:21:33.261+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:33.271+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:33.271+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:33.281+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:33:290,0.307884,-0.089511,9.801407
06-07 17:21:33.281+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:33:253,0.070000,0.070000,0.070000
06-07 17:21:33.291+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:33:277,0.018990,-0.014696,0.037918
06-07 17:21:33.291+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:33:278,0.325424,-0.122034,9.856036
06-07 17:21:33.301+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:33.311+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:33.311+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:33.311+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:33.311+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:33.311+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:33.311+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:33:312,0.070000,0.070000,0.070000
06-07 17:21:33.331+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:33.331+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:33:336,688.000000
06-07 17:21:33.341+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:33.351+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:33:324,0.308747,-0.088796,9.801387
06-07 17:21:33.361+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:33:325,0.020920,0.033663,0.047510
06-07 17:21:33.361+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:33.361+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:33.361+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:33:347,0.210000,0.070000,0.070000
06-07 17:21:33.361+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:33:342,0.267996,-0.100499,9.808180
06-07 17:21:33.371+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:33:375,0.015768,-0.004008,0.064255
06-07 17:21:33.381+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:33.391+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:33.391+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:33:396,0.070000,0.070000,0.070000
06-07 17:21:33.391+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:33:386,0.308572,-0.088753,9.801393
06-07 17:21:33.391+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:33.391+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:33.401+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:33:391,0.306281,-0.093320,9.853643
06-07 17:21:33.411+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:33.411+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:33.431+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:33:406,0.011020,0.003009,0.023574
06-07 17:21:33.441+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:33:415,0.307246,-0.089000,9.801432
06-07 17:21:33.441+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:33.441+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:33:422,0.275175,-0.050249,9.891929
06-07 17:21:33.441+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:33.441+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:33:426,0.070000,0.070000,0.070000
06-07 17:21:33.451+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:33.451+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:33.471+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:33:469,0.070000,0.070000,0.070000
06-07 17:21:33.471+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:33:455,0.306241,-0.089811,9.801455
06-07 17:21:33.481+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:33:448,0.018416,-0.052502,0.009207
06-07 17:21:33.481+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:33.481+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:33.481+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:33:466,0.330210,-0.071785,9.856036
06-07 17:21:33.491+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:33.491+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:33.511+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:33.511+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:33.511+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:33:487,-0.037107,-0.064740,0.009241
06-07 17:21:33.511+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:33:492,0.306392,-0.091686,9.801434
06-07 17:21:33.511+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:33:513,0.330210,-0.071785,9.848858
06-07 17:21:33.521+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:33.531+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:33:530,687.000000
06-07 17:21:33.531+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:33.531+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:33.541+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer alive timeout
06-07 17:21:33.541+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:21:33.541+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:33.541+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:33.551+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:33:506,-0.070000,0.070000,0.070000
06-07 17:21:33.551+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:33.551+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:33.551+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20297
06-07 17:21:33.561+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20297)
06-07 17:21:33.561+0200 I/servicemanager(19582): es.ugr.frailty.accelerometer launch request sent!
06-07 17:21:33.561+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:33.561+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope alive timeout
06-07 17:21:33.561+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:21:33.561+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:33.561+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:33.571+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20330
06-07 17:21:33.581+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20330)
06-07 17:21:33.581+0200 I/servicemanager(19582): es.ugr.frailty.gyroscope launch request sent!
06-07 17:21:33.581+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:33.581+0200 I/servicemanager(19582): es.ugr.frailty.heartrate alive timeout
06-07 17:21:33.581+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:21:33.581+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:33.581+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:33.591+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19621
06-07 17:21:33.601+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:33.601+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(19621), cmd(0)
06-07 17:21:33.601+0200 W/CAPI_APPFW_APP_CONTROL(19621): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:33.601+0200 I/utils   (19621): specific action
06-07 17:21:33.601+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19621)
06-07 17:21:33.601+0200 I/servicemanager(19582): es.ugr.frailty.heartrate launch request sent!
06-07 17:21:33.601+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:33.601+0200 I/servicemanager(19582): es.ugr.frailty.location alive timeout
06-07 17:21:33.601+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:21:33.601+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:33.611+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:33.621+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20394
06-07 17:21:33.621+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:33.621+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(20394), cmd(0)
06-07 17:21:33.621+0200 W/CAPI_APPFW_APP_CONTROL(20394): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:33.631+0200 I/utils   (20394): specific action
06-07 17:21:33.631+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20394)
06-07 17:21:33.631+0200 I/servicemanager(19582): es.ugr.frailty.location launch request sent!
06-07 17:21:33.631+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:33.631+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration alive timeout
06-07 17:21:33.631+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:21:33.631+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:33.631+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:33.641+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20358
06-07 17:21:33.641+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20358)
06-07 17:21:33.641+0200 I/servicemanager(19582): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:21:33.641+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:33.641+0200 I/servicemanager(19582): es.ugr.frailty.gravity alive timeout
06-07 17:21:33.641+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:21:33.641+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:33.641+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:33.661+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 20375
06-07 17:21:33.661+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20375)
06-07 17:21:33.661+0200 I/servicemanager(19582): es.ugr.frailty.gravity launch request sent!
06-07 17:21:33.661+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:33.661+0200 I/servicemanager(19582): es.ugr.frailty.pressure alive timeout
06-07 17:21:33.661+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:21:33.661+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:33.661+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:33:540,0.020091,0.017179,0.119269
06-07 17:21:33.661+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:33.671+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:33.671+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19663
06-07 17:21:33.681+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:33.681+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(15), pid(19663), cmd(0)
06-07 17:21:33.681+0200 W/CAPI_APPFW_APP_CONTROL(19663): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:33.681+0200 I/utils   (19663): specific action
06-07 17:21:33.691+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19663)
06-07 17:21:33.691+0200 I/servicemanager(19582): es.ugr.frailty.pressure launch request sent!
06-07 17:21:33.691+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:33.691+0200 I/servicemanager(19582): es.ugr.frailty.light alive timeout
06-07 17:21:33.691+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:21:33.691+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:33.691+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:33.701+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19670
06-07 17:21:33.711+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19670)
06-07 17:21:33.711+0200 I/servicemanager(19582): es.ugr.frailty.light launch request sent!
06-07 17:21:33.711+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:33.711+0200 I/servicemanager(19582): es.ugr.frailty.pedometer alive timeout
06-07 17:21:33.711+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:21:33.711+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:21:33.711+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 19582
06-07 17:21:33.721+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19682
06-07 17:21:33.731+0200 W/AUL     (19582): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19682)
06-07 17:21:33.731+0200 I/servicemanager(19582): es.ugr.frailty.pedometer launch request sent!
06-07 17:21:33.731+0200 I/servicemanager(19582): App control destroyed.
06-07 17:21:33.821+0200 W/CAPI_APPFW_APP_CONTROL(19682): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:33.821+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:33.821+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(19682), cmd(0)
06-07 17:21:33.831+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:33.831+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:33.851+0200 I/utils   (19682): specific action
06-07 17:21:33.861+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:21:33.861+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(15), pid(19670), cmd(0)
06-07 17:21:33.861+0200 W/CAPI_APPFW_APP_CONTROL(19670): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:21:33.861+0200 I/utils   (19670): specific action
06-07 17:21:33.861+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:33.901+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:33:872,687.000000
06-07 17:21:33.901+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:33:543,0.307009,-0.091357,9.801417
06-07 17:21:34.001+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:34.011+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:34.011+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:34.011+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:34.011+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:33:562,-0.070000,0.070000,0.070000
06-07 17:21:34.031+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:33:596,0.320638,-0.057428,9.899107
06-07 17:21:34.031+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:34:13,691.000000
06-07 17:21:34.031+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:34:24,0.306351,-0.091700,9.801435
06-07 17:21:34.031+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:34.041+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:34.041+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:33:675,0.000667,0.044863,0.102520
06-07 17:21:34.051+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:34:42,-0.070000,0.070000,0.070000
06-07 17:21:34.061+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:34.061+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:34.071+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:34:49,0.330210,-0.136391,9.841680
06-07 17:21:34.071+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:34.081+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:34:68,0.304365,-0.092314,9.801491
06-07 17:21:34.091+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:34.091+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:34:70,-0.013169,0.020952,0.030697
06-07 17:21:34.091+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:34.091+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:34.101+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:34:83,0.070000,-0.070000,0.070000
06-07 17:21:34.111+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:34.111+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:34.121+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:34:104,0.305171,-0.090483,9.801483
06-07 17:21:34.121+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:34.121+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:34.141+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:21:34.141+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:21:34.141+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:21:34.151+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:34:132,687.000000
06-07 17:21:34.161+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:34:98,0.308674,-0.131605,9.856036
06-07 17:21:34.161+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:34.161+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:34.171+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:34:107,-0.004930,0.031713,0.054580
06-07 17:21:34.171+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:34:171,0.320638,-0.150748,9.853643
06-07 17:21:34.181+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:34.181+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:34:160,0.070000,0.070000,0.070000
06-07 17:21:34.191+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:34.191+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:34:180,0.306376,-0.090405,9.801446
06-07 17:21:34.191+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:34.201+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:34:188,0.032200,0.000969,0.059310
06-07 17:21:34.211+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:34.211+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:34:216,0.306746,-0.088431,9.801453
06-07 17:21:34.221+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:34.221+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:34:200,0.140000,0.070000,0.070000
06-07 17:21:34.221+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:34:227,0.026999,-0.028281,0.040174
06-07 17:21:34.231+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:34:205,0.299103,-0.078963,9.848858
06-07 17:21:34.231+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:34.231+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:34.241+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:34.241+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:34:249,0.315853,-0.119641,9.853643
06-07 17:21:34.251+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:34.251+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:34:250,0.305860,-0.085912,9.801502
06-07 17:21:34.251+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:34:237,0.140000,0.070000,0.070000
06-07 17:21:34.251+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:34.261+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:34.271+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:34.271+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:34:256,0.028729,-0.041658,0.037810
06-07 17:21:34.281+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:34:278,0.304281,-0.088246,9.801531
06-07 17:21:34.281+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:34.291+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:34:268,0.140000,0.070000,0.070000
06-07 17:21:34.291+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:34.301+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:34:280,0.294317,-0.119641,9.858429
06-07 17:21:34.301+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:34.301+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:34.311+0200 I/heartrate(19621): es.ugr.frailty.heartrate - capturing data
06-07 17:21:34.311+0200 I/heartrate(19621): es.ugr.frailty.heartrate: waiting for rigth values
06-07 17:21:34.311+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:34:311,0.304506,-0.088420,9.801522
06-07 17:21:34.321+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:34:295,-0.001151,-0.042412,0.030684
06-07 17:21:34.321+0200 I/light   (19670): es.ugr.frailty.light - capturing data
06-07 17:21:34.331+0200 I/light   (19670): es.ugr.frailty.light: SM-R760,07/06/2018,17:21:34:331,685.000000
06-07 17:21:34.331+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:34.341+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20297) cmd(0)
06-07 17:21:34.341+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:34:303,0.140000,0.070000,0.070000
06-07 17:21:34.341+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:34.351+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:34:312,0.303888,-0.133998,9.817751
06-07 17:21:34.351+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:34.351+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:34.351+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:34:339,0.006800,-0.016837,0.037852
06-07 17:21:34.351+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20330) cmd(0)
06-07 17:21:34.371+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:34.371+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:34:354,0.210000,0.070000,0.070000
06-07 17:21:34.381+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:34.381+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:34:361,0.305037,-0.090151,9.801490
06-07 17:21:34.381+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:21:34:368,0.308674,-0.143569,9.856036
06-07 17:21:34.391+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:21:34:382,-0.002671,-0.001872,0.054605
06-07 17:21:34.391+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:34.401+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:21:34:395,0.210000,0.140000,0.070000
06-07 17:21:34.401+0200 I/accelerometer(20297): es.ugr.frailty.accelerometer - capturing data
06-07 17:21:34.421+0200 I/linearacceleration(20358): es.ugr.frailty.linearacceleration - capturing data
06-07 17:21:34.451+0200 E/AUL_AMD ( 2479): amd_launch.c: __recv_timeout_handler(1018) > application is not responding : pid(20375) cmd(0)
06-07 17:21:34.501+0200 I/gravity (20375): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:21:34:405,0.305402,-0.089340,9.801486
06-07 17:21:34.501+0200 I/gravity (20375): es.ugr.frailty.gravity - capturing data
06-07 17:21:34.501+0200 I/gyroscope(20330): es.ugr.frailty.gyroscope - capturing data
06-07 17:21:34.511+0200 W/CRASH_MANAGER(19711): worker.c: worker_job(1205) > 11201776c6f63152838483
