S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 6624
Date: 2018-04-23 20:07:55+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70cc52d, r5   = 0xf7662f98
r6   = 0xffba4690, r7   = 0xffba4540
r8   = 0xf765fc18, r9   = 0x00000000
r10  = 0xffba461c, fp   = 0xffba4690
ip   = 0x00000001, sp   = 0xffba4518
lr   = 0xf70cc539, pc   = 0xf7135228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    111692 KB
Buffers:     38568 KB
Cached:     184576 KB
VmPeak:      52508 KB
VmSize:      52504 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11980 KB
VmRSS:       11980 KB
VmData:      10232 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 6624 TID = 6624
6624 6627 

Maps Information
f3f97000 f4796000 rw-p [stack:6627]
f479d000 f479f000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47a7000 f47ab000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47b4000 f47b6000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47be000 f47c1000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47d0000 f47d5000 r-xp /usr/lib/libsystem.so.0.0.0
f47e0000 f47e3000 r-xp /lib/libattr.so.1.1.0
f47eb000 f47fb000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4803000 f480c000 r-xp /usr/lib/libedbus.so.1.7.99
f4814000 f4815000 r-xp /usr/lib/libresponse.so.0.2.96
f481e000 f4823000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60c5000 f61cb000 r-xp /usr/lib/libicuuc.so.57.1
f61e1000 f6369000 r-xp /usr/lib/libicui18n.so.57.1
f6379000 f6386000 r-xp /usr/lib/libail.so.0.1.0
f638f000 f6396000 r-xp /usr/lib/libminizip.so.1.0.0
f639f000 f6548000 r-xp /usr/lib/libcrypto.so.1.0.0
f6568000 f65af000 r-xp /usr/lib/libssl.so.1.0.0
f65bb000 f65bd000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65c5000 f65cc000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65d5000 f65dc000 r-xp /lib/libcrypt-2.13.so
f660d000 f6610000 r-xp /lib/libcap.so.2.21
f6618000 f661a000 r-xp /usr/lib/libiri.so
f6622000 f666b000 r-xp /usr/lib/libmdm.so.1.2.69
f6673000 f6679000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6681000 f66a4000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66ae000 f66b0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66b8000 f66d5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66de000 f66e2000 r-xp /usr/lib/libsmack.so.1.0.0
f66eb000 f6704000 r-xp /usr/lib/libnetwork.so.0.0.0
f670d000 f6715000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f671d000 f6723000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f672c000 f672e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6737000 f6747000 r-xp /lib/libresolv-2.13.so
f674b000 f6763000 r-xp /usr/lib/liblzma.so.5.0.3
f676c000 f676e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6776000 f6790000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6798000 f67c7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67d0000 f67df000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f67e9000 f67f3000 r-xp /usr/lib/libsensord-shared.so
f67fc000 f68cf000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68da000 f68f0000 r-xp /lib/libz.so.1.2.5
f68f8000 f68fd000 r-xp /usr/lib/libffi.so.5.0.10
f6905000 f6906000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f690e000 f691e000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6926000 f693f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6947000 f6949000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6951000 f69c6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69d0000 f69d6000 r-xp /lib/librt-2.13.so
f69df000 f69fd000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a07000 f6a08000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a10000 f6a33000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a3b000 f6a40000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a48000 f6a72000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a7b000 f6a92000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6a9a000 f6b03000 r-xp /lib/libm-2.13.so
f6b0c000 f6ba0000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bb3000 f6bb8000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bc0000 f6bc7000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6bcf000 f6bf9000 r-xp /usr/lib/libsensor.so.1.9.6
f6c02000 f6cce000 r-xp /usr/lib/libxml2.so.2.7.8
f6cdb000 f6cdd000 r-xp /usr/lib/libiniparser.so.0
f6ce6000 f6cec000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cf5000 f6dc5000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dc6000 f6dfa000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e03000 f6e3f000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e47000 f6e4a000 r-xp /usr/lib/libbundle.so.0.1.22
f6e52000 f6e58000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e60000 f6ea1000 r-xp /usr/lib/libeina.so.1.7.99
f6eaa000 f6ec1000 r-xp /usr/lib/libecore.so.1.7.99
f6ed8000 f6ee1000 r-xp /usr/lib/libvconf.so.0.2.45
f6ee9000 f6efd000 r-xp /lib/libpthread-2.13.so
f6f08000 f6f15000 r-xp /usr/lib/libaul.so.0.1.0
f6f1f000 f6f21000 r-xp /lib/libdl-2.13.so
f6f2a000 f6f35000 r-xp /lib/libunwind.so.8.0.1
f6f62000 f6f6a000 r-xp /lib/libgcc_s-4.6.so.1
f6f6b000 f708f000 r-xp /lib/libc-2.13.so
f709d000 f709f000 r-xp /usr/lib/libdlog.so.0.0.0
f70a7000 f70b3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70bc000 f70c1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70c9000 f70d8000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70e0000 f70e4000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f70ed000 f70f0000 r-xp /usr/lib/libappcore-agent.so.1.1
f70f8000 f70fa000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7102000 f7106000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f710e000 f712b000 r-xp /lib/ld-2.13.so
f7134000 f7137000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7137000 f713b000 r-xp /usr/lib/libsys-assert.so
f762f000 f76b8000 rw-p [heap]
ffb85000 ffba6000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6624)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7135228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf70cc539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6dd33f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6dd1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6ddde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6de3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6de3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e1875b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e131f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6dd1c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6ddde57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6de3be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6de3dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e15e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e16017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e1df93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf47b51fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf47a8171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf687b663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d28fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d2a7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ebaca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6eb5b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6eb65a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6eb6879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf70ee183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf70ee7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71354f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6f8285c) [/lib/libc.so.6] + 0x1785c
29: (0xf7134f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 20:07:44.269+0200 E/location( 6567): request sending failed to service es.ugr.frailty.servicemanager
04-23 20:07:44.269+0200 I/CAPI_APPFW_APPLICATION( 6567): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:07:44.269+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:07:44.269+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:07:44.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:07:44.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:44.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:07:44.349+0200 W/LOCATION( 6567): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:07:44.349+0200 I/LOCATION( 6567): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 20:07:44.349+0200 I/LOCATION( 6567): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 20:07:44.349+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.349+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:355,0.046275,9.772449,0.817004
04-23 20:07:44.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.459+0200 W/libgps_d( 3139): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,g)
04-23 20:07:44.459+0200 W/libgps  ( 3139): [proxy__gps_stop][line = 1067]: called.
04-23 20:07:44.459+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:44.459+0200 W/libgps_d( 3139): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 20:07:44.459+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,g)
04-23 20:07:44.459+0200 W/libgps_d( 3139): GpsiHookStateGps              : EXIT
04-23 20:07:44.459+0200 W/libgps_d( 3139): GpsiHookStateIdle             : ENTRY
04-23 20:07:44.459+0200 E/CAPI_LOCATION_MANAGER( 4477): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 20:07:44.459+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:2
04-23 20:07:44.469+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:374,0.047626,9.772483,0.816514
04-23 20:07:44.479+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.479+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:485,0.047663,9.772552,0.815685
04-23 20:07:44.509+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.509+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:514,0.047930,9.772593,0.815166
04-23 20:07:44.519+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.519+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:524,0.047724,9.772634,0.814698
04-23 20:07:44.529+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.529+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:537,0.047866,9.772617,0.814884
04-23 20:07:44.539+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:553,0.047559,9.772823,0.812428
04-23 20:07:44.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:574,0.046792,9.772941,0.811059
04-23 20:07:44.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:578,0.049273,9.773099,0.809003
04-23 20:07:44.589+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.589+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:593,0.048580,9.772939,0.810987
04-23 20:07:44.599+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.609+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:612,0.049378,9.772969,0.810571
04-23 20:07:44.609+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.619+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:621,0.049898,9.772914,0.811206
04-23 20:07:44.629+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.629+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:639,0.050861,9.773029,0.809748
04-23 20:07:44.639+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.639+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:647,0.050287,9.773134,0.808519
04-23 20:07:44.649+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.659+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:665,0.050421,9.773111,0.808787
04-23 20:07:44.679+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:44.679+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:692,0.050551,9.773202,0.807679
04-23 20:07:44.689+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.689+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:697,0.052185,9.773371,0.805535
04-23 20:07:44.689+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.699+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:702,0.051195,9.773429,0.804895
04-23 20:07:44.699+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.709+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:712,0.050021,9.773466,0.804517
04-23 20:07:44.719+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.729+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:732,0.049828,9.773478,0.804386
04-23 20:07:44.739+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:07:44.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:07:44.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:07:44.759+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f10d38
04-23 20:07:44.809+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:751,0.050908,9.773681,0.801848
04-23 20:07:44.809+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:44.809+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f30f98]
04-23 20:07:44.809+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:07:44.809+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:07:44.809+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:07:44.809+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:07:44.819+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:44.819+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:44.829+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:44.849+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:44.849+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:07:44.849+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:07:44.849+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:44.849+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:44.849+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:44.849+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:44.849+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:44.849+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:44.849+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:44.859+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:44.869+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:44.869+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:07:44.869+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:44.899+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:44:822,0.050671,9.773740,0.801145
04-23 20:07:44.919+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:44.979+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:45.029+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:07:45.029+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:07:45.029+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:07:45.029+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f30f98
04-23 20:07:45.089+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f1d9d8]
04-23 20:07:45.089+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:07:45.089+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:07:45.089+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:07:45.089+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:07:45.099+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:45.099+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:45.119+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:45.119+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:45.119+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:07:45.119+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:07:45.119+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:45.119+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:45.129+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:45.129+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:45.129+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:45.129+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:45.129+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:45.139+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:45.149+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:45.149+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:07:45.149+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:45.189+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:45.199+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 20:07:45.199+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 20:07:45.199+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 20:07:45.199+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_destroy(471) > Destroy handle: 0xf3f1d9d8
04-23 20:07:45.229+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.239+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:245,0.050340,9.773581,0.803101
04-23 20:07:45.249+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.249+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:256,0.050473,9.773663,0.802096
04-23 20:07:45.299+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.309+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:313,0.050264,9.773695,0.801716
04-23 20:07:45.319+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.319+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:326,0.051193,9.773733,0.801184
04-23 20:07:45.339+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.359+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:348,0.051874,9.774016,0.797685
04-23 20:07:45.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:375,0.053093,9.774090,0.796702
04-23 20:07:45.379+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.389+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:387,0.052867,9.774190,0.795488
04-23 20:07:45.389+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.399+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:403,0.053108,9.774139,0.796097
04-23 20:07:45.399+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.429+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:408,0.052887,9.774090,0.796718
04-23 20:07:45.429+0200 W/AUL     ( 6585): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 20:07:45.429+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:07:45.429+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:07:45.429+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6547
04-23 20:07:45.429+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:07:45.429+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6547
04-23 20:07:45.429+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6547)
04-23 20:07:45.439+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.439+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:448,0.052781,9.774026,0.797508
04-23 20:07:45.439+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.449+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:452,0.053145,9.774102,0.796545
04-23 20:07:45.449+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.449+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:457,0.053164,9.773965,0.798226
04-23 20:07:45.459+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.459+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:464,0.054189,9.774057,0.797027
04-23 20:07:45.459+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.469+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:472,0.053914,9.774089,0.796656
04-23 20:07:45.469+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.479+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:489,0.056451,9.774118,0.796115
04-23 20:07:45.489+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.489+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:498,0.056065,9.774065,0.796805
04-23 20:07:45.499+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.499+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:503,0.057511,9.774190,0.795164
04-23 20:07:45.499+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.499+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:508,0.059111,9.774224,0.794622
04-23 20:07:45.499+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.509+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:513,0.058813,9.774214,0.794777
04-23 20:07:45.519+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.519+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:523,0.058205,9.774148,0.795625
04-23 20:07:45.519+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.519+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:529,0.057984,9.774106,0.796164
04-23 20:07:45.529+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.529+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:534,0.057762,9.774143,0.795716
04-23 20:07:45.529+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.539+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:540,0.057887,9.774121,0.795986
04-23 20:07:45.539+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:551,0.059589,9.774090,0.796245
04-23 20:07:45.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.549+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:556,0.060772,9.774097,0.796059
04-23 20:07:45.549+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.559+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:561,0.061558,9.774096,0.796005
04-23 20:07:45.559+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.559+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:566,0.060387,9.773969,0.797668
04-23 20:07:45.559+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:573,0.058673,9.773957,0.797938
04-23 20:07:45.579+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.579+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:583,0.057053,9.773873,0.799083
04-23 20:07:45.579+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.579+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:588,0.056074,9.773875,0.799126
04-23 20:07:45.579+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.589+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:592,0.063824,9.773237,0.806318
04-23 20:07:45.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:773,0.062761,9.772492,0.815377
04-23 20:07:45.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:45.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:45:973,0.046907,9.772087,0.821276
04-23 20:07:46.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:46.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:46:173,0.057818,9.772742,0.812747
04-23 20:07:46.269+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:07:46.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:46.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:46:373,0.051445,9.773757,0.800879
04-23 20:07:46.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:46.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:46:575,0.052878,9.773269,0.806729
04-23 20:07:46.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:46.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:46:773,0.041853,9.772631,0.815060
04-23 20:07:46.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:46.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:46:973,0.044901,9.773583,0.803386
04-23 20:07:47.169+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:47.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:47:174,0.042875,9.774756,0.789106
04-23 20:07:47.359+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:47.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:47:371,0.045592,9.773734,0.801511
04-23 20:07:47.569+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:47.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:47:573,0.052169,9.774036,0.797420
04-23 20:07:47.769+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:47.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:47:773,0.046141,9.774252,0.795150
04-23 20:07:47.969+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:47.969+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:47:973,0.041325,9.773902,0.799700
04-23 20:07:48.159+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:48.169+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:48:172,0.039670,9.774056,0.797890
04-23 20:07:48.369+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:48.369+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:48:373,0.033016,9.773599,0.803782
04-23 20:07:48.559+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:48.569+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:48:571,0.036576,9.774799,0.788893
04-23 20:07:48.759+0200 I/gravity ( 6253): capturing data from es.ugr.frailty.gravity
04-23 20:07:48.769+0200 I/gravity ( 6253): es.ugr.frailty.gravity: SM-R760,23/04/2018,20:07:48:771,0.051596,9.775171,0.783424
04-23 20:07:48.939+0200 I/servicemanager( 5532): es.ugr.frailty.gravity sleep timeout
04-23 20:07:48.939+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 20:07:48.939+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:48.939+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:48.949+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 6253
04-23 20:07:48.949+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6253)
04-23 20:07:48.949+0200 I/servicemanager( 5532): es.ugr.frailty.gravity stop request sent!
04-23 20:07:48.949+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:07:48.949+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:48.949+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(6253), cmd(0)
04-23 20:07:48.959+0200 I/gravity ( 6253): stopping es.ugr.frailty.gravity service
04-23 20:07:48.959+0200 W/AUL     ( 6253): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:07:48.959+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:48.959+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6253
04-23 20:07:48.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:07:48.969+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:48.969+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:07:49.019+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:49.019+0200 I/utils   ( 5532): specific action
04-23 20:07:49.019+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:49.019+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:49.019+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:49.019+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:49.019+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:49.019+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:07:49.029+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:49.029+0200 W/AUL     ( 6253): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:07:49.029+0200 I/gravity ( 6253): request sent to service es.ugr.frailty.servicemanager
04-23 20:07:49.029+0200 I/CAPI_APPFW_APPLICATION( 6253): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 20:07:49.029+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:49.039+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:07:49.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 20:07:49.039+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(999) > app status : 4
04-23 20:07:49.059+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:49.059+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:07:49.079+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:49.079+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:07:49.079+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:07:49.079+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:07:49.079+0200 I/utils   ( 5538): specific action
04-23 20:07:49.079+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:49.079+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:49.079+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:49.079+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:49.079+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:49.079+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:49.079+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gravity.csv
04-23 20:07:49.079+0200 I/recorder( 5538): guardando datos en local
04-23 20:07:49.099+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:07:49.119+0200 E/PKGMGR_INFO( 2974): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 20:07:49.139+0200 I/gravity ( 6253): es.ugr.frailty.gravity listener destroyed
04-23 20:07:49.289+0200 W/AUL     ( 6594): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gravity]
04-23 20:07:49.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 20:07:49.289+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 20:07:49.289+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 6253
04-23 20:07:49.289+0200 W/AUL_AMD ( 2481): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 20:07:49.289+0200 I/AUL_AMD ( 2481): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 6253
04-23 20:07:49.289+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(6253)
04-23 20:07:51.039+0200 W/AUL_AMD ( 2481): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 20:07:52.949+0200 I/servicemanager( 5532): es.ugr.frailty.location alive timeout
04-23 20:07:52.949+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 20:07:52.959+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:52.959+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:52.969+0200 W/AUL_AMD ( 2481): amd_launch.c: start_process(606) > child process: 6624
04-23 20:07:52.969+0200 E/RESOURCED( 2560): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 20:07:53.019+0200 W/AUL_AMD ( 2481): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 6624
04-23 20:07:53.019+0200 W/AUL     ( 2481): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(6624) type(svcapp) bg(0)
04-23 20:07:53.019+0200 W/STARTER ( 2705): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [6624]
04-23 20:07:53.019+0200 E/CAPI_APPFW_APPLICATION( 6624): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:07:53.019+0200 E/CAPI_APPFW_APPLICATION( 6624): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 20:07:53.019+0200 W/AUL_AMD ( 2481): amd_status.c: __socket_monitor_cb(1277) > (6624) was created
04-23 20:07:53.039+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(6624)
04-23 20:07:53.039+0200 I/servicemanager( 5532): es.ugr.frailty.location launch request sent!
04-23 20:07:53.039+0200 I/servicemanager( 5532): App control destroyed.
04-23 20:07:53.049+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:07:53.049+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6624
04-23 20:07:53.049+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 20:07:53.059+0200 W/LOCATION( 6624): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 20:07:53.059+0200 E/LOCATION( 6624): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 20:07:53.059+0200 E/PKGMGR_INFO( 6624): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 20:07:53.059+0200 W/AUL_AMD ( 2481): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 6624
04-23 20:07:53.059+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:07:53.059+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 20:07:53.069+0200 W/LOCATION( 6624): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:53.089+0200 I/LOCATION( 6624): location.c: location_new(269) > method: 0
04-23 20:07:53.089+0200 W/LOCATION( 6624): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:53.089+0200 W/LOCATION( 6624): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:53.099+0200 W/LOCATION( 6624): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:53.099+0200 W/LOCATION( 6624): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:53.109+0200 W/LOCATION( 6624): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:53.109+0200 W/LOCATION( 6624): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:53.109+0200 W/LOCATION( 6624): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:53.109+0200 W/LOCATION( 6624): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:53.109+0200 W/LOCATION( 6624): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:53.129+0200 W/LOCATION( 6624): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:07:53.129+0200 W/LOCATION( 6624): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 20:07:53.139+0200 W/LOCATION( 6624): module-internal.c: module_new(311) > module (wps) open success
04-23 20:07:53.139+0200 W/LOCATION( 6624): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 20:07:53.149+0200 W/LOCATION( 6624): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 20:07:53.149+0200 W/LOCATION( 6624): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:07:53.149+0200 W/LOCATION( 6624): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:07:53.169+0200 W/LOCATION( 6624): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 20:07:53.169+0200 I/LOCATION( 6624): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf765fc18
04-23 20:07:53.169+0200 I/LOCATION( 6624): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 20:07:53.169+0200 I/LOCATION( 6624): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf765fc18
04-23 20:07:53.169+0200 I/LOCATION( 6624): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 20:07:53.169+0200 I/location( 6624): es.ugr.frailty.location: creado servicio de localización
04-23 20:07:53.219+0200 I/LOCATION( 6624): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 20:07:53.259+0200 W/LOCATION( 6624): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:53.259+0200 W/LOCATION( 6624): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:53.259+0200 I/LOCATION( 6624): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:07:53.329+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:26
04-23 20:07:53.329+0200 D/gpsd_d  ( 3121): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 20:07:53.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 20:07:53.329+0200 W/libgps  ( 3139): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 20:07:53.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 20:07:53.329+0200 W/libgps_d( 3139): GpsiHookStateIdle             : EXIT
04-23 20:07:53.329+0200 W/libgps_d( 3139): GpsiHookStateGps              : ENTRY
04-23 20:07:53.329+0200 W/libgps  ( 3139): [proxy__gps_start][line = 1022]: called.
04-23 20:07:53.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:53.329+0200 W/libgps_d( 3139): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:53.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:27
04-23 20:07:53.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:8
04-23 20:07:53.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 20:07:53.339+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:0, msg id:1
04-23 20:07:53.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(11), data(0xf7a02d60), size(4)
04-23 20:07:53.339+0200 W/libgps_d( 3139): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 20:07:53.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 20:07:53.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 20:07:53.389+0200 W/LOCATION( 6624): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 20:07:53.389+0200 W/LOCATION( 6624): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 20:07:53.469+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:53.499+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_create(453) > New handle created[0xf3f2f4b0]
04-23 20:07:53.499+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 20:07:53.499+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 20:07:53.499+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 20:07:53.499+0200 I/CAPI_NETWORK_CONNECTION( 4477): connection.c: connection_get_type(507) > Connected Network = 2
04-23 20:07:53.509+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:53.509+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:53.519+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:53.529+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:53.529+0200 E/LOCATION( 4477): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 20:07:53.529+0200 I/LOCATION( 4477): location.c: location_new(269) > method: 1
04-23 20:07:53.529+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 20:07:53.529+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (gps) open success
04-23 20:07:53.529+0200 W/LOCATION( 4477): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 20:07:53.529+0200 W/LOCATION( 4477): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 20:07:53.529+0200 W/LOCATION( 4477): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 20:07:53.529+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 20:07:53.529+0200 W/LOCATION( 4477): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 20:07:53.539+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:53.549+0200 I/AUL     ( 4477): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 20:07:53.549+0200 E/LOCATION( 4477): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 20:07:53.549+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:53.589+0200 I/SECURE_STORAGE( 2501): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 20:07:53.589+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 20:07:53.589+0200 W/libgps  ( 3139): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(948859), time2(935700)
04-23 20:07:53.589+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 20:07:53.589+0200 W/libgps  ( 3139): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 20:07:53.589+0200 I/libgps_d( 3139): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 20:07:53.589+0200 W/gpsd    ( 3121): HandleIncomingMessage() dest id:2, msg id:25
04-23 20:07:53.619+0200 W/LOCATION( 6624): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 20:07:53.619+0200 I/LOCATION( 6624): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 20:07:53.619+0200 I/LOCATION( 6624): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 20:07:53.619+0200 I/location( 6624): es.ugr.frailty.location:iniciado servicio de localización
04-23 20:07:53.709+0200 I/LOCATION( 6624): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 20:07:53.749+0200 E/location( 6624): es.ugr.frailty.location: error intentando obtener la última localización
04-23 20:07:53.749+0200 W/AUL     ( 6624): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 20:07:53.749+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:53.749+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 6624
04-23 20:07:53.759+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5532
04-23 20:07:53.759+0200 W/AUL     ( 6624): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5532)
04-23 20:07:53.759+0200 I/location( 6624): request sent to service es.ugr.frailty.servicemanager
04-23 20:07:53.759+0200 W/CAPI_APPFW_APP_CONTROL( 6624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:53.769+0200 I/utils   ( 6624): specific action
04-23 20:07:53.769+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:53.769+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:53.769+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5532), cmd(0)
04-23 20:07:53.769+0200 I/utils   ( 5532): specific action
04-23 20:07:53.769+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:53.769+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:53.769+0200 W/CAPI_APPFW_APP_CONTROL( 5532): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:53.769+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 20:07:53.769+0200 W/AUL_AMD ( 2481): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 20:07:53.769+0200 W/AUL_AMD ( 2481): amd_launch.c: _start_app(1782) > caller pid : 5532
04-23 20:07:53.779+0200 W/AUL_AMD ( 2481): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5538
04-23 20:07:53.779+0200 E/AUL_AMD ( 2481): amd_launch.c: __real_send(909) > send fail to client
04-23 20:07:53.779+0200 W/AUL_AMD ( 2481): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(5538), cmd(0)
04-23 20:07:53.779+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:53.779+0200 I/utils   ( 5538): specific action
04-23 20:07:53.779+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:53.779+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:53.779+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:53.779+0200 W/CAPI_APPFW_APP_CONTROL( 5538): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 20:07:53.779+0200 I/recorder( 5538): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 20:07:53.779+0200 I/recorder( 5538): guardando datos en local
04-23 20:07:53.779+0200 W/AUL     ( 5532): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5538)
04-23 20:07:53.789+0200 I/servicemanager( 5532): request sent to service es.ugr.frailty.recorder
04-23 20:07:53.789+0200 I/servicemanager( 5532): requesting to save local data
04-23 20:07:54.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:07:54.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:54.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:07:54.589+0200 E/CAPI_TELEPHONY( 4477): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 20:07:55.179+0200 W/LOCATION( 6624): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 20:07:55.339+0200 W/libgps_d( 3139): OnGpsExtensionMessage: message_id(1), data(0xf7a02d60), size(2752)
04-23 20:07:55.339+0200 W/libgps_d( 3139): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 20:07:55.339+0200 W/libgps  ( 3139): proxy__gps_sv_status_cb : called
04-23 20:07:55.389+0200 W/CRASH_MANAGER( 5620): worker.c: worker_job(1205) > 11066246c6f63152450687
