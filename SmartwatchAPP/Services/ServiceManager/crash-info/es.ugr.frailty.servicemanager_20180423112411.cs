S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: servicemanager
PID: 15026
Date: 2018-04-23 11:24:11+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/servicemanager
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc4

Register Information
r0   = 0x000000c6, r1   = 0x000000c4
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xffd7a808
r6   = 0xf71743a2, r7   = 0x000000c6
r8   = 0x0000002b, r9   = 0x00000000
r10  = 0xf7174376, fp   = 0xffd7a7fc
ip   = 0xffd7ad3c, sp   = 0xffd7a290
lr   = 0xf6fd2e8c, pc   = 0xf70080b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     16452 KB
Buffers:     69200 KB
Cached:     187804 KB
VmPeak:      11504 KB
VmSize:      11500 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7240 KB
VmRSS:        7240 KB
VmData:       1572 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7928 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f676a000 f676d000 r-xp /lib/libattr.so.1.1.0
f6775000 f677c000 r-xp /lib/libcrypt-2.13.so
f67ac000 f67af000 r-xp /lib/libcap.so.2.21
f67b7000 f67b9000 r-xp /usr/lib/libiri.so
f67c1000 f67c3000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f67cc000 f67ce000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67d7000 f67f4000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67fd000 f6801000 r-xp /usr/lib/libsmack.so.1.0.0
f680a000 f680c000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6814000 f6819000 r-xp /usr/lib/libffi.so.5.0.10
f6822000 f6823000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f682b000 f683b000 r-xp /lib/libresolv-2.13.so
f683f000 f6857000 r-xp /usr/lib/liblzma.so.5.0.3
f685f000 f6861000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6869000 f6883000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f688b000 f68ba000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68c3000 f68d2000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68db000 f68e5000 r-xp /usr/lib/libsensord-shared.so
f68ee000 f6922000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f692b000 f69fe000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a09000 f6a1f000 r-xp /lib/libz.so.1.2.5
f6a27000 f6a2d000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6a36000 f6aab000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ab5000 f6ad3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6add000 f6ade000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ae6000 f6b09000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6b11000 f6b16000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b1e000 f6b48000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b51000 f6b68000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b70000 f6b76000 r-xp /lib/librt-2.13.so
f6b7f000 f6c4f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6c50000 f6cb9000 r-xp /lib/libm-2.13.so
f6cc2000 f6d56000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d69000 f6d6e000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d76000 f6d7d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d85000 f6daf000 r-xp /usr/lib/libsensor.so.1.9.6
f6db8000 f6e84000 r-xp /usr/lib/libxml2.so.2.7.8
f6e91000 f6e93000 r-xp /usr/lib/libiniparser.so.0
f6e9c000 f6e9f000 r-xp /usr/lib/libbundle.so.0.1.22
f6ea7000 f6ead000 r-xp /usr/lib/libappsvc.so.0.1.0
f6eb5000 f6ef6000 r-xp /usr/lib/libeina.so.1.7.99
f6eff000 f6f08000 r-xp /usr/lib/libvconf.so.0.2.45
f6f10000 f6f24000 r-xp /lib/libpthread-2.13.so
f6f2f000 f6f3c000 r-xp /usr/lib/libaul.so.0.1.0
f6f46000 f6f48000 r-xp /lib/libdl-2.13.so
f6f51000 f6f5c000 r-xp /lib/libunwind.so.8.0.1
f6f89000 f6f91000 r-xp /lib/libgcc_s-4.6.so.1
f6f92000 f70b6000 r-xp /lib/libc-2.13.so
f70c4000 f70db000 r-xp /usr/lib/libecore.so.1.7.99
f70f2000 f70f4000 r-xp /usr/lib/libdlog.so.0.0.0
f70fc000 f7108000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7111000 f7116000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f711e000 f7122000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f712b000 f712e000 r-xp /usr/lib/libappcore-agent.so.1.1
f714c000 f7169000 r-xp /lib/ld-2.13.so
f7172000 f7175000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/servicemanager
f7175000 f7179000 r-xp /usr/lib/libsys-assert.so
f73ed000 f745b000 rw-p [heap]
ffd5b000 ffd7c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:15026)
Call Stack Count: 1
 0: strlen + 0x4 (0xf70080b4) [/lib/libc.so.6] + 0x760b4
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: servicemanager
App ID: es.ugr.frailty.servicemanager
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
23 11:24:09.061+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.170378] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.071+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.187040] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.091+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.203775] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.111+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.220383] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.121+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.237178] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.141+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.253896] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.161+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.270536] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.171+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.287210] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.191+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:24:09.191+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:24:09.191+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.304427] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.211+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.320575] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.221+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.337309] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.241+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.354089] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.261+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.370937] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.271+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.387347] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.291+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.404141] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.311+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.420848] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.321+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.437441] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.341+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.454206] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.361+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.472477] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.371+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.487614] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.391+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:24:09.391+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:24:09.391+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.504328] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.411+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.521234] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.431+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.539983] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.441+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.554831] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.461+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.571140] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.471+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.587807] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.491+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.604468] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.511+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.624013] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.521+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.638305] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.541+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.654668] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.561+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.672097] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.571+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.688065] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.591+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:24:09.591+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:24:09.591+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.705243] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.611+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.721635] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.621+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.738357] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.641+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.754958] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.661+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.771716] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.671+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.788351] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.691+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.805107] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.711+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.821885] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.721+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.838497] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.741+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.855284] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.761+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.871950] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.771+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.888585] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.791+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:24:09.791+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:24:09.791+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.906317] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.811+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.922292] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.821+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.939615] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.841+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.955341] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.861+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.972244] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.871+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12324.988708] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.891+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.005438] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.911+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.022302] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.921+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.039734] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.941+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.055698] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.961+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.072396] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.971+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.088965] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:09.991+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:24:09.991+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:24:09.991+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.105861] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.011+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.122597] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.021+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.139135] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.041+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.155865] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.061+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.173294] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.071+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.189249] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.091+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.205928] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.111+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.222697] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.131+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.241025] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.141+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.256002] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.161+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.273977] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.171+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.289445] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.191+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:24:10.191+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:24:10.191+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.306330] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.211+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.322902] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.221+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.339590] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.241+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.356975] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.261+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.372995] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.271+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.389656] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.291+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.406463] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.311+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.423279] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.331+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.440907] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.341+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.456449] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.361+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.473957] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.371+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.489873] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.391+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:24:10.391+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:24:10.391+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.506597] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.411+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.523434] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.431+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.540138] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.441+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.556593] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.461+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.573243] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.481+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.590168] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.491+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.606899] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.511+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12325.623847] pp(0x633168) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:24:10.521+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [12325.635817] layer(0x47f2c0) now usable
04-23 11:24:10.521+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [12325.635868] layer[0x47ee10]zpos[1]
04-23 11:24:10.521+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [12325.635918] layer(0x47f310) now usable
04-23 11:24:10.521+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [12325.635938] layer[0x47ef30]zpos[2]
04-23 11:24:10.521+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [12325.636154] dpms[0 -> 3]sync[1]
04-23 11:24:10.521+0200 I/TDM     ( 1945): 
04-23 11:24:10.541+0200 W/WATCH_CORE( 2872): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 11:24:10.541+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 11:24:10.541+0200 W/STARTER ( 2693): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 11:24:10.541+0200 E/STARTER ( 2693): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 11:24:10.541+0200 E/STARTER ( 2693): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 11:24:10.541+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 11:24:10.541+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 11:24:10.541+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -149443828[0;m
04-23 11:24:10.541+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 11:24:10.541+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 11:24:10.551+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 11:24:10.551+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 11:24:10.551+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 11:24:10.551+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 11:24:10.561+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 11:24:10.561+0200 W/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 11:24:10.561+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 11:24:10.561+0200 I/HIGEAR  ( 3261): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 11:24:10.591+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:24:10.591+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:24:10.671+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [12325.781250] dpms[3 -> 3]done
04-23 11:24:10.671+0200 I/TDM     ( 1945): 
04-23 11:24:10.671+0200 I/watchface-viewer( 2872): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 11:24:10.681+0200 W/SHealthCommon( 3087): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 11:24:10.681+0200 W/SHealthService( 3087): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 11:24:10.691+0200 W/SHealthCommon( 2880): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 11:24:10.691+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 11:24:10.691+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 11:24:10.691+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 11:24:10.691+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 11:24:10.691+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 11:24:10.701+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: PAUSE State: RUNNING
04-23 11:24:10.701+0200 I/CAPI_APPFW_APPLICATION( 2759): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 11:24:10.711+0200 W/W_HOME  ( 2759): main.c: _appcore_pause_cb(488) > appcore pause
04-23 11:24:10.711+0200 W/W_HOME  ( 2759): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 11:24:10.711+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 11:24:10.711+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 11:24:10.711+0200 W/W_HOME  ( 2759): main.c: home_pause(547) > clock/widget paused
04-23 11:24:10.711+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 11:24:10.711+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 11:24:10.711+0200 W/W_HOME  ( 2759): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 11:24:10.711+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 11:24:10.711+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 11:24:10.711+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_enable(138) > 1
04-23 11:24:10.711+0200 W/W_HOME  ( 2759): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 11:24:10.711+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 11:24:10.711+0200 E/CAPI_APPFW_APP_CONTROL( 3670): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 11:24:10.711+0200 W/MUSIC_CONTROL_SERVICE( 3670): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3670]   [com.samsung.w-home]register msg port [false][0m
04-23 11:24:10.731+0200 W/WATCH_CORE( 2872): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 11:24:10.731+0200 W/AUL     ( 2872): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2872) status(bg) type(watchapp)
04-23 11:24:10.731+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppPause(552) > 
04-23 11:24:10.761+0200 W/W_INDICATOR( 2699): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 11:24:10.771+0200 W/W_INDICATOR( 2699): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 11:24:10.771+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 11:24:10.771+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 11:24:10.771+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 11:24:11.221+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: MEM_FLUSH State: PAUSED
04-23 11:24:11.401+0200 W/AUL     (15026): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 11:24:11.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 11:24:11.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15026
04-23 11:24:11.421+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15029
04-23 11:24:11.421+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 11:24:11.421+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(15029), cmd(0)
04-23 11:24:11.431+0200 W/AUL     (15026): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15029)
04-23 11:24:11.431+0200 I/utils   (15029): specific action
04-23 11:24:11.431+0200 I/servicemanager(15026): request sent to service es.ugr.frailty.httppostreq
04-23 11:24:11.431+0200 I/httppostreq(15029): internet connection check received
04-23 11:24:11.431+0200 I/CAPI_NETWORK_CONNECTION(15029): connection.c: connection_create(453) > New handle created[0xf752d568]
04-23 11:24:11.431+0200 I/httppostreq(15029): internet connection != null
04-23 11:24:11.431+0200 I/CAPI_NETWORK_CONNECTION(15029): connection.c: connection_get_type(507) > Connected Network = 2
04-23 11:24:11.431+0200 I/httppostreq(15029): internet connection type...
04-23 11:24:11.431+0200 I/httppostreq(15029): internet connection type 1
04-23 11:24:11.431+0200 I/httppostreq(15029): internet available
04-23 11:24:11.431+0200 W/AUL     (15029): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 11:24:11.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 11:24:11.441+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15029
04-23 11:24:11.451+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15026
04-23 11:24:11.461+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 11:24:11.461+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(15026), cmd(0)
04-23 11:24:11.461+0200 W/CAPI_APPFW_APP_CONTROL(15026): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 11:24:11.461+0200 I/utils   (15026): specific action
04-23 11:24:11.461+0200 W/CAPI_APPFW_APP_CONTROL(15026): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 11:24:11.461+0200 I/servicemanager(15026): internet connection available. stop all sensors
04-23 11:24:11.471+0200 W/AUL     (15026): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 11:24:11.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 11:24:11.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15026
04-23 11:24:11.491+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 15054
04-23 11:24:11.491+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 11:24:11.491+0200 W/AUL     (15029): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15026)
04-23 11:24:11.511+0200 I/httppostreq(15029): request sent to service es.ugr.frailty.servicemanager
04-23 11:24:11.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 15054
04-23 11:24:11.541+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(15054) type(svcapp) bg(0)
04-23 11:24:11.541+0200 W/AUL     (15026): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15054)
04-23 11:24:11.541+0200 I/servicemanager(15026): es.ugr.frailty.accelerometer stop request sent!
04-23 11:24:11.541+0200 I/servicemanager(15026): App control destroyed.
04-23 11:24:11.541+0200 E/EFL     (15026): ecore<15026> ecore.c:573 _ecore_magic_fail() 
04-23 11:24:11.541+0200 E/EFL     (15026): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 11:24:11.541+0200 E/EFL     (15026): *** IN FUNCTION: ecore_timer_del()
04-23 11:24:11.541+0200 E/EFL     (15026): ecore<15026> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 11:24:11.541+0200 E/EFL     (15026): ecore<15026> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 11:24:11.541+0200 E/EFL     (15026): *** SPANK SPANK SPANK!!!
04-23 11:24:11.541+0200 E/EFL     (15026): *** Now go fix your code. Tut tut tut!
04-23 11:24:11.541+0200 E/servicemanager(15026): deleting timer 0
04-23 11:24:11.541+0200 E/EFL     (15026): ecore<15026> ecore.c:573 _ecore_magic_fail() 
04-23 11:24:11.541+0200 E/EFL     (15026): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 11:24:11.541+0200 E/EFL     (15026): *** IN FUNCTION: ecore_timer_del()
04-23 11:24:11.541+0200 E/EFL     (15026): ecore<15026> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 11:24:11.541+0200 E/EFL     (15026): ecore<15026> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 11:24:11.541+0200 E/EFL     (15026): *** SPANK SPANK SPANK!!!
04-23 11:24:11.541+0200 E/EFL     (15026): *** Now go fix your code. Tut tut tut!
04-23 11:24:11.541+0200 E/servicemanager(15026): deleting timer 1
04-23 11:24:11.541+0200 E/servicemanager(15026): deleting timer 2
04-23 11:24:11.541+0200 W/AUL     (15026): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 11:24:11.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 11:24:11.541+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15026
04-23 11:24:11.541+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [15054]
04-23 11:24:11.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15032
04-23 11:24:11.551+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 11:24:11.551+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(15032), cmd(0)
04-23 11:24:11.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 11:24:11.561+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15054
04-23 11:24:11.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 11:24:11.571+0200 I/utils   (15032): specific action
04-23 11:24:11.571+0200 I/recorder(15032): obteniendo datos locales...
04-23 11:24:11.571+0200 I/recorder(15032): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:58:632,9.817751,0.019143,0.806381
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:58:731,-0.040678,9.784252,0.768096
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:58:832,-0.011964,9.827322,0.787239
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:58:934,-0.047856,9.781858,0.823131
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:36,-0.052642,9.822537,0.717847
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:131,-0.055035,9.832108,0.772882
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:232,0.014357,9.810574,0.792024
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:340,-0.043071,9.817751,0.768096
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:434,-0.016750,9.777073,0.725025
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:537,-0.009571,9.808180,0.782453
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:632,0.021535,9.812965,0.722632
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:734,-0.040678,9.803394,0.756132
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:830,-0.011964,9.815358,0.772882
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:937,0.040678,9.781858,0.772882
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:00:31,-0.004786,9.784252,0.772882
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:00:131,0.007178,9.812965,0.746561
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:00:235,-0.014357,9.803394,0.832702
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:00:338,-0.007178,9.827322,0.789631
04-23 11:24:11.571+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:00:437,-0.004786,9.786645,0.756132
04-23 11:24:11.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 11:24:11.571+0200 E/CAPI_APPFW_APPLICATION(15054): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 11:24:11.571+0200 E/CAPI_APPFW_APPLICATION(15054): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:00:532,-0.023928,9.810574,0.760918
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:00:632,-0.031107,9.805787,0.751346
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:00:734,-0.038285,9.817751,0.756132
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:00:835,-0.023928,9.777073,0.792024
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:00:929,-0.026321,9.827322,0.765703
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:01:31,-0.028714,9.805787,0.768096
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:01:132,-0.009571,9.824929,0.741775
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:01:233,0.009571,9.765109,0.739382
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:01:331,-0.031107,9.815358,0.775275
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:01:432,-0.028714,9.815358,0.811167
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:01:530,-0.016750,9.812965,0.756132
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:01:631,0.009571,9.791430,0.775275
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:01:732,-0.033500,9.829715,0.746561
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:01:833,-0.031107,9.793823,0.777667
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:01:931,-0.026321,9.801002,0.753739
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:02:33,-0.026321,9.786645,0.815953
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:02:130,-0.026321,9.774680,0.780060
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:02:232,-0.045464,9.824929,0.792024
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:02:331,-0.016750,9.812965,0.736989
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:02:432,-0.043071,9.803394,0.725025
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:02:532,0.004786,9.781858,0.744168
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:02:632,-0.033500,9.829715,0.803988
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:02:731,-0.031107,9.801002,0.729811
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:02:839,-0.004786,9.820145,0.744168
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:02:931,0.002393,9.786645,0.782453
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:03:33,-0.035892,9.798609,0.760918
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:03:132,0.014357,9.805787,0.765703
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:03:232,-0.047856,9.786645,0.732204
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:03:334,-0.007178,9.779467,0.758525
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:03:432,-0.040678,9.805787,0.729811
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:03:534,-0.028714,9.769895,0.794417
04-23 11:24:11.581+0200 I/recorder(15032): obteniendo datos locales es.ugr.frailty.accelerometer
04-23 11:24:11.581+0200 I/recorder(15032): obteniendo datos locales, DATA: SM-R760,23/04/2018,11:23:58:632,9.817751,0.019143,0.806381
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:58:731,-0.040678,9.784252,0.768096
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:58:832,-0.011964,9.827322,0.787239
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:58:934,-0.047856,9.781858,0.823131
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:36,-0.052642,9.822537,0.717847
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:131,-0.055035,9.832108,0.772882
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:232,0.014357,9.810574,0.792024
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:340,-0.043071,9.817751,0.768096
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:434,-0.016750,9.777073,0.725025
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:537,-0.009571,9.808180,0.782453
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:632,0.021535,9.812965,0.722632
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:734,-0.040678,9.803394,0.756132
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:830,-0.011964,9.815358,0.772882
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:23:59:937,0.040678,9.781858,0.772882
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:00:31,-0.004786,9.784252,0.772882
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:00:131,0.007178,9.812965,0.746561
04-23 11:24:11.581+0200 I/recorder(15032): SM-R760,23/04/2018,11:24:00:235,-0.014
04-23 11:24:11.581+0200 W/AUL     (15032): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 11:24:11.581+0200 W/AUL     (15026): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15032)
04-23 11:24:11.581+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 15054
04-23 11:24:11.581+0200 I/servicemanager(15026): request sent to service es.ugr.frailty.recorder
04-23 11:24:11.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 11:24:11.581+0200 I/utils   (15054): Trying to start service: es.ugr.frailty.accelerometer
04-23 11:24:11.581+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 15032
04-23 11:24:11.591+0200 I/utils   (15054): es.ugr.frailty.accelerometer sensor supported
04-23 11:24:11.591+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 15026
04-23 11:24:11.591+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (15054) was created
04-23 11:24:11.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 11:24:11.591+0200 W/CAPI_APPFW_APP_CONTROL(15026): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 11:24:11.591+0200 I/utils   (15026): specific action
04-23 11:24:11.591+0200 W/CAPI_APPFW_APP_CONTROL(15026): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 11:24:11.591+0200 W/CAPI_APPFW_APP_CONTROL(15026): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 11:24:11.591+0200 I/servicemanager(15026): obteniendo datos locales. Datos recibidos
04-23 11:24:11.591+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 11:24:11.591+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(15026), cmd(0)
04-23 11:24:11.591+0200 W/AUL     (15032): launch.c: app_request_to_launchpad(298) > request cmd(0) result(15026)
04-23 11:24:11.591+0200 I/recorder(15032): request sent to service es.ugr.frailty.servicemanager
04-23 11:24:11.611+0200 I/utils   (15054): es.ugr.frailty.accelerometer listener started
04-23 11:24:11.611+0200 I/accelerometer(15054): stopping es.ugr.frailty.accelerometer service
04-23 11:24:11.611+0200 E/CAPI_APPFW_APP_CONTROL(15054): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 11:24:11.611+0200 E/accelerometer(15054): request sending failed to service es.ugr.frailty.servicemanager
04-23 11:24:11.611+0200 I/CAPI_APPFW_APPLICATION(15054): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 11:24:11.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 11:24:11.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 11:24:11.671+0200 W/AUL     (15068): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.servicemanager]
04-23 11:24:11.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 11:24:11.671+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 11:24:11.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 15026
04-23 11:24:11.671+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 11:24:11.701+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 15026
04-23 11:24:11.701+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(15026)
04-23 11:24:11.721+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 11:24:11.731+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 11:24:11.751+0200 W/CRASH_MANAGER(15069): worker.c: worker_job(1205) > 1115026736572152447545
