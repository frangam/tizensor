S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 17655
Date: 2018-06-07 17:12:16+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf74c852d, r5   = 0xf77bdf98
r6   = 0xffc10250, r7   = 0xffc10100
r8   = 0xf77bac18, r9   = 0x00000000
r10  = 0xffc101dc, fp   = 0xffc10250
ip   = 0x00000001, sp   = 0xffc100d8
lr   = 0xf74c8539, pc   = 0xf7531228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     74976 KB
Buffers:     10772 KB
Cached:      56680 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11592 KB
VmRSS:       11592 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 17655 TID = 17655
17655 17661 

Maps Information
f4393000 f4b92000 rw-p [stack:17661]
f4b99000 f4b9b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ba3000 f4ba7000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4bb0000 f4bb2000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4bba000 f4bbd000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4bcc000 f4bd1000 r-xp /usr/lib/libsystem.so.0.0.0
f4bdc000 f4bdf000 r-xp /lib/libattr.so.1.1.0
f4be7000 f4bf7000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4bff000 f4c08000 r-xp /usr/lib/libedbus.so.1.7.99
f4c10000 f4c11000 r-xp /usr/lib/libresponse.so.0.2.96
f4c1a000 f4c1f000 r-xp /usr/lib/libproc-stat.so.0.2.96
f64c1000 f65c7000 r-xp /usr/lib/libicuuc.so.57.1
f65dd000 f6765000 r-xp /usr/lib/libicui18n.so.57.1
f6775000 f6782000 r-xp /usr/lib/libail.so.0.1.0
f678b000 f6792000 r-xp /usr/lib/libminizip.so.1.0.0
f679b000 f6944000 r-xp /usr/lib/libcrypto.so.1.0.0
f6964000 f69ab000 r-xp /usr/lib/libssl.so.1.0.0
f69b7000 f69b9000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f69c1000 f69c8000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f69d1000 f69d8000 r-xp /lib/libcrypt-2.13.so
f6a09000 f6a0c000 r-xp /lib/libcap.so.2.21
f6a14000 f6a16000 r-xp /usr/lib/libiri.so
f6a1e000 f6a67000 r-xp /usr/lib/libmdm.so.1.2.69
f6a6f000 f6a75000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6a7d000 f6aa0000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6aaa000 f6aac000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ab4000 f6ad1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6ada000 f6ade000 r-xp /usr/lib/libsmack.so.1.0.0
f6ae7000 f6b00000 r-xp /usr/lib/libnetwork.so.0.0.0
f6b09000 f6b11000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6b19000 f6b1f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6b28000 f6b2a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b33000 f6b43000 r-xp /lib/libresolv-2.13.so
f6b47000 f6b5f000 r-xp /usr/lib/liblzma.so.5.0.3
f6b68000 f6b6a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b72000 f6b8c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b94000 f6bc3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bcc000 f6bdb000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6be5000 f6bef000 r-xp /usr/lib/libsensord-shared.so
f6bf8000 f6ccb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6cd6000 f6cec000 r-xp /lib/libz.so.1.2.5
f6cf4000 f6cf9000 r-xp /usr/lib/libffi.so.5.0.10
f6d01000 f6d02000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d0a000 f6d1a000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6d22000 f6d3b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6d43000 f6d45000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d4d000 f6dc2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6dcc000 f6dd2000 r-xp /lib/librt-2.13.so
f6ddb000 f6df9000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e03000 f6e04000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e0c000 f6e2f000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e37000 f6e3c000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e44000 f6e6e000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e77000 f6e8e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e96000 f6eff000 r-xp /lib/libm-2.13.so
f6f08000 f6f9c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6faf000 f6fb4000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fbc000 f6fc3000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fcb000 f6ff5000 r-xp /usr/lib/libsensor.so.1.9.6
f6ffe000 f70ca000 r-xp /usr/lib/libxml2.so.2.7.8
f70d7000 f70d9000 r-xp /usr/lib/libiniparser.so.0
f70e2000 f70e8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f70f1000 f71c1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71c2000 f71f6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f71ff000 f723b000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7243000 f7246000 r-xp /usr/lib/libbundle.so.0.1.22
f724e000 f7254000 r-xp /usr/lib/libappsvc.so.0.1.0
f725c000 f729d000 r-xp /usr/lib/libeina.so.1.7.99
f72a6000 f72bd000 r-xp /usr/lib/libecore.so.1.7.99
f72d4000 f72dd000 r-xp /usr/lib/libvconf.so.0.2.45
f72e5000 f72f9000 r-xp /lib/libpthread-2.13.so
f7304000 f7311000 r-xp /usr/lib/libaul.so.0.1.0
f731b000 f731d000 r-xp /lib/libdl-2.13.so
f7326000 f7331000 r-xp /lib/libunwind.so.8.0.1
f735e000 f7366000 r-xp /lib/libgcc_s-4.6.so.1
f7367000 f748b000 r-xp /lib/libc-2.13.so
f7499000 f749b000 r-xp /usr/lib/libdlog.so.0.0.0
f74a3000 f74af000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74b8000 f74bd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74c5000 f74d4000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f74dc000 f74e0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74e9000 f74ec000 r-xp /usr/lib/libappcore-agent.so.1.1
f74f4000 f74f6000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f74fe000 f7502000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f750a000 f7527000 r-xp /lib/ld-2.13.so
f7530000 f7533000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7533000 f7537000 r-xp /usr/lib/libsys-assert.so
f778a000 f77fb000 rw-p [heap]
ffbf1000 ffc12000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17655)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7531228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf74c8539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf71cf3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf71cdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf71d9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf71dfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf71dfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf721475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf720f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf71cdc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf71d9e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf71dfbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf71dfdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7211e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7212017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7219f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4bb11fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ba4171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6c77663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7124fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71267a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf72b6ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf72b1b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf72b25a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf72b2879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf74ea183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74ea7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf75315c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf737e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf7530f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
/2018,17:12:15:612,-0.070000,0.280000,0.210000
06-07 17:12:15.621+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.621+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:623,0.903328,-1.365541,9.669006
06-07 17:12:15.621+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:15:612,0.815953,-1.062413,9.796216
06-07 17:12:15.621+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:15.631+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.631+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:632,0.140000,0.350000,0.420000
06-07 17:12:15.631+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:15:617,0.017883,-0.009138,0.007545
06-07 17:12:15.641+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.641+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:639,0.904817,-1.364651,9.668993
06-07 17:12:15.641+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.641+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:15.651+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:648,0.070000,-0.070000,0.210000
06-07 17:12:15.651+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.661+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:654,0.907481,-1.365521,9.668620
06-07 17:12:15.661+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.661+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:664,0.490000,-0.210000,0.140000
06-07 17:12:15.661+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:15:654,-0.075812,0.070924,-0.011751
06-07 17:12:15.661+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:15.671+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:15:633,0.849452,-1.105484,9.817751
06-07 17:12:15.671+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:15.671+0200 W/CAPI_APPFW_APP_CONTROL(17548): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:15.671+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:671,0.910438,-1.365875,9.668292
06-07 17:12:15.671+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:15.671+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(17548), cmd(0)
06-07 17:12:15.671+0200 I/utils   (17548): specific action
06-07 17:12:15.671+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.671+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.681+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:15.681+0200 I/heartrate(17619): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:12:15:688,81
06-07 17:12:15.681+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:683,0.911009,-1.365789,9.668250
06-07 17:12:15.681+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.691+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:695,0.912389,-1.368113,9.667791
06-07 17:12:15.691+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:683,0.490000,-0.210000,0.070000
06-07 17:12:15.691+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.691+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.691+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:15.701+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:15:705,620.000000
06-07 17:12:15.701+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:702,0.915747,-1.366730,9.667670
06-07 17:12:15.711+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.711+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:15:677,0.882952,-1.127020,9.786645
06-07 17:12:15.711+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:15.711+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:716,0.916023,-1.364388,9.667974
06-07 17:12:15.711+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:701,0.490000,0.210000,0.070000
06-07 17:12:15.721+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.721+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:15:706,0.000472,0.045941,0.058761
06-07 17:12:15.721+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:15.721+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.731+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:730,0.912259,-1.359937,9.668958
06-07 17:12:15.731+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:729,0.210000,-0.070000,0.070000
06-07 17:12:15.731+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.731+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.741+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:15:729,0.034833,-0.063558,0.105925
06-07 17:12:15.741+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:744,0.140000,0.070000,0.070000
06-07 17:12:15.741+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:745,0.914338,-1.368568,9.667543
06-07 17:12:15.751+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.751+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:15:720,0.890130,-1.079163,9.791430
06-07 17:12:15.751+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:15.751+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.761+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:757,0.140000,0.280000,0.070000
06-07 17:12:15.761+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.761+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:761,0.925993,-1.392150,9.663066
06-07 17:12:15.771+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.771+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:772,0.420000,0.280000,0.070000
06-07 17:12:15.771+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:776,0.933110,-1.405964,9.660380
06-07 17:12:15.771+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:15.771+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.781+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:15:759,0.799203,-1.043271,9.808180
06-07 17:12:15.781+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:15.781+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.781+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:785,0.420000,-0.070000,-0.070000
06-07 17:12:15.781+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:15:782,0.077555,-0.044435,0.129883
06-07 17:12:15.781+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:15.791+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.791+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:790,0.930856,-1.394490,9.662261
06-07 17:12:15.791+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.791+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:15:786,0.801596,-1.014557,9.762716
06-07 17:12:15.801+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:798,0.560000,0.070000,0.070000
06-07 17:12:15.801+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.801+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:15.811+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:803,0.925112,-1.384117,9.664304
06-07 17:12:15.811+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.811+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:813,0.210000,0.070000,0.070000
06-07 17:12:15.811+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:15:803,0.029650,-0.074978,0.072764
06-07 17:12:15.821+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:818,0.914889,-1.372094,9.666991
06-07 17:12:15.821+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.821+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.821+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:15:813,0.803988,-1.045663,9.729217
06-07 17:12:15.821+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:15.831+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:827,0.070000,0.140000,0.210000
06-07 17:12:15.831+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.831+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:833,0.909524,-1.356148,9.669747
06-07 17:12:15.841+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:15.841+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.841+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:15:845,-0.047426,-0.040350,0.006325
06-07 17:12:15.841+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:839,0.070000,0.210000,0.140000
06-07 17:12:15.841+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:15.841+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.841+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:847,0.903130,-1.348447,9.671424
06-07 17:12:15.851+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.871+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:855,0.350000,-0.070000,0.210000
06-07 17:12:15.871+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.871+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:15:833,0.842274,-1.064806,9.712467
06-07 17:12:15.871+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:15.871+0200 W/LOCATION(17655): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:12:15.881+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:15.881+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:15:851,-0.022443,0.046029,-0.025070
06-07 17:12:15.881+0200 I/heartrate(17619): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:12:15:888,80
06-07 17:12:15.881+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:15:881,0.851845,-1.057628,9.717253
06-07 17:12:15.891+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:15.891+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:15:896,0.904487,-1.062413,9.702895
06-07 17:12:15.891+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:15.891+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 17:12:15.891+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:15.901+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:12:15.901+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:15.901+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:15.901+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:15:905,613.000000
06-07 17:12:15.911+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:15:901,0.028999,0.138014,-0.044865
06-07 17:12:15.911+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17664
06-07 17:12:15.911+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:861,0.894674,-1.335021,9.674071
06-07 17:12:15.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17664)
06-07 17:12:15.911+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 17:12:15.911+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:15.911+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 17:12:15.911+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:12:15.921+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:15.921+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:15.921+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:15.921+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:15.921+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.931+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:897,0.350000,-0.210000,0.070000
06-07 17:12:15.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17548
06-07 17:12:15.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17548)
06-07 17:12:15.931+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 17:12:15.931+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:15.931+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 17:12:15.931+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:12:15.931+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:15.941+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:15.941+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:936,0.888546,-1.321496,9.676493
06-07 17:12:15.941+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:15.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17619
06-07 17:12:15.951+0200 W/CAPI_APPFW_APP_CONTROL(17619): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:15.951+0200 I/utils   (17619): specific action
06-07 17:12:15.951+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:15.951+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(17619), cmd(0)
06-07 17:12:15.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17619)
06-07 17:12:15.951+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 17:12:15.951+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:15.951+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 17:12:15.951+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:12:15.951+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:15.951+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:15.961+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:15:928,0.844666,-0.981057,9.958927
06-07 17:12:15.961+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:15.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17655
06-07 17:12:15.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17655)
06-07 17:12:15.971+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 17:12:15.971+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:15.971+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 17:12:15.971+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:12:15.971+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:15.971+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:15.971+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:15:945,0.049997,0.077911,0.021674
06-07 17:12:15.971+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:15.981+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:15:964,0.210000,-0.140000,0.070000
06-07 17:12:15.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17504
06-07 17:12:15.981+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17504)
06-07 17:12:15.991+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:12:15.991+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:15.991+0200 I/servicemanager(12566): es.ugr.frailty.gravity alive timeout
06-07 17:12:15.991+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 17:12:15.991+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:15.991+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:15.991+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:16.001+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17469
06-07 17:12:16.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17469)
06-07 17:12:16.001+0200 I/servicemanager(12566): es.ugr.frailty.gravity launch request sent!
06-07 17:12:16.001+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:16.001+0200 I/servicemanager(12566): es.ugr.frailty.pressure alive timeout
06-07 17:12:16.001+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 17:12:16.001+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:16.001+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:16.011+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:15:976,0.789631,-1.014557,9.535398
06-07 17:12:16.011+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.011+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:18,0.837488,-1.048056,9.635897
06-07 17:12:16.011+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12603
06-07 17:12:16.021+0200 W/CAPI_APPFW_APP_CONTROL(12603): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:16.021+0200 I/utils   (12603): specific action
06-07 17:12:16.021+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:24,0.961915,-1.158126,9.810574
06-07 17:12:16.021+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:16.021+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(12603), cmd(0)
06-07 17:12:16.021+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12603)
06-07 17:12:16.021+0200 I/servicemanager(12566): es.ugr.frailty.pressure launch request sent!
06-07 17:12:16.021+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:16.021+0200 I/servicemanager(12566): es.ugr.frailty.light alive timeout
06-07 17:12:16.021+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 17:12:16.021+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:16.021+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:16.031+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 16749
06-07 17:12:16.031+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:42,0.064307,-0.008610,0.090895
06-07 17:12:16.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(16749)
06-07 17:12:16.041+0200 I/servicemanager(12566): es.ugr.frailty.light launch request sent!
06-07 17:12:16.041+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:16.041+0200 I/servicemanager(12566): es.ugr.frailty.pedometer alive timeout
06-07 17:12:16.041+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 17:12:16.041+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.041+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:12:16.041+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:15:992,0.883799,-1.310553,9.678416
06-07 17:12:16.041+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.041+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:12:16.051+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12618
06-07 17:12:16.061+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:16.061+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(16749), cmd(0)
06-07 17:12:16.061+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:16.061+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(32) , send fd(15), pid(12618), cmd(0)
06-07 17:12:16.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:12:16.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:12:16.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:12:16.071+0200 W/CAPI_APPFW_APP_CONTROL(16749): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:16.071+0200 W/CAPI_APPFW_APP_CONTROL(12618): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:16.071+0200 I/utils   (12618): specific action
06-07 17:12:16.071+0200 I/utils   (16749): specific action
06-07 17:12:16.071+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12618)
06-07 17:12:16.071+0200 I/servicemanager(12566): es.ugr.frailty.pedometer launch request sent!
06-07 17:12:16.071+0200 I/servicemanager(12566): App control destroyed.
06-07 17:12:16.071+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:33,0.847059,-1.143769,9.937392
06-07 17:12:16.071+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.081+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:16.081+0200 I/heartrate(17619): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:12:16:88,80
06-07 17:12:16.081+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:85,0.746561,-1.138984,9.966106
06-07 17:12:16.081+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.091+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:47,0.280000,0.070000,0.280000
06-07 17:12:16.091+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:94,0.835095,-1.095913,9.681360
06-07 17:12:16.091+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.091+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.091+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:99,0.928415,-1.086342,9.621540
06-07 17:12:16.091+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:16.101+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.101+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:16:105,609.000000
06-07 17:12:16.101+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:12:16.101+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(15), pid(17664), cmd(0)
06-07 17:12:16.101+0200 W/CAPI_APPFW_APP_CONTROL(17664): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:12:16.101+0200 I/utils   (17664): specific action
06-07 17:12:16.101+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.111+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:50,0.878010,-1.295879,9.680919
06-07 17:12:16.111+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:114,0.985843,-1.055235,9.664611
06-07 17:12:16.111+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.111+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:104,-0.044696,-0.052406,0.093307
06-07 17:12:16.111+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:119,0.839881,-1.158126,9.724431
06-07 17:12:16.111+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.121+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:111,0.140000,0.280000,0.280000
06-07 17:12:16.121+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:125,0.842274,-1.280160,9.741181
06-07 17:12:16.121+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.121+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:130,0.945165,-1.277767,9.791430
06-07 17:12:16.121+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.131+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:134,0.969093,-1.270589,9.848858
06-07 17:12:16.131+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.131+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.131+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:140,0.859023,-1.198804,9.815358
06-07 17:12:16.131+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.141+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.141+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:145,0.847059,-1.150948,9.726824
06-07 17:12:16.141+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.141+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:151,0.861416,-1.170090,9.712467
06-07 17:12:16.151+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.151+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:156,0.945165,-1.222732,9.777073
06-07 17:12:16.151+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.151+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.161+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:162,0.851845,-1.361516,9.808180
06-07 17:12:16.161+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.161+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:166,0.894916,-1.339981,9.743573
06-07 17:12:16.161+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.161+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:151,-0.051979,-0.059965,-0.002899
06-07 17:12:16.161+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:170,0.899701,-1.256232,9.755538
06-07 17:12:16.161+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.171+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:143,0.871625,-1.270528,9.684855
06-07 17:12:16.171+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.171+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:175,0.899701,-1.234696,9.808180
06-07 17:12:16.171+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.171+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.181+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:181,0.866202,-1.241875,9.757930
06-07 17:12:16.181+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:161,0.140000,-0.070000,0.140000
06-07 17:12:16.181+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.181+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:186,0.863809,-1.153341,9.815358
06-07 17:12:16.181+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.181+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:191,0.942772,-1.232304,9.695717
06-07 17:12:16.191+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.191+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:196,0.926022,-1.122234,9.712467
06-07 17:12:16.191+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.201+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.201+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:201,0.914058,-1.069592,9.700503
06-07 17:12:16.201+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.201+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:206,0.892523,-1.043271,9.767502
06-07 17:12:16.201+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.201+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:206,0.490000,-0.070000,0.140000
06-07 17:12:16.201+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:211,0.849452,-1.136591,9.793823
06-07 17:12:16.211+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:200,0.060772,0.004167,-0.036941
06-07 17:12:16.211+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.211+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.211+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:194,0.864245,-1.241217,9.689316
06-07 17:12:16.211+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:220,0.825524,-1.227518,9.789038
06-07 17:12:16.221+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:217,0.560000,-0.210000,-0.070000
06-07 17:12:16.221+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.221+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.231+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.231+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:228,0.280000,-0.070000,0.070000
06-07 17:12:16.241+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.241+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:230,0.854656,-1.214289,9.693578
06-07 17:12:16.241+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.241+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:238,0.132475,-0.054899,0.123941
06-07 17:12:16.241+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:246,0.897308,-1.347159,9.714860
06-07 17:12:16.241+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.251+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.251+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.261+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:252,0.840555,-1.185241,9.698404
06-07 17:12:16.261+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:264,0.921237,-1.294517,9.748360
06-07 17:12:16.261+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:261,0.108332,-0.024091,0.194674
06-07 17:12:16.261+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:253,0.560000,0.630000,0.070000
06-07 17:12:16.271+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.271+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.271+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.281+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:16.281+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:285,-0.005346,-0.012121,0.072982
06-07 17:12:16.281+0200 I/heartrate(17619): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:12:16:288,80
06-07 17:12:16.281+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:280,0.834677,-1.166952,9.701130
06-07 17:12:16.281+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.291+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.291+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:281,0.928415,-1.294517,9.789038
06-07 17:12:16.291+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.291+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:16.301+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:296,0.842903,-1.154728,9.701881
06-07 17:12:16.301+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:16:306,610.000000
06-07 17:12:16.301+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.311+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.311+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:312,0.850501,-1.154250,9.701275
06-07 17:12:16.321+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:293,0.210000,0.070000,0.210000
06-07 17:12:16.321+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.321+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.321+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:302,-0.035220,-0.053568,-0.051325
06-07 17:12:16.321+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.331+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:316,0.981057,-1.296910,9.812965
06-07 17:12:16.331+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:326,0.855381,-1.160270,9.700128
06-07 17:12:16.331+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.331+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:16.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391536350,000000, pattern:[H:mm][0;m
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:12:16.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:12:16.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:12:16.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:12][0;m
06-07 17:12:16.341+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:341,0.857184,-1.163990,9.699523
06-07 17:12:16.341+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.351+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:335,-0.044984,-0.034109,-0.040648
06-07 17:12:16.351+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.351+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:327,-0.140000,-0.210000,0.350000
06-07 17:12:16.361+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:359,0.859014,-1.161425,9.699669
06-07 17:12:16.361+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:337,0.983450,-1.194018,9.812965
06-07 17:12:16.361+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.361+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.371+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.371+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:376,-0.140000,-0.280000,0.420000
06-07 17:12:16.371+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:374,0.855011,-1.148982,9.701504
06-07 17:12:16.371+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:374,0.875773,-1.177269,9.729217
06-07 17:12:16.371+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.381+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.381+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:360,-0.038420,0.051359,0.027357
06-07 17:12:16.391+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.391+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:391,0.848104,-1.134170,9.703853
06-07 17:12:16.391+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:384,0.796810,-1.129412,9.652647
06-07 17:12:16.391+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.391+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.401+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.401+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:405,0.842624,-1.118420,9.706158
06-07 17:12:16.411+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:395,0.140000,-0.070000,0.280000
06-07 17:12:16.411+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.411+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.421+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:409,-0.066651,0.034508,0.113439
06-07 17:12:16.421+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:402,0.842274,-1.124627,9.676575
06-07 17:12:16.421+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:421,0.843368,-1.110279,9.707028
06-07 17:12:16.431+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.431+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.431+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:436,-0.106689,0.089805,0.033303
06-07 17:12:16.431+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.441+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:439,0.844108,-1.104397,9.707635
06-07 17:12:16.441+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:422,0.280000,-0.280000,0.280000
06-07 17:12:16.441+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.441+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:443,0.844666,-1.012164,9.796216
06-07 17:12:16.441+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.451+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.451+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:458,0.844388,-1.098573,9.708271
06-07 17:12:16.451+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.461+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.461+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:460,-0.070757,0.040984,-0.040339
06-07 17:12:16.461+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.471+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:472,0.842303,-1.090660,9.709345
06-07 17:12:16.471+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.481+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:453,0.490000,-0.210000,0.140000
06-07 17:12:16.481+0200 I/heartrate(17619): es.ugr.frailty.heartrate - capturing data
06-07 17:12:16.481+0200 I/heartrate(17619): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:12:16:488,80
06-07 17:12:16.481+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:485,0.840593,-1.084683,9.710162
06-07 17:12:16.491+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.491+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.491+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:496,0.350000,-0.210000,0.350000
06-07 17:12:16.491+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:12:16.501+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:500,0.837304,-1.077483,9.711248
06-07 17:12:16.501+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:12:16:505,608.000000
06-07 17:12:16.501+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:465,0.885344,-1.155733,9.765109
06-07 17:12:16.501+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.501+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:12:16:511,0.911665,-1.150948,9.793823
06-07 17:12:16.501+0200 I/accelerometer(17664): es.ugr.frailty.accelerometer - capturing data
06-07 17:12:16.511+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.511+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.511+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:516,0.838227,-1.068972,9.712109
06-07 17:12:16.521+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:472,0.047883,-0.039186,0.019176
06-07 17:12:16.521+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration - capturing data
06-07 17:12:16.521+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.541+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:12:16:524,-0.210000,-0.210000,0.420000
06-07 17:12:16.541+0200 I/gyroscope(17548): es.ugr.frailty.gyroscope - capturing data
06-07 17:12:16.551+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:533,0.839814,-1.060283,9.712924
06-07 17:12:16.551+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.561+0200 I/gravity (17469): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:12:16:562,0.843113,-1.051085,9.713638
06-07 17:12:16.561+0200 I/gravity (17469): es.ugr.frailty.gravity - capturing data
06-07 17:12:16.571+0200 I/linearacceleration(17504): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:12:16:527,0.050332,-0.019965,0.045727
06-07 17:12:16.571+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11176556c6f63152838433
