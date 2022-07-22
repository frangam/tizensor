S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 17406
Date: 2018-06-07 17:11:27+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75bc52d, r5   = 0xf786cf98
r6   = 0xffc97190, r7   = 0xffc97040
r8   = 0xf7869c18, r9   = 0x00000000
r10  = 0xffc9711c, fp   = 0xffc97190
ip   = 0x00000001, sp   = 0xffc97018
lr   = 0xf75bc539, pc   = 0xf7625228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    101104 KB
Buffers:      8484 KB
Cached:      50220 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11584 KB
VmRSS:       11584 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 17406 TID = 17406
17406 17410 

Maps Information
f4487000 f4c86000 rw-p [stack:17410]
f4c8d000 f4c8f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c97000 f4c9b000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ca4000 f4ca6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4cae000 f4cb1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4cc0000 f4cc5000 r-xp /usr/lib/libsystem.so.0.0.0
f4cd0000 f4cd3000 r-xp /lib/libattr.so.1.1.0
f4cdb000 f4ceb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cf3000 f4cfc000 r-xp /usr/lib/libedbus.so.1.7.99
f4d04000 f4d05000 r-xp /usr/lib/libresponse.so.0.2.96
f4d0e000 f4d13000 r-xp /usr/lib/libproc-stat.so.0.2.96
f65b5000 f66bb000 r-xp /usr/lib/libicuuc.so.57.1
f66d1000 f6859000 r-xp /usr/lib/libicui18n.so.57.1
f6869000 f6876000 r-xp /usr/lib/libail.so.0.1.0
f687f000 f6886000 r-xp /usr/lib/libminizip.so.1.0.0
f688f000 f6a38000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a58000 f6a9f000 r-xp /usr/lib/libssl.so.1.0.0
f6aab000 f6aad000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6ab5000 f6abc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6ac5000 f6acc000 r-xp /lib/libcrypt-2.13.so
f6afd000 f6b00000 r-xp /lib/libcap.so.2.21
f6b08000 f6b0a000 r-xp /usr/lib/libiri.so
f6b12000 f6b5b000 r-xp /usr/lib/libmdm.so.1.2.69
f6b63000 f6b69000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b71000 f6b94000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b9e000 f6ba0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ba8000 f6bc5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bce000 f6bd2000 r-xp /usr/lib/libsmack.so.1.0.0
f6bdb000 f6bf4000 r-xp /usr/lib/libnetwork.so.0.0.0
f6bfd000 f6c05000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6c0d000 f6c13000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c1c000 f6c1e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c27000 f6c37000 r-xp /lib/libresolv-2.13.so
f6c3b000 f6c53000 r-xp /usr/lib/liblzma.so.5.0.3
f6c5c000 f6c5e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c66000 f6c80000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c88000 f6cb7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6cc0000 f6ccf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cd9000 f6ce3000 r-xp /usr/lib/libsensord-shared.so
f6cec000 f6dbf000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dca000 f6de0000 r-xp /lib/libz.so.1.2.5
f6de8000 f6ded000 r-xp /usr/lib/libffi.so.5.0.10
f6df5000 f6df6000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6dfe000 f6e0e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6e16000 f6e2f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e37000 f6e39000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e41000 f6eb6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ec0000 f6ec6000 r-xp /lib/librt-2.13.so
f6ecf000 f6eed000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ef7000 f6ef8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f00000 f6f23000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f2b000 f6f30000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f38000 f6f62000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f6b000 f6f82000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f8a000 f6ff3000 r-xp /lib/libm-2.13.so
f6ffc000 f7090000 r-xp /usr/lib/libstdc++.so.6.0.16
f70a3000 f70a8000 r-xp /usr/lib/libctx-client.so.0.8.3
f70b0000 f70b7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70bf000 f70e9000 r-xp /usr/lib/libsensor.so.1.9.6
f70f2000 f71be000 r-xp /usr/lib/libxml2.so.2.7.8
f71cb000 f71cd000 r-xp /usr/lib/libiniparser.so.0
f71d6000 f71dc000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71e5000 f72b5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f72b6000 f72ea000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72f3000 f732f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7337000 f733a000 r-xp /usr/lib/libbundle.so.0.1.22
f7342000 f7348000 r-xp /usr/lib/libappsvc.so.0.1.0
f7350000 f7391000 r-xp /usr/lib/libeina.so.1.7.99
f739a000 f73b1000 r-xp /usr/lib/libecore.so.1.7.99
f73c8000 f73d1000 r-xp /usr/lib/libvconf.so.0.2.45
f73d9000 f73ed000 r-xp /lib/libpthread-2.13.so
f73f8000 f7405000 r-xp /usr/lib/libaul.so.0.1.0
f740f000 f7411000 r-xp /lib/libdl-2.13.so
f741a000 f7425000 r-xp /lib/libunwind.so.8.0.1
f7452000 f745a000 r-xp /lib/libgcc_s-4.6.so.1
f745b000 f757f000 r-xp /lib/libc-2.13.so
f758d000 f758f000 r-xp /usr/lib/libdlog.so.0.0.0
f7597000 f75a3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75ac000 f75b1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75b9000 f75c8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75d0000 f75d4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75dd000 f75e0000 r-xp /usr/lib/libappcore-agent.so.1.1
f75e8000 f75ea000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75f2000 f75f6000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75fe000 f761b000 r-xp /lib/ld-2.13.so
f7624000 f7627000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7627000 f762b000 r-xp /usr/lib/libsys-assert.so
f7839000 f78aa000 rw-p [heap]
ffc78000 ffc99000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17406)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7625228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf75bc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72c33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72c1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72cde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72d3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72d3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf730875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73031f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72c1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72cde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72d3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72d3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7305e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7306017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf730df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ca51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4c98171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d6b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7218fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf721a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf73aaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf73a5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf73a65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf73a6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75de183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75de7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76255c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf747285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7624f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.661+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/16945/oom_score_adj failed
06-07 17:11:26.661+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/16891/oom_score_adj failed
06-07 17:11:26.661+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/16876/oom_score_adj failed
06-07 17:11:26.661+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/16868/oom_score_adj failed
06-07 17:11:26.661+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/16808/oom_score_adj failed
06-07 17:11:26.661+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/16792/oom_score_adj failed
06-07 17:11:26.661+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/16778/oom_score_adj failed
06-07 17:11:26.661+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/16699/oom_score_adj failed
06-07 17:11:26.661+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/16633/oom_score_adj failed
06-07 17:11:26.661+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/16604/oom_score_adj failed
06-07 17:11:26.661+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/16582/oom_score_adj failed
06-07 17:11:26.661+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/16527/oom_score_adj failed
06-07 17:11:26.661+0200 E/RESOURCED( 2560): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/14648/oom_score_adj failed
06-07 17:11:26.661+0200 E/RESOURCED( 2560): vmpressure-lowmem-handler.c: lowmem_handle_request(1073) > kill 0 victims, total_size = 0 from 450 to 990 0
06-07 17:11:26.661+0200 E/RESOURCED( 2560): vmpressure-lowmem-handler.c: lowmem_handle_request(1073) > kill 0 victims, total_size = 0 from 270 to 430 0
06-07 17:11:26.691+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:26.701+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:26:705,775.000000
06-07 17:11:26.701+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.701+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:26.711+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:26:715,81
06-07 17:11:26.721+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:726,-0.344525,-4.536587,-1.231712
06-07 17:11:26.731+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:26:664,0.910000,0.140000,0.140000
06-07 17:11:26.731+0200 E/RESOURCED( 2560): vmpressure-lowmem-handler.c: lowmem_kill_victim(608) > we killed, force(0), 17261 (gravity) score = 240 (240), size: rss = 104208 KB, sigterm = 1
06-07 17:11:26.731+0200 E/RESOURCED( 2560): vmpressure-lowmem-handler.c: lowmem_kill_victims(970) > victim = 1, max_victims = 5, total_size = 104208
06-07 17:11:26.731+0200 E/RESOURCED( 2560): vmpressure-lowmem-handler.c: lowmem_handle_request(1073) > kill 1 victims, total_size = 101 from 230 to 250 1
06-07 17:11:26.731+0200 E/RESOURCED( 2560): vmpressure-lowmem-handler.c: lowmem_handle_request(1119) > Done: killed 1 processes reclaimed: 101 remaining: 0 shortfall: 31 status: 1
06-07 17:11:26.731+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:732,0.385352,-2.457112,9.486015
06-07 17:11:26.731+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.731+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:26:669,-1.024128,-4.843073,8.547162
06-07 17:11:26.731+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.741+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:743,0.345807,-2.385404,9.505822
06-07 17:11:26.741+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:743,-0.340218,-4.703891,-1.211042
06-07 17:11:26.741+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.741+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.741+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:749,-0.306896,-4.801531,-1.166475
06-07 17:11:26.741+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:750,0.282848,-2.304892,9.527741
06-07 17:11:26.741+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.751+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.751+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:754,-0.305108,-4.917483,-1.166013
06-07 17:11:26.751+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.751+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:756,0.219302,-2.185042,9.557609
06-07 17:11:26.751+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.751+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:759,-0.391519,-4.928982,-1.196233
06-07 17:11:26.751+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.761+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:762,0.163333,-2.079603,9.582221
06-07 17:11:26.761+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:764,-0.428840,-5.040412,-1.217060
06-07 17:11:26.761+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.761+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.761+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:770,-0.479306,2.375370,1.954135
06-07 17:11:26.761+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:769,0.117678,-2.017605,9.596135
06-07 17:11:26.761+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.771+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.771+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:775,-0.392585,2.268939,1.757583
06-07 17:11:26.771+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.771+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:776,0.072423,-1.968519,9.606772
06-07 17:11:26.771+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.771+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:780,-0.374061,2.094528,1.630418
06-07 17:11:26.771+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.781+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:784,-0.414851,2.008375,1.573427
06-07 17:11:26.781+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.781+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:791,-0.404473,1.837145,1.388348
06-07 17:11:26.791+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.791+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:782,0.037269,-1.968913,9.606893
06-07 17:11:26.791+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.791+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:796,-0.366143,1.604693,1.195443
06-07 17:11:26.791+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.791+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:801,-0.317797,1.428084,1.109472
06-07 17:11:26.801+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.801+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:801,0.001701,-1.992932,9.602011
06-07 17:11:26.801+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:806,-0.308849,1.363618,1.028877
06-07 17:11:26.801+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.801+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:26.821+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:813,-0.028520,-2.046870,9.590615
06-07 17:11:26.821+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.831+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:828,-0.056673,-2.079633,9.583439
06-07 17:11:26.841+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.851+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:849,-0.084632,-2.073699,9.584518
06-07 17:11:26.861+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.861+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:866,-0.128251,-2.008209,9.597970
06-07 17:11:26.871+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.881+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:882,-0.174568,-1.932864,9.612698
06-07 17:11:26.881+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.881+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:26.891+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:892,-0.221759,-1.823079,9.633150
06-07 17:11:26.891+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.901+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:902,-0.249704,-1.787498,9.639132
06-07 17:11:26.901+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.901+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:909,-0.268800,-1.784516,9.639172
06-07 17:11:26.901+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:26:895,776.000000
06-07 17:11:26.901+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:26.901+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.911+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:915,-0.301831,-1.709252,9.651826
06-07 17:11:26.911+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.911+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:26:918,81
06-07 17:11:26.921+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:26.921+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:922,-0.328070,-1.645700,9.662009
06-07 17:11:26.921+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.921+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:928,-0.344171,-1.590971,9.670612
06-07 17:11:26.931+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.931+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:936,-0.361979,-1.514895,9.682172
06-07 17:11:26.931+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.941+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:943,-0.380781,-1.399107,9.698860
06-07 17:11:26.941+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.941+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:949,-0.398855,-1.271672,9.715665
06-07 17:11:26.951+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.951+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:959,-0.415939,-1.138115,9.731499
06-07 17:11:26.951+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.961+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:965,-0.434044,-0.968386,9.749063
06-07 17:11:26.961+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.971+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:972,-0.448751,-0.788288,9.764610
06-07 17:11:26.971+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.971+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:978,-0.457464,-0.629409,9.775733
06-07 17:11:26.981+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:26.981+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:26.981+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:985,-0.465952,-0.466721,9.784449
06-07 17:11:26.981+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:26:813,-0.262588,1.318497,0.951210
06-07 17:11:26.981+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.001+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:26:992,-0.473820,-0.292130,9.790839
06-07 17:11:27.001+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.001+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.001+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:27:9,-0.478128,-0.132003,9.794098
06-07 17:11:27.001+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:26:979,-1.036092,-4.905287,8.551948
06-07 17:11:27.011+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.011+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.011+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:27:17,-0.477950,-0.005650,9.794994
06-07 17:11:26.991+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:26:992,0.630000,-0.210000,0.140000
06-07 17:11:27.011+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.021+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:27:24,-0.477345,0.098338,9.794532
06-07 17:11:27.021+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.021+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:13,-0.296054,1.149707,0.880118
06-07 17:11:27.021+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:28,0.420000,0.210000,0.210000
06-07 17:11:27.021+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.021+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.031+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:27:35,-0.474682,0.172050,9.793644
06-07 17:11:27.031+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:35,0.140000,1.120000,0.420000
06-07 17:11:27.031+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.031+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.031+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:42,0.070000,0.700000,0.140000
06-07 17:11:27.041+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:27:42,-0.473254,0.211696,9.792936
06-07 17:11:27.041+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.041+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.041+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:48,-0.210000,-0.420000,0.140000
06-07 17:11:27.041+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.041+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:27:50,-0.336647,-7.225621,6.621741
06-07 17:11:27.051+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.051+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:27:57,-0.375512,-7.056977,6.799150
06-07 17:11:27.051+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.061+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:27:64,-0.406000,-6.906495,6.950243
06-07 17:11:27.061+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 17:11:27.061+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 17:11:27.061+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 17:11:27.061+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.071+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:53,-0.700000,-0.490000,-0.280000
06-07 17:11:27.071+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:27:72,-0.432208,-6.765306,7.086198
06-07 17:11:27.071+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.071+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.071+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:79,-0.560000,0.630000,-0.280000
06-07 17:11:27.071+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:27:80,-0.456943,-6.629968,7.211457
06-07 17:11:27.081+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.081+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.081+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:86,-0.140000,-0.560000,0.700000
06-07 17:11:27.081+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:27:86,-0.483309,-6.488444,7.337363
06-07 17:11:27.081+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.081+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.091+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:93,0.280000,-0.210000,-0.350000
06-07 17:11:27.091+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:27:93,-0.507727,-6.357298,7.449655
06-07 17:11:27.091+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.091+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.091+0200 I/gravity (17261): es.ugr.frailty.gravity: SM-R760,07/06/2018,17:11:27:99,-0.528639,-6.242583,7.544606
06-07 17:11:27.101+0200 I/gravity (17261): es.ugr.frailty.gravity - capturing data
06-07 17:11:27.111+0200 E/RESOURCED( 2560): lowmem-limit.c: lowmem_limit_cb(305) > some application was crashed by kernel when it exceeded the threshold (104857600)
06-07 17:11:27.111+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:27.121+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:99,0.350000,0.280000,0.140000
06-07 17:11:27.121+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.131+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:135,0.420000,0.560000,0.280000
06-07 17:11:27.131+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.131+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:141,0.420000,-0.070000,-0.070000
06-07 17:11:27.141+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.141+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:147,0.280000,-0.070000,0.280000
06-07 17:11:27.141+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.151+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:153,0.630000,0.490000,-0.210000
06-07 17:11:27.151+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.151+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:159,0.910000,0.350000,0.210000
06-07 17:11:27.151+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.161+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:164,0.350000,0.140000,0.070000
06-07 17:11:27.161+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.171+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:171,-0.070000,0.140000,0.070000
06-07 17:11:27.171+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.171+0200 E/AUL_AMD ( 2479): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
06-07 17:11:27.171+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:27.171+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(25) , send fd(15), pid(17261), cmd(0)
06-07 17:11:27.171+0200 E/AUL_AMD ( 2479): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
06-07 17:11:27.171+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:27.171+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(17261), cmd(0)
06-07 17:11:27.171+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:178,0.280000,-0.070000,0.070000
06-07 17:11:27.171+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.181+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:184,0.420000,-0.490000,-0.210000
06-07 17:11:27.181+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.181+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:191,0.560000,-0.140000,-0.070000
06-07 17:11:27.191+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.191+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:197,0.140000,0.280000,-0.070000
06-07 17:11:27.191+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.191+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:27.201+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:203,-0.210000,0.490000,0.070000
06-07 17:11:27.201+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.201+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:210,-0.420000,0.490000,0.070000
06-07 17:11:27.201+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:27:163,776.000000
06-07 17:11:27.211+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:27:205,81
06-07 17:11:27.211+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.221+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.221+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:216,-1.024128,-4.886144,8.482556
06-07 17:11:27.221+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:224,0.140000,-0.140000,-0.070000
06-07 17:11:27.221+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.231+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.231+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:232,-0.431259,1.114235,0.915831
06-07 17:11:27.251+0200 W/AUL     (17466): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gravity]
06-07 17:11:27.251+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 23
06-07 17:11:27.251+0200 W/AUL_AMD ( 2479): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
06-07 17:11:27.251+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 17060
06-07 17:11:27.251+0200 W/AUL_AMD ( 2479): amd_request.c: __send_app_termination_signal(528) > send dead signal done
06-07 17:11:27.251+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:243,0.700000,0.280000,-0.070000
06-07 17:11:27.251+0200 I/AUL_AMD ( 2479): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 17060
06-07 17:11:27.251+0200 W/AUL     ( 2479): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(17060)
06-07 17:11:27.261+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.261+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:27.261+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:27:270,778.000000
06-07 17:11:27.271+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:268,0.280000,0.350000,0.070000
06-07 17:11:27.271+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:236,-1.060020,-4.914857,8.578269
06-07 17:11:27.271+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.271+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.271+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.281+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:285,-0.630000,0.420000,0.070000
06-07 17:11:27.281+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:289,-0.981057,-4.847858,8.537591
06-07 17:11:27.291+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.291+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:283,-0.615832,0.530916,0.905857
06-07 17:11:27.291+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.291+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:299,-0.770000,-0.140000,-0.140000
06-07 17:11:27.301+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.301+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.311+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:27.311+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:27:316,81
06-07 17:11:27.311+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:308,-0.945165,-4.883751,8.590233
06-07 17:11:27.311+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.311+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:313,0.070000,-0.770000,-0.210000
06-07 17:11:27.311+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:312,-0.322127,-0.299421,0.803835
06-07 17:11:27.321+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.321+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:27.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528391487343,000000, pattern:[H:mm][0;m
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 17:11:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 17:11:27.331+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 17:11:27.331+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[17:11][0;m
06-07 17:11:27.341+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:333,0.560000,-0.070000,-0.070000
06-07 17:11:27.341+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.341+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:349,0.070000,0.420000,0.140000
06-07 17:11:27.351+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.351+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:356,-0.700000,-0.140000,-0.140000
06-07 17:11:27.351+0200 W/LOCATION(17406): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 17:11:27.361+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:328,-1.000200,-4.871787,8.532805
06-07 17:11:27.361+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.371+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:341,-0.070992,1.158121,0.536449
06-07 17:11:27.371+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.371+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.371+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:381,-0.630000,-0.700000,-0.210000
06-07 17:11:27.381+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:370,-1.045663,-4.905287,8.544770
06-07 17:11:27.381+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.381+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.391+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:392,-0.210000,-0.140000,-0.210000
06-07 17:11:27.391+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:380,0.100565,1.255348,2.594452
06-07 17:11:27.391+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.391+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.391+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:392,-1.052842,-4.900501,8.549555
06-07 17:11:27.401+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.401+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:409,-0.995414,-4.867002,8.523234
06-07 17:11:27.401+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:404,-0.350000,0.560000,0.280000
06-07 17:11:27.411+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.411+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:401,1.178738,0.389221,1.830979
06-07 17:11:27.421+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.421+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:424,-0.980000,0.490000,0.210000
06-07 17:11:27.421+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.431+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.431+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:435,-1.120000,-0.280000,-0.070000
06-07 17:11:27.441+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.441+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:434,-1.527145,0.285377,0.470244
06-07 17:11:27.451+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:453,-0.420000,-0.560000,-0.070000
06-07 17:11:27.461+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.461+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:27.461+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:27:469,776.000000
06-07 17:11:27.471+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:466,-0.070000,-0.280000,-0.070000
06-07 17:11:27.471+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.471+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:441,-1.055235,-4.878965,8.542377
06-07 17:11:27.481+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.481+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:479,-0.280000,0.070000,-0.070000
06-07 17:11:27.481+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.491+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.501+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:496,-0.770000,0.070000,0.070000
06-07 17:11:27.501+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.501+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:496,-2.027627,0.618331,0.270139
06-07 17:11:27.511+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:511,-0.770000,-0.210000,-0.140000
06-07 17:11:27.511+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:27.521+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:27:520,81
06-07 17:11:27.521+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:495,-1.081556,-4.895715,8.571091
06-07 17:11:27.521+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.521+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.521+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.531+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:534,-0.140000,0.070000,-0.140000
06-07 17:11:27.541+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:535,-1.000200,-4.859823,8.535198
06-07 17:11:27.541+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.541+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:535,0.020549,2.509143,0.938396
06-07 17:11:27.551+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:554,0.140000,0.280000,-0.070000
06-07 17:11:27.551+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.551+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.551+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.571+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:560,-0.964308,-4.864608,8.535198
06-07 17:11:27.571+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:568,-0.210000,-0.140000,-0.070000
06-07 17:11:27.571+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.571+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:566,0.250859,2.650402,1.606918
06-07 17:11:27.581+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.581+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.591+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:589,-0.700000,-0.280000,-0.070000
06-07 17:11:27.591+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.601+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:582,-0.961915,-4.890929,8.566305
06-07 17:11:27.601+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.601+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:594,-0.086846,2.186131,1.133052
06-07 17:11:27.601+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:607,-1.000200,-4.941179,8.544770
06-07 17:11:27.601+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:605,-0.700000,-0.280000,-0.070000
06-07 17:11:27.611+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.611+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.621+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.621+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:623,-0.140000,-0.070000,0.140000
06-07 17:11:27.621+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:619,-0.222654,1.691641,0.983377
06-07 17:11:27.631+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.631+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.631+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:626,-0.993021,-4.905287,8.511270
06-07 17:11:27.631+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:636,-0.140000,0.210000,0.140000
06-07 17:11:27.631+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.641+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.651+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:641,0.070149,1.582019,0.191754
06-07 17:11:27.651+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:653,-0.210000,0.070000,0.140000
06-07 17:11:27.651+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:645,-1.009771,-4.893322,8.554340
06-07 17:11:27.651+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.651+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.651+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.661+0200 I/light   (16749): es.ugr.frailty.light - capturing data
06-07 17:11:27.671+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:664,-0.560000,-0.070000,-0.070000
06-07 17:11:27.671+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.671+0200 I/light   (16749): es.ugr.frailty.light: SM-R760,07/06/2018,17:11:27:675,777.000000
06-07 17:11:27.671+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:679,-0.630000,0.140000,-0.070000
06-07 17:11:27.671+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:662,0.111864,0.444788,-0.177818
06-07 17:11:27.681+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:665,-0.995414,-4.888536,8.566305
06-07 17:11:27.681+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.681+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.681+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.691+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:691,-1.024128,-4.902894,8.571091
06-07 17:11:27.691+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:691,0.070000,0.560000,0.350000
06-07 17:11:27.691+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.701+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.701+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:693,0.347527,-0.497877,-0.510986
06-07 17:11:27.701+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:705,0.210000,0.350000,0.210000
06-07 17:11:27.711+0200 I/heartrate(15106): es.ugr.frailty.heartrate - capturing data
06-07 17:11:27.711+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer alive timeout
06-07 17:11:27.711+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 17:11:27.711+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:27.711+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:27.711+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.721+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:722,0.140000,0.350000,0.070000
06-07 17:11:27.721+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
06-07 17:11:27.731+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
06-07 17:11:27.731+0200 I/servicemanager(12566): es.ugr.frailty.accelerometer launch request sent!
06-07 17:11:27.731+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:27.731+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope alive timeout
06-07 17:11:27.731+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 17:11:27.731+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:27.731+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.731+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:27.731+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:740,0.140000,0.070000,0.140000
06-07 17:11:27.741+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.741+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17323
06-07 17:11:27.751+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17323)
06-07 17:11:27.751+0200 I/servicemanager(12566): es.ugr.frailty.gyroscope launch request sent!
06-07 17:11:27.751+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:27.751+0200 I/servicemanager(12566): es.ugr.frailty.heartrate alive timeout
06-07 17:11:27.751+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 17:11:27.751+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:27.751+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:27.771+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15106
06-07 17:11:27.781+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15106)
06-07 17:11:27.781+0200 I/servicemanager(12566): es.ugr.frailty.heartrate launch request sent!
06-07 17:11:27.781+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:27.781+0200 I/servicemanager(12566): es.ugr.frailty.location alive timeout
06-07 17:11:27.781+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 17:11:27.781+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:27.781+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:747,-0.070000,0.420000,0.280000
06-07 17:11:27.781+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:27.791+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.791+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17406
06-07 17:11:27.801+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17406)
06-07 17:11:27.801+0200 I/servicemanager(12566): es.ugr.frailty.location launch request sent!
06-07 17:11:27.801+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:27.801+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration alive timeout
06-07 17:11:27.801+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 17:11:27.801+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 17:11:27.801+0200 I/heartrate(15106): es.ugr.frailty.heartrate: SM-R760,07/06/2018,17:11:27:716,81
06-07 17:11:27.801+0200 W/CAPI_APPFW_APP_CONTROL(15106): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 17:11:27.801+0200 I/utils   (15106): specific action
06-07 17:11:27.801+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 12566
06-07 17:11:27.811+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration - capturing data
06-07 17:11:27.811+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17305
06-07 17:11:27.821+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:798,-0.070000,0.420000,0.280000
06-07 17:11:27.821+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope - capturing data
06-07 17:11:27.821+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 17:11:27.821+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(15106), cmd(0)
06-07 17:11:27.821+0200 W/AUL     (12566): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17305)
06-07 17:11:27.821+0200 I/servicemanager(12566): es.ugr.frailty.linearacceleration launch request sent!
06-07 17:11:27.821+0200 I/servicemanager(12566): App control destroyed.
06-07 17:11:27.821+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,17:11:27:712,-1.043271,-4.900501,8.530413
06-07 17:11:27.831+0200 I/accelerometer(17419): es.ugr.frailty.accelerometer - capturing data
06-07 17:11:27.831+0200 I/gyroscope(17323): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,17:11:27:835,0.140000,0.420000,0.280000
06-07 17:11:27.831+0200 I/linearacceleration(17305): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,17:11:27:830,0.193083,0.146887,-0.710676
06-07 17:11:27.831+0200 W/CRASH_MANAGER(12719): worker.c: worker_job(1205) > 11174066c6f63152838428
