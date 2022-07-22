S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 18470
Date: 2018-04-23 13:51:01+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf703c648, r1   = 0xf77f11b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf77f11b8, r5   = 0x00012cd0
r6   = 0xf7803e88, r7   = 0xf703c250
r8   = 0x000005e0, r9   = 0xf6b1f824
r10  = 0xf77e99d8, fp   = 0x00000000
ip   = 0xf703b030, sp   = 0xff988710
lr   = 0xf6f7f5d0, pc   = 0xf6f7b9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     50544 KB
Buffers:     31368 KB
Cached:     149396 KB
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
f66b6000 f66b9000 r-xp /lib/libattr.so.1.1.0
f66c2000 f66c9000 r-xp /lib/libcrypt-2.13.so
f66f9000 f66fc000 r-xp /lib/libcap.so.2.21
f6704000 f6706000 r-xp /usr/lib/libiri.so
f670e000 f672b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6734000 f6738000 r-xp /usr/lib/libsmack.so.1.0.0
f6742000 f6744000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f674c000 f6751000 r-xp /usr/lib/libffi.so.5.0.10
f6759000 f675a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6762000 f6764000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f676c000 f676e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6778000 f6788000 r-xp /lib/libresolv-2.13.so
f678c000 f67a4000 r-xp /usr/lib/liblzma.so.5.0.3
f67ac000 f67ae000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67b6000 f67e5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f67ee000 f67fd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6806000 f6810000 r-xp /usr/lib/libsensord-shared.so
f6819000 f684d000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6856000 f6929000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6934000 f694a000 r-xp /lib/libz.so.1.2.5
f6952000 f6958000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6961000 f69d6000 r-xp /usr/lib/libsqlite3.so.0.8.6
f69e0000 f69fa000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6a02000 f6a08000 r-xp /lib/librt-2.13.so
f6a11000 f6a2f000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a39000 f6a3a000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a42000 f6a47000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a4f000 f6b1f000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6b20000 f6b4a000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b53000 f6b6a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b72000 f6bdb000 r-xp /lib/libm-2.13.so
f6be4000 f6c78000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c8b000 f6c90000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c98000 f6c9f000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6ca7000 f6cd1000 r-xp /usr/lib/libsensor.so.1.9.6
f6cda000 f6da6000 r-xp /usr/lib/libxml2.so.2.7.8
f6db3000 f6db5000 r-xp /usr/lib/libiniparser.so.0
f6dbe000 f6dc1000 r-xp /usr/lib/libbundle.so.0.1.22
f6dc9000 f6dcf000 r-xp /usr/lib/libappsvc.so.0.1.0
f6dd7000 f6dfa000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6e02000 f6e43000 r-xp /usr/lib/libeina.so.1.7.99
f6e4c000 f6e63000 r-xp /usr/lib/libecore.so.1.7.99
f6e7a000 f6e83000 r-xp /usr/lib/libvconf.so.0.2.45
f6e8b000 f6e9f000 r-xp /lib/libpthread-2.13.so
f6eaa000 f6eb7000 r-xp /usr/lib/libaul.so.0.1.0
f6ec1000 f6ec3000 r-xp /lib/libdl-2.13.so
f6ecc000 f6ed7000 r-xp /lib/libunwind.so.8.0.1
f6f04000 f6f0c000 r-xp /lib/libgcc_s-4.6.so.1
f6f0d000 f7031000 r-xp /lib/libc-2.13.so
f703f000 f7041000 r-xp /usr/lib/libdlog.so.0.0.0
f7049000 f7055000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f705e000 f7063000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f706b000 f706f000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7078000 f707a000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7083000 f7086000 r-xp /usr/lib/libappcore-agent.so.1.1
f70a4000 f70c1000 r-xp /lib/ld-2.13.so
f70ca000 f70cd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f70cd000 f70d1000 r-xp /usr/lib/libsys-assert.so
f77df000 f782d000 rw-p [heap]
ff96a000 ff98b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18470)
Call Stack Count: 1
 0: (0xf6f7b9fc) [/lib/libc.so.6] + 0x6e9fc
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
et_item], key=13
04-23 13:50:50.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:50.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491450300,000000, pattern:[H:mm][0;m
04-23 13:50:50.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:50.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:50.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:50.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:50.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:50:50.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:50][0;m
04-23 13:50:50.481+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:50.481+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:50:494,78
04-23 13:50:50.681+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:50.681+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:50:694,78
04-23 13:50:50.881+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:50.881+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:50:894,78
04-23 13:50:51.081+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:51.081+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:51:94,78
04-23 13:50:51.281+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:51.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:51.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:51.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:51.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:51.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491451299,000000, pattern:[H:mm][0;m
04-23 13:50:51.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:51.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:51.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:51.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:51.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:50:51.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:50][0;m
04-23 13:50:51.291+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:51:295,79
04-23 13:50:51.481+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:51.481+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:51:494,79
04-23 13:50:51.681+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:51.681+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:51:695,79
04-23 13:50:51.881+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:51.891+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:51:895,79
04-23 13:50:52.081+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:52.091+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:52:95,79
04-23 13:50:52.281+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:52.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491452297,000000, pattern:[H:mm][0;m
04-23 13:50:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:52.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:50:52.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:50][0;m
04-23 13:50:52.291+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:52:295,79
04-23 13:50:52.481+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:52.491+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:52:496,79
04-23 13:50:52.681+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:52.691+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:52:695,79
04-23 13:50:52.881+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:52.891+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:52:895,79
04-23 13:50:53.081+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:53.091+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:53:96,79
04-23 13:50:53.281+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:53.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491453297,000000, pattern:[H:mm][0;m
04-23 13:50:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:53.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:50:53.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:50][0;m
04-23 13:50:53.291+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:53:296,79
04-23 13:50:53.481+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:53.491+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:53:496,79
04-23 13:50:53.681+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:53.691+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:53:696,79
04-23 13:50:53.881+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:53.891+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:53:897,79
04-23 13:50:54.081+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:54.091+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:54:96,79
04-23 13:50:54.281+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:54.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491454297,000000, pattern:[H:mm][0;m
04-23 13:50:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:54.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:50:54.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:50][0;m
04-23 13:50:54.291+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:54:297,79
04-23 13:50:54.481+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:54.491+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:54:496,79
04-23 13:50:54.681+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:54.691+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:54:697,78
04-23 13:50:54.881+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:54.891+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:54:897,79
04-23 13:50:55.081+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:55.091+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:55:97,80
04-23 13:50:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:55.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491455297,000000, pattern:[H:mm][0;m
04-23 13:50:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:55.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:50:55.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:50][0;m
04-23 13:50:55.291+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:55.291+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:55:297,80
04-23 13:50:55.481+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:55.491+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:55:498,79
04-23 13:50:55.681+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:55.691+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:55:697,79
04-23 13:50:55.881+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:55.891+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:55:897,79
04-23 13:50:56.081+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:56.091+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:56:98,79
04-23 13:50:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:56.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491456297,000000, pattern:[H:mm][0;m
04-23 13:50:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:56.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:50:56.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:50][0;m
04-23 13:50:56.291+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:56.291+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:56:304,79
04-23 13:50:56.481+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:56.491+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:56:498,79
04-23 13:50:56.691+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:56.691+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:56:698,79
04-23 13:50:56.881+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:56.891+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:56:898,79
04-23 13:50:57.081+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:57.091+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:57:98,79
04-23 13:50:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:57.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491457298,000000, pattern:[H:mm][0;m
04-23 13:50:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:57.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:50:57.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:50][0;m
04-23 13:50:57.291+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:57.291+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:57:304,78
04-23 13:50:57.491+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:57.491+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:57:498,78
04-23 13:50:57.691+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:57.691+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:57:699,78
04-23 13:50:57.891+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:57.891+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:57:900,78
04-23 13:50:58.091+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:58.091+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:58:99,77
04-23 13:50:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:58.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491458299,000000, pattern:[H:mm][0;m
04-23 13:50:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:58.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:50:58.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:50][0;m
04-23 13:50:58.291+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:58.301+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:58:305,77
04-23 13:50:58.491+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:58.491+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:58:500,76
04-23 13:50:58.691+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:58.691+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:58:699,77
04-23 13:50:58.891+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:58.891+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:58:900,76
04-23 13:50:59.091+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:59.091+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:59:100,76
04-23 13:50:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:59.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491459297,000000, pattern:[H:mm][0;m
04-23 13:50:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:50:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:50:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:50:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:50:59.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:50:59.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:50][0;m
04-23 13:50:59.291+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:59.291+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:59:304,76
04-23 13:50:59.491+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:59.491+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:59:500,76
04-23 13:50:59.691+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:59.691+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:59:700,76
04-23 13:50:59.891+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:50:59.891+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:50:59:900,76
04-23 13:51:00.091+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:00.091+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:00:100,77
04-23 13:51:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:00.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491460299,000000, pattern:[H:mm][0;m
04-23 13:51:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:00.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:00.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:51:00.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:51][0;m
04-23 13:51:00.301+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:00.301+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:00:313,77
04-23 13:51:00.491+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:00.491+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:00:500,77
04-23 13:51:00.691+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:00.691+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:00:701,77
04-23 13:51:00.891+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:00.891+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:00:901,77
04-23 13:51:01.091+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:01.091+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:01:101,77
04-23 13:51:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:01.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491461293,000000, pattern:[H:mm][0;m
04-23 13:51:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:01.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:51:01.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:51][0;m
04-23 13:51:01.281+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:51:01.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:51:01.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:51:01.301+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:01.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17422
04-23 13:51:01.311+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:51:01.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17422), cmd(0)
04-23 13:51:01.311+0200 I/utils   (17422): specific action
04-23 13:51:01.311+0200 I/httppostreq(17422): internet connection check received
04-23 13:51:01.311+0200 I/httppostreq(17422): internet connection != null
04-23 13:51:01.311+0200 I/CAPI_NETWORK_CONNECTION(17422): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:51:01.311+0200 I/httppostreq(17422): internet connection type...
04-23 13:51:01.311+0200 I/httppostreq(17422): internet connection type 1
04-23 13:51:01.311+0200 I/httppostreq(17422): internet available
04-23 13:51:01.311+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:51:01.311+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17422)
04-23 13:51:01.311+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.httppostreq
04-23 13:51:01.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:51:01.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17422
04-23 13:51:01.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
04-23 13:51:01.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:51:01.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17419), cmd(0)
04-23 13:51:01.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:51:01.341+0200 I/utils   (17419): specific action
04-23 13:51:01.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:51:01.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:51:01.341+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:51:01.341+0200 I/servicemanager(17419): internet connection available. stop all sensors
04-23 13:51:01.341+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:51:01.341+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
04-23 13:51:01.341+0200 I/httppostreq(17422): request sent to service es.ugr.frailty.servicemanager
04-23 13:51:01.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:51:01.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:51:01.351+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:51:01.351+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18458
04-23 13:51:01.351+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:01:309,77
04-23 13:51:01.391+0200 E/CAPI_APPFW_APPLICATION(18458): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:51:01.391+0200 E/CAPI_APPFW_APPLICATION(18458): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:51:01.391+0200 I/utils   (18458): trying to start service: es.ugr.frailty.accelerometer
04-23 13:51:01.401+0200 I/utils   (18458): es.ugr.frailty.accelerometer sensor supported
04-23 13:51:01.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18458
04-23 13:51:01.401+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(18458) type(svcapp) bg(0)
04-23 13:51:01.411+0200 I/utils   (18458): es.ugr.frailty.accelerometer listener started
04-23 13:51:01.411+0200 I/accelerometer(18458): stopping es.ugr.frailty.accelerometer service
04-23 13:51:01.411+0200 E/CAPI_APPFW_APP_CONTROL(18458): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:51:01.411+0200 E/accelerometer(18458): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:51:01.411+0200 I/CAPI_APPFW_APPLICATION(18458): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:51:01.411+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18458) was created
04-23 13:51:01.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:51:01.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:51:01.421+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18458)
04-23 13:51:01.421+0200 I/servicemanager(17419): es.ugr.frailty.accelerometer stop request sent!
04-23 13:51:01.421+0200 I/servicemanager(17419): App control destroyed.
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:51:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:51:01.421+0200 I/servicemanager(17419): deleting timer 0
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:51:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:51:01.421+0200 I/servicemanager(17419): deleting timer 1
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:51:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:51:01.421+0200 I/servicemanager(17419): deleting timer 2
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:51:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:51:01.421+0200 I/servicemanager(17419): deleting timer 3
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:51:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:51:01.421+0200 I/servicemanager(17419): deleting timer 4
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:51:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:51:01.421+0200 I/servicemanager(17419): deleting timer 5
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:51:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:51:01.421+0200 I/servicemanager(17419): deleting timer 6
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:51:01.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:51:01.421+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:51:01.421+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:51:01.421+0200 I/servicemanager(17419): deleting timer 7
04-23 13:51:01.421+0200 I/servicemanager(17419): deleting timer 8
04-23 13:51:01.421+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:51:01.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:51:01.421+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18458]
04-23 13:51:01.421+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:51:01.431+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18470
04-23 13:51:01.441+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:51:01.491+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18470
04-23 13:51:01.491+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(18470) type(svcapp) bg(0)
04-23 13:51:01.491+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18470]
04-23 13:51:01.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:51:01.491+0200 E/CAPI_APPFW_APPLICATION(18470): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:51:01.491+0200 E/CAPI_APPFW_APPLICATION(18470): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:51:01.491+0200 I/utils   (18470): specific action
04-23 13:51:01.491+0200 I/recorder(18470): obteniendo datos locales...
04-23 13:51:01.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18458
04-23 13:51:01.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:51:01.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18458
04-23 13:51:01.511+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18470) was created
04-23 13:51:01.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:51:01.531+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18470)
04-23 13:51:01.531+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.recorder
04-23 13:51:01.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:51:01.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:51:01.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18470
04-23 13:51:01.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:51:01.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:51:01.641+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18470
04-23 13:51:01.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:51:01.671+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:01.681+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:01:688,78
04-23 13:51:01.701+0200 I/recorder(18470): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:24:189,1.849652,-2.009971,9.454042
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:24:371,1.804188,-3.177669,9.157332
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:24:577,1.634298,-3.120241,9.145369
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:24:777,1.775474,-3.187240,9.329616
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:24:977,1.730011,-3.986443,9.047262
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:25:177,1.875973,-3.194418,9.078369
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:25:380,1.828116,-2.565106,9.475577
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:25:577,1.797010,-2.864209,9.312866
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:25:777,1.782653,-2.883351,9.391829
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:25:977,1.605584,-3.132205,9.339187
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:26:178,1.696511,-3.089134,9.427721
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:26:378,1.749153,-3.046063,9.394222
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:26:578,1.830509,-2.309074,9.410972
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:26:778,1.761117,-2.758924,9.851252
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:26:978,1.651048,-2.816352,9.568897
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:27:178,1.820938,-1.667797,9.049655
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:27:378,1.813759,-2.115255,9.659825
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:27:579,1.596013,-2.000400,9.748360
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:27:779,1.792224,-1.598405,9.580862
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:27:979,1.835295,-1.612763,9.549755
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:28:179,1.856830,-1.488336,9.547362
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:28:379,1.801795,-1.507478,9.628718
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:28:579,1.878366,-1.406980,9.509077
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:28:780,1.844866,-1.655833,9.710074
04-23 13:51:01.701+0200 I/recorder(18470): SM-R760,23/04/2018,13:46:28:980,1.741975,-1.658226,9.638289
04-23 13:51:01.711+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:01.711+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:01:719,77
04-23 13:51:01.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:51:01.731+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18458
04-23 13:51:01.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:51:01.801+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:51:01.801+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18470
04-23 13:51:01.811+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:51:01.881+0200 W/CRASH_MANAGER(17537): worker.c: worker_job(1205) > 1118470726563152448426
