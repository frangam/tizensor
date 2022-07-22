S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 18194
Date: 2018-04-23 13:49:41+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7308648, r1   = 0xf78e51b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf78e51b8, r5   = 0x00012cd0
r6   = 0xf78f7e88, r7   = 0xf7308250
r8   = 0x000005e0, r9   = 0xf6deb824
r10  = 0xf78dd9d8, fp   = 0x00000000
ip   = 0xf7307030, sp   = 0xff876d00
lr   = 0xf724b5d0, pc   = 0xf72479fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     68556 KB
Buffers:     30984 KB
Cached:     148996 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7764 KB
VmRSS:        7760 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6982000 f6985000 r-xp /lib/libattr.so.1.1.0
f698e000 f6995000 r-xp /lib/libcrypt-2.13.so
f69c5000 f69c8000 r-xp /lib/libcap.so.2.21
f69d0000 f69d2000 r-xp /usr/lib/libiri.so
f69da000 f69f7000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a00000 f6a04000 r-xp /usr/lib/libsmack.so.1.0.0
f6a0e000 f6a10000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a18000 f6a1d000 r-xp /usr/lib/libffi.so.5.0.10
f6a25000 f6a26000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a2e000 f6a30000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a38000 f6a3a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a44000 f6a54000 r-xp /lib/libresolv-2.13.so
f6a58000 f6a70000 r-xp /usr/lib/liblzma.so.5.0.3
f6a78000 f6a7a000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a82000 f6ab1000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6aba000 f6ac9000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6ad2000 f6adc000 r-xp /usr/lib/libsensord-shared.so
f6ae5000 f6b19000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6b22000 f6bf5000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c00000 f6c16000 r-xp /lib/libz.so.1.2.5
f6c1e000 f6c24000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c2d000 f6ca2000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cac000 f6cc6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6cce000 f6cd4000 r-xp /lib/librt-2.13.so
f6cdd000 f6cfb000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d05000 f6d06000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d0e000 f6d13000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d1b000 f6deb000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6dec000 f6e16000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e1f000 f6e36000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e3e000 f6ea7000 r-xp /lib/libm-2.13.so
f6eb0000 f6f44000 r-xp /usr/lib/libstdc++.so.6.0.16
f6f57000 f6f5c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6f64000 f6f6b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6f73000 f6f9d000 r-xp /usr/lib/libsensor.so.1.9.6
f6fa6000 f7072000 r-xp /usr/lib/libxml2.so.2.7.8
f707f000 f7081000 r-xp /usr/lib/libiniparser.so.0
f708a000 f708d000 r-xp /usr/lib/libbundle.so.0.1.22
f7095000 f709b000 r-xp /usr/lib/libappsvc.so.0.1.0
f70a3000 f70c6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f70ce000 f710f000 r-xp /usr/lib/libeina.so.1.7.99
f7118000 f712f000 r-xp /usr/lib/libecore.so.1.7.99
f7146000 f714f000 r-xp /usr/lib/libvconf.so.0.2.45
f7157000 f716b000 r-xp /lib/libpthread-2.13.so
f7176000 f7183000 r-xp /usr/lib/libaul.so.0.1.0
f718d000 f718f000 r-xp /lib/libdl-2.13.so
f7198000 f71a3000 r-xp /lib/libunwind.so.8.0.1
f71d0000 f71d8000 r-xp /lib/libgcc_s-4.6.so.1
f71d9000 f72fd000 r-xp /lib/libc-2.13.so
f730b000 f730d000 r-xp /usr/lib/libdlog.so.0.0.0
f7315000 f7321000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f732a000 f732f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7337000 f733b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7344000 f7346000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f734f000 f7352000 r-xp /usr/lib/libappcore-agent.so.1.1
f7370000 f738d000 r-xp /lib/ld-2.13.so
f7396000 f7399000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7399000 f739d000 r-xp /usr/lib/libsys-assert.so
f78d3000 f7921000 rw-p [heap]
ff858000 ff879000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18194)
Call Stack Count: 1
 0: (0xf72479fc) [/lib/libc.so.6] + 0x6e9fc
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: recorder
App ID: es.ugr.frailty.recorder
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
ng]
04-23 13:49:30.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:30.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:30.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:30.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:30.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:30.431+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:30.431+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:30:440,78
04-23 13:49:30.631+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:30.631+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:30:641,78
04-23 13:49:30.831+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:30.831+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:30:841,79
04-23 13:49:31.031+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:31.031+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:31:41,79
04-23 13:49:31.231+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:31.231+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:31:241,79
04-23 13:49:31.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:31.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:31.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:31.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:31.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491371299,000000, pattern:[H:mm][0;m
04-23 13:49:31.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:31.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:31.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:31.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:31.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:31.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:31.431+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:31.431+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:31:442,79
04-23 13:49:31.631+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:31.631+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:31:641,79
04-23 13:49:31.831+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:31.831+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:31:841,79
04-23 13:49:32.031+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:32.031+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:32:42,80
04-23 13:49:32.231+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:32.231+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:32:242,80
04-23 13:49:32.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:32.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:32.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:32.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:32.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491372299,000000, pattern:[H:mm][0;m
04-23 13:49:32.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:32.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:32.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:32.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:32.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:32.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:32.431+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:32.431+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:32:442,80
04-23 13:49:32.631+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:32.631+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:32:642,80
04-23 13:49:32.831+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:32.831+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:32:842,80
04-23 13:49:33.031+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:33.031+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:33:42,80
04-23 13:49:33.231+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:33.231+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:33:243,80
04-23 13:49:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:33.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491373297,000000, pattern:[H:mm][0;m
04-23 13:49:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:33.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:33.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:33.431+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:33.431+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:33:442,80
04-23 13:49:33.631+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:33.631+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:33:643,80
04-23 13:49:33.831+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:33.831+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:33:844,80
04-23 13:49:34.031+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:34.031+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:34:43,80
04-23 13:49:34.231+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:34.231+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:34:243,80
04-23 13:49:34.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:34.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:34.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:34.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:34.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491374299,000000, pattern:[H:mm][0;m
04-23 13:49:34.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:34.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:34.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:34.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:34.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:34.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:34.431+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:34.431+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:34:444,80
04-23 13:49:34.631+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:34.631+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:34:643,80
04-23 13:49:34.831+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:34.831+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:34:843,80
04-23 13:49:35.031+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:35.031+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:35:44,80
04-23 13:49:35.231+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:35.231+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:35:244,80
04-23 13:49:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:35.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491375297,000000, pattern:[H:mm][0;m
04-23 13:49:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:35.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:35.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:35.431+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:35.431+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:35:444,80
04-23 13:49:35.631+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:35.631+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:35:644,80
04-23 13:49:35.831+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:35.831+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:35:844,80
04-23 13:49:36.031+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:36.031+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:36:44,80
04-23 13:49:36.231+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:36.231+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:36:245,80
04-23 13:49:36.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:36.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:36.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:36.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:36.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491376299,000000, pattern:[H:mm][0;m
04-23 13:49:36.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:36.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:36.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:36.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:36.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:36.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:36.431+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:36.431+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:36:444,80
04-23 13:49:36.631+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:36.631+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:36:645,80
04-23 13:49:36.831+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:36.841+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:36:845,80
04-23 13:49:37.031+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:37.041+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:37:45,80
04-23 13:49:37.231+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:37.241+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:37:245,79
04-23 13:49:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:37.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491377297,000000, pattern:[H:mm][0;m
04-23 13:49:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:37.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:37.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:37.431+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:37.441+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:37:446,79
04-23 13:49:37.631+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:37.641+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:37:645,79
04-23 13:49:37.831+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:37.841+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:37:845,79
04-23 13:49:38.031+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:38.041+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:38:46,79
04-23 13:49:38.231+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:38.241+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:38:246,78
04-23 13:49:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:38.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491378297,000000, pattern:[H:mm][0;m
04-23 13:49:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:38.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:38.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:38.431+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:38.441+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:38:446,78
04-23 13:49:38.631+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:38.641+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:38:646,78
04-23 13:49:38.831+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:38.841+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:38:847,78
04-23 13:49:39.031+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:39.041+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:39:46,78
04-23 13:49:39.231+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:39.241+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:39:247,77
04-23 13:49:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:39.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491379297,000000, pattern:[H:mm][0;m
04-23 13:49:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:39.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:39.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:39.431+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:39.441+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:39:446,77
04-23 13:49:39.631+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:39.641+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:39:647,76
04-23 13:49:39.831+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:39.841+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:39:847,76
04-23 13:49:40.031+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:40.041+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:40:47,75
04-23 13:49:40.231+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:40.241+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:40:247,76
04-23 13:49:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:40.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491380297,000000, pattern:[H:mm][0;m
04-23 13:49:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:40.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:40.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:40.431+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:40.441+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:40:448,75
04-23 13:49:40.631+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:40.641+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:40:647,75
04-23 13:49:40.831+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:40.841+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:40:847,74
04-23 13:49:41.041+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:41.041+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:41:49,75
04-23 13:49:41.231+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:41.241+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:41:248,74
04-23 13:49:41.281+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:49:41.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:49:41.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:49:41.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:41.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:41.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:41.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:41.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491381298,000000, pattern:[H:mm][0;m
04-23 13:49:41.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:41.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:41.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:41.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:41.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:41.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:41.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17422
04-23 13:49:41.301+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:49:41.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17422), cmd(0)
04-23 13:49:41.311+0200 I/utils   (17422): specific action
04-23 13:49:41.311+0200 I/httppostreq(17422): internet connection check received
04-23 13:49:41.311+0200 I/httppostreq(17422): internet connection != null
04-23 13:49:41.311+0200 I/CAPI_NETWORK_CONNECTION(17422): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:49:41.311+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17422)
04-23 13:49:41.311+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.httppostreq
04-23 13:49:41.311+0200 I/httppostreq(17422): internet connection type...
04-23 13:49:41.311+0200 I/httppostreq(17422): internet connection type 1
04-23 13:49:41.311+0200 I/httppostreq(17422): internet available
04-23 13:49:41.311+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:49:41.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:49:41.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17422
04-23 13:49:41.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
04-23 13:49:41.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:49:41.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17419), cmd(0)
04-23 13:49:41.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:49:41.341+0200 I/utils   (17419): specific action
04-23 13:49:41.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:49:41.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:49:41.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:49:41.341+0200 I/servicemanager(17419): internet connection available. stop all sensors
04-23 13:49:41.341+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:49:41.341+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
04-23 13:49:41.341+0200 I/httppostreq(17422): request sent to service es.ugr.frailty.servicemanager
04-23 13:49:41.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:49:41.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:49:41.351+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18182
04-23 13:49:41.351+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:49:41.391+0200 E/CAPI_APPFW_APPLICATION(18182): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:49:41.391+0200 E/CAPI_APPFW_APPLICATION(18182): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:49:41.391+0200 I/utils   (18182): trying to start service: es.ugr.frailty.accelerometer
04-23 13:49:41.391+0200 I/utils   (18182): es.ugr.frailty.accelerometer sensor supported
04-23 13:49:41.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18182
04-23 13:49:41.401+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(18182) type(svcapp) bg(0)
04-23 13:49:41.401+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18182)
04-23 13:49:41.401+0200 I/servicemanager(17419): es.ugr.frailty.accelerometer stop request sent!
04-23 13:49:41.401+0200 I/servicemanager(17419): App control destroyed.
04-23 13:49:41.401+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:49:41.401+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:49:41.401+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:49:41.401+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:49:41.401+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:49:41.401+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:49:41.401+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:49:41.401+0200 I/utils   (18182): es.ugr.frailty.accelerometer listener started
04-23 13:49:41.401+0200 I/accelerometer(18182): stopping es.ugr.frailty.accelerometer service
04-23 13:49:41.401+0200 E/CAPI_APPFW_APP_CONTROL(18182): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:49:41.401+0200 E/accelerometer(18182): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:49:41.401+0200 I/CAPI_APPFW_APPLICATION(18182): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:49:41.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:49:41.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:49:41.411+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18182) was created
04-23 13:49:41.411+0200 I/servicemanager(17419): deleting timer 0
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:49:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:49:41.411+0200 I/servicemanager(17419): deleting timer 1
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:49:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:49:41.411+0200 I/servicemanager(17419): deleting timer 2
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:49:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:49:41.411+0200 I/servicemanager(17419): deleting timer 3
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:49:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:49:41.411+0200 I/servicemanager(17419): deleting timer 4
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:49:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:49:41.411+0200 I/servicemanager(17419): deleting timer 5
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:49:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:49:41.411+0200 I/servicemanager(17419): deleting timer 6
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:49:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:49:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:49:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:49:41.411+0200 I/servicemanager(17419): deleting timer 7
04-23 13:49:41.411+0200 I/servicemanager(17419): deleting timer 8
04-23 13:49:41.411+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:49:41.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:49:41.421+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18182]
04-23 13:49:41.421+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:49:41.431+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18194
04-23 13:49:41.431+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:49:41.471+0200 E/CAPI_APPFW_APPLICATION(18194): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:49:41.471+0200 E/CAPI_APPFW_APPLICATION(18194): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:49:41.471+0200 I/utils   (18194): specific action
04-23 13:49:41.471+0200 I/recorder(18194): obteniendo datos locales...
04-23 13:49:41.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18194
04-23 13:49:41.481+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(18194) type(svcapp) bg(0)
04-23 13:49:41.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:49:41.481+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18194)
04-23 13:49:41.481+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.recorder
04-23 13:49:41.491+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18194]
04-23 13:49:41.491+0200 I/recorder(18194): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:24:189,1.849652,-2.009971,9.454042
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:24:371,1.804188,-3.177669,9.157332
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:24:577,1.634298,-3.120241,9.145369
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:24:777,1.775474,-3.187240,9.329616
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:24:977,1.730011,-3.986443,9.047262
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:25:177,1.875973,-3.194418,9.078369
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:25:380,1.828116,-2.565106,9.475577
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:25:577,1.797010,-2.864209,9.312866
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:25:777,1.782653,-2.883351,9.391829
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:25:977,1.605584,-3.132205,9.339187
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:26:178,1.696511,-3.089134,9.427721
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:26:378,1.749153,-3.046063,9.394222
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:26:578,1.830509,-2.309074,9.410972
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:26:778,1.761117,-2.758924,9.851252
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:26:978,1.651048,-2.816352,9.568897
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:27:178,1.820938,-1.667797,9.049655
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:27:378,1.813759,-2.115255,9.659825
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:27:579,1.596013,-2.000400,9.748360
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:27:779,1.792224,-1.598405,9.580862
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:27:979,1.835295,-1.612763,9.549755
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:28:179,1.856830,-1.488336,9.547362
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:28:379,1.801795,-1.507478,9.628718
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:28:579,1.878366,-1.406980,9.509077
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:28:780,1.844866,-1.655833,9.710074
04-23 13:49:41.491+0200 I/recorder(18194): SM-R760,23/04/2018,13:46:28:980,1.741975,-1.658226,9.638289
04-23 13:49:41.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18182
04-23 13:49:41.501+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18194) was created
04-23 13:49:41.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:49:41.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18182
04-23 13:49:41.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:49:41.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:49:41.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:49:41.601+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18194
04-23 13:49:41.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:49:41.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:49:41.641+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18194
04-23 13:49:41.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:49:41.681+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:41.691+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:41:698,75
04-23 13:49:41.691+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:41.691+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:41:703,74
04-23 13:49:41.701+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:49:41.711+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18182
04-23 13:49:41.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:49:41.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:49:41.801+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18194
04-23 13:49:41.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:49:41.841+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:41.851+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:41:856,74
04-23 13:49:41.861+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:49:41.871+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:49:41.881+0200 W/CRASH_MANAGER(17537): worker.c: worker_job(1205) > 1118194726563152448418
