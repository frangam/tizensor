S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 24519
Date: 2018-04-23 16:04:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf739e52d, r5   = 0xf7916f98
r6   = 0xff83e578, r7   = 0xff83e428
r8   = 0xf7913c18, r9   = 0x00000000
r10  = 0xff83e504, fp   = 0xff83e578
ip   = 0x00000001, sp   = 0xff83d2a8
lr   = 0xf739e539, pc   = 0xf74072b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     13176 KB
Buffers:     62048 KB
Cached:     222260 KB
VmPeak:      53468 KB
VmSize:      53404 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12180 KB
VmRSS:       12180 KB
VmData:      11132 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 24519 TID = 24519
24519 24522 

Maps Information
f4269000 f4a68000 rw-p [stack:24522]
f4a6f000 f4a71000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a79000 f4a7d000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a86000 f4a88000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a90000 f4a93000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4aa2000 f4aa7000 r-xp /usr/lib/libsystem.so.0.0.0
f4ab2000 f4ab5000 r-xp /lib/libattr.so.1.1.0
f4abd000 f4acd000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4ad5000 f4ade000 r-xp /usr/lib/libedbus.so.1.7.99
f4ae6000 f4ae7000 r-xp /usr/lib/libresponse.so.0.2.96
f4af0000 f4af5000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6397000 f649d000 r-xp /usr/lib/libicuuc.so.57.1
f64b3000 f663b000 r-xp /usr/lib/libicui18n.so.57.1
f664b000 f6658000 r-xp /usr/lib/libail.so.0.1.0
f6661000 f6668000 r-xp /usr/lib/libminizip.so.1.0.0
f6671000 f681a000 r-xp /usr/lib/libcrypto.so.1.0.0
f683a000 f6881000 r-xp /usr/lib/libssl.so.1.0.0
f688d000 f688f000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6897000 f689e000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68a7000 f68ae000 r-xp /lib/libcrypt-2.13.so
f68df000 f68e2000 r-xp /lib/libcap.so.2.21
f68ea000 f68ec000 r-xp /usr/lib/libiri.so
f68f4000 f693d000 r-xp /usr/lib/libmdm.so.1.2.69
f6945000 f694b000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6953000 f6976000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6980000 f6982000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f698a000 f69a7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69b0000 f69b4000 r-xp /usr/lib/libsmack.so.1.0.0
f69bd000 f69d6000 r-xp /usr/lib/libnetwork.so.0.0.0
f69df000 f69e7000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f69ef000 f69f5000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f69fe000 f6a00000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a09000 f6a19000 r-xp /lib/libresolv-2.13.so
f6a1d000 f6a35000 r-xp /usr/lib/liblzma.so.5.0.3
f6a3e000 f6a40000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a48000 f6a62000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a6a000 f6a99000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6aa2000 f6ab1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6abb000 f6ac5000 r-xp /usr/lib/libsensord-shared.so
f6ace000 f6ba1000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bac000 f6bc2000 r-xp /lib/libz.so.1.2.5
f6bca000 f6bcf000 r-xp /usr/lib/libffi.so.5.0.10
f6bd7000 f6bd8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6be0000 f6bf0000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6bf8000 f6c11000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c19000 f6c1b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c23000 f6c98000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ca2000 f6ca8000 r-xp /lib/librt-2.13.so
f6cb1000 f6ccf000 r-xp /usr/lib/libsystemd.so.0.4.0
f6cd9000 f6cda000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ce2000 f6d05000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d0d000 f6d12000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d1a000 f6d44000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d4d000 f6d64000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6d6c000 f6dd5000 r-xp /lib/libm-2.13.so
f6dde000 f6e72000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e85000 f6e8a000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e92000 f6e99000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ea1000 f6ecb000 r-xp /usr/lib/libsensor.so.1.9.6
f6ed4000 f6fa0000 r-xp /usr/lib/libxml2.so.2.7.8
f6fad000 f6faf000 r-xp /usr/lib/libiniparser.so.0
f6fb8000 f6fbe000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6fc7000 f7097000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7098000 f70cc000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f70d5000 f7111000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7119000 f711c000 r-xp /usr/lib/libbundle.so.0.1.22
f7124000 f712a000 r-xp /usr/lib/libappsvc.so.0.1.0
f7132000 f7173000 r-xp /usr/lib/libeina.so.1.7.99
f717c000 f7193000 r-xp /usr/lib/libecore.so.1.7.99
f71aa000 f71b3000 r-xp /usr/lib/libvconf.so.0.2.45
f71bb000 f71cf000 r-xp /lib/libpthread-2.13.so
f71da000 f71e7000 r-xp /usr/lib/libaul.so.0.1.0
f71f1000 f71f3000 r-xp /lib/libdl-2.13.so
f71fc000 f7207000 r-xp /lib/libunwind.so.8.0.1
f7234000 f723c000 r-xp /lib/libgcc_s-4.6.so.1
f723d000 f7361000 r-xp /lib/libc-2.13.so
f736f000 f7371000 r-xp /usr/lib/libdlog.so.0.0.0
f7379000 f7385000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f738e000 f7393000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f739b000 f73aa000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f73b2000 f73b6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73bf000 f73c2000 r-xp /usr/lib/libappcore-agent.so.1.1
f73ca000 f73cc000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f73d4000 f73d8000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f73e0000 f73fd000 r-xp /lib/ld-2.13.so
f7406000 f7409000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7409000 f740d000 r-xp /usr/lib/libsys-assert.so
f78e3000 f7947000 rw-p [heap]
ff81f000 ff840000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24519)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf74072b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf739e539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70a53f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70a3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70afe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf70b5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf70b5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf70ea75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70e51f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70a3c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70afe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf70b5be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf70b5dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf70e7e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf70e8017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf70ec8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf73d60bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4a7a171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b4d663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6ffafcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6ffc7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf718cca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7187b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71885a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf7188879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf73c0183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73c07fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74076a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf725485c) [/lib/libc.so.6] + 0x1785c
29: (0xf7406fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
760,23/04/2018,16:03:47:593,-2.964707,-9.188439,2.656033
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:47:619,-3.000600,-9.059227,2.419144
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:47:623,-2.912065,-9.018548,2.395216
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:47:719,-2.976671,-8.855836,2.794817
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:47:764,-2.792424,-9.121440,2.883351
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:47:790,-2.720639,-9.233903,2.816352
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:47:802,-2.751746,-8.987441,2.883351
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:47:866,-2.641676,-8.798409,2.921637
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:47:885,-2.864209,-8.822337,2.880959
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:47:888,-2.924029,-8.729016,2.828316
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:47:944,-2.813959,-8.944371,2.940779
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:47:961,-2.806781,-9.107083,2.790031
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:47:987,-2.720639,-8.824730,2.641676
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:27,-2.878566,-8.985049,2.555535
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:85,-3.089134,-9.071191,2.711068
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:92,-3.058028,-8.982656,2.940779
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:111,-3.010171,-8.831908,2.919244
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:182,-2.921637,-8.865408,2.462214
04-23 16:04:09.891+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:236,-2.991028,-8.997013,2.581856
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:240,-3.067599,-9.092726,2.569891
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:245,-3.036492,-9.121440,2.636890
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:250,-3.034099,-9.085547,2.732604
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:254,-3.048456,-8.874979,2.821138
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:258,-2.950350,-8.858230,2.825923
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:262,-3.058028,-8.803195,2.830709
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:267,-3.125026,-8.755339,2.711068
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:272,-3.201597,-9.016156,2.426322
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:276,-3.187240,-8.882158,2.526821
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:279,-3.218346,-9.028119,2.912065
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:284,-3.136991,-9.265009,2.959922
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:288,-3.081956,-8.874979,2.794817
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:295,-3.141776,-8.877372,2.285146
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:299,-3.333202,-9.064013,2.289931
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:303,-3.426522,-8.975478,2.426322
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:315,-3.376273,-9.004191,2.562713
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:344,-3.282953,-8.958728,2.467000
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:401,-3.220739,-9.020942,2.289931
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:406,-3.376273,-9.183653,2.148755
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:411,-3.479164,-9.068797,1.923829
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:415,-3.632305,-9.083155,2.282753
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:420,-3.462414,-9.272188,2.538785
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:425,-3.347559,-9.198010,2.304288
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:429,-3.383451,-9.078369,1.954936
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:589,-3.476771,-8.898908,2.141576
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:789,-3.582055,-9.095119,2.124826
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:48:989,-3.534199,-9.142976,2.079363
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:189,-3.495914,-8.587841,2.029114
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:392,-3.596412,-9.087940,1.875973
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:408,-3.546163,-9.209974,1.875973
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:429,-3.668197,-9.061620,2.177469
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:450,-3.720839,-8.836694,2.153540
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:469,-3.572484,-8.879765,2.057827
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:490,-3.632305,-9.217153,1.878366
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:510,-3.572484,-9.178867,2.007578
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:534,-3.675375,-8.927622,1.964507
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:564,-3.823731,-9.219545,2.050649
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:574,-3.823731,-9.382257,2.017149
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:653,-3.598805,-9.140583,2.072184
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:665,-3.527020,-9.052048,2.036292
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:688,-3.620341,-9.195618,1.950150
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:699,-3.625126,-9.415757,1.988436
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:714,-3.586841,-9.296116,1.959722
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:732,-3.637090,-9.032906,1.763510
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:745,-3.833302,-9.202796,1.954936
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:761,-3.783052,-9.119047,2.053042
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:775,-3.775874,-9.248260,1.950150
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:782,-3.699304,-9.451650,1.600798
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:800,-3.436093,-9.420543,1.354338
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:810,-3.323631,-9.198010,1.462015
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:829,-3.412165,-8.970692,1.753939
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:850,-3.333202,-9.164511,1.433301
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:871,-3.488736,-9.154939,1.129412
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:914,-3.519842,-9.360723,0.957129
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:958,-3.620341,-9.451650,0.808774
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:962,-3.479164,-9.399008,1.110270
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:49:999,-3.448057,-9.609575,1.356731
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:3,-3.491128,-9.942179,1.088734
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:57,-3.414558,-9.834501,0.921237
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:79,-3.287738,-9.535398,0.354138
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:83,-3.117848,-9.375079,0.715454
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:103,-2.962314,-9.628718,1.251446
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:118,-2.782853,-9.590433,1.182054
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:136,-2.457429,-9.533006,0.892523
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:140,-2.289931,-10.650455,0.902094
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:158,-2.510071,-10.298709,1.296910
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:162,-2.122434,-9.131011,1.600798
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:201,-2.041078,-9.056834,1.194018
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:216,-1.682154,-9.896714,1.182054
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:220,-1.423729,-9.657433,1.842474
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:230,-1.308874,-9.202796,2.153540
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:251,-1.251446,-8.779266,1.715654
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:270,-1.220340,-8.650054,1.383051
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:290,-1.182054,-8.726624,1.579263
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:310,-1.473979,-8.513663,2.103291
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:329,-1.462015,-8.152347,2.749353
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:348,-1.184447,-8.535198,2.081756
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:383,-1.375873,-8.726624,1.615155
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:394,-1.421337,-8.733803,2.139183
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:414,-1.806581,-8.784052,3.036492
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:610,-3.017349,-8.465806,3.885944
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:50:811,-3.189633,-8.630912,2.962314
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:16,-3.132205,-8.925228,3.086741
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:213,-3.708875,-8.772088,1.746760
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:410,-5.833702,-10.322637,2.005185
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:435,-6.374479,-8.695518,2.210968
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:465,-7.439285,-6.608976,1.545763
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:495,-9.245867,-7.503892,1.361516
04-23 16:04:09.901+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:500,-9.530612,-7.635497,1.761117
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:510,-8.922836,-7.929814,2.474179
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:554,-9.078369,-7.640282,3.000600
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:577,-9.506684,-7.676175,2.701497
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:586,-9.987641,-7.039684,4.024727
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:611,-8.779266,-7.549356,4.304688
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:625,-6.946364,-7.125826,3.529413
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:641,-5.601598,-7.429714,2.797210
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:652,-5.264209,-6.317052,2.510071
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:706,-4.524827,-4.297509,2.081756
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:713,-3.708875,-3.323631,1.375873
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:717,-3.278167,-3.074777,1.258625
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:745,-3.036492,-2.143969,1.189233
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:766,-3.306881,-2.282753,4.417150
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:786,-3.326023,-4.240082,7.130611
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:806,-2.385644,-5.106283,6.987042
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:826,-1.416551,-4.388437,5.491528
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:850,-2.127219,-8.331808,4.890929
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:854,-4.539185,-14.871392,2.148755
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:872,-3.699304,-16.364515,0.136391
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:899,-2.029114,-13.430914,-0.308674
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:913,-4.275974,-11.174481,-1.854438
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:933,-7.527820,-12.827922,-6.307480
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:968,-6.525227,-14.569898,-11.097912
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:972,-6.953543,-11.416157,-12.911672
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:51:991,-7.649854,-9.190832,-9.925428
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:110,-6.865008,-8.441878,-6.352944
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:121,-6.458229,-6.869793,-3.883551
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:139,-6.290731,-5.589634,-2.711068
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:143,-6.288338,-5.864808,-2.615355
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:182,-6.678369,-6.867401,-3.742374
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:217,-7.867601,-5.029713,-3.266203
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:227,-8.271988,-1.524228,-1.940579
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:254,-8.216952,-4.869394,-0.277567
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:258,-9.284152,-5.067998,1.962115
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:262,-9.260223,-5.673382,0.792024
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:321,-7.410572,-6.326623,-0.334995
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:387,-6.494121,-10.762917,-0.157926
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:391,-5.749953,-10.688738,-0.189033
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:397,-6.503692,-7.685746,0.801596
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:400,-8.738588,-3.768696,1.186840
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:404,-9.348758,-4.338188,1.328017
04-23 16:04:09.911+0200 I/accelerometer(24584): es.ugr.frailty.accelerometer listener destroyed
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:408,-7.819745,-7.027720,1.098306
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:412,-7.204789,-8.080563,1.227518
04-23 16:04:09.911+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:416,-7.956135,-7.073184,1.127020
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:420,-7.771888,-5.374279,0.775275
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:423,-7.532606,-6.453443,0.007178
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:430,-7.470392,-6.766902,0.076570
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:526,-7.200003,-6.692725,-0.023928
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:52:535,-6.967900,-6.740582,-0.162712
04-23 16:04:09.921+0200 I/recorder(22624): obteniendo datos locales es.ugr.frailty.accelerometer
04-23 16:04:09.921+0200 I/recorder(22624): obteniendo datos locales, DATA: SM-R760,23/04/2018,16:03:12:285,-2.139183,-2.622534,9.097511
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:12:485,-2.117648,-2.600998,9.162118
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:12:686,-2.122434,-2.622534,9.150154
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:12:890,-2.115255,-2.639283,9.181261
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:13:89,-2.170290,-2.591427,9.209974
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:13:289,-2.187040,-2.667997,9.205189
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:13:412,-2.103291,-2.584249,9.188439
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:13:435,-2.175076,-2.593820,9.214760
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:13:447,-2.127219,-2.658426,9.195618
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:13:471,-2.108077,-2.636890,9.157332
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:13:486,-2.208575,-2.581856,9.236296
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:13:507,-2.184647,-2.608176,9.174082
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:13:526,-2.160719,-2.579463,9.207582
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:13:546,-2.175076,-2.660819,9.202796
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:13:568,-2.158326,-2.617748,9.186047
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/2018,16:03:13:586,-2.141576,-2.565106,9.171689
04-23 16:04:09.921+0200 I/recorder(22624): SM-R760,23/04/20
04-23 16:04:09.921+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:04:09.951+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:04:09.961+0200 W/AUL     (22624): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:04:09.961+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:04:09.991+0200 I/gyroscope(24599): es.ugr.frailty.gyroscope listener destroyed
04-23 16:04:10.001+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:04:10.011+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24617
04-23 16:04:10.011+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:04:10.041+0200 W/AUL     (24641): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 16:04:10.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:04:10.041+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:04:10.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24584
04-23 16:04:10.041+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:04:10.071+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24584
04-23 16:04:10.071+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24584)
04-23 16:04:10.081+0200 W/LOCATION(24632): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:04:10.081+0200 E/LOCATION(24632): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:04:10.081+0200 E/PKGMGR_INFO(24632): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:04:10.091+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:04:10.101+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:04:10.121+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:04:10.131+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24632
04-23 16:04:10.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:04:10.141+0200 W/AUL     (24643): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 16:04:10.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:04:10.141+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:04:10.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24599
04-23 16:04:10.141+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:04:10.141+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24599
04-23 16:04:10.141+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24599)
04-23 16:04:10.151+0200 I/heartrate(24617): es.ugr.frailty.heartrate listener destroyed
04-23 16:04:10.151+0200 W/LOCATION(24632): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:10.161+0200 I/LOCATION(24632): location.c: location_new(269) > method: 0
04-23 16:04:10.161+0200 W/LOCATION(24632): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:10.171+0200 W/LOCATION(24632): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:10.171+0200 W/LOCATION(24632): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:10.181+0200 W/LOCATION(24632): module-internal.c: module_new(311) > module (gps) open success
04-23 16:04:10.191+0200 W/LOCATION(24632): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:04:10.191+0200 W/LOCATION(24632): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:04:10.191+0200 W/LOCATION(24632): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:10.191+0200 W/LOCATION(24632): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:10.191+0200 W/LOCATION(24632): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:10.211+0200 W/LOCATION(24632): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:04:10.211+0200 W/LOCATION(24632): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:04:10.221+0200 W/LOCATION(24632): module-internal.c: module_new(311) > module (wps) open success
04-23 16:04:10.221+0200 W/LOCATION(24632): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:04:10.231+0200 W/LOCATION(24632): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:04:10.231+0200 W/LOCATION(24632): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:04:10.231+0200 W/LOCATION(24632): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:04:10.241+0200 W/AUL     (24645): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 16:04:10.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:04:10.241+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:04:10.241+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 21185
04-23 16:04:10.241+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:04:10.251+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21185
04-23 16:04:10.251+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21185)
04-23 16:04:10.281+0200 W/AUL     (24646): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 16:04:10.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:04:10.281+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:04:10.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24617
04-23 16:04:10.281+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:04:10.291+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24617
04-23 16:04:10.291+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24617)
04-23 16:04:10.301+0200 W/LOCATION(24632): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:04:10.301+0200 I/LOCATION(24632): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7a09c18
04-23 16:04:10.301+0200 I/LOCATION(24632): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:04:10.301+0200 I/LOCATION(24632): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7a09c18
04-23 16:04:10.301+0200 I/LOCATION(24632): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:04:10.311+0200 I/location(24632): es.ugr.frailty.location: creado servicio de localización
04-23 16:04:10.361+0200 I/LOCATION(24632): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:04:10.411+0200 W/LOCATION(24632): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:10.411+0200 W/LOCATION(24632): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:10.411+0200 I/LOCATION(24632): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:04:10.521+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:04:10.521+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:04:10.521+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:04:10.521+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:04:10.521+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:04:10.521+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:04:10.521+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:04:10.521+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:04:10.521+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:04:10.521+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:04:10.521+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:04:10.521+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:04:10.521+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:04:10.521+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:04:10.521+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:04:10.521+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:04:10.521+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:04:10.521+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:04:10.591+0200 W/LOCATION(24632): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:04:10.591+0200 W/LOCATION(24632): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:04:10.731+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:10.771+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:04:10.771+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(6146430), time2(6135181)
04-23 16:04:10.771+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 16:04:10.771+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:04:10.771+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:04:10.771+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:04:10.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e18c10]
04-23 16:04:10.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:04:10.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:04:10.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:04:10.771+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:04:10.781+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:10.781+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:10.791+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:10.801+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:10.801+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:04:10.801+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:04:10.801+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:10.801+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:04:10.801+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:04:10.801+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:04:10.801+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:10.801+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:10.801+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:10.801+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:10.821+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:10.821+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:04:10.821+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:10.861+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:10.891+0200 W/LOCATION(24632): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:04:10.891+0200 I/LOCATION(24632): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:04:10.891+0200 I/LOCATION(24632): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:04:10.891+0200 I/location(24632): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:04:10.981+0200 I/LOCATION(24632): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:04:11.031+0200 W/AUL     (24632): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:04:11.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:04:11.031+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24632
04-23 16:04:11.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:04:11.041+0200 W/AUL     (24632): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:04:11.041+0200 I/location(24632): request sent to service es.ugr.frailty.servicemanager
04-23 16:04:11.041+0200 I/location(24632): stopping es.ugr.frailty.location service
04-23 16:04:11.041+0200 E/CAPI_APPFW_APP_CONTROL(24632): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:04:11.041+0200 E/location(24632): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:04:11.041+0200 I/CAPI_APPFW_APPLICATION(24632): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:04:11.041+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:11.041+0200 I/utils   (19708): specific action
04-23 16:04:11.041+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:11.041+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:11.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:04:11.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:04:11.041+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:11.041+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:04:11.041+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:04:11.041+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:04:11.041+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:04:11.041+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:04:11.051+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 24653
04-23 16:04:11.051+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:04:11.091+0200 E/CAPI_APPFW_APPLICATION(24653): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:04:11.091+0200 E/CAPI_APPFW_APPLICATION(24653): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:04:11.091+0200 W/CAPI_APPFW_APP_CONTROL(24653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:11.091+0200 I/utils   (24653): specific action
04-23 16:04:11.091+0200 W/CAPI_APPFW_APP_CONTROL(24653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:11.091+0200 W/CAPI_APPFW_APP_CONTROL(24653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:11.091+0200 W/CAPI_APPFW_APP_CONTROL(24653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:11.091+0200 W/CAPI_APPFW_APP_CONTROL(24653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:04:11.111+0200 I/recorder(24653): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:04:11.111+0200 I/recorder(24653): guardando datos en local
04-23 16:04:11.111+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 24653
04-23 16:04:11.111+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(24653) type(svcapp) bg(0)
04-23 16:04:11.111+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [24653]
04-23 16:04:11.131+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (24653) was created
04-23 16:04:11.131+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:04:11.131+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24653)
04-23 16:04:11.131+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:04:11.131+0200 I/servicemanager(19708): requesting to save local data
04-23 16:04:11.141+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24653
04-23 16:04:11.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:04:11.151+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24653
04-23 16:04:11.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:04:11.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:04:11.181+0200 W/LOCATION(24632): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:04:11.191+0200 I/LOCATION(24632): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:04:11.191+0200 I/LOCATION(24632): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:04:11.311+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 16:04:11.311+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:04:11.311+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:04:11.311+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:04:11.311+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 16:04:11.321+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:04:11.321+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:04:11.321+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:04:11.321+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:04:11.431+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:11.471+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:04:11.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:04:11.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:04:11.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e18c10
04-23 16:04:11.531+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e1a358]
04-23 16:04:11.531+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:04:11.531+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:04:11.531+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:04:11.531+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:04:11.541+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:11.541+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:11.541+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:11.551+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:11.551+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:04:11.551+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:04:11.551+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:11.551+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:04:11.551+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:04:11.551+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:04:11.551+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:11.551+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:11.551+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:11.561+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:11.571+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:11.571+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:04:11.571+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:11.601+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:04:11.611+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:11.621+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:11.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:04:11.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:04:11.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:04:11.671+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e1a358
04-23 16:04:11.671+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:04:11.701+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e1a3a0]
04-23 16:04:11.701+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:04:11.701+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:04:11.701+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:04:11.701+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:04:11.711+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:11.711+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:11.721+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:11.731+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:11.731+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:04:11.731+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:04:11.731+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:04:11.731+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:04:11.731+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:04:11.731+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:04:11.731+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:04:11.731+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:04:11.731+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:04:11.741+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:11.751+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:04:11.751+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:04:11.751+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:11.781+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:04:11.801+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:04:11.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:04:11.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:04:11.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:04:11.811+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e1a3a0
04-23 16:04:11.981+0200 W/AUL     (24660): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:04:11.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:04:11.981+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:04:11.981+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24503
04-23 16:04:11.981+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:04:11.981+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24503
04-23 16:04:11.981+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24503)
04-23 16:04:13.041+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:04:16.801+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11244516c6f631524492239
04-23 16:04:17.261+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11244856c6f631524492244
04-23 16:04:23.891+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11245196c6f63152449224
