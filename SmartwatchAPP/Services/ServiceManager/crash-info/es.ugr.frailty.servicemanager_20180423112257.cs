S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: servicemanager
PID: 14784
Date: 2018-04-23 11:22:57+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/servicemanager
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x34

Register Information
r0   = 0x00000036, r1   = 0x00000034
r2   = 0x00000000, r3   = 0xffffffff
r4   = 0x00000000, r5   = 0xffc9f790
r6   = 0xf753e35c, r7   = 0x00000036
r8   = 0x0000002b, r9   = 0x00000000
r10  = 0xf753e330, fp   = 0xffc9f784
ip   = 0xffc9fcc4, sp   = 0xffc9f218
lr   = 0xf739ce8c, pc   = 0xf73d20b4
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     13208 KB
Buffers:     69004 KB
Cached:     191492 KB
VmPeak:      11504 KB
VmSize:      11500 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7360 KB
VmRSS:        7360 KB
VmData:       1572 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7928 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6b34000 f6b37000 r-xp /lib/libattr.so.1.1.0
f6b3f000 f6b46000 r-xp /lib/libcrypt-2.13.so
f6b76000 f6b79000 r-xp /lib/libcap.so.2.21
f6b81000 f6b83000 r-xp /usr/lib/libiri.so
f6b8b000 f6b8d000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b96000 f6b98000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ba1000 f6bbe000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bc7000 f6bcb000 r-xp /usr/lib/libsmack.so.1.0.0
f6bd4000 f6bd6000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bde000 f6be3000 r-xp /usr/lib/libffi.so.5.0.10
f6bec000 f6bed000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6bf5000 f6c05000 r-xp /lib/libresolv-2.13.so
f6c09000 f6c21000 r-xp /usr/lib/liblzma.so.5.0.3
f6c29000 f6c2b000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c33000 f6c4d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c55000 f6c84000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c8d000 f6c9c000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ca5000 f6caf000 r-xp /usr/lib/libsensord-shared.so
f6cb8000 f6cec000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cf5000 f6dc8000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dd3000 f6de9000 r-xp /lib/libz.so.1.2.5
f6df1000 f6df7000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6e00000 f6e75000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e7f000 f6e9d000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ea7000 f6ea8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6eb0000 f6ed3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6edb000 f6ee0000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ee8000 f6f12000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f1b000 f6f32000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f3a000 f6f40000 r-xp /lib/librt-2.13.so
f6f49000 f7019000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f701a000 f7083000 r-xp /lib/libm-2.13.so
f708c000 f7120000 r-xp /usr/lib/libstdc++.so.6.0.16
f7133000 f7138000 r-xp /usr/lib/libctx-client.so.0.8.3
f7140000 f7147000 r-xp /usr/lib/libctx-shared.so.0.8.3
f714f000 f7179000 r-xp /usr/lib/libsensor.so.1.9.6
f7182000 f724e000 r-xp /usr/lib/libxml2.so.2.7.8
f725b000 f725d000 r-xp /usr/lib/libiniparser.so.0
f7266000 f7269000 r-xp /usr/lib/libbundle.so.0.1.22
f7271000 f7277000 r-xp /usr/lib/libappsvc.so.0.1.0
f727f000 f72c0000 r-xp /usr/lib/libeina.so.1.7.99
f72c9000 f72d2000 r-xp /usr/lib/libvconf.so.0.2.45
f72da000 f72ee000 r-xp /lib/libpthread-2.13.so
f72f9000 f7306000 r-xp /usr/lib/libaul.so.0.1.0
f7310000 f7312000 r-xp /lib/libdl-2.13.so
f731b000 f7326000 r-xp /lib/libunwind.so.8.0.1
f7353000 f735b000 r-xp /lib/libgcc_s-4.6.so.1
f735c000 f7480000 r-xp /lib/libc-2.13.so
f748e000 f74a5000 r-xp /usr/lib/libecore.so.1.7.99
f74bc000 f74be000 r-xp /usr/lib/libdlog.so.0.0.0
f74c6000 f74d2000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74db000 f74e0000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74e8000 f74ec000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74f5000 f74f8000 r-xp /usr/lib/libappcore-agent.so.1.1
f7516000 f7533000 r-xp /lib/ld-2.13.so
f753c000 f753f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/servicemanager
f753f000 f7543000 r-xp /usr/lib/libsys-assert.so
f7862000 f78d0000 rw-p [heap]
ffc80000 ffca1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14784)
Call Stack Count: 1
 0: strlen + 0x4 (0xf73d20b4) [/lib/libc.so.6] + 0x760b4
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
0x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.701+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12249.809962] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.711+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12249.826617] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.731+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12249.844090] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.751+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12249.860549] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.761+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12249.876992] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.781+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12249.893565] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.791+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:22:54.791+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:22:54.801+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12249.910308] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.811+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12249.926957] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.831+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12249.943716] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.851+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12249.960515] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.861+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12249.978013] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.881+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12249.993850] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.901+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.010550] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.911+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.027260] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.931+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.044114] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.951+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.060700] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.961+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.077390] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.981+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.094158] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:54.991+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:22:54.991+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:22:55.001+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.110877] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.011+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.127390] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.031+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.144227] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.051+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.163616] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.061+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.177487] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.081+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.194231] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.101+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.211074] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.111+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.227593] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.131+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.244484] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.151+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.261140] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.161+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.277785] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.181+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.294613] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.191+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:22:55.191+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:22:55.201+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.313966] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.221+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.330575] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.231+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.346001] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.251+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.361381] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.261+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.379024] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.281+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.394728] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.301+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.411456] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.311+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.428043] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.331+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.445024] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.351+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.461457] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.361+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.478189] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.381+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.494992] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.391+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:22:55.391+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:22:55.401+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.512126] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.411+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.528425] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.431+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.545243] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.451+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.561787] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.461+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.578413] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.481+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.595266] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.501+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.612012] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.511+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.628587] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.531+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.645351] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.551+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.662100] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.561+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.678702] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.581+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.695305] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.591+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:22:55.591+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:22:55.601+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.712462] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.611+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.728714] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.631+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.746169] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.651+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.762271] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.661+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.778846] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.681+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.795567] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.701+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.813049] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.711+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.828993] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.731+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.846636] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.751+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.862396] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.771+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.880287] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.781+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.895946] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.791+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:22:55.791+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:22:55.801+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.912685] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.811+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.929237] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.831+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.945966] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.851+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.962876] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.861+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.979388] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.881+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12250.996112] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.901+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.012991] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.911+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.029439] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.931+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.046297] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.951+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.062993] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.971+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.080738] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.981+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.096229] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:55.991+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:22:55.991+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:22:56.001+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.113057] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:56.021+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.131082] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:56.031+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.147755] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:56.051+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.163153] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:56.061+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.179894] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:56.081+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.196617] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:56.101+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.213641] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:56.111+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.229929] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:56.131+0200 I/TDM     ( 1945): tdm_pp.c: tdm_pp_set_info(322) > [12251.247079] pp(0x708008) info: src(360x360 0,0 360x360 AR24) dst(360x360 0,0 360x360 AR24) trans(1) sync(1) flags(0)
04-23 11:22:56.141+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [12251.252118] layer(0x47f2c0) now usable
04-23 11:22:56.141+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [12251.252170] layer[0x47ee10]zpos[1]
04-23 11:22:56.141+0200 I/TDM     ( 1945): tdm_display.c: tdm_layer_unset_buffer(1602) > [12251.252212] layer(0x47f310) now usable
04-23 11:22:56.141+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_layer_unset_buffer(1678) > [12251.252232] layer[0x47ef30]zpos[2]
04-23 11:22:56.141+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1403) > [12251.252430] dpms[0 -> 3]sync[1]
04-23 11:22:56.141+0200 I/TDM     ( 1945): 
04-23 11:22:56.161+0200 W/WATCH_CORE( 2872): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
04-23 11:22:56.161+0200 W/W_HOME  ( 2759): dbus.c: _dbus_message_recv_cb(204) > LCD off
04-23 11:22:56.161+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
04-23 11:22:56.161+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_disable_timer_del(157) > timer del
04-23 11:22:56.161+0200 W/W_HOME  ( 2759): gesture.c: _manual_render_enable(138) > 1
04-23 11:22:56.161+0200 W/W_HOME  ( 2759): event_manager.c: _lcd_off_cb(729) > lcd state: 0
04-23 11:22:56.161+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 11:22:56.161+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -149443828[0;m
04-23 11:22:56.161+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 11:22:56.161+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 11:22:56.161+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [timeout]
04-23 11:22:56.161+0200 W/STARTER ( 2693): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 11:22:56.161+0200 E/STARTER ( 2693): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 11:22:56.161+0200 E/STARTER ( 2693): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 11:22:56.161+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 11:22:56.161+0200 W/STARTER ( 2693): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 11:22:56.161+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 11:22:56.171+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 11:22:56.171+0200 E/WAKEUP-SERVICE( 3261): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 11:22:56.171+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 11:22:56.181+0200 I/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 11:22:56.181+0200 W/TIZEN_N_SOUND_MANAGER( 3261): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 11:22:56.181+0200 W/WAKEUP-SERVICE( 3261): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 11:22:56.181+0200 I/HIGEAR  ( 3261): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 11:22:56.191+0200 I/CAPI_WATCH_APPLICATION( 2872): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 11:22:56.191+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 11:22:56.291+0200 I/TDM     ( 1945): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [12251.401655] dpms[3 -> 3]done
04-23 11:22:56.291+0200 I/TDM     ( 1945): 
04-23 11:22:56.301+0200 W/SHealthCommon( 2880): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 11:22:56.301+0200 I/watchface-viewer( 2872): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 11:22:56.331+0200 W/STARTER ( 2693): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [timeout]
04-23 11:22:56.331+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 11:22:56.331+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 11:22:56.331+0200 W/STARTER ( 2693): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 11:22:56.341+0200 W/SHealthCommon( 3087): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 11:22:56.341+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: PAUSE State: RUNNING
04-23 11:22:56.341+0200 I/CAPI_APPFW_APPLICATION( 2759): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 11:22:56.341+0200 W/W_HOME  ( 2759): main.c: _appcore_pause_cb(488) > appcore pause
04-23 11:22:56.341+0200 W/W_HOME  ( 2759): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 11:22:56.341+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 11:22:56.341+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 11:22:56.341+0200 W/W_HOME  ( 2759): main.c: home_pause(547) > clock/widget paused
04-23 11:22:56.341+0200 W/W_HOME  ( 2759): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 11:22:56.351+0200 I/MESSAGE_PORT( 2455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 11:22:56.351+0200 E/CAPI_APPFW_APP_CONTROL( 3670): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 11:22:56.351+0200 W/MUSIC_CONTROL_SERVICE( 3670): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3670]   [com.samsung.w-home]register msg port [false][0m
04-23 11:22:56.351+0200 W/SHealthService( 3087): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(670) > [1;35m ###[0;m
04-23 11:22:56.351+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 11:22:56.361+0200 W/WATCH_CORE( 2872): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 11:22:56.361+0200 W/AUL     ( 2872): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2872) status(bg) type(watchapp)
04-23 11:22:56.361+0200 E/watchface-loader( 2872): watchface-loader.cpp: OnAppPause(552) > 
04-23 11:22:56.371+0200 W/W_INDICATOR( 2699): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 11:22:56.371+0200 W/W_INDICATOR( 2699): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 11:22:56.371+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 11:22:56.371+0200 W/W_INDICATOR( 2699): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 11:22:56.371+0200 W/W_INDICATOR( 2699): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 11:22:56.851+0200 I/APP_CORE( 2759): appcore-efl.c: __do_app(453) > [APP 2759] Event: MEM_FLUSH State: PAUSED
04-23 11:22:57.091+0200 W/AUL     (14784): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 11:22:57.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 11:22:57.091+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14784
04-23 11:22:57.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14787
04-23 11:22:57.111+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 11:22:57.111+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14787), cmd(0)
04-23 11:22:57.111+0200 W/AUL     (14784): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14787)
04-23 11:22:57.121+0200 I/servicemanager(14784): request sent to service es.ugr.frailty.httppostreq
04-23 11:22:57.121+0200 I/utils   (14787): specific action
04-23 11:22:57.121+0200 I/httppostreq(14787): internet connection check received
04-23 11:22:57.121+0200 I/CAPI_NETWORK_CONNECTION(14787): connection.c: connection_create(453) > New handle created[0xf8006be0]
04-23 11:22:57.121+0200 I/httppostreq(14787): internet connection != null
04-23 11:22:57.121+0200 I/CAPI_NETWORK_CONNECTION(14787): connection.c: connection_get_type(507) > Connected Network = 2
04-23 11:22:57.121+0200 I/httppostreq(14787): internet connection type...
04-23 11:22:57.121+0200 I/httppostreq(14787): internet connection type 1
04-23 11:22:57.121+0200 I/httppostreq(14787): internet available
04-23 11:22:57.121+0200 W/AUL     (14787): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 11:22:57.121+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 11:22:57.121+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14787
04-23 11:22:57.141+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14784
04-23 11:22:57.141+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 11:22:57.141+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14784), cmd(0)
04-23 11:22:57.141+0200 W/CAPI_APPFW_APP_CONTROL(14784): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 11:22:57.141+0200 I/utils   (14784): specific action
04-23 11:22:57.141+0200 W/CAPI_APPFW_APP_CONTROL(14784): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 11:22:57.141+0200 I/servicemanager(14784): internet connection available. stop all sensors
04-23 11:22:57.141+0200 W/AUL     (14784): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 11:22:57.151+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 11:22:57.151+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14784
04-23 11:22:57.171+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 14813
04-23 11:22:57.171+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 11:22:57.171+0200 W/AUL     (14787): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14784)
04-23 11:22:57.171+0200 I/httppostreq(14787): request sent to service es.ugr.frailty.servicemanager
04-23 11:22:57.221+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 14813
04-23 11:22:57.221+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(14813) type(svcapp) bg(0)
04-23 11:22:57.221+0200 E/CAPI_APPFW_APPLICATION(14813): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 11:22:57.221+0200 E/CAPI_APPFW_APPLICATION(14813): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 11:22:57.221+0200 W/AUL     (14784): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14813)
04-23 11:22:57.221+0200 I/servicemanager(14784): es.ugr.frailty.accelerometer stop request sent!
04-23 11:22:57.221+0200 I/servicemanager(14784): App control destroyed.
04-23 11:22:57.221+0200 E/EFL     (14784): ecore<14784> ecore.c:573 _ecore_magic_fail() 
04-23 11:22:57.221+0200 E/EFL     (14784): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 11:22:57.221+0200 E/EFL     (14784): *** IN FUNCTION: ecore_timer_del()
04-23 11:22:57.221+0200 E/EFL     (14784): ecore<14784> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 11:22:57.221+0200 E/EFL     (14784): ecore<14784> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 11:22:57.221+0200 E/EFL     (14784): *** SPANK SPANK SPANK!!!
04-23 11:22:57.221+0200 E/EFL     (14784): *** Now go fix your code. Tut tut tut!
04-23 11:22:57.221+0200 E/servicemanager(14784): deleting timer 0
04-23 11:22:57.221+0200 E/EFL     (14784): ecore<14784> ecore.c:573 _ecore_magic_fail() 
04-23 11:22:57.221+0200 E/EFL     (14784): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 11:22:57.221+0200 E/EFL     (14784): *** IN FUNCTION: ecore_timer_del()
04-23 11:22:57.221+0200 E/EFL     (14784): ecore<14784> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 11:22:57.221+0200 E/EFL     (14784): ecore<14784> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 11:22:57.221+0200 E/EFL     (14784): *** SPANK SPANK SPANK!!!
04-23 11:22:57.221+0200 E/EFL     (14784): *** Now go fix your code. Tut tut tut!
04-23 11:22:57.221+0200 E/servicemanager(14784): deleting timer 1
04-23 11:22:57.221+0200 E/servicemanager(14784): deleting timer 2
04-23 11:22:57.221+0200 W/AUL     (14784): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 11:22:57.221+0200 I/utils   (14813): Trying to start service: es.ugr.frailty.accelerometer
04-23 11:22:57.221+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 11:22:57.221+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14784
04-23 11:22:57.231+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [14813]
04-23 11:22:57.241+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14790
04-23 11:22:57.241+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (14813) was created
04-23 11:22:57.241+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 11:22:57.241+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14790), cmd(0)
04-23 11:22:57.241+0200 I/utils   (14790): specific action
04-23 11:22:57.241+0200 I/recorder(14790): obteniendo datos locales...
04-23 11:22:57.241+0200 I/recorder(14790): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 11:22:57.241+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:44:349,9.767502,0.023928,0.753739
04-23 11:22:57.241+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:44:446,-0.033500,9.796216,0.768096
04-23 11:22:57.241+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:44:550,-0.050249,9.789038,0.770489
04-23 11:22:57.241+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:44:649,-0.038285,9.820145,0.734596
04-23 11:22:57.241+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:44:749,-0.011964,9.765109,0.813560
04-23 11:22:57.241+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:44:848,-0.021535,9.812965,0.748954
04-23 11:22:57.241+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:44:948,0.026321,9.815358,0.768096
04-23 11:22:57.241+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:48,-0.002393,9.834501,0.736989
04-23 11:22:57.241+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:149,-0.031107,9.836893,0.792024
04-23 11:22:57.241+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 11:22:57.251+0200 I/utils   (14813): es.ugr.frailty.accelerometer sensor supported
04-23 11:22:57.251+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14813
04-23 11:22:57.251+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:250,-0.026321,9.846465,0.734596
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:351,-0.033500,9.829715,0.768096
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:448,-0.014357,9.777073,0.799203
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:551,-0.040678,9.793823,0.760918
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:647,-0.033500,9.820145,0.744168
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:749,-0.050249,9.796216,0.736989
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:847,-0.031107,9.810574,0.727418
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:947,-0.011964,9.808180,0.741775
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:46:47,-0.019143,9.827322,0.770489
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:46:148,-0.019143,9.786645,0.722632
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:46:247,-0.052642,9.769895,0.746561
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:46:347,-0.033500,9.779467,0.744168
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:46:449,-0.021535,9.793823,0.760918
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:46:547,-0.002393,9.805787,0.758525
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:46:648,-0.016750,9.772287,0.729811
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:46:748,-0.043071,9.789038,0.799203
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:46:849,-0.019143,9.769895,0.765703
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:46:947,-0.047856,9.808180,0.765703
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:47:47,-0.002393,9.829715,0.770489
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:47:147,-0.019143,9.801002,0.794417
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:47:248,-0.045464,9.803394,0.727418
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:47:346,-0.031107,9.815358,0.758525
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:47:447,-0.040678,9.805787,0.775275
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:47:548,-0.019143,9.793823,0.705883
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:47:649,-0.038285,9.812965,0.768096
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:47:749,-0.004786,9.832108,0.739382
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:47:851,-0.038285,9.839286,0.756132
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:47:952,-0.021535,9.817751,0.765703
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:48:47,-0.004786,9.793823,0.708275
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:48:149,-0.028714,9.808180,0.753739
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:48:249,-0.035892,9.812965,0.746561
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:48:347,-0.043071,9.803394,0.775275
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:48:447,-0.011964,9.817751,0.780060
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:48:545,-0.031107,9.829715,0.780060
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:48:646,-0.038285,9.815358,0.734596
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:48:748,0.011964,9.820145,0.768096
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:48:853,-0.002393,9.817751,0.765703
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:48:947,0.019143,9.827322,0.770489
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:49:49,-0.038285,9.815358,0.741775
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:49:147,0.028714,9.779467,0.760918
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:49:245,-0.031107,9.808180,0.801596
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:49:348,-0.021535,9.793823,0.784846
04-23 11:22:57.261+0200 I/recorder(14790): obteniendo datos locales es.ugr.frailty.accelerometer
04-23 11:22:57.261+0200 I/recorder(14790): obteniendo datos locales, DATA: SM-R760,23/04/2018,11:22:44:349,9.767502,0.023928,0.753739
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:44:446,-0.033500,9.796216,0.768096
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:44:550,-0.050249,9.789038,0.770489
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:44:649,-0.038285,9.820145,0.734596
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:44:749,-0.011964,9.765109,0.813560
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:44:848,-0.021535,9.812965,0.748954
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:44:948,0.026321,9.815358,0.768096
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:48,-0.002393,9.834501,0.736989
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:149,-0.031107,9.836893,0.792024
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:250,-0.026321,9.846465,0.734596
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:351,-0.033500,9.829715,0.768096
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:448,-0.014357,9.777073,0.799203
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:551,-0.040678,9.793823,0.760918
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:647,-0.033500,9.820145,0.744168
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:749,-0.050249,9.796216,0.736989
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:847,-0.031107,9.810574,0.727418
04-23 11:22:57.261+0200 I/recorder(14790): SM-R760,23/04/2018,11:22:45:947,-0
04-23 11:22:57.261+0200 W/AUL     (14790): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 11:22:57.261+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 11:22:57.271+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 14813
04-23 11:22:57.271+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 11:22:57.281+0200 W/AUL     (14784): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14790)
04-23 11:22:57.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 11:22:57.281+0200 I/servicemanager(14784): request sent to service es.ugr.frailty.recorder
04-23 11:22:57.281+0200 I/utils   (14813): es.ugr.frailty.accelerometer listener started
04-23 11:22:57.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 14790
04-23 11:22:57.281+0200 I/accelerometer(14813): stopping es.ugr.frailty.accelerometer service
04-23 11:22:57.281+0200 E/CAPI_APPFW_APP_CONTROL(14813): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 11:22:57.281+0200 E/accelerometer(14813): request sending failed to service es.ugr.frailty.servicemanager
04-23 11:22:57.281+0200 I/CAPI_APPFW_APPLICATION(14813): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 11:22:57.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 14784
04-23 11:22:57.291+0200 W/CAPI_APPFW_APP_CONTROL(14784): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 11:22:57.291+0200 W/AUL     (14790): launch.c: app_request_to_launchpad(298) > request cmd(0) result(14784)
04-23 11:22:57.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 11:22:57.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 11:22:57.291+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 11:22:57.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(14784), cmd(0)
04-23 11:22:57.291+0200 I/recorder(14790): request sent to service es.ugr.frailty.servicemanager
04-23 11:22:57.291+0200 I/utils   (14784): specific action
04-23 11:22:57.291+0200 W/CAPI_APPFW_APP_CONTROL(14784): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 11:22:57.291+0200 W/CAPI_APPFW_APP_CONTROL(14784): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 11:22:57.371+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 11:22:57.401+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 11:22:57.401+0200 W/AUL     (14829): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.servicemanager]
04-23 11:22:57.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 11:22:57.401+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 11:22:57.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 14784
04-23 11:22:57.401+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 11:22:57.401+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 14784
04-23 11:22:57.401+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(14784)
04-23 11:22:57.431+0200 I/accelerometer(14813): es.ugr.frailty.accelerometer listener destroyed
04-23 11:22:57.461+0200 W/CRASH_MANAGER(14828): worker.c: worker_job(1205) > 1114784736572152447537
