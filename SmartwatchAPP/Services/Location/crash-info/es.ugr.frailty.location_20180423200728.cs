S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6475
Date: 2018-04-23 20:07:28+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf709452d, r5   = 0xf71e7f98
r6   = 0xffb68180, r7   = 0xffb68030
r8   = 0xf71e4c18, r9   = 0x00000000
r10  = 0xffb6810c, fp   = 0xffb68180
ip   = 0x00000001, sp   = 0xffb68008
lr   = 0xf7094539, pc   = 0xf70fd228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    100088 KB
Buffers:     38164 KB
Cached:     184000 KB
VmPeak:      52512 KB
VmSize:      52508 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11624 KB
VmRSS:       11624 KB
VmData:      10236 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          56 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6475 TID = 6475
6475 6478 

Maps Information
f3f5f000 f475e000 rw-p [stack:6478]
f4765000 f4767000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f476f000 f4773000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f477c000 f477e000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4786000 f4789000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4798000 f479d000 r-xp /usr/lib/libsystem.so.0.0.0
f47a8000 f47ab000 r-xp /lib/libattr.so.1.1.0
f47b3000 f47c3000 r-xp /usr/lib/libmdm-common.so.1.1.24
f47cb000 f47d4000 r-xp /usr/lib/libedbus.so.1.7.99
f47dc000 f47dd000 r-xp /usr/lib/libresponse.so.0.2.96
f47e6000 f47eb000 r-xp /usr/lib/libproc-stat.so.0.2.96
f608d000 f6193000 r-xp /usr/lib/libicuuc.so.57.1
f61a9000 f6331000 r-xp /usr/lib/libicui18n.so.57.1
f6341000 f634e000 r-xp /usr/lib/libail.so.0.1.0
f6357000 f635e000 r-xp /usr/lib/libminizip.so.1.0.0
f6367000 f6510000 r-xp /usr/lib/libcrypto.so.1.0.0
f6530000 f6577000 r-xp /usr/lib/libssl.so.1.0.0
f6583000 f6585000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f658d000 f6594000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f659d000 f65a4000 r-xp /lib/libcrypt-2.13.so
f65d5000 f65d8000 r-xp /lib/libcap.so.2.21
f65e0000 f65e2000 r-xp /usr/lib/libiri.so
f65ea000 f6633000 r-xp /usr/lib/libmdm.so.1.2.69
f663b000 f6641000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6649000 f666c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6676000 f6678000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6680000 f669d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66a6000 f66aa000 r-xp /usr/lib/libsmack.so.1.0.0
f66b3000 f66cc000 r-xp /usr/lib/libnetwork.so.0.0.0
f66d5000 f66dd000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f66e5000 f66eb000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f66f4000 f66f6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66ff000 f670f000 r-xp /lib/libresolv-2.13.so
f6713000 f672b000 r-xp /usr/lib/liblzma.so.5.0.3
f6734000 f6736000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f673e000 f6758000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6760000 f678f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6798000 f67a7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67b1000 f67bb000 r-xp /usr/lib/libsensord-shared.so
f67c4000 f6897000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68a2000 f68b8000 r-xp /lib/libz.so.1.2.5
f68c0000 f68c5000 r-xp /usr/lib/libffi.so.5.0.10
f68cd000 f68ce000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f68d6000 f68e6000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f68ee000 f6907000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f690f000 f6911000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6919000 f698e000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6998000 f699e000 r-xp /lib/librt-2.13.so
f69a7000 f69c5000 r-xp /usr/lib/libsystemd.so.0.4.0
f69cf000 f69d0000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f69d8000 f69fb000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a03000 f6a08000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a10000 f6a3a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a43000 f6a5a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a62000 f6acb000 r-xp /lib/libm-2.13.so
f6ad4000 f6b68000 r-xp /usr/lib/libstdc++.so.6.0.16
f6b7b000 f6b80000 r-xp /usr/lib/libctx-client.so.0.8.3
f6b88000 f6b8f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6b97000 f6bc1000 r-xp /usr/lib/libsensor.so.1.9.6
f6bca000 f6c96000 r-xp /usr/lib/libxml2.so.2.7.8
f6ca3000 f6ca5000 r-xp /usr/lib/libiniparser.so.0
f6cae000 f6cb4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cbd000 f6d8d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6d8e000 f6dc2000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dcb000 f6e07000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e0f000 f6e12000 r-xp /usr/lib/libbundle.so.0.1.22
f6e1a000 f6e20000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e28000 f6e69000 r-xp /usr/lib/libeina.so.1.7.99
f6e72000 f6e89000 r-xp /usr/lib/libecore.so.1.7.99
f6ea0000 f6ea9000 r-xp /usr/lib/libvconf.so.0.2.45
f6eb1000 f6ec5000 r-xp /lib/libpthread-2.13.so
f6ed0000 f6edd000 r-xp /usr/lib/libaul.so.0.1.0
f6ee7000 f6ee9000 r-xp /lib/libdl-2.13.so
f6ef2000 f6efd000 r-xp /lib/libunwind.so.8.0.1
f6f2a000 f6f32000 r-xp /lib/libgcc_s-4.6.so.1
f6f33000 f7057000 r-xp /lib/libc-2.13.so
f7065000 f7067000 r-xp /usr/lib/libdlog.so.0.0.0
f706f000 f707b000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7084000 f7089000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7091000 f70a0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70a8000 f70ac000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70b5000 f70b8000 r-xp /usr/lib/libappcore-agent.so.1.1
f70c0000 f70c2000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f70ca000 f70ce000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f70d6000 f70f3000 r-xp /lib/ld-2.13.so
f70fc000 f70ff000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f70ff000 f7103000 r-xp /usr/lib/libsys-assert.so
f71b4000 f723e000 rw-p [heap]
ffb49000 ffb6a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6475)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf70fd228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7094539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6d9b3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6d99c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6da5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dabbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dabdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6de075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ddb1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6d99c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6da5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dabbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dabdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ddde5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6dde017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6de5f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf477d1fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4770171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6843663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6cf0fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6cf27a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6e82ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6e7db4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6e7e5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6e7e879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70b6183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70b67fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf70fd4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f4a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf70fcf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
on-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:07:18.529+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:18.529+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:388,0.045005,9.772315,0.818672
04-23 20:07:18.539+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:18.539+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:546,0.046613,9.772201,0.819941
04-23 20:07:18.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:18.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:554,0.049352,9.772566,0.815417
04-23 20:07:18.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:18.559+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:562,0.047706,9.772522,0.816046
04-23 20:07:18.559+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:18.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:573,0.048074,9.772372,0.817811
04-23 20:07:18.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:18.579+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:579,0.048781,9.772423,0.817169
04-23 20:07:18.579+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:18.619+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:18.619+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:589,0.047634,9.772285,0.818871
04-23 20:07:18.629+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:07:18.629+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:07:18.629+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:07:18.629+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f1ddb8
04-23 20:07:18.689+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:18.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:697,0.047095,9.772408,0.817436
04-23 20:07:18.689+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:18.699+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:702,0.047397,9.772497,0.816360
04-23 20:07:18.709+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:18.719+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:723,0.046192,9.772518,0.816173
04-23 20:07:18.729+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:18.729+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:733,0.045058,9.772365,0.818068
04-23 20:07:18.739+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:18.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:747,0.042183,9.773324,0.806691
04-23 20:07:18.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:18.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:774,0.045851,9.772711,0.813880
04-23 20:07:18.819+0200 W/AUL     ( 6439): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:07:18.819+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:07:18.819+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:07:18.819+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6403
04-23 20:07:18.819+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:07:18.819+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6403
04-23 20:07:18.819+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6403)
04-23 20:07:18.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:18.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:18:975,0.050683,9.773031,0.809737
04-23 20:07:19.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:19.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:19:174,0.048391,9.772748,0.813288
04-23 20:07:19.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:19.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:19:374,0.054008,9.773057,0.809214
04-23 20:07:19.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:19.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:19:575,0.053771,9.772807,0.812236
04-23 20:07:19.639+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:07:19.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:19.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:19:774,0.063173,9.773804,0.799476
04-23 20:07:19.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:19.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:19:974,0.057455,9.773813,0.799786
04-23 20:07:20.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:20.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:20:174,0.049708,9.773566,0.803312
04-23 20:07:20.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:20.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:20:374,0.050085,9.773760,0.800930
04-23 20:07:20.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:20.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:20:575,0.051878,9.772829,0.812104
04-23 20:07:20.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:20.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:20:774,0.051540,9.774024,0.797615
04-23 20:07:20.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:20.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:20:975,0.066433,9.774487,0.790800
04-23 20:07:21.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:21.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:21:174,0.069998,9.774659,0.788368
04-23 20:07:21.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:21.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:21:374,0.062837,9.774782,0.787444
04-23 20:07:21.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:21.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:21:576,0.068474,9.776134,0.770002
04-23 20:07:21.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:21.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:21:774,0.070584,9.775918,0.772545
04-23 20:07:21.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:21.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:21:974,0.063278,9.775066,0.783872
04-23 20:07:22.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:22.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:22:174,0.061545,9.774851,0.786692
04-23 20:07:22.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:22.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:22:374,0.064440,9.775074,0.783684
04-23 20:07:22.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:22.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:22:574,0.064568,9.774526,0.790481
04-23 20:07:22.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:22.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:22:774,0.067065,9.773941,0.797471
04-23 20:07:22.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:22.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:22:973,0.063942,9.774344,0.792772
04-23 20:07:23.179+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:23.179+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:23:183,0.072314,9.774964,0.784361
04-23 20:07:23.379+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:23.379+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:23:383,0.050835,9.774273,0.794604
04-23 20:07:23.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:23.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:23:573,0.044494,9.773024,0.810188
04-23 20:07:23.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:23.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:23:774,0.052298,9.774493,0.791791
04-23 20:07:23.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:23.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:23:973,0.051008,9.774423,0.792745
04-23 20:07:24.179+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:24.179+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:24:183,0.046175,9.774056,0.797540
04-23 20:07:24.379+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:24.379+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:24:383,0.042235,9.772763,0.813443
04-23 20:07:24.579+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:24.579+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:24:583,0.044298,9.771412,0.829417
04-23 20:07:24.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:24.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:24:773,0.052990,9.772657,0.814095
04-23 20:07:24.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:24.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:24:974,0.058726,9.773042,0.809071
04-23 20:07:25.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:25.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:25:173,0.063273,9.772816,0.811452
04-23 20:07:25.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:25.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:25:374,0.048703,9.772035,0.821799
04-23 20:07:25.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:25.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:25:574,0.041301,9.772981,0.810877
04-23 20:07:25.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:25.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:25:774,0.055949,9.773393,0.805017
04-23 20:07:25.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:25.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:25:973,0.056632,9.772980,0.809969
04-23 20:07:26.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:26.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:26:174,0.061131,9.773218,0.806750
04-23 20:07:26.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:26.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:26:374,0.071455,9.774600,0.788966
04-23 20:07:26.539+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:07:26.539+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:07:26.539+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:26.539+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:26.549+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6475
04-23 20:07:26.549+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:07:26.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:26.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:26:574,0.047716,9.774015,0.797950
04-23 20:07:26.599+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6475
04-23 20:07:26.599+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6475) type(svcapp) bg(0)
04-23 20:07:26.599+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6475]
04-23 20:07:26.609+0200 E/CAPI_APPFW_APPLICATION( 6475): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:07:26.609+0200 E/CAPI_APPFW_APPLICATION( 6475): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:07:26.609+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6475) was created
04-23 20:07:26.619+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:07:26.629+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6475)
04-23 20:07:26.629+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:07:26.629+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:07:26.629+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6475
04-23 20:07:26.629+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:07:26.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:07:26.669+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6475
04-23 20:07:26.669+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:07:26.679+0200 W/LOCATION( 6475): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:07:26.679+0200 E/LOCATION( 6475): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:07:26.679+0200 E/PKGMGR_INFO( 6475): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:07:26.679+0200 W/LOCATION( 6475): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:26.699+0200 I/LOCATION( 6475): location.c: location_new(269) > method: 0
04-23 20:07:26.699+0200 W/LOCATION( 6475): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:26.699+0200 W/LOCATION( 6475): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:26.709+0200 W/LOCATION( 6475): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:26.709+0200 W/LOCATION( 6475): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:26.719+0200 W/LOCATION( 6475): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:26.719+0200 W/LOCATION( 6475): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:26.719+0200 W/LOCATION( 6475): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:26.719+0200 W/LOCATION( 6475): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:26.719+0200 W/LOCATION( 6475): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:26.739+0200 W/LOCATION( 6475): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:07:26.739+0200 W/LOCATION( 6475): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:07:26.749+0200 W/LOCATION( 6475): module-internal.c: module_new(311) > module (wps) open success
04-23 20:07:26.749+0200 W/LOCATION( 6475): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:07:26.749+0200 W/LOCATION( 6475): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:07:26.749+0200 W/LOCATION( 6475): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:07:26.749+0200 W/LOCATION( 6475): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:07:26.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:26.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:26:774,0.042392,9.773643,0.802801
04-23 20:07:26.779+0200 W/LOCATION( 6475): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:07:26.779+0200 I/LOCATION( 6475): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf71e4c18
04-23 20:07:26.779+0200 I/LOCATION( 6475): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:07:26.779+0200 I/LOCATION( 6475): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf71e4c18
04-23 20:07:26.779+0200 I/LOCATION( 6475): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:07:26.779+0200 I/location( 6475): es.ugr.frailty.location: creado servicio de localización
04-23 20:07:26.819+0200 I/LOCATION( 6475): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:07:26.859+0200 W/LOCATION( 6475): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:26.859+0200 W/LOCATION( 6475): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:26.859+0200 I/LOCATION( 6475): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:07:26.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:07:26.929+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:07:26.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:07:26.929+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:07:26.929+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:07:26.929+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:07:26.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:26.929+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:26.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:07:26.929+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:07:26.929+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:07:26.939+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:07:26.939+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:07:26.939+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:07:26.939+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:07:26.939+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:07:26.939+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:07:26.939+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:07:26.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:26.989+0200 W/LOCATION( 6475): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:07:26.989+0200 W/LOCATION( 6475): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:07:27.009+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:26:979,0.061856,9.774818,0.787077
04-23 20:07:27.069+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:27.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf79e45a8]
04-23 20:07:27.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:07:27.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:07:27.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:07:27.099+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:07:27.109+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:27.109+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:27.119+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:27.129+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:27.129+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:07:27.129+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:07:27.129+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:27.129+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:27.129+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:27.129+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:27.129+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:27.129+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:27.129+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:27.139+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:27.139+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:27.139+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:07:27.149+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:27.179+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:07:27.179+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(922442), time2(909298)
04-23 20:07:27.179+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:07:27.179+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:07:27.179+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:07:27.179+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:07:27.189+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:27.209+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.229+0200 W/LOCATION( 6475): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:07:27.229+0200 I/LOCATION( 6475): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:07:27.229+0200 I/LOCATION( 6475): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:07:27.229+0200 I/location( 6475): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:07:27.239+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:221,0.061414,9.774545,0.790496
04-23 20:07:27.309+0200 I/LOCATION( 6475): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:07:27.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:07:27.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:27.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:07:27.359+0200 E/location( 6475): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:07:27.359+0200 W/AUL     ( 6475): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:07:27.359+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:27.359+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6475
04-23 20:07:27.369+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:07:27.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.379+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:27.379+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:07:27.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:27.379+0200 I/utils   ( 5532): specific action
04-23 20:07:27.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:27.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:27.379+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:27.379+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:07:27.379+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:27.379+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:27.389+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:07:27.389+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:07:27.389+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:07:27.389+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:07:27.389+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:381,0.056411,9.774254,0.794456
04-23 20:07:27.389+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.399+0200 W/AUL     ( 6475): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:07:27.399+0200 I/location( 6475): request sent to service es.ugr.frailty.servicemanager
04-23 20:07:27.399+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:27.399+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:27.399+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:07:27.399+0200 W/CAPI_APPFW_APP_CONTROL( 6475): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:27.399+0200 I/utils   ( 6475): specific action
04-23 20:07:27.399+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:399,0.056958,9.774251,0.794457
04-23 20:07:27.399+0200 I/utils   ( 5538): specific action
04-23 20:07:27.399+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:27.399+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:27.399+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:27.399+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:27.399+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:07:27.399+0200 I/recorder( 5538): guardando datos en local
04-23 20:07:27.409+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.409+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:416,0.058155,9.774311,0.793630
04-23 20:07:27.429+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.429+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:433,0.059165,9.774340,0.793199
04-23 20:07:27.439+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.449+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:453,0.060353,9.774325,0.793288
04-23 20:07:27.469+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.469+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:474,0.059002,9.774164,0.795368
04-23 20:07:27.489+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.489+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:493,0.057697,9.774138,0.795779
04-23 20:07:27.499+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.509+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:513,0.057713,9.774170,0.795401
04-23 20:07:27.519+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.529+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:533,0.057719,9.774162,0.795484
04-23 20:07:27.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:553,0.059192,9.774102,0.796122
04-23 20:07:27.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:573,0.058219,9.774118,0.795993
04-23 20:07:27.579+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.589+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:592,0.057747,9.774044,0.796938
04-23 20:07:27.609+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.609+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:613,0.055250,9.773973,0.797997
04-23 20:07:27.619+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.629+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:632,0.053330,9.773921,0.798755
04-23 20:07:27.639+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.649+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:652,0.054131,9.773888,0.799103
04-23 20:07:27.669+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.669+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:674,0.054202,9.773840,0.799683
04-23 20:07:27.679+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:692,0.054602,9.773772,0.800489
04-23 20:07:27.699+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.709+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:712,0.054641,9.773761,0.800624
04-23 20:07:27.729+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.729+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:733,0.055370,9.773894,0.798942
04-23 20:07:27.739+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:753,0.055500,9.773796,0.800136
04-23 20:07:27.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:773,0.055397,9.773763,0.800545
04-23 20:07:27.789+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.789+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:793,0.056437,9.773823,0.799741
04-23 20:07:27.799+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.809+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:813,0.055262,9.773862,0.799343
04-23 20:07:27.819+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.829+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:832,0.056991,9.773886,0.798934
04-23 20:07:27.839+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.849+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:853,0.060411,9.773812,0.799579
04-23 20:07:27.869+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.869+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:873,0.059507,9.773779,0.800056
04-23 20:07:27.879+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.889+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:892,0.057967,9.773667,0.801528
04-23 20:07:27.899+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.909+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:913,0.056938,9.773690,0.801326
04-23 20:07:27.919+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.929+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:933,0.054687,9.773696,0.801417
04-23 20:07:27.939+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:952,0.053610,9.773630,0.802290
04-23 20:07:27.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:27.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:974,0.053155,9.773570,0.803051
04-23 20:07:27.979+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.029+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:27:992,0.053167,9.773518,0.803683
04-23 20:07:28.029+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.039+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:41,0.053174,9.773469,0.804279
04-23 20:07:28.039+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.049+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:53,0.052962,9.773481,0.804139
04-23 20:07:28.049+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.049+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:58,0.052525,9.773610,0.802603
04-23 20:07:28.089+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.089+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:99,0.052676,9.773642,0.802211
04-23 20:07:28.119+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.119+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:123,0.052138,9.773570,0.803114
04-23 20:07:28.119+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.119+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:127,0.051619,9.773715,0.801380
04-23 20:07:28.119+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.129+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:132,0.051812,9.773746,0.800983
04-23 20:07:28.139+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.149+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:152,0.051311,9.773693,0.801675
04-23 20:07:28.179+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.179+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:183,0.050949,9.773654,0.802169
04-23 20:07:28.209+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:07:28.219+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.219+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:223,0.051284,9.773689,0.801722
04-23 20:07:28.219+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.229+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:229,0.051416,9.773706,0.801495
04-23 20:07:28.229+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.229+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:235,0.052215,9.773882,0.799306
04-23 20:07:28.239+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.249+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:252,0.051932,9.774003,0.797844
04-23 20:07:28.269+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.269+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:274,0.051790,9.774081,0.796895
04-23 20:07:28.279+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.289+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:292,0.053464,9.774212,0.795183
04-23 20:07:28.299+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.309+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:313,0.053788,9.774105,0.796468
04-23 20:07:28.329+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:07:28.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:28.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:07:28.339+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:333,0.053194,9.774054,0.797139
04-23 20:07:28.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:353,0.053314,9.773938,0.798550
04-23 20:07:28.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:374,0.053539,9.774034,0.797368
04-23 20:07:28.389+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.389+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:393,0.052966,9.773919,0.798807
04-23 20:07:28.399+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.409+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:412,0.051715,9.773946,0.798557
04-23 20:07:28.419+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.429+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:432,0.052466,9.773935,0.798639
04-23 20:07:28.439+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.449+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:453,0.053528,9.773975,0.798075
04-23 20:07:28.469+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.469+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:474,0.054675,9.773911,0.798777
04-23 20:07:28.479+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.489+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:492,0.053751,9.773643,0.802112
04-23 20:07:28.499+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.509+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:513,0.052015,9.773658,0.802058
04-23 20:07:28.539+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.589+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:543,0.050956,9.773580,0.803080
04-23 20:07:28.589+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.599+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:602,0.052318,9.773641,0.802244
04-23 20:07:28.599+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.599+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:606,0.053272,9.773626,0.802353
04-23 20:07:28.599+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.609+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:612,0.052812,9.773690,0.801611
04-23 20:07:28.609+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.609+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:617,0.053069,9.773789,0.800381
04-23 20:07:28.619+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.629+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:633,0.053310,9.773803,0.800198
04-23 20:07:28.639+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.649+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:652,0.051240,9.773778,0.800636
04-23 20:07:28.669+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.669+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:673,0.052146,9.773917,0.798882
04-23 20:07:28.679+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:693,0.054280,9.774199,0.795278
04-23 20:07:28.699+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.709+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:713,0.054228,9.774341,0.793547
04-23 20:07:28.719+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.729+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:732,0.055430,9.774257,0.794497
04-23 20:07:28.739+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.749+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:753,0.055001,9.774105,0.796391
04-23 20:07:28.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:773,0.051988,9.773927,0.798771
04-23 20:07:28.779+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.789+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:792,0.052270,9.773937,0.798622
04-23 20:07:28.799+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.809+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:813,0.051876,9.773981,0.798114
04-23 20:07:28.819+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.829+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:832,0.052619,9.774084,0.796808
04-23 20:07:28.839+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.849+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:852,0.052991,9.774123,0.796303
04-23 20:07:28.869+0200 W/LOCATION( 6475): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:07:28.879+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.889+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:887,0.053570,9.774041,0.797267
04-23 20:07:28.889+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.899+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:900,0.052554,9.773948,0.798484
04-23 20:07:28.909+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.909+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:913,0.052601,9.773917,0.798855
04-23 20:07:28.919+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.929+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:933,0.052175,9.773896,0.799134
04-23 20:07:28.939+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.949+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:952,0.051417,9.773928,0.798792
04-23 20:07:28.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:973,0.050465,9.773917,0.798983
04-23 20:07:28.979+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:28.989+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:28:993,0.049790,9.773884,0.799441
04-23 20:07:28.999+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:29.009+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:29:12,0.050617,9.773605,0.802777
04-23 20:07:29.019+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:29.029+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:29:32,0.052533,9.773605,0.802660
04-23 20:07:29.049+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:29.049+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:29:53,0.053831,9.773782,0.800427
04-23 20:07:29.079+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:29.079+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:29:87,0.054706,9.773838,0.799676
04-23 20:07:29.099+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:29.119+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:29:112,0.053822,9.773857,0.799502
04-23 20:07:29.119+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:29.129+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:29:131,0.052448,9.773795,0.800356
04-23 20:07:29.129+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:29.139+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11064756c6f63152450684
