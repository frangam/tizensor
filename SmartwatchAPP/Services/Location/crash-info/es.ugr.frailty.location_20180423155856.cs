S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 20925
Date: 2018-04-23 15:58:56+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf743452d, r5   = 0xf78b8958
r6   = 0xfff00038, r7   = 0xffeffee8
r8   = 0xf78cbc18, r9   = 0x00000000
r10  = 0xffefffc4, fp   = 0xfff00038
ip   = 0x00000001, sp   = 0xffefed68
lr   = 0xf7434539, pc   = 0xf749d2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     10212 KB
Buffers:     58848 KB
Cached:     234372 KB
VmPeak:      52508 KB
VmSize:      52504 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11648 KB
VmRSS:       11648 KB
VmData:      10232 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 20925 TID = 20925
20925 20928 

Maps Information
f42ff000 f4afe000 rw-p [stack:20928]
f4b05000 f4b07000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4b0f000 f4b13000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4b1c000 f4b1e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4b26000 f4b29000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4b38000 f4b3d000 r-xp /usr/lib/libsystem.so.0.0.0
f4b48000 f4b4b000 r-xp /lib/libattr.so.1.1.0
f4b53000 f4b63000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b6b000 f4b74000 r-xp /usr/lib/libedbus.so.1.7.99
f4b7c000 f4b7d000 r-xp /usr/lib/libresponse.so.0.2.96
f4b86000 f4b8b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f642d000 f6533000 r-xp /usr/lib/libicuuc.so.57.1
f6549000 f66d1000 r-xp /usr/lib/libicui18n.so.57.1
f66e1000 f66ee000 r-xp /usr/lib/libail.so.0.1.0
f66f7000 f66fe000 r-xp /usr/lib/libminizip.so.1.0.0
f6707000 f68b0000 r-xp /usr/lib/libcrypto.so.1.0.0
f68d0000 f6917000 r-xp /usr/lib/libssl.so.1.0.0
f6923000 f6925000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f692d000 f6934000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f693d000 f6944000 r-xp /lib/libcrypt-2.13.so
f6975000 f6978000 r-xp /lib/libcap.so.2.21
f6980000 f6982000 r-xp /usr/lib/libiri.so
f698a000 f69d3000 r-xp /usr/lib/libmdm.so.1.2.69
f69db000 f69e1000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f69e9000 f6a0c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6a16000 f6a18000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a20000 f6a3d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a46000 f6a4a000 r-xp /usr/lib/libsmack.so.1.0.0
f6a53000 f6a6c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a75000 f6a7d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a85000 f6a8b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a94000 f6a96000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a9f000 f6aaf000 r-xp /lib/libresolv-2.13.so
f6ab3000 f6acb000 r-xp /usr/lib/liblzma.so.5.0.3
f6ad4000 f6ad6000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ade000 f6af8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b00000 f6b2f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b38000 f6b47000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b51000 f6b5b000 r-xp /usr/lib/libsensord-shared.so
f6b64000 f6c37000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c42000 f6c58000 r-xp /lib/libz.so.1.2.5
f6c60000 f6c65000 r-xp /usr/lib/libffi.so.5.0.10
f6c6d000 f6c6e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c76000 f6c86000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c8e000 f6ca7000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6caf000 f6cb1000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cb9000 f6d2e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d38000 f6d3e000 r-xp /lib/librt-2.13.so
f6d47000 f6d65000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d6f000 f6d70000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d78000 f6d9b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6da3000 f6da8000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6db0000 f6dda000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6de3000 f6dfa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e02000 f6e6b000 r-xp /lib/libm-2.13.so
f6e74000 f6f08000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f1b000 f6f20000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f28000 f6f2f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f37000 f6f61000 r-xp /usr/lib/libsensor.so.1.9.6
f6f6a000 f7036000 r-xp /usr/lib/libxml2.so.2.7.8
f7043000 f7045000 r-xp /usr/lib/libiniparser.so.0
f704e000 f7054000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f705d000 f712d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f712e000 f7162000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f716b000 f71a7000 r-xp /usr/lib/libSLP-location.so.0.9.24
f71af000 f71b2000 r-xp /usr/lib/libbundle.so.0.1.22
f71ba000 f71c0000 r-xp /usr/lib/libappsvc.so.0.1.0
f71c8000 f7209000 r-xp /usr/lib/libeina.so.1.7.99
f7212000 f7229000 r-xp /usr/lib/libecore.so.1.7.99
f7240000 f7249000 r-xp /usr/lib/libvconf.so.0.2.45
f7251000 f7265000 r-xp /lib/libpthread-2.13.so
f7270000 f727d000 r-xp /usr/lib/libaul.so.0.1.0
f7287000 f7289000 r-xp /lib/libdl-2.13.so
f7292000 f729d000 r-xp /lib/libunwind.so.8.0.1
f72ca000 f72d2000 r-xp /lib/libgcc_s-4.6.so.1
f72d3000 f73f7000 r-xp /lib/libc-2.13.so
f7405000 f7407000 r-xp /usr/lib/libdlog.so.0.0.0
f740f000 f741b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7424000 f7429000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7431000 f7440000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7448000 f744c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7455000 f7458000 r-xp /usr/lib/libappcore-agent.so.1.1
f7460000 f7462000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f746a000 f746e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7476000 f7493000 r-xp /lib/ld-2.13.so
f749c000 f749f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f749f000 f74a3000 r-xp /usr/lib/libsys-assert.so
f789b000 f7924000 rw-p [heap]
ffee1000 fff02000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20925)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf749d2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7434539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf713b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7139c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7145e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf714bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf714bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf718075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf717b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7139c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7145e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf714bbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf714bdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf717de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf717e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf71828d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf746c0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4b10171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6be3663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7090fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70927a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7222ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf721db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf721e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf721e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7456183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf74567fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf749d6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf72ea85c) [/lib/libc.so.6] + 0x1785c
29: (0xf749cfa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
19713): SM-R760,23/04/2018,15:58:17:528,0.420000,0.980000,1.750000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:47:845,-3.150000,-2.940000,-0.700000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:47:875,-6.090000,-2.730000,1.750000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:47:907,-2.520000,-5.880000,0.980000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:47:911,4.410000,-2.030000,0.910000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:47:935,-0.560000,-0.630000,0.210000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:47:939,-10.360000,-2.730000,1.400000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:47:957,-2.100000,-1.680000,0.070000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:47:980,5.530000,0.070000,-1.120000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:47:996,0.210000,-1.260000,-0.350000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:16,-2.730000,-2.730000,0.840000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:36,2.240000,0.560000,0.070000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:58,7.560000,0.560000,-0.630000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:79,7.840000,0.420000,-0.140000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:105,-0.210000,0.070000,0.420000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:159,-1.260000,-0.910000,1.050000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:163,2.870000,0.910000,0.350000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:227,1.260000,0.210000,0.770000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:230,2.520000,0.140000,0.700000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:261,6.440000,0.980000,-0.140000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:270,3.430000,-2.240000,0.210000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:280,0.770000,-1.190000,0.980000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:285,-2.310000,-0.910000,1.400000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:291,3.570000,-0.350000,0.840000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:298,8.680000,1.260000,0.280000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:317,11.200000,-1.540000,-0.770000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:351,10.990000,-0.140000,-0.350000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:401,6.090000,0.210000,-0.350000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:410,0.280000,0.140000,0.840000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:421,6.020000,-2.940000,0.770000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:437,5.880000,-2.940000,1.330000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:616,2.590000,0.840000,-0.420000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:48:838,10.500000,0.910000,-1.050000
04-23 15:59:10.141+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:49:20,1.680000,-0.420000,0.910000
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:49:223,43.610001,4.270000,-11.760000
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:49:425,-8.960000,5.180000,-2.380000
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:49:617,63.770000,9.520000,-2.730000
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:49:816,1.470000,0.280000,9.030000
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:50:17,6.650000,1.190000,13.930000
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:50:218,-29.820000,3.290000,21.490000
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:50:437,-52.290001,7.700000,16.379999
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:50:618,16.940001,-4.830000,-17.080000
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:50:814,32.830002,5.460000,-7.210000
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:15,26.460001,-3.500000,0.280000
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:215,22.049999,-2.380000,-1.540000
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:415,150.009995,-3.920000,-10.290000
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:436,135.660004,1.260000,-8.330000
04-23 15:59:10.151+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:456,101.010002,1.680000,-5.600000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:530,90.300003,-1.400000,-4.480000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:585,106.820000,1.260000,-6.090000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:589,129.149994,0.420000,-10.710000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:593,151.339996,-1.540000,-16.030001
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:629,166.320007,2.100000,-14.280000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:634,156.729996,1.820000,-17.219999
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:639,121.730003,1.400000,-16.590000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:644,81.340004,2.310000,-14.630000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:650,46.619999,0.630000,-13.160000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:656,25.760000,-0.560000,-10.500000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:682,20.020000,-0.700000,-6.510000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:696,31.010000,-1.400000,-4.830000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:721,25.620001,-2.030000,-4.200000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:736,-2.240000,-3.360000,-2.170000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:755,-16.520000,-2.520000,0.210000
04-23 15:59:10.161+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:776,-17.920000,-2.520000,1.050000
04-23 15:59:10.171+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:795,-44.240002,-3.780000,1.820000
04-23 15:59:10.171+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:815,-74.620003,-5.530000,4.620000
04-23 15:59:10.171+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:835,-70.840004,-4.200000,4.550000
04-23 15:59:10.171+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:856,-44.939999,-4.410000,6.020000
04-23 15:59:10.171+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:875,-40.810001,-4.550000,2.100000
04-23 15:59:10.171+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:895,-68.180000,-7.070000,1.890000
04-23 15:59:10.171+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:916,-78.540001,-12.040000,-0.770000
04-23 15:59:10.171+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:935,-60.200001,-9.310000,0.140000
04-23 15:59:10.171+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:956,-48.299999,-3.640000,-1.820000
04-23 15:59:10.171+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:976,-65.730003,-6.090000,-1.190000
04-23 15:59:10.181+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:51:995,-61.810001,-5.950000,-2.170000
04-23 15:59:10.181+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:16,-52.290001,-3.080000,-3.640000
04-23 15:59:10.181+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:59:10.181+0200 W/LOCATION(21145): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:59:10.181+0200 W/LOCATION(21145): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:10.181+0200 W/LOCATION(21145): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:10.181+0200 W/LOCATION(21145): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:10.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21133
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:36,-61.040001,-3.080000,-4.200000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:56,-78.889999,-4.900000,-3.850000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:75,-83.370003,-7.910000,-1.960000
04-23 15:59:10.191+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:95,-62.020000,-5.600000,-4.060000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:116,-50.959999,-3.220000,-5.460000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:137,-46.830002,-5.320000,-4.340000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:156,-40.880001,-5.040000,-6.440000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:175,-41.230000,-3.640000,-4.620000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:195,-34.720001,-2.450000,-3.290000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:216,-29.260000,-1.470000,-2.940000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:234,-29.260000,-2.450000,-1.120000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:260,-35.139999,-3.850000,-0.700000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:277,-38.990002,-5.040000,-0.070000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:314,-32.410000,-3.360000,-0.840000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:531,-36.330002,-3.710000,-3.710000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:587,-51.799999,-5.600000,-4.130000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:608,-54.389999,-8.260000,-3.290000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:642,-44.029999,-6.300000,-3.990000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:654,-31.500000,-4.480000,-5.390000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:694,-26.040001,-4.480000,-5.810000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:52:731,-39.130001,-2.310000,3.570000
04-23 15:59:10.191+0200 I/recorder(19713): obteniendo datos locales es.ugr.frailty.gyroscope
04-23 15:59:10.191+0200 I/recorder(19713): obteniendo datos locales, DATA: SM-R760,23/04/2018,15:58:12:925,-40.040001,31.500000,18.410000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:129,-3.430000,-0.560000,-1.890000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:326,-16.870001,2.170000,8.330000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:427,-44.170002,4.830000,8.960000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:449,-44.730000,2.450000,10.360000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:465,-58.590000,1.190000,9.940000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:485,-66.150002,-1.330000,9.380000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:508,-44.099998,0.560000,6.580000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:528,-43.540001,-1.680000,4.200000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:545,-55.860001,-5.110000,3.150000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:564,-51.939999,-2.520000,2.030000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:623,-41.160000,0.630000,0.910000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:638,-28.840000,0.910000,0.490000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:642,-0.560000,-0.420000,-0.420000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:691,9.520000,-4.200000,-1.400000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R760,23/04/2018,15:58:13:705,18.760000,-4.480000,-2.170000
04-23 15:59:10.191+0200 I/recorder(19713): SM-R7
04-23 15:59:10.191+0200 W/AUL     (19713): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:59:10.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:10.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:10.201+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:59:10.211+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:59:10.241+0200 I/heartrate(21133): es.ugr.frailty.heartrate listener destroyed
04-23 15:59:10.241+0200 I/utils   (21126): es.ugr.frailty.gyroscope listener started
04-23 15:59:10.241+0200 I/gyroscope(21126): stopping es.ugr.frailty.gyroscope service
04-23 15:59:10.241+0200 E/CAPI_APPFW_APP_CONTROL(21126): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:59:10.241+0200 E/gyroscope(21126): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:59:10.241+0200 I/CAPI_APPFW_APPLICATION(21126): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:59:10.291+0200 E/CAPI_APPFW_APPLICATION(21122): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:59:10.291+0200 E/CAPI_APPFW_APPLICATION(21122): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:59:10.291+0200 I/utils   (21122): trying to start service: es.ugr.frailty.accelerometer
04-23 15:59:10.331+0200 I/utils   (21122): es.ugr.frailty.accelerometer sensor supported
04-23 15:59:10.361+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:59:10.371+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:59:10.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:10.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:10.411+0200 I/gyroscope(21126): es.ugr.frailty.gyroscope listener destroyed
04-23 15:59:10.411+0200 E/AUL     ( 2476): app_sock.c: __app_recv_raw(518) > recv error: 4
04-23 15:59:10.421+0200 W/AUL     (21173): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 15:59:10.421+0200 I/utils   (21122): es.ugr.frailty.accelerometer listener started
04-23 15:59:10.421+0200 I/accelerometer(21122): stopping es.ugr.frailty.accelerometer service
04-23 15:59:10.421+0200 E/CAPI_APPFW_APP_CONTROL(21122): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:59:10.421+0200 E/accelerometer(21122): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:59:10.421+0200 I/CAPI_APPFW_APPLICATION(21122): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:59:10.451+0200 W/LOCATION(21145): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:59:10.471+0200 W/LOCATION(21145): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 15:59:10.491+0200 W/LOCATION(21145): module-internal.c: module_new(311) > module (wps) open success
04-23 15:59:10.511+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:59:10.531+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 15:59:10.541+0200 W/LOCATION(21145): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 15:59:10.541+0200 W/LOCATION(21145): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 15:59:10.541+0200 W/LOCATION(21145): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:59:10.541+0200 W/LOCATION(21145): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:59:10.541+0200 I/accelerometer(21122): es.ugr.frailty.accelerometer listener destroyed
04-23 15:59:10.551+0200 E/AUL     ( 2476): app_sock.c: __app_recv_raw(518) > recv error: 4
04-23 15:59:10.561+0200 W/AUL     (21175): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 15:59:10.581+0200 W/LOCATION(21145): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 15:59:10.581+0200 I/LOCATION(21145): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf746ac18
04-23 15:59:10.581+0200 I/LOCATION(21145): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 15:59:10.581+0200 I/LOCATION(21145): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf746ac18
04-23 15:59:10.581+0200 I/LOCATION(21145): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 15:59:10.591+0200 I/location(21145): es.ugr.frailty.location: creado servicio de localización
04-23 15:59:10.601+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:10.601+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:10.631+0200 E/AUL     ( 2476): app_sock.c: __app_recv_raw(524) > recv error 0 0
04-23 15:59:10.631+0200 E/AUL_AMD ( 2476): amd_request.c: __request_handler(665) > recv error
04-23 15:59:10.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:59:10.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:59:10.641+0200 W/AUL     (21178): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 15:59:10.651+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 15:59:10.651+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:59:10.651+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19713), cmd(0)
04-23 15:59:10.651+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21122) was created
04-23 15:59:10.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21145
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21133
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21126
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 18814
04-23 15:59:10.661+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:59:10.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:59:10.681+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21133
04-23 15:59:10.681+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21133)
04-23 15:59:10.681+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21126
04-23 15:59:10.681+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21126)
04-23 15:59:10.681+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 18814
04-23 15:59:10.681+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(18814)
04-23 15:59:10.701+0200 W/AUL     (21179): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 15:59:10.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:59:10.701+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:59:10.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21122
04-23 15:59:10.701+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:59:10.711+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21122
04-23 15:59:10.711+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21122)
04-23 15:59:10.741+0200 I/LOCATION(21145): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 15:59:10.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:10.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:10.821+0200 W/LOCATION(21145): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:10.821+0200 W/LOCATION(21145): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:10.821+0200 I/LOCATION(21145): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:59:10.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 15:59:10.911+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 15:59:10.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 15:59:10.911+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 15:59:10.911+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 15:59:10.911+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 15:59:10.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:59:10.911+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 15:59:10.911+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 15:59:10.911+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 15:59:10.911+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 15:59:10.921+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 15:59:10.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 15:59:10.921+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 15:59:10.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 15:59:10.921+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 15:59:10.921+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 15:59:10.921+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 15:59:10.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:10.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:11.011+0200 W/LOCATION(21145): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 15:59:11.011+0200 W/LOCATION(21145): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 15:59:11.111+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:11.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7332cc8]
04-23 15:59:11.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:59:11.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:59:11.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:59:11.161+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:59:11.161+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 15:59:11.161+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5846823), time2(5841739)
04-23 15:59:11.161+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 15:59:11.161+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 15:59:11.161+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 15:59:11.161+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 15:59:11.171+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:11.171+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:11.181+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:11.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:11.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:11.191+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:11.191+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:59:11.191+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:59:11.191+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:11.191+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:59:11.191+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:59:11.191+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:59:11.191+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:11.191+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:11.191+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:11.201+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:11.211+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:11.211+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:59:11.221+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:11.261+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:11.301+0200 W/LOCATION(21145): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:59:11.311+0200 I/LOCATION(21145): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 15:59:11.311+0200 I/LOCATION(21145): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 15:59:11.321+0200 I/location(21145): es.ugr.frailty.location:iniciado servicio de localización
04-23 15:59:11.371+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 15:59:11.371+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 15:59:11.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:59:11.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 15:59:11.381+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:59:11.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:11.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:11.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:11.401+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:11.401+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 15:59:11.401+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 15:59:11.401+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:59:11.531+0200 I/LOCATION(21145): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 15:59:11.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:11.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:11.601+0200 W/AUL     (21145): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 15:59:11.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:59:11.611+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 21145
04-23 15:59:11.611+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 15:59:11.621+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.621+0200 I/utils   (19708): specific action
04-23 15:59:11.621+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.621+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.621+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.621+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 15:59:11.621+0200 W/AUL     (21145): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 15:59:11.621+0200 I/location(21145): request sent to service es.ugr.frailty.servicemanager
04-23 15:59:11.621+0200 I/location(21145): stopping es.ugr.frailty.location service
04-23 15:59:11.621+0200 E/CAPI_APPFW_APP_CONTROL(21145): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 15:59:11.621+0200 E/location(21145): request sending failed to service es.ugr.frailty.servicemanager
04-23 15:59:11.621+0200 I/CAPI_APPFW_APPLICATION(21145): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 15:59:11.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 15:59:11.631+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 15:59:11.641+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 21185
04-23 15:59:11.641+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 15:59:11.681+0200 E/CAPI_APPFW_APPLICATION(21185): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:59:11.681+0200 E/CAPI_APPFW_APPLICATION(21185): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 15:59:11.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.681+0200 I/utils   (21185): specific action
04-23 15:59:11.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.681+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 15:59:11.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 21185
04-23 15:59:11.701+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(21185) type(svcapp) bg(0)
04-23 15:59:11.701+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 15:59:11.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 15:59:11.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 15:59:11.701+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 15:59:11.701+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (21185) was created
04-23 15:59:11.701+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 15:59:11.701+0200 I/recorder(21185): guardando datos en local
04-23 15:59:11.701+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [21185]
04-23 15:59:11.711+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 15:59:11.711+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 15:59:11.711+0200 I/servicemanager(19708): requesting to save local data
04-23 15:59:11.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:59:11.731+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21185
04-23 15:59:11.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:59:11.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 15:59:11.741+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21185
04-23 15:59:11.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 15:59:11.791+0200 W/LOCATION(21145): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 15:59:11.791+0200 I/LOCATION(21145): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 15:59:11.791+0200 I/LOCATION(21145): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 15:59:11.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:11.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:11.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 15:59:11.881+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 15:59:11.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 15:59:11.881+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 15:59:11.881+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 15:59:11.881+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 15:59:11.881+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 15:59:11.881+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 15:59:11.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 15:59:11.931+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:59:11.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:11.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:12.001+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:12.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:59:12.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:59:12.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:59:12.051+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7332cc8
04-23 15:59:12.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7346040]
04-23 15:59:12.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:59:12.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:59:12.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:59:12.131+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:59:12.141+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:12.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:12.151+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.161+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:59:12.161+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:59:12.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:12.161+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:59:12.161+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:59:12.161+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:59:12.161+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:12.161+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:12.161+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:12.171+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.171+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.171+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:59:12.181+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:12.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:12.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:12.231+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:12.241+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:12.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:59:12.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:59:12.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:59:12.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7346040
04-23 15:59:12.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:12.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:12.391+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73b2f08]
04-23 15:59:12.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 15:59:12.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 15:59:12.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 15:59:12.401+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 15:59:12.401+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:12.401+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:12.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.431+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.431+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 15:59:12.431+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 15:59:12.431+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 15:59:12.431+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 15:59:12.431+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 15:59:12.431+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 15:59:12.431+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 15:59:12.431+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 15:59:12.431+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 15:59:12.441+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 15:59:12.451+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 15:59:12.451+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:12.501+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 15:59:12.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 15:59:12.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 15:59:12.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 15:59:12.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73b2f08
04-23 15:59:12.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:12.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:12.631+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:59:12.661+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 15:59:12.691+0200 W/AUL     (21192): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 15:59:12.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 15:59:12.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 15:59:12.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21079
04-23 15:59:12.691+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 15:59:12.701+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21079
04-23 15:59:12.701+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21079)
04-23 15:59:12.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:12.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:12.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:12.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:13.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 15:59:13.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 15:59:13.371+0200 W/CRASH_MANAGER(19814): worker.c: worker_job(1205) > 11209256c6f63152449193
