S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 18265
Date: 2018-04-23 13:50:01+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf739c648, r1   = 0xf79d41b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf79d41b8, r5   = 0x00012cd0
r6   = 0xf79e6e88, r7   = 0xf739c250
r8   = 0x000005e0, r9   = 0xf6e7f824
r10  = 0xf79cc9d8, fp   = 0x00000000
ip   = 0xf739b030, sp   = 0xff9aa400
lr   = 0xf72df5d0, pc   = 0xf72db9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     64472 KB
Buffers:     31076 KB
Cached:     149092 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7692 KB
VmRSS:        7688 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          44 KB
VmSwap:          0 KB

Maps Information
f6a16000 f6a19000 r-xp /lib/libattr.so.1.1.0
f6a22000 f6a29000 r-xp /lib/libcrypt-2.13.so
f6a59000 f6a5c000 r-xp /lib/libcap.so.2.21
f6a64000 f6a66000 r-xp /usr/lib/libiri.so
f6a6e000 f6a8b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a94000 f6a98000 r-xp /usr/lib/libsmack.so.1.0.0
f6aa2000 f6aa4000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6aac000 f6ab1000 r-xp /usr/lib/libffi.so.5.0.10
f6ab9000 f6aba000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ac2000 f6ac4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6acc000 f6ace000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ad8000 f6ae8000 r-xp /lib/libresolv-2.13.so
f6aec000 f6b04000 r-xp /usr/lib/liblzma.so.5.0.3
f6b0c000 f6b0e000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b16000 f6b45000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b4e000 f6b5d000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b66000 f6b70000 r-xp /usr/lib/libsensord-shared.so
f6b79000 f6bad000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6bb6000 f6c89000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c94000 f6caa000 r-xp /lib/libz.so.1.2.5
f6cb2000 f6cb8000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6cc1000 f6d36000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d40000 f6d5a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d62000 f6d68000 r-xp /lib/librt-2.13.so
f6d71000 f6d8f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d99000 f6d9a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6da2000 f6da7000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6daf000 f6e7f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e80000 f6eaa000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6eb3000 f6eca000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ed2000 f6f3b000 r-xp /lib/libm-2.13.so
f6f44000 f6fd8000 r-xp /usr/lib/libstdc++.so.6.0.16
f6feb000 f6ff0000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ff8000 f6fff000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7007000 f7031000 r-xp /usr/lib/libsensor.so.1.9.6
f703a000 f7106000 r-xp /usr/lib/libxml2.so.2.7.8
f7113000 f7115000 r-xp /usr/lib/libiniparser.so.0
f711e000 f7121000 r-xp /usr/lib/libbundle.so.0.1.22
f7129000 f712f000 r-xp /usr/lib/libappsvc.so.0.1.0
f7137000 f715a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7162000 f71a3000 r-xp /usr/lib/libeina.so.1.7.99
f71ac000 f71c3000 r-xp /usr/lib/libecore.so.1.7.99
f71da000 f71e3000 r-xp /usr/lib/libvconf.so.0.2.45
f71eb000 f71ff000 r-xp /lib/libpthread-2.13.so
f720a000 f7217000 r-xp /usr/lib/libaul.so.0.1.0
f7221000 f7223000 r-xp /lib/libdl-2.13.so
f722c000 f7237000 r-xp /lib/libunwind.so.8.0.1
f7264000 f726c000 r-xp /lib/libgcc_s-4.6.so.1
f726d000 f7391000 r-xp /lib/libc-2.13.so
f739f000 f73a1000 r-xp /usr/lib/libdlog.so.0.0.0
f73a9000 f73b5000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73be000 f73c3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73cb000 f73cf000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73d8000 f73da000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f73e3000 f73e6000 r-xp /usr/lib/libappcore-agent.so.1.1
f7404000 f7421000 r-xp /lib/ld-2.13.so
f742a000 f742d000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f742d000 f7431000 r-xp /usr/lib/libsys-assert.so
f79c2000 f7a10000 rw-p [heap]
ff98c000 ff9ad000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18265)
Call Stack Count: 1
 0: (0xf72db9fc) [/lib/libc.so.6] + 0x6e9fc
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
:653,73
04-23 13:49:49.841+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:49.841+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:49:853,74
04-23 13:49:50.041+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:50.041+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:50:54,74
04-23 13:49:50.241+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:50.241+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:50:254,74
04-23 13:49:50.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:50.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:50.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:50.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:50.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491390298,000000, pattern:[H:mm][0;m
04-23 13:49:50.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:50.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:50.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:50.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:50.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:50.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:50.441+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:50.441+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:50:454,75
04-23 13:49:50.641+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:50.641+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:50:655,75
04-23 13:49:50.841+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:50.841+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:50:854,75
04-23 13:49:51.041+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:51.041+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:51:54,75
04-23 13:49:51.241+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:51.241+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:51:255,75
04-23 13:49:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:51.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491391297,000000, pattern:[H:mm][0;m
04-23 13:49:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:51.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:51.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:51.441+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:51.441+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:51:454,75
04-23 13:49:51.641+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:51.641+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:51:655,75
04-23 13:49:51.841+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:51.851+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:51:855,75
04-23 13:49:52.041+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:52.051+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:52:55,75
04-23 13:49:52.241+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:52.251+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:52:255,76
04-23 13:49:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:52.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491392297,000000, pattern:[H:mm][0;m
04-23 13:49:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:52.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:52.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:52.441+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:52.451+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:52:456,76
04-23 13:49:52.641+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:52.651+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:52:656,76
04-23 13:49:52.841+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:52.851+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:52:856,76
04-23 13:49:53.041+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:53.051+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:53:57,76
04-23 13:49:53.241+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:53.251+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:53:257,76
04-23 13:49:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:53.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491393297,000000, pattern:[H:mm][0;m
04-23 13:49:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:53.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:53.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:53.441+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:53.451+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:53:457,75
04-23 13:49:53.641+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:53.651+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:53:658,76
04-23 13:49:53.841+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:53.851+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:53:857,76
04-23 13:49:54.041+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:54.051+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:54:56,75
04-23 13:49:54.241+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:54.251+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:54:257,75
04-23 13:49:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:54.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491394297,000000, pattern:[H:mm][0;m
04-23 13:49:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:54.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:54.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:54.441+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:54.451+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:54:457,75
04-23 13:49:54.641+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:54.651+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:54:657,75
04-23 13:49:54.841+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:54.851+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:54:857,75
04-23 13:49:55.041+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:55.051+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:55:57,75
04-23 13:49:55.241+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:55.251+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:55:257,75
04-23 13:49:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:55.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491395297,000000, pattern:[H:mm][0;m
04-23 13:49:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:55.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:55.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:55.441+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:55.451+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:55:458,74
04-23 13:49:55.641+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:55.651+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:55:657,74
04-23 13:49:55.841+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:55.851+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:55:857,74
04-23 13:49:56.041+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:56.051+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:56:58,75
04-23 13:49:56.241+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:56.251+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:56:258,75
04-23 13:49:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:56.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491396297,000000, pattern:[H:mm][0;m
04-23 13:49:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:56.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:56.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:56.441+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:56.451+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:56:458,75
04-23 13:49:56.651+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:56.651+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:56:659,75
04-23 13:49:56.841+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:56.851+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:56:858,75
04-23 13:49:57.041+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:57.051+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:57:58,75
04-23 13:49:57.251+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:57.251+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:57:259,75
04-23 13:49:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:57.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491397298,000000, pattern:[H:mm][0;m
04-23 13:49:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:57.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:57.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:57.451+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:57.451+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:57:459,75
04-23 13:49:57.651+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:57.651+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:57:659,75
04-23 13:49:57.851+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:57.851+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:57:859,75
04-23 13:49:58.051+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:58.051+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:58:59,75
04-23 13:49:58.251+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:58.251+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:58:259,75
04-23 13:49:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:58.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491398298,000000, pattern:[H:mm][0;m
04-23 13:49:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:58.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:58.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:58.451+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:58.451+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:58:460,75
04-23 13:49:58.651+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:58.651+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:58:659,75
04-23 13:49:58.851+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:58.851+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:58:860,75
04-23 13:49:59.051+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:59.051+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:59:60,75
04-23 13:49:59.251+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:59.251+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:59:260,75
04-23 13:49:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:59.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491399298,000000, pattern:[H:mm][0;m
04-23 13:49:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:49:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:49:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:49:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:49:59.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:49:59.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:49][0;m
04-23 13:49:59.451+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:59.451+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:59:460,75
04-23 13:49:59.651+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:59.651+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:59:660,75
04-23 13:49:59.851+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:49:59.851+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:49:59:860,75
04-23 13:50:00.051+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:00.051+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:00:60,75
04-23 13:50:00.251+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:00.251+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:00:261,75
04-23 13:50:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:00.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491400298,000000, pattern:[H:mm][0;m
04-23 13:50:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:00.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:50:00.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:50][0;m
04-23 13:50:00.451+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:00.451+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:00:461,75
04-23 13:50:00.651+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:00.651+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:00:661,75
04-23 13:50:00.851+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:00.851+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:00:861,75
04-23 13:50:01.051+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:01.051+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:01:61,75
04-23 13:50:01.251+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:01.251+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:01:261,75
04-23 13:50:01.281+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:50:01.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:50:01.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:50:01.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17422
04-23 13:50:01.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:01.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:01.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:01.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:01.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491401306,000000, pattern:[H:mm][0;m
04-23 13:50:01.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:01.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:01.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:01.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:01.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:50:01.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:50][0;m
04-23 13:50:01.301+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:50:01.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17422), cmd(0)
04-23 13:50:01.301+0200 I/utils   (17422): specific action
04-23 13:50:01.301+0200 I/httppostreq(17422): internet connection check received
04-23 13:50:01.301+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17422)
04-23 13:50:01.301+0200 I/httppostreq(17422): internet connection != null
04-23 13:50:01.311+0200 I/CAPI_NETWORK_CONNECTION(17422): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:50:01.311+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.httppostreq
04-23 13:50:01.311+0200 I/httppostreq(17422): internet connection type...
04-23 13:50:01.311+0200 I/httppostreq(17422): internet connection type 1
04-23 13:50:01.311+0200 I/httppostreq(17422): internet available
04-23 13:50:01.311+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:50:01.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:50:01.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17422
04-23 13:50:01.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
04-23 13:50:01.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:50:01.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17419), cmd(0)
04-23 13:50:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:50:01.331+0200 I/utils   (17419): specific action
04-23 13:50:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:50:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:50:01.331+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
04-23 13:50:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:50:01.331+0200 I/servicemanager(17419): internet connection available. stop all sensors
04-23 13:50:01.331+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:50:01.331+0200 I/httppostreq(17422): request sent to service es.ugr.frailty.servicemanager
04-23 13:50:01.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:50:01.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:50:01.351+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:50:01.351+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18252
04-23 13:50:01.391+0200 E/CAPI_APPFW_APPLICATION(18252): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:50:01.391+0200 E/CAPI_APPFW_APPLICATION(18252): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:50:01.391+0200 I/utils   (18252): trying to start service: es.ugr.frailty.accelerometer
04-23 13:50:01.391+0200 I/utils   (18252): es.ugr.frailty.accelerometer sensor supported
04-23 13:50:01.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18252
04-23 13:50:01.401+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(18252) type(svcapp) bg(0)
04-23 13:50:01.401+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18252)
04-23 13:50:01.401+0200 I/servicemanager(17419): es.ugr.frailty.accelerometer stop request sent!
04-23 13:50:01.401+0200 I/servicemanager(17419): App control destroyed.
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:50:01.401+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:50:01.401+0200 I/servicemanager(17419): deleting timer 0
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:50:01.401+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:50:01.401+0200 I/servicemanager(17419): deleting timer 1
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:50:01.401+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:50:01.401+0200 I/servicemanager(17419): deleting timer 2
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:50:01.401+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:50:01.401+0200 I/servicemanager(17419): deleting timer 3
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:50:01.401+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:50:01.401+0200 I/servicemanager(17419): deleting timer 4
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:50:01.401+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:50:01.401+0200 I/servicemanager(17419): deleting timer 5
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:50:01.401+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:50:01.401+0200 I/servicemanager(17419): deleting timer 6
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:50:01.401+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:50:01.401+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:50:01.401+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:50:01.401+0200 I/servicemanager(17419): deleting timer 7
04-23 13:50:01.401+0200 I/servicemanager(17419): deleting timer 8
04-23 13:50:01.401+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:50:01.401+0200 I/utils   (18252): es.ugr.frailty.accelerometer listener started
04-23 13:50:01.401+0200 I/accelerometer(18252): stopping es.ugr.frailty.accelerometer service
04-23 13:50:01.401+0200 E/CAPI_APPFW_APP_CONTROL(18252): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:50:01.401+0200 E/accelerometer(18252): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:50:01.401+0200 I/CAPI_APPFW_APPLICATION(18252): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:50:01.411+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18252]
04-23 13:50:01.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:50:01.411+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:50:01.421+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:50:01.421+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18265
04-23 13:50:01.471+0200 E/CAPI_APPFW_APPLICATION(18265): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:50:01.471+0200 E/CAPI_APPFW_APPLICATION(18265): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:50:01.471+0200 I/utils   (18265): specific action
04-23 13:50:01.471+0200 I/recorder(18265): obteniendo datos locales...
04-23 13:50:01.471+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18265
04-23 13:50:01.471+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(18265) type(svcapp) bg(0)
04-23 13:50:01.481+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18252) was created
04-23 13:50:01.481+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18265) was created
04-23 13:50:01.481+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18265]
04-23 13:50:01.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:50:01.491+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18252
04-23 13:50:01.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:50:01.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:50:01.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:50:01.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18252
04-23 13:50:01.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:50:01.521+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18252
04-23 13:50:01.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:50:01.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:50:01.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:50:01.601+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18265
04-23 13:50:01.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:50:01.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:50:01.651+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18265
04-23 13:50:01.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:50:01.701+0200 I/recorder(18265): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:24:189,1.849652,-2.009971,9.454042
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:24:371,1.804188,-3.177669,9.157332
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:24:577,1.634298,-3.120241,9.145369
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:24:777,1.775474,-3.187240,9.329616
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:24:977,1.730011,-3.986443,9.047262
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:25:177,1.875973,-3.194418,9.078369
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:25:380,1.828116,-2.565106,9.475577
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:25:577,1.797010,-2.864209,9.312866
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:25:777,1.782653,-2.883351,9.391829
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:25:977,1.605584,-3.132205,9.339187
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:26:178,1.696511,-3.089134,9.427721
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:26:378,1.749153,-3.046063,9.394222
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:26:578,1.830509,-2.309074,9.410972
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:26:778,1.761117,-2.758924,9.851252
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:26:978,1.651048,-2.816352,9.568897
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:27:178,1.820938,-1.667797,9.049655
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:27:378,1.813759,-2.115255,9.659825
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:27:579,1.596013,-2.000400,9.748360
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:27:779,1.792224,-1.598405,9.580862
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:27:979,1.835295,-1.612763,9.549755
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:28:179,1.856830,-1.488336,9.547362
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:28:379,1.801795,-1.507478,9.628718
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:28:579,1.878366,-1.406980,9.509077
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:28:780,1.844866,-1.655833,9.710074
04-23 13:50:01.701+0200 I/recorder(18265): SM-R760,23/04/2018,13:46:28:980,1.741975,-1.658226,9.638289
04-23 13:50:01.751+0200 W/CRASH_MANAGER(17537): worker.c: worker_job(1205) > 1118265726563152448420
