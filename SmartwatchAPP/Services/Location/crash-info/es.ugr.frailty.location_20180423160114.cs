S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22271
Date: 2018-04-23 16:01:14+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf70e452d, r5   = 0xf770ff98
r6   = 0xffaf22f8, r7   = 0xffaf21a8
r8   = 0xf770cc18, r9   = 0x00000000
r10  = 0xffaf2284, fp   = 0xffaf22f8
ip   = 0x00000001, sp   = 0xffaf1028
lr   = 0xf70e4539, pc   = 0xf714d2b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      5672 KB
Buffers:     60036 KB
Cached:     233896 KB
VmPeak:      52412 KB
VmSize:      52408 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11588 KB
VmRSS:       11588 KB
VmData:      10136 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22271 TID = 22271
22271 22294 

Maps Information
f3faf000 f47ae000 rw-p [stack:22294]
f47b5000 f47b7000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47bf000 f47c3000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47cc000 f47ce000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f47d6000 f47d9000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f47e8000 f47ed000 r-xp /usr/lib/libsystem.so.0.0.0
f47f8000 f47fb000 r-xp /lib/libattr.so.1.1.0
f4803000 f4813000 r-xp /usr/lib/libmdm-common.so.1.1.24
f481b000 f4824000 r-xp /usr/lib/libedbus.so.1.7.99
f482c000 f482d000 r-xp /usr/lib/libresponse.so.0.2.96
f4836000 f483b000 r-xp /usr/lib/libproc-stat.so.0.2.96
f60dd000 f61e3000 r-xp /usr/lib/libicuuc.so.57.1
f61f9000 f6381000 r-xp /usr/lib/libicui18n.so.57.1
f6391000 f639e000 r-xp /usr/lib/libail.so.0.1.0
f63a7000 f63ae000 r-xp /usr/lib/libminizip.so.1.0.0
f63b7000 f6560000 r-xp /usr/lib/libcrypto.so.1.0.0
f6580000 f65c7000 r-xp /usr/lib/libssl.so.1.0.0
f65d3000 f65d5000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f65dd000 f65e4000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f65ed000 f65f4000 r-xp /lib/libcrypt-2.13.so
f6625000 f6628000 r-xp /lib/libcap.so.2.21
f6630000 f6632000 r-xp /usr/lib/libiri.so
f663a000 f6683000 r-xp /usr/lib/libmdm.so.1.2.69
f668b000 f6691000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6699000 f66bc000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66c6000 f66c8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66d0000 f66ed000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f66f6000 f66fa000 r-xp /usr/lib/libsmack.so.1.0.0
f6703000 f671c000 r-xp /usr/lib/libnetwork.so.0.0.0
f6725000 f672d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6735000 f673b000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6744000 f6746000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f674f000 f675f000 r-xp /lib/libresolv-2.13.so
f6763000 f677b000 r-xp /usr/lib/liblzma.so.5.0.3
f6784000 f6786000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f678e000 f67a8000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67b0000 f67df000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67e8000 f67f7000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6801000 f680b000 r-xp /usr/lib/libsensord-shared.so
f6814000 f68e7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f68f2000 f6908000 r-xp /lib/libz.so.1.2.5
f6910000 f6915000 r-xp /usr/lib/libffi.so.5.0.10
f691d000 f691e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6926000 f6936000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f693e000 f6957000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f695f000 f6961000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6969000 f69de000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69e8000 f69ee000 r-xp /lib/librt-2.13.so
f69f7000 f6a15000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a1f000 f6a20000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a28000 f6a4b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a53000 f6a58000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a60000 f6a8a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6a93000 f6aaa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ab2000 f6b1b000 r-xp /lib/libm-2.13.so
f6b24000 f6bb8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bcb000 f6bd0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bd8000 f6bdf000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6be7000 f6c11000 r-xp /usr/lib/libsensor.so.1.9.6
f6c1a000 f6ce6000 r-xp /usr/lib/libxml2.so.2.7.8
f6cf3000 f6cf5000 r-xp /usr/lib/libiniparser.so.0
f6cfe000 f6d04000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d0d000 f6ddd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dde000 f6e12000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e1b000 f6e57000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e5f000 f6e62000 r-xp /usr/lib/libbundle.so.0.1.22
f6e6a000 f6e70000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e78000 f6eb9000 r-xp /usr/lib/libeina.so.1.7.99
f6ec2000 f6ed9000 r-xp /usr/lib/libecore.so.1.7.99
f6ef0000 f6ef9000 r-xp /usr/lib/libvconf.so.0.2.45
f6f01000 f6f15000 r-xp /lib/libpthread-2.13.so
f6f20000 f6f2d000 r-xp /usr/lib/libaul.so.0.1.0
f6f37000 f6f39000 r-xp /lib/libdl-2.13.so
f6f42000 f6f4d000 r-xp /lib/libunwind.so.8.0.1
f6f7a000 f6f82000 r-xp /lib/libgcc_s-4.6.so.1
f6f83000 f70a7000 r-xp /lib/libc-2.13.so
f70b5000 f70b7000 r-xp /usr/lib/libdlog.so.0.0.0
f70bf000 f70cb000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f70d4000 f70d9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f70e1000 f70f0000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f70f8000 f70fc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7105000 f7108000 r-xp /usr/lib/libappcore-agent.so.1.1
f7110000 f7112000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f711a000 f711e000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7126000 f7143000 r-xp /lib/ld-2.13.so
f714c000 f714f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f714f000 f7153000 r-xp /usr/lib/libsys-assert.so
f76dc000 f774d000 rw-p [heap]
ffad3000 ffaf4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22271)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf714d2b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf70e4539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6deb3f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6de9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6df5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6dfbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6dfbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e3075b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e2b1f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6de9c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6df5e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6dfbbe7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6dfbdc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e2de5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e2e017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e328d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf711c0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf47c0171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6893663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d40fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d427a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6ed2ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ecdb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6ece5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6ece879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7106183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71067fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf714d6a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf6f9a85c) [/lib/libc.so.6] + 0x1785c
29: (0xf714cfa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.531+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.531+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.541+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.541+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.541+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.561+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.561+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.561+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.561+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.561+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.561+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.581+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.581+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.581+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:01:23.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:01:23.591+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.601+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.601+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.601+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.601+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.601+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.611+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.611+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.611+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.611+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.611+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.611+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.631+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.631+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.631+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.631+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:23.631+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:23.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:01:23.641+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:01:23.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:01:23.641+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:01:23.641+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:01:23.641+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:01:23.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:23.641+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:01:23.641+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:01:23.641+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:01:23.641+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:01:23.641+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:01:23.641+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:01:23.651+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.651+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.651+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.651+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.651+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.651+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:01:23.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:01:23.651+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:01:23.651+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:01:23.651+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:01:23.661+0200 E/EFL     ( 2316): ecore_x<2316> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=5979316 button=1
04-23 16:01:23.661+0200 E/EFL     ( 2316): <2316> e_mod_processmgr.c:495 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
04-23 16:01:23.681+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.681+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.681+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.701+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.701+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.701+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.711+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.711+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.711+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.721+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(166) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
04-23 16:01:23.731+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.731+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.731+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.731+0200 W/SHealthService( 3091): ContextPedometerProxy.cpp: SOnContextPedometerUpdatedCB(653) > [1;35mpedometerMode: 0, length of Array [1][0;m
04-23 16:01:23.741+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.741+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.741+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.761+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.761+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.761+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.761+0200 W/SHealthCommon( 3091): SHealthMessagePortConnection.cpp: SendServiceMessage(561) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 1[0;m
04-23 16:01:23.761+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
04-23 16:01:23.761+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
04-23 16:01:23.761+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_int(1132) > preference_get_int(3091) : key(pedometer_goal_achieve_percents) error
04-23 16:01:23.761+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_is_existing(1514) > Error : key(best_step_goal) is not exist
04-23 16:01:23.761+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
04-23 16:01:23.761+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
04-23 16:01:23.761+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
04-23 16:01:23.761+0200 E/CAPI_APPFW_APPLICATION_PREFERENCE( 3091): preference.c: preference_get_int(1132) > preference_get_int(3091) : key(best_step_goal) error
04-23 16:01:23.761+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 16:01:23.771+0200 W/SHealthService( 3091): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 16:01:23.781+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.781+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.781+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.781+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1440 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.781+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1445 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.781+0200 E/EFL     ( 2316): evas_main<2316> evas_object_main.c:1450 evas_object_color_set() Evas only handles pre multiplied colors!
04-23 16:01:23.781+0200 W/W_HOME  ( 2775): event_manager.c: _ecore_x_message_cb(437) > moment bar move:0
04-23 16:01:23.781+0200 E/W_INDICATOR( 2704): windicator_util.c: _ecore_event_client_message_cb(1015) > [_ecore_event_client_message_cb:1015] quickpanel 0
04-23 16:01:23.781+0200 E/W_INDICATOR( 2704): windicator_util.c: _ecore_event_client_message_cb(942) > [_ecore_event_client_message_cb:942] quickpanel is closed
04-23 16:01:23.781+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:01:23.781+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:01:23.781+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:01:23.781+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 16:01:23.781+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 16:01:23.781+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:01:23.781+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 16:01:23.781+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:01:23.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:01:23.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:01:23.791+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 16:01:23.791+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.windicator]register msg port [false][0m
04-23 16:01:23.791+0200 W/W_INDICATOR( 2704): windicator_message_port.c: _mp_messageport_register(326) > [_mp_messageport_register:326] Used message-port
04-23 16:01:23.791+0200 E/MESSAGE_PORT( 2704): message_port.cpp: message_port_unregister_local_port(123) > [MESSAGE_PORT_ERROR_PORT_NOT_FOUND] The local port ID (2) is not registered.
04-23 16:01:23.791+0200 E/W_INDICATOR( 2704): windicator_message_port.c: windicator_message_port_fini(356) > [windicator_message_port_fini:356] Failed to unregister music service message port cb
04-23 16:01:23.791+0200 E/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_moment_bar_hide(1556) > [windicator_moment_bar_hide:1556] Hide Moment Bar : dynamic_layout(0xf7903570)
04-23 16:01:23.791+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 16:01:23.791+0200 W/W_INDICATOR( 2704): windicator_connection.c: windi_connection_pause(2080) > [windi_connection_pause:2080] 
04-23 16:01:23.791+0200 E/W_INDICATOR( 2704): windicator_connection.c: windi_connection_pause(2087) > [windi_connection_pause:2087] There is no handle
04-23 16:01:23.791+0200 E/W_INDICATOR( 2704): windicator_util.c: _ecore_event_client_message_cb(942) > [_ecore_event_client_message_cb:942] quickpanel is closed
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 16:01:23.791+0200 I/MESSAGE_PORT( 2461): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 16:01:23.791+0200 E/CAPI_APPFW_APP_CONTROL( 3238): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 16:01:23.791+0200 W/MUSIC_CONTROL_SERVICE( 3238): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3238]   [com.samsung.windicator]register msg port [false][0m
04-23 16:01:23.791+0200 W/W_INDICATOR( 2704): windicator_message_port.c: _mp_messageport_register(326) > [_mp_messageport_register:326] Used message-port
04-23 16:01:23.791+0200 E/MESSAGE_PORT( 2704): message_port.cpp: message_port_unregister_local_port(123) > [MESSAGE_PORT_ERROR_PORT_NOT_FOUND] The local port ID (2) is not registered.
04-23 16:01:23.791+0200 E/W_INDICATOR( 2704): windicator_message_port.c: windicator_message_port_fini(356) > [windicator_message_port_fini:356] Failed to unregister music service message port cb
04-23 16:01:23.791+0200 E/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_moment_bar_hide(1556) > [windicator_moment_bar_hide:1556] Hide Moment Bar : dynamic_layout(0xf7903570)
04-23 16:01:23.791+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 16:01:23.801+0200 W/W_INDICATOR( 2704): windicator_connection.c: windi_connection_pause(2080) > [windi_connection_pause:2080] 
04-23 16:01:23.801+0200 E/W_INDICATOR( 2704): windicator_connection.c: windi_connection_pause(2087) > [windi_connection_pause:2087] There is no handle
04-23 16:01:23.801+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1442) > [5979.462127] layer(0x5ac250) not usable
04-23 16:01:23.801+0200 I/TDM     ( 1785): tdm_display.c: tdm_layer_set_info(1459) > [5979.462147] layer(0x5ac250) info: src(360x360 0,0 360x360 AR24) dst(0,0 360x360) trans(0)
04-23 16:01:23.801+0200 I/TDM     ( 1785): tdm_exynos_display.c: exynos_layer_set_info(1578) > [5979.462163] layer[0x5abcf0]zpos[0]
04-23 16:01:23.811+0200 I/HealthDataService( 2931): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 16:01:23.821+0200 W/LOCATION(22378): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:01:23.821+0200 W/LOCATION(22378): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:01:23.841+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:23.841+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:23.841+0200 I/healthData( 3091): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 16:01:23.881+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:01:23.881+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(5979546), time2(5975077)
04-23 16:01:23.881+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:01:23.881+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:01:23.881+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:01:23.881+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:01:23.921+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:23.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01e70]
04-23 16:01:23.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:23.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:23.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:23.981+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:23.981+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:23.991+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:23.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:01:23.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:01:24.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:24.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:24.011+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:24.011+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:24.011+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:24.011+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:24.011+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:24.011+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:24.011+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:24.011+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:24.011+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:24.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:24.021+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:24.021+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:24.031+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:24.031+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:24.031+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:24.071+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:24.121+0200 W/LOCATION(22378): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:24.121+0200 I/LOCATION(22378): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:24.121+0200 I/LOCATION(22378): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:01:24.121+0200 I/location(22378): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:01:24.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:01:24.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:01:24.231+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:24.231+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:24.241+0200 I/LOCATION(22378): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:24.311+0200 W/AUL     (22378): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:01:24.321+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:24.321+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 22378
04-23 16:01:24.331+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:01:24.341+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:24.341+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:24.341+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:01:24.341+0200 I/utils   (19708): specific action
04-23 16:01:24.341+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:24.341+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:24.341+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:24.341+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:01:24.341+0200 W/AUL     (22378): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:01:24.341+0200 I/location(22378): request sent to service es.ugr.frailty.servicemanager
04-23 16:01:24.341+0200 I/location(22378): stopping es.ugr.frailty.location service
04-23 16:01:24.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:24.341+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:24.351+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21185
04-23 16:01:24.351+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:24.351+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(21185), cmd(0)
04-23 16:01:24.361+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:24.361+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21185)
04-23 16:01:24.361+0200 I/utils   (21185): specific action
04-23 16:01:24.361+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:01:24.361+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:24.361+0200 I/servicemanager(19708): requesting to save local data
04-23 16:01:24.371+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:24.371+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:24.371+0200 W/CAPI_APPFW_APP_CONTROL(21185): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:01:24.371+0200 I/recorder(21185): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:01:24.371+0200 I/recorder(21185): guardando datos en local
04-23 16:01:24.371+0200 E/CAPI_APPFW_APP_CONTROL(22378): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:01:24.371+0200 E/location(22378): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:01:24.371+0200 I/CAPI_APPFW_APPLICATION(22378): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:01:24.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:01:24.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:01:24.391+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:01:24.391+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:01:24.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:01:24.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:01:24.401+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:01:24.401+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:01:24.401+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:01:24.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:24.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:24.421+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:01:24.421+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:01:24.421+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:01:24.431+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:24.431+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:24.451+0200 W/LOCATION(22378): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:01:24.451+0200 I/LOCATION(22378): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:24.451+0200 I/LOCATION(22378): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:01:24.531+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:01:24.531+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:01:24.531+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:01:24.531+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:01:24.531+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:01:24.531+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:01:24.531+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:01:24.531+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:01:24.531+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:01:24.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:01:24.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:01:24.631+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:24.631+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:24.631+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:24.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:24.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:24.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:24.681+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01e70
04-23 16:01:24.731+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7375fc0]
04-23 16:01:24.731+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:24.731+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:24.731+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:24.741+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:24.741+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:24.741+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:24.761+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:24.761+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:24.761+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:24.761+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:24.761+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:24.761+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:24.761+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:24.761+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:24.761+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:24.761+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:24.761+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:24.771+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:24.781+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:24.781+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:24.781+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:24.791+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:01:24.791+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:01:24.831+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:24.831+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:24.831+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:24.841+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:24.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:24.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:24.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:24.921+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7375fc0
04-23 16:01:24.931+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:01:24.931+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:01:24.931+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:01:24.931+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:01:24.941+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22378
04-23 16:01:24.941+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22378)
04-23 16:01:24.941+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:01:24.941+0200 I/servicemanager(19708): App control destroyed.
04-23 16:01:24.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf73864b0]
04-23 16:01:24.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:01:24.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:01:24.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:01:24.951+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:01:24.961+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:24.961+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:24.971+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:24.981+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:24.981+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:01:24.981+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:01:24.981+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:01:24.981+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:01:24.981+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:01:24.981+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:01:24.981+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:01:24.981+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:01:24.981+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:01:24.991+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:01:24.991+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:01:25.001+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:25.011+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:01:25.011+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:01:25.011+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:25.041+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:25.051+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:25.071+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:01:25.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:01:25.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:01:25.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:01:25.081+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf73864b0
04-23 16:01:25.191+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:01:25.191+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:01:25.231+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:25.231+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:25.251+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 16:01:25.251+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:01:25.251+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22378), cmd(0)
04-23 16:01:25.271+0200 W/AUL     (22390): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:01:25.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:01:25.281+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:01:25.281+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22343
04-23 16:01:25.281+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:01:25.281+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22343
04-23 16:01:25.281+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22343)
04-23 16:01:25.301+0200 W/KEYROUTER( 2316): e_mod_main.c: DeliverDeviceKeyEvents(3237) > Deliver KeyPress to focus window. value=1997, window=0x1e00003
04-23 16:01:25.301+0200 W/KEYROUTER( 2316): e_mod_main.c: DeliverDeviceKeyEvents(3248) > Deliver KeyPress as shared grab. value=1997, window=0x1800002
04-23 16:01:25.301+0200 W/STARTER ( 2701): hw_key.c: _key_press_cb(1443) > [_key_press_cb:1443] POWER Key is pressed
04-23 16:01:25.301+0200 W/STARTER ( 2701): hw_key.c: _key_press_cb(1446) > [_key_press_cb:1446] LCD state : 1
04-23 16:01:25.301+0200 W/STARTER ( 2701): hw_key.c: _key_press_cb(1453) > [_key_press_cb:1453] PM state : 1
04-23 16:01:25.301+0200 E/EFL     ( 2775): ecore_x<2775> ecore_x_events.c:537 _ecore_x_event_handle_key_press() KeyEvent:press time=5980958
04-23 16:01:25.301+0200 W/W_HOME  ( 2775): main.c: _direct_home_key_cb(1447) > was_win_on_top:1
04-23 16:01:25.301+0200 E/STARTER ( 2701): hw_key.c: _key_press_cb(1459) > [_key_press_cb:1459] Failed to get VCONFKEY_SIMPLECLOCK_UI_STATUS
04-23 16:01:25.301+0200 W/STARTER ( 2701): hw_key.c: _key_press_cb(1462) > [_key_press_cb:1462] Simple Clock state : 0
04-23 16:01:25.301+0200 W/STARTER ( 2701): hw_key.c: _key_press_cb(1467) > [_key_press_cb:1467] powerkey count : 1
04-23 16:01:25.391+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:01:25.391+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:01:25.431+0200 I/heartrate(22257): capturing data from es.ugr.frailty.heartrate
04-23 16:01:25.431+0200 I/heartrate(22257): es.ugr.frailty.heartrate: waiting for rigth values
04-23 16:01:25.461+0200 W/KEYROUTER( 2316): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x1800002
04-23 16:01:25.461+0200 W/KEYROUTER( 2316): e_mod_main.c: DeliverDeviceKeyEvents(3275) > Deliver KeyRelease. value=1997, window=0x1e00003
04-23 16:01:25.461+0200 W/STARTER ( 2701): hw_key.c: _key_release_cb(1340) > [_key_release_cb:1340] POWER Key is released
04-23 16:01:25.461+0200 E/EFL     ( 2775): ecore_x<2775> ecore_x_events.c:551 _ecore_x_event_handle_key_release() KeyEvent:release time=5981124
04-23 16:01:25.591+0200 I/CAPI_WATCH_APPLICATION( 2864): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 16:01:25.591+0200 E/watchface-loader( 2864): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 16:01:25.611+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11222716c6f63152449207
