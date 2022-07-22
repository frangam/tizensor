S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 17852
Date: 2018-04-23 13:48:01+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf75be648, r1   = 0xf7a121b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7a121b8, r5   = 0x00012cd0
r6   = 0xf7a24e88, r7   = 0xf75be250
r8   = 0x000005e0, r9   = 0xf70a1824
r10  = 0xf7a0a9d8, fp   = 0x00000000
ip   = 0xf75bd030, sp   = 0xffabf690
lr   = 0xf75015d0, pc   = 0xf74fd9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     82308 KB
Buffers:     30492 KB
Cached:     148920 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7716 KB
VmRSS:        7712 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6c38000 f6c3b000 r-xp /lib/libattr.so.1.1.0
f6c44000 f6c4b000 r-xp /lib/libcrypt-2.13.so
f6c7b000 f6c7e000 r-xp /lib/libcap.so.2.21
f6c86000 f6c88000 r-xp /usr/lib/libiri.so
f6c90000 f6cad000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cb6000 f6cba000 r-xp /usr/lib/libsmack.so.1.0.0
f6cc4000 f6cc6000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6cce000 f6cd3000 r-xp /usr/lib/libffi.so.5.0.10
f6cdb000 f6cdc000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ce4000 f6ce6000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6cee000 f6cf0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6cfa000 f6d0a000 r-xp /lib/libresolv-2.13.so
f6d0e000 f6d26000 r-xp /usr/lib/liblzma.so.5.0.3
f6d2e000 f6d30000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d38000 f6d67000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d70000 f6d7f000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d88000 f6d92000 r-xp /usr/lib/libsensord-shared.so
f6d9b000 f6dcf000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6dd8000 f6eab000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6eb6000 f6ecc000 r-xp /lib/libz.so.1.2.5
f6ed4000 f6eda000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ee3000 f6f58000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f62000 f6f7c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6f84000 f6f8a000 r-xp /lib/librt-2.13.so
f6f93000 f6fb1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6fbb000 f6fbc000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fc4000 f6fc9000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fd1000 f70a1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70a2000 f70cc000 r-xp /usr/lib/libdbus-1.so.3.8.12
f70d5000 f70ec000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f70f4000 f715d000 r-xp /lib/libm-2.13.so
f7166000 f71fa000 r-xp /usr/lib/libstdc++.so.6.0.16
f720d000 f7212000 r-xp /usr/lib/libctx-client.so.0.8.3
f721a000 f7221000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7229000 f7253000 r-xp /usr/lib/libsensor.so.1.9.6
f725c000 f7328000 r-xp /usr/lib/libxml2.so.2.7.8
f7335000 f7337000 r-xp /usr/lib/libiniparser.so.0
f7340000 f7343000 r-xp /usr/lib/libbundle.so.0.1.22
f734b000 f7351000 r-xp /usr/lib/libappsvc.so.0.1.0
f7359000 f737c000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7384000 f73c5000 r-xp /usr/lib/libeina.so.1.7.99
f73ce000 f73e5000 r-xp /usr/lib/libecore.so.1.7.99
f73fc000 f7405000 r-xp /usr/lib/libvconf.so.0.2.45
f740d000 f7421000 r-xp /lib/libpthread-2.13.so
f742c000 f7439000 r-xp /usr/lib/libaul.so.0.1.0
f7443000 f7445000 r-xp /lib/libdl-2.13.so
f744e000 f7459000 r-xp /lib/libunwind.so.8.0.1
f7486000 f748e000 r-xp /lib/libgcc_s-4.6.so.1
f748f000 f75b3000 r-xp /lib/libc-2.13.so
f75c1000 f75c3000 r-xp /usr/lib/libdlog.so.0.0.0
f75cb000 f75d7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f75e0000 f75e5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f75ed000 f75f1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75fa000 f75fc000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7605000 f7608000 r-xp /usr/lib/libappcore-agent.so.1.1
f7626000 f7643000 r-xp /lib/ld-2.13.so
f764c000 f764f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f764f000 f7653000 r-xp /usr/lib/libsys-assert.so
f7a00000 f7a4e000 rw-p [heap]
ffaa1000 ffac2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:17852)
Call Stack Count: 1
 0: (0xf74fd9fc) [/lib/libc.so.6] + 0x6e9fc
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
SM-R760,23/04/2018,13:47:51:175,77
04-23 13:47:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:51.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491271298,000000, pattern:[H:mm][0;m
04-23 13:47:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:51.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:51.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:51.361+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:51.371+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:51:375,77
04-23 13:47:51.561+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:51.571+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:51:575,76
04-23 13:47:51.761+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:51.771+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:51:775,76
04-23 13:47:51.961+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:51.971+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:51:975,76
04-23 13:47:52.161+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:52.171+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:52:175,76
04-23 13:47:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:52.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491272297,000000, pattern:[H:mm][0;m
04-23 13:47:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:52.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:52.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:52.361+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:52.371+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:52:376,76
04-23 13:47:52.561+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:52.571+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:52:575,76
04-23 13:47:52.761+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:52.771+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:52:776,76
04-23 13:47:52.961+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:52.971+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:52:976,76
04-23 13:47:53.161+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:53.171+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:53:176,76
04-23 13:47:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:53.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491273298,000000, pattern:[H:mm][0;m
04-23 13:47:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:53.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:53.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:53.361+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:53.371+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:53:376,76
04-23 13:47:53.561+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:53.571+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:53:577,77
04-23 13:47:53.761+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:53.771+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:53:777,77
04-23 13:47:53.961+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:53.971+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:53:976,77
04-23 13:47:54.161+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:54.171+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:54:177,77
04-23 13:47:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:54.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491274298,000000, pattern:[H:mm][0;m
04-23 13:47:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:54.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:54.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:54.361+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:54.371+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:54:377,77
04-23 13:47:54.561+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:54.571+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:54:577,77
04-23 13:47:54.761+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:54.771+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:54:777,77
04-23 13:47:54.961+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:54.971+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:54:977,77
04-23 13:47:55.161+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:55.171+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:55:177,77
04-23 13:47:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:55.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491275298,000000, pattern:[H:mm][0;m
04-23 13:47:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:55.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:55.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:55.361+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:55.371+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:55:378,77
04-23 13:47:55.561+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:55.571+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:55:577,76
04-23 13:47:55.761+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:55.771+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:55:778,76
04-23 13:47:55.961+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:55.971+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:55:978,75
04-23 13:47:56.161+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:56.171+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:56:178,76
04-23 13:47:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:56.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491276298,000000, pattern:[H:mm][0;m
04-23 13:47:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:56.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:56.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:56.361+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:56.371+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:56:378,75
04-23 13:47:56.571+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:56.571+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:56:579,75
04-23 13:47:56.761+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:56.771+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:56:778,75
04-23 13:47:56.971+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:56.971+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:56:978,75
04-23 13:47:57.171+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:57.171+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:57:179,75
04-23 13:47:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:57.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491277298,000000, pattern:[H:mm][0;m
04-23 13:47:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:57.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:57.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:57.371+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:57.371+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:57:379,75
04-23 13:47:57.571+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:57.571+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:57:579,74
04-23 13:47:57.771+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:57.771+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:57:779,74
04-23 13:47:57.971+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:57.971+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:57:979,74
04-23 13:47:58.171+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:58.171+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:58:181,74
04-23 13:47:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:58.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491278299,000000, pattern:[H:mm][0;m
04-23 13:47:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:58.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:58.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:58.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:58.371+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:58.371+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:58:380,74
04-23 13:47:58.571+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:58.571+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:58:579,74
04-23 13:47:58.771+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:58.771+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:58:780,74
04-23 13:47:58.971+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:58.971+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:58:980,73
04-23 13:47:59.171+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:59.171+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:59:180,73
04-23 13:47:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:59.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491279297,000000, pattern:[H:mm][0;m
04-23 13:47:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:47:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:47:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:47:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:47:59.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:47:59.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:47][0;m
04-23 13:47:59.371+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:59.371+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:59:380,73
04-23 13:47:59.571+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:59.571+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:59:581,73
04-23 13:47:59.771+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:59.771+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:59:780,73
04-23 13:47:59.971+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:47:59.971+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:47:59:980,73
04-23 13:48:00.171+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:48:00.171+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:48:00:181,72
04-23 13:48:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:48:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:48:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:48:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:48:00.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491280298,000000, pattern:[H:mm][0;m
04-23 13:48:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:48:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:48:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:48:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:48:00.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:48:00.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:48][0;m
04-23 13:48:00.371+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:48:00.371+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:48:00:381,73
04-23 13:48:00.571+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:48:00.571+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:48:00:581,73
04-23 13:48:00.771+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:48:00.771+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:48:00:782,73
04-23 13:48:00.971+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:48:00.971+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:48:00:982,73
04-23 13:48:01.171+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:48:01.171+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:48:01:182,73
04-23 13:48:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:48:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:48:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:48:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:48:01.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491281293,000000, pattern:[H:mm][0;m
04-23 13:48:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:48:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:48:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:48:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:48:01.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:48:01.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:48][0;m
04-23 13:48:01.281+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:48:01.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:48:01.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:48:01.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17422
04-23 13:48:01.301+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:48:01.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17422), cmd(0)
04-23 13:48:01.311+0200 I/utils   (17422): specific action
04-23 13:48:01.311+0200 I/httppostreq(17422): internet connection check received
04-23 13:48:01.311+0200 I/httppostreq(17422): internet connection != null
04-23 13:48:01.311+0200 I/CAPI_NETWORK_CONNECTION(17422): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:48:01.311+0200 I/httppostreq(17422): internet connection type...
04-23 13:48:01.311+0200 I/httppostreq(17422): internet connection type 1
04-23 13:48:01.311+0200 I/httppostreq(17422): internet available
04-23 13:48:01.311+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:48:01.311+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17422)
04-23 13:48:01.311+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.httppostreq
04-23 13:48:01.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:48:01.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17422
04-23 13:48:01.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
04-23 13:48:01.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:48:01.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17419), cmd(0)
04-23 13:48:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:48:01.331+0200 I/utils   (17419): specific action
04-23 13:48:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:48:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:48:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:48:01.331+0200 I/servicemanager(17419): internet connection available. stop all sensors
04-23 13:48:01.331+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:48:01.341+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
04-23 13:48:01.341+0200 I/httppostreq(17422): request sent to service es.ugr.frailty.servicemanager
04-23 13:48:01.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:48:01.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:48:01.351+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 17837
04-23 13:48:01.351+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:48:01.371+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:48:01.371+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:48:01:382,73
04-23 13:48:01.381+0200 E/CAPI_APPFW_APPLICATION(17837): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:48:01.391+0200 E/CAPI_APPFW_APPLICATION(17837): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:48:01.391+0200 I/utils   (17837): trying to start service: es.ugr.frailty.accelerometer
04-23 13:48:01.391+0200 I/utils   (17837): es.ugr.frailty.accelerometer sensor supported
04-23 13:48:01.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 17837
04-23 13:48:01.401+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(17837) type(svcapp) bg(0)
04-23 13:48:01.401+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (17837) was created
04-23 13:48:01.411+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17837)
04-23 13:48:01.421+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [17837]
04-23 13:48:01.421+0200 I/utils   (17837): es.ugr.frailty.accelerometer listener started
04-23 13:48:01.421+0200 I/accelerometer(17837): stopping es.ugr.frailty.accelerometer service
04-23 13:48:01.421+0200 E/CAPI_APPFW_APP_CONTROL(17837): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:48:01.421+0200 E/accelerometer(17837): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:48:01.421+0200 I/CAPI_APPFW_APPLICATION(17837): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:48:01.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:48:01.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:48:01.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:48:01.451+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17837
04-23 13:48:01.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:48:01.461+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17837
04-23 13:48:01.461+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:48:01.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:48:01.561+0200 I/servicemanager(17419): es.ugr.frailty.accelerometer stop request sent!
04-23 13:48:01.561+0200 I/servicemanager(17419): App control destroyed.
04-23 13:48:01.561+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:48:01.561+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:48:01.561+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:48:01.561+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:48:01.571+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:48:01.571+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:48:01.571+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:48:01.571+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:48:01.571+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:48:01:582,73
04-23 13:48:01.571+0200 I/servicemanager(17419): deleting timer 0
04-23 13:48:01.581+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:48:01.581+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:48:01.581+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:48:01.581+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:48:01.591+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:48:01.591+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:48:01.591+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:48:01.591+0200 I/servicemanager(17419): deleting timer 1
04-23 13:48:01.591+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:48:01.591+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:48:01.591+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:48:01.591+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:48:01.601+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:48:01.601+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:48:01.601+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:48:01.601+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:48:01.601+0200 I/servicemanager(17419): deleting timer 2
04-23 13:48:01.601+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:48:01.601+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:48:01.601+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:48:01.611+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:48:01.611+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:48:01.611+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:48:01.611+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:48:01.611+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:48:01.611+0200 I/servicemanager(17419): deleting timer 3
04-23 13:48:01.611+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:48:01.611+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:48:01.611+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:48:01.611+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:48:01.611+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:48:01.611+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:48:01.611+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:48:01.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:48:01.621+0200 I/servicemanager(17419): deleting timer 4
04-23 13:48:01.621+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:48:01.621+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:48:01.621+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:48:01.621+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17837
04-23 13:48:01.631+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:48:01.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:48:01.671+0200 I/accelerometer(17837): es.ugr.frailty.accelerometer listener destroyed
04-23 13:48:01.671+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:48:01.671+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:48:01.671+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:48:01.671+0200 I/servicemanager(17419): deleting timer 5
04-23 13:48:01.671+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:48:01.671+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:48:01.671+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:48:01.671+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:48:01.671+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:48:01.671+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:48:01.671+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:48:01.671+0200 I/servicemanager(17419): deleting timer 6
04-23 13:48:01.671+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:48:01.671+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:48:01.671+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:48:01.671+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:48:01.671+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:48:01.671+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:48:01.671+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:48:01.671+0200 I/servicemanager(17419): deleting timer 7
04-23 13:48:01.671+0200 I/servicemanager(17419): deleting timer 8
04-23 13:48:01.671+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:48:01.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:48:01.671+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:48:01.681+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 17852
04-23 13:48:01.681+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:48:01.721+0200 E/CAPI_APPFW_APPLICATION(17852): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:48:01.721+0200 E/CAPI_APPFW_APPLICATION(17852): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:48:01.721+0200 I/utils   (17852): specific action
04-23 13:48:01.721+0200 I/recorder(17852): obteniendo datos locales...
04-23 13:48:01.731+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 17852
04-23 13:48:01.731+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(17852) type(svcapp) bg(0)
04-23 13:48:01.741+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (17852) was created
04-23 13:48:01.741+0200 I/recorder(17852): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:24:189,1.849652,-2.009971,9.454042
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:24:371,1.804188,-3.177669,9.157332
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:24:577,1.634298,-3.120241,9.145369
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:24:777,1.775474,-3.187240,9.329616
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:24:977,1.730011,-3.986443,9.047262
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:25:177,1.875973,-3.194418,9.078369
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:25:380,1.828116,-2.565106,9.475577
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:25:577,1.797010,-2.864209,9.312866
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:25:777,1.782653,-2.883351,9.391829
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:25:977,1.605584,-3.132205,9.339187
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:26:178,1.696511,-3.089134,9.427721
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:26:378,1.749153,-3.046063,9.394222
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:26:578,1.830509,-2.309074,9.410972
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:26:778,1.761117,-2.758924,9.851252
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:26:978,1.651048,-2.816352,9.568897
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:27:178,1.820938,-1.667797,9.049655
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:27:378,1.813759,-2.115255,9.659825
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:27:579,1.596013,-2.000400,9.748360
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:27:779,1.792224,-1.598405,9.580862
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:27:979,1.835295,-1.612763,9.549755
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:28:179,1.856830,-1.488336,9.547362
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:28:379,1.801795,-1.507478,9.628718
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:28:579,1.878366,-1.406980,9.509077
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:28:780,1.844866,-1.655833,9.710074
04-23 13:48:01.741+0200 I/recorder(17852): SM-R760,23/04/2018,13:46:28:980,1.741975,-1.658226,9.638289
04-23 13:48:01.751+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [17852]
04-23 13:48:01.751+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17852)
04-23 13:48:01.751+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.recorder
04-23 13:48:01.761+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:48:01.771+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17852
04-23 13:48:01.771+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:48:01.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:48:01.771+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:48:01:782,74
04-23 13:48:01.781+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17852
04-23 13:48:01.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:48:01.821+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:48:01.871+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:48:01.881+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17852
04-23 13:48:01.901+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:48:01.941+0200 W/AUL     (17858): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 13:48:01.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 13:48:01.951+0200 E/EFL     ( 2478): ecore<2478> ecore.c:573 _ecore_magic_fail() 
04-23 13:48:01.951+0200 E/EFL     ( 2478): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:48:01.951+0200 E/EFL     ( 2478): *** IN FUNCTION: ecore_timer_del()
04-23 13:48:01.951+0200 E/EFL     ( 2478): ecore<2478> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:48:01.951+0200 E/EFL     ( 2478): ecore<2478> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:48:01.951+0200 E/EFL     ( 2478): *** SPANK SPANK SPANK!!!
04-23 13:48:01.951+0200 E/EFL     ( 2478): *** Now go fix your code. Tut tut tut!
04-23 13:48:01.951+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: -1
04-23 13:48:01.951+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 17837
04-23 13:48:01.951+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 13:48:01.961+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 17837
04-23 13:48:01.961+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(17837)
04-23 13:48:01.961+0200 E/AUL     (17858): daemon-manager-release-agent.c: main(22) > APP_RELEASED request sending error
04-23 13:48:01.971+0200 W/CRASH_MANAGER(17537): worker.c: worker_job(1205) > 1117852726563152448408
