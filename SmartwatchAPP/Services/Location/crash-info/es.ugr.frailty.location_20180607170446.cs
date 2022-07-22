S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 15450
Date: 2018-06-07 17:04:46+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf715852d, r5   = 0xf76fcf98
r6   = 0xff9a6a10, r7   = 0xff9a68c0
r8   = 0xf76f9c18, r9   = 0x00000000
r10  = 0xff9a699c, fp   = 0xff9a6a10
ip   = 0x00000001, sp   = 0xff9a6898
lr   = 0xf7158539, pc   = 0xf71c1228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     50468 KB
Buffers:     12844 KB
Cached:      67680 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11696 KB
VmRSS:       11696 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 15450 TID = 15450
15450 15454 

Maps Information
f4023000 f4822000 rw-p [stack:15454]
f4829000 f482b000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4833000 f4837000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4840000 f4842000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f484a000 f484d000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f485c000 f4861000 r-xp /usr/lib/libsystem.so.0.0.0
f486c000 f486f000 r-xp /lib/libattr.so.1.1.0
f4877000 f4887000 r-xp /usr/lib/libmdm-common.so.1.1.24
f488f000 f4898000 r-xp /usr/lib/libedbus.so.1.7.99
f48a0000 f48a1000 r-xp /usr/lib/libresponse.so.0.2.96
f48aa000 f48af000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6151000 f6257000 r-xp /usr/lib/libicuuc.so.57.1
f626d000 f63f5000 r-xp /usr/lib/libicui18n.so.57.1
f6405000 f6412000 r-xp /usr/lib/libail.so.0.1.0
f641b000 f6422000 r-xp /usr/lib/libminizip.so.1.0.0
f642b000 f65d4000 r-xp /usr/lib/libcrypto.so.1.0.0
f65f4000 f663b000 r-xp /usr/lib/libssl.so.1.0.0
f6647000 f6649000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6651000 f6658000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6661000 f6668000 r-xp /lib/libcrypt-2.13.so
f6699000 f669c000 r-xp /lib/libcap.so.2.21
f66a4000 f66a6000 r-xp /usr/lib/libiri.so
f66ae000 f66f7000 r-xp /usr/lib/libmdm.so.1.2.69
f66ff000 f6705000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f670d000 f6730000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f673a000 f673c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6744000 f6761000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f676a000 f676e000 r-xp /usr/lib/libsmack.so.1.0.0
f6777000 f6790000 r-xp /usr/lib/libnetwork.so.0.0.0
f6799000 f67a1000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67a9000 f67af000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67b8000 f67ba000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67c3000 f67d3000 r-xp /lib/libresolv-2.13.so
f67d7000 f67ef000 r-xp /usr/lib/liblzma.so.5.0.3
f67f8000 f67fa000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6802000 f681c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6824000 f6853000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f685c000 f686b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6875000 f687f000 r-xp /usr/lib/libsensord-shared.so
f6888000 f695b000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6966000 f697c000 r-xp /lib/libz.so.1.2.5
f6984000 f6989000 r-xp /usr/lib/libffi.so.5.0.10
f6991000 f6992000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f699a000 f69aa000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69b2000 f69cb000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69d3000 f69d5000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69dd000 f6a52000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a5c000 f6a62000 r-xp /lib/librt-2.13.so
f6a6b000 f6a89000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a93000 f6a94000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a9c000 f6abf000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ac7000 f6acc000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ad4000 f6afe000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b07000 f6b1e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b26000 f6b8f000 r-xp /lib/libm-2.13.so
f6b98000 f6c2c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c3f000 f6c44000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c4c000 f6c53000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c5b000 f6c85000 r-xp /usr/lib/libsensor.so.1.9.6
f6c8e000 f6d5a000 r-xp /usr/lib/libxml2.so.2.7.8
f6d67000 f6d69000 r-xp /usr/lib/libiniparser.so.0
f6d72000 f6d78000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d81000 f6e51000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e52000 f6e86000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e8f000 f6ecb000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6ed3000 f6ed6000 r-xp /usr/lib/libbundle.so.0.1.22
f6ede000 f6ee4000 r-xp /usr/lib/libappsvc.so.0.1.0
f6eec000 f6f2d000 r-xp /usr/lib/libeina.so.1.7.99
f6f36000 f6f4d000 r-xp /usr/lib/libecore.so.1.7.99
f6f64000 f6f6d000 r-xp /usr/lib/libvconf.so.0.2.45
f6f75000 f6f89000 r-xp /lib/libpthread-2.13.so
f6f94000 f6fa1000 r-xp /usr/lib/libaul.so.0.1.0
f6fab000 f6fad000 r-xp /lib/libdl-2.13.so
f6fb6000 f6fc1000 r-xp /lib/libunwind.so.8.0.1
f6fee000 f6ff6000 r-xp /lib/libgcc_s-4.6.so.1
f6ff7000 f711b000 r-xp /lib/libc-2.13.so
f7129000 f712b000 r-xp /usr/lib/libdlog.so.0.0.0
f7133000 f713f000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7148000 f714d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7155000 f7164000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f716c000 f7170000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7179000 f717c000 r-xp /usr/lib/libappcore-agent.so.1.1
f7184000 f7186000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f718e000 f7192000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f719a000 f71b7000 r-xp /lib/ld-2.13.so
f71c0000 f71c3000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71c3000 f71c7000 r-xp /usr/lib/libsys-assert.so
f76c9000 f7757000 rw-p [heap]
ff988000 ff9a9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15450)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf71c1228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7158539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e5f3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e5dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e69e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e6fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e6fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6ea475b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e9f1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e5dc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e69e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e6fbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e6fdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ea1e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6ea2017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6ea9f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf48411fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4834171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6907663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6db4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6db67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f46ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f41b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f425a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f42879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf717a183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf717a7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71c15c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf700e85c) [/lib/libc.so.6] + 0x1785c
29: (0xf71c0f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
eter - capturing data
06-07 17:04:46.431+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:437,1.684547,-1.217947,9.616754
06-07 17:04:46.431+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:429,-0.009635,-0.000288,0.110210
06-07 17:04:46.431+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:46.431+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.441+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.441+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:445,0.070000,-0.140000,-0.840000
06-07 17:04:46.441+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.441+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:46:444,77
06-07 17:04:46.441+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:437,1.671316,-1.204886,9.587770
06-07 17:04:46.441+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:450,2.380000,0.630000,-0.560000
06-07 17:04:46.441+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.451+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:445,0.005659,-0.011950,0.031119
06-07 17:04:46.451+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.451+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.451+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.451+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:459,1.673159,-1.210061,9.586797
06-07 17:04:46.451+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:461,1.674976,-1.201197,9.681360
06-07 17:04:46.461+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.461+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:460,0.025435,0.009388,0.019020
06-07 17:04:46.461+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.461+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:470,0.022516,0.010533,0.062029
06-07 17:04:46.461+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.471+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:470,1.672409,-1.208100,9.587175
06-07 17:04:46.471+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:475,1.768296,-1.153341,9.712467
06-07 17:04:46.471+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:455,1.120000,0.630000,-0.490000
06-07 17:04:46.471+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:04:46.471+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(15350), cmd(0)
06-07 17:04:46.471+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.481+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.481+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:488,0.025454,0.013490,0.119136
06-07 17:04:46.481+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.481+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:485,1.669312,-1.204725,9.588140
06-07 17:04:46.481+0200 W/CAPI_APPFW_APP_CONTROL(15350): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:04:46.481+0200 I/utils   (15350): specific action
06-07 17:04:46.481+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.491+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.491+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:496,1.701297,-1.165305,9.628718
06-07 17:04:46.491+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.491+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:495,-0.070000,-0.280000,0.280000
06-07 17:04:46.491+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.501+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:500,1.669721,-1.205393,9.587984
06-07 17:04:46.501+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:504,-0.350000,-0.630000,0.490000
06-07 17:04:46.501+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.501+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:509,0.140000,-0.420000,0.490000
06-07 17:04:46.501+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.501+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.511+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.511+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:513,1.669718,-1.208150,9.587638
06-07 17:04:46.511+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:516,1.655833,-1.165305,9.619147
06-07 17:04:46.511+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:492,0.055812,-0.023201,0.104099
06-07 17:04:46.511+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.511+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.521+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:523,-0.000420,-0.113877,0.133053
06-07 17:04:46.521+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.521+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:528,0.053468,-0.028305,0.051996
06-07 17:04:46.521+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.521+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:525,1.669461,-1.206839,9.587848
06-07 17:04:46.521+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.531+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.531+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:537,1.718047,-1.172483,9.655040
06-07 17:04:46.531+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:514,0.490000,-0.350000,0.420000
06-07 17:04:46.531+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.531+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:541,1.669640,-1.205994,9.587923
06-07 17:04:46.541+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:544,0.910000,-0.350000,0.140000
06-07 17:04:46.541+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.541+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.541+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:549,0.700000,0.070000,0.350000
06-07 17:04:46.541+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.551+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:532,0.035777,-0.022138,0.054430
06-07 17:04:46.551+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:549,1.671320,-1.205189,9.587731
06-07 17:04:46.551+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.551+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.551+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.551+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:562,1.746760,-1.179662,9.681360
06-07 17:04:46.561+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:558,-0.002985,-0.013180,0.028117
06-07 17:04:46.561+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.561+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:561,1.671494,-1.203318,9.587936
06-07 17:04:46.561+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:568,-0.024735,0.028351,0.061759
06-07 17:04:46.561+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.561+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.561+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.571+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:574,1.673501,-1.207274,9.587089
06-07 17:04:46.571+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.571+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:575,1.751546,-1.134198,9.638289
06-07 17:04:46.571+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:554,-0.910000,0.490000,0.560000
06-07 17:04:46.571+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:580,1.672554,-1.211324,9.586743
06-07 17:04:46.571+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.581+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.581+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:585,-1.750000,0.140000,0.630000
06-07 17:04:46.581+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:586,1.671372,-1.208689,9.587281
06-07 17:04:46.581+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.581+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.581+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:46.591+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:46:595,576.000000
06-07 17:04:46.591+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:592,1.671951,-1.204870,9.587662
06-07 17:04:46.591+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.601+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.601+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:603,1.671546,-1.205682,9.587630
06-07 17:04:46.601+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.601+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:606,1.667797,-1.225125,9.695717
06-07 17:04:46.601+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:609,1.671672,-1.205531,9.587626
06-07 17:04:46.601+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:573,0.017014,0.020179,0.102127
06-07 17:04:46.601+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.611+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.611+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.611+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:616,1.698904,-1.222732,9.607183
06-07 17:04:46.611+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:615,0.041521,0.037518,0.077876
06-07 17:04:46.621+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:590,-0.910000,0.210000,0.630000
06-07 17:04:46.621+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.631+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.631+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.631+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:637,1.749153,-1.122234,9.669396
06-07 17:04:46.641+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:616,1.671765,-1.204840,9.587698
06-07 17:04:46.641+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.651+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:655,1.671969,-1.204568,9.587696
06-07 17:04:46.651+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.661+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:664,1.673240,-1.203902,9.587558
06-07 17:04:46.661+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.671+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:46.671+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.681+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:46:678,77
06-07 17:04:46.681+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:680,1.682154,-1.174876,9.681360
06-07 17:04:46.691+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:636,-0.037726,-0.008885,0.058374
06-07 17:04:46.691+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.691+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.701+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:674,1.674518,-1.206662,9.586988
06-07 17:04:46.701+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:629,0.560000,0.840000,-0.140000
06-07 17:04:46.701+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.711+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.711+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:704,1.746760,-1.146162,9.695717
06-07 17:04:46.711+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.711+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:719,1.751546,-1.215554,9.667004
06-07 17:04:46.711+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.721+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:724,1.737189,-1.234696,9.652647
06-07 17:04:46.721+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:713,-0.350000,0.560000,-0.070000
06-07 17:04:46.731+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.731+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:701,-0.016911,0.006190,0.058168
06-07 17:04:46.731+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.731+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:720,1.676457,-1.209983,9.586230
06-07 17:04:46.731+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:739,1.720440,-1.201197,9.674182
06-07 17:04:46.731+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.741+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.751+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:750,0.015411,0.010304,0.055481
06-07 17:04:46.751+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.761+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:764,1.670190,-1.165305,9.659825
06-07 17:04:46.761+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:749,-1.400000,0.210000,0.210000
06-07 17:04:46.761+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:758,1.676455,-1.209976,9.586232
06-07 17:04:46.761+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.771+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.771+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.771+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.781+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:779,1.646262,-1.112662,9.676575
06-07 17:04:46.781+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:778,-0.019491,-0.003847,0.023934
06-07 17:04:46.781+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.781+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:790,0.055928,-0.008330,0.066824
06-07 17:04:46.791+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:46.791+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.791+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:46:797,575.000000
06-07 17:04:46.791+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:774,-0.630000,0.210000,0.350000
06-07 17:04:46.791+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.791+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.801+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:803,0.026482,0.030917,0.077061
06-07 17:04:46.801+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.801+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:787,1.674319,-1.209573,9.586656
06-07 17:04:46.811+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:810,0.041139,0.023273,0.045552
06-07 17:04:46.811+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.811+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.811+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:797,1.708475,-1.127020,9.667004
06-07 17:04:46.811+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.811+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:818,0.010948,0.040735,0.095856
06-07 17:04:46.811+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.821+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:824,-0.025596,0.034520,0.100581
06-07 17:04:46.821+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:803,-0.070000,0.070000,0.280000
06-07 17:04:46.821+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.821+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.821+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:830,-0.030270,0.024357,0.054316
06-07 17:04:46.831+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.831+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:816,1.675341,-1.209151,9.586531
06-07 17:04:46.831+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:46.841+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:46:844,77
06-07 17:04:46.841+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:839,0.008708,0.040561,0.022314
06-07 17:04:46.851+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:819,1.691726,-1.112662,9.635897
06-07 17:04:46.851+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.851+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.851+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.861+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:864,0.009659,-0.072008,0.094337
06-07 17:04:46.861+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.861+0200 W/LOCATION(15450): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:04:46.871+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:862,1.676392,-1.207718,9.586528
06-07 17:04:46.871+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.881+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:880,0.018149,-0.038008,0.116703
06-07 17:04:46.881+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.891+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:830,-0.490000,-0.070000,0.140000
06-07 17:04:46.891+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.891+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:895,0.088249,0.048906,0.037710
06-07 17:04:46.891+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.891+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:858,1.698904,-1.155733,9.652647
06-07 17:04:46.891+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.901+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:903,1.710868,-1.217947,9.669396
06-07 17:04:46.901+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.901+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:898,0.210000,-0.070000,-0.350000
06-07 17:04:46.901+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.901+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:902,0.077935,-0.061560,0.069028
06-07 17:04:46.911+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.911+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:908,1.713261,-1.213161,9.702895
06-07 17:04:46.911+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.921+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:882,1.678024,-1.207887,9.586221
06-07 17:04:46.921+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:918,0.035762,-0.006935,0.046314
06-07 17:04:46.921+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.921+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.921+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:910,0.560000,0.560000,-0.070000
06-07 17:04:46.921+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.931+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:930,0.052242,0.020896,0.031898
06-07 17:04:46.931+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.941+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:927,1.677020,-1.208818,9.586279
06-07 17:04:46.941+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.941+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:948,1.677610,-1.211358,9.585855
06-07 17:04:46.941+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.941+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:944,0.047853,-0.013486,0.091962
06-07 17:04:46.941+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.951+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:955,0.011870,0.003269,0.008943
06-07 17:04:46.951+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:920,1.715654,-1.234696,9.645468
06-07 17:04:46.961+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.961+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:933,-0.350000,0.140000,-0.280000
06-07 17:04:46.961+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.971+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:970,1.753939,-1.198804,9.669396
06-07 17:04:46.971+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.971+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.981+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:977,1.732404,-1.170090,9.600004
06-07 17:04:46.981+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:968,0.005332,-0.028468,0.040574
06-07 17:04:46.981+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:46.981+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:46.981+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:46:978,-0.350000,-0.140000,-0.070000
06-07 17:04:46.981+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:46.991+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:46.991+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:46:953,1.679584,-1.214253,9.585143
06-07 17:04:46.991+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:46:996,575.000000
06-07 17:04:46.991+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:46.991+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:46:988,-0.012595,-0.017873,0.026843
06-07 17:04:47.001+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:4,-0.280000,0.350000,-0.070000
06-07 17:04:47.001+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:46:987,1.720440,-1.177269,9.633504
06-07 17:04:47.001+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.001+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.011+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:1,1.681188,-1.214591,9.584820
06-07 17:04:47.011+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.011+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.011+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:11,1.734797,-1.174876,9.676575
06-07 17:04:47.011+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.021+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:16,0.001445,-0.092177,0.106140
06-07 17:04:47.021+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:24,-1.050000,-0.210000,0.280000
06-07 17:04:47.021+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.021+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:18,1.682322,-1.213156,9.584802
06-07 17:04:47.031+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:25,1.627119,-1.124627,9.681360
06-07 17:04:47.031+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.031+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.031+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:47.041+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:47:43,77
06-07 17:04:47.041+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.041+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:39,1.653440,-1.182054,9.640682
06-07 17:04:47.051+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:34,-0.041757,-0.026561,0.114055
06-07 17:04:47.051+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.051+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:04:47.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:04:47.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:04:47.061+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:48,0.280000,-0.070000,-0.070000
06-07 17:04:47.061+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:51,1.676850,-1.211190,9.586009
06-07 17:04:47.061+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.071+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.071+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:62,-0.088714,0.058048,0.144685
06-07 17:04:47.081+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.081+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:82,1.120000,-0.140000,0.070000
06-07 17:04:47.091+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:61,1.667797,-1.177269,9.690931
06-07 17:04:47.091+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.091+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:74,1.676842,-1.211592,9.585960
06-07 17:04:47.091+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.091+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.091+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:96,1.720440,-1.177269,9.652647
06-07 17:04:47.101+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:95,-0.025804,0.106557,0.037211
06-07 17:04:47.101+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:101,1.677407,-1.213018,9.585681
06-07 17:04:47.101+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.101+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:101,0.910000,-0.420000,-0.210000
06-07 17:04:47.101+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.111+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.111+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.121+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:115,1.737189,-1.177269,9.633504
06-07 17:04:47.121+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:112,0.013122,0.022478,-0.030526
06-07 17:04:47.121+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.121+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.121+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:122,0.770000,0.140000,-0.140000
06-07 17:04:47.131+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:120,1.674733,-1.209780,9.586557
06-07 17:04:47.131+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.131+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.131+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:140,-0.210000,-0.280000,0.070000
06-07 17:04:47.141+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:128,1.696511,-1.127020,9.681360
06-07 17:04:47.141+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.141+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:131,0.077871,-0.027249,0.053681
06-07 17:04:47.141+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.141+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:148,1.682154,-1.158126,9.640682
06-07 17:04:47.141+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.151+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.151+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:152,0.038730,-0.044832,0.042480
06-07 17:04:47.161+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:139,1.674612,-1.205534,9.587113
06-07 17:04:47.161+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.161+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:161,-0.910000,-0.280000,0.070000
06-07 17:04:47.161+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.171+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.171+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:175,1.677019,-1.208512,9.586318
06-07 17:04:47.181+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:152,1.722832,-1.107877,9.602397
06-07 17:04:47.181+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.181+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:173,0.061396,0.062501,0.059703
06-07 17:04:47.181+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.181+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:181,0.280000,0.070000,0.070000
06-07 17:04:47.191+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:47.191+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.191+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:47:196,573.000000
06-07 17:04:47.191+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:186,1.763510,-1.160519,9.678967
06-07 17:04:47.191+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.191+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.201+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:191,0.005059,0.134327,0.025853
06-07 17:04:47.201+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:204,1.753939,-1.232304,9.702895
06-07 17:04:47.201+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.211+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.211+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:206,0.560000,-0.070000,-0.070000
06-07 17:04:47.211+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:196,1.679187,-1.210517,9.585686
06-07 17:04:47.211+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.211+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.221+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:221,1.682337,-1.214705,9.584603
06-07 17:04:47.221+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.221+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:218,-0.021147,0.036884,0.051360
06-07 17:04:47.231+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.231+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:210,1.715654,-1.198804,9.678967
06-07 17:04:47.231+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.231+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:47.241+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:04:47:244,77
06-07 17:04:47.241+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:230,0.140000,0.070000,-0.210000
06-07 17:04:47.241+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.241+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:233,1.679112,-1.213573,9.585312
06-07 17:04:47.251+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:240,1.679761,-1.143769,9.647861
06-07 17:04:47.251+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.251+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:240,-0.017968,-0.039929,0.103835
06-07 17:04:47.251+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:255,0.140000,-0.350000,-0.210000
06-07 17:04:47.261+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.261+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.261+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.271+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:267,-0.024350,-0.067349,0.063465
06-07 17:04:47.271+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:256,1.694118,-1.129412,9.652647
06-07 17:04:47.271+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.271+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.271+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:281,1.701297,-1.095913,9.643075
06-07 17:04:47.281+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:278,0.840000,0.070000,0.140000
06-07 17:04:47.281+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:268,1.676192,-1.211950,9.586028
06-07 17:04:47.281+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.281+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.291+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:288,0.020096,-0.055969,0.116377
06-07 17:04:47.291+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.291+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:294,1.713261,-1.165305,9.640682
06-07 17:04:47.301+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.301+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:292,1.674965,-1.212690,9.586149
06-07 17:04:47.301+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:299,0.840000,-0.070000,0.070000
06-07 17:04:47.301+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.311+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.311+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.311+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:320,0.840000,-0.420000,0.070000
06-07 17:04:47.311+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:308,-0.012918,-0.092225,0.023220
06-07 17:04:47.321+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:310,1.674391,-1.214721,9.585993
06-07 17:04:47.321+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.321+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:329,0.023356,-0.089524,-0.012115
06-07 17:04:47.321+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:317,1.713261,-1.215554,9.664611
06-07 17:04:47.321+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.331+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.331+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.331+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:337,1.674517,-1.213003,9.586188
06-07 17:04:47.331+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.331+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:04:47.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391087348,000000, pattern:[H:mm][0;m
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:04:47.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:04:47.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:04:47.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:04][0;m
06-07 17:04:47.341+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:335,1.753939,-1.189233,9.647861
06-07 17:04:47.341+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.351+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:337,-0.210000,0.420000,0.070000
06-07 17:04:47.351+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:354,1.741975,-1.160519,9.631111
06-07 17:04:47.351+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:342,1.672496,-1.214989,9.586289
06-07 17:04:47.351+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.361+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:366,0.028877,-0.040146,0.096335
06-07 17:04:47.371+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.381+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.361+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:361,1.696511,-1.213161,9.647861
06-07 17:04:47.381+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.381+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.391+0200 I/light   (14648): es.ugr.frailty.light - capturing data
06-07 17:04:47.391+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:394,1.691726,-1.150948,9.690931
06-07 17:04:47.401+0200 I/light   (14648): es.ugr.frailty.light: SM-R760,07/06/2018,17:04:47:397,572.000000
06-07 17:04:47.401+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:387,0.006618,0.137414,0.085521
06-07 17:04:47.401+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:385,1.673319,-1.212992,9.586398
06-07 17:04:47.411+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:390,0.210000,-0.070000,0.070000
06-07 17:04:47.411+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.411+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.421+0200 I/gravity (15326): es.ugr.frailty.gravity - capturing data
06-07 17:04:47.421+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.441+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:425,1.679761,-1.205983,9.655040
06-07 17:04:47.441+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.441+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:446,1.730011,-1.148555,9.667004
06-07 17:04:47.441+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer - capturing data
06-07 17:04:47.441+0200 I/accelerometer(15494): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:04:47:450,1.727618,-1.184447,9.638289
06-07 17:04:47.451+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:04:47:430,0.047780,0.027022,0.117305
06-07 17:04:47.451+0200 I/linearacceleration(15364): es.ugr.frailty.linearacceleration - capturing data
06-07 17:04:47.451+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:04:47.451+0200 I/gravity (15326): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:04:47:429,1.672482,-1.211632,9.586717
06-07 17:04:47.451+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:04:47:419,0.700000,-0.140000,0.210000
06-07 17:04:47.451+0200 I/gyroscope(15350): es.ugr.frailty.gyroscope - capturing data
06-07 17:04:47.461+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11154506c6f63152838388
