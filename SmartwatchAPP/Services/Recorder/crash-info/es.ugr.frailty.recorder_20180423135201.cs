S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 18675
Date: 2018-04-23 13:52:01+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf76d0648, r1   = 0xf7ea41b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7ea41b8, r5   = 0x00012cd0
r6   = 0xf7eb6e88, r7   = 0xf76d0250
r8   = 0x000005e0, r9   = 0xf71b3824
r10  = 0xf7e9c9d8, fp   = 0x00000000
ip   = 0xf76cf030, sp   = 0xffef0590
lr   = 0xf76135d0, pc   = 0xf760f9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     32656 KB
Buffers:     31668 KB
Cached:     149888 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7716 KB
VmRSS:        7716 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6d4a000 f6d4d000 r-xp /lib/libattr.so.1.1.0
f6d56000 f6d5d000 r-xp /lib/libcrypt-2.13.so
f6d8d000 f6d90000 r-xp /lib/libcap.so.2.21
f6d98000 f6d9a000 r-xp /usr/lib/libiri.so
f6da2000 f6dbf000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6dc8000 f6dcc000 r-xp /usr/lib/libsmack.so.1.0.0
f6dd6000 f6dd8000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6de0000 f6de5000 r-xp /usr/lib/libffi.so.5.0.10
f6ded000 f6dee000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6df6000 f6df8000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6e00000 f6e02000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6e0c000 f6e1c000 r-xp /lib/libresolv-2.13.so
f6e20000 f6e38000 r-xp /usr/lib/liblzma.so.5.0.3
f6e40000 f6e42000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6e4a000 f6e79000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6e82000 f6e91000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6e9a000 f6ea4000 r-xp /usr/lib/libsensord-shared.so
f6ead000 f6ee1000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6eea000 f6fbd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6fc8000 f6fde000 r-xp /lib/libz.so.1.2.5
f6fe6000 f6fec000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ff5000 f706a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f7074000 f708e000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f7096000 f709c000 r-xp /lib/librt-2.13.so
f70a5000 f70c3000 r-xp /usr/lib/libsystemd.so.0.4.0
f70cd000 f70ce000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f70d6000 f70db000 r-xp /usr/lib/libxdgmime.so.1.1.0
f70e3000 f71b3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f71b4000 f71de000 r-xp /usr/lib/libdbus-1.so.3.8.12
f71e7000 f71fe000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7206000 f726f000 r-xp /lib/libm-2.13.so
f7278000 f730c000 r-xp /usr/lib/libstdc++.so.6.0.16
f731f000 f7324000 r-xp /usr/lib/libctx-client.so.0.8.3
f732c000 f7333000 r-xp /usr/lib/libctx-shared.so.0.8.3
f733b000 f7365000 r-xp /usr/lib/libsensor.so.1.9.6
f736e000 f743a000 r-xp /usr/lib/libxml2.so.2.7.8
f7447000 f7449000 r-xp /usr/lib/libiniparser.so.0
f7452000 f7455000 r-xp /usr/lib/libbundle.so.0.1.22
f745d000 f7463000 r-xp /usr/lib/libappsvc.so.0.1.0
f746b000 f748e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7496000 f74d7000 r-xp /usr/lib/libeina.so.1.7.99
f74e0000 f74f7000 r-xp /usr/lib/libecore.so.1.7.99
f750e000 f7517000 r-xp /usr/lib/libvconf.so.0.2.45
f751f000 f7533000 r-xp /lib/libpthread-2.13.so
f753e000 f754b000 r-xp /usr/lib/libaul.so.0.1.0
f7555000 f7557000 r-xp /lib/libdl-2.13.so
f7560000 f756b000 r-xp /lib/libunwind.so.8.0.1
f7598000 f75a0000 r-xp /lib/libgcc_s-4.6.so.1
f75a1000 f76c5000 r-xp /lib/libc-2.13.so
f76d3000 f76d5000 r-xp /usr/lib/libdlog.so.0.0.0
f76dd000 f76e9000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f76f2000 f76f7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f76ff000 f7703000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f770c000 f770e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7717000 f771a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7738000 f7755000 r-xp /lib/ld-2.13.so
f775e000 f7761000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7761000 f7765000 r-xp /usr/lib/libsys-assert.so
f7e92000 f7ee0000 rw-p [heap]
ffed2000 ffef3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18675)
Call Stack Count: 1
 0: (0xf760f9fc) [/lib/libc.so.6] + 0x6e9fc
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
200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:50.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:51:50.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:51][0;m
04-23 13:51:50.321+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:50.321+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:50:334,79
04-23 13:51:50.521+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:50.521+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:50:534,78
04-23 13:51:50.721+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:50.721+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:50:734,79
04-23 13:51:50.921+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:50.921+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:50:934,80
04-23 13:51:51.121+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:51.121+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:51:134,80
04-23 13:51:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:51.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491511298,000000, pattern:[H:mm][0;m
04-23 13:51:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:51.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:51.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:51:51.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:51][0;m
04-23 13:51:51.321+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:51.321+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:51:335,80
04-23 13:51:51.521+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:51.521+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:51:534,80
04-23 13:51:51.721+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:51.721+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:51:735,80
04-23 13:51:51.921+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:51.931+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:51:935,80
04-23 13:51:52.121+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:52.131+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:52:135,80
04-23 13:51:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:52.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491512297,000000, pattern:[H:mm][0;m
04-23 13:51:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:52.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:52.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:51:52.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:51][0;m
04-23 13:51:52.321+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:52.331+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:52:335,80
04-23 13:51:52.521+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:52.531+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:52:535,80
04-23 13:51:52.721+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:52.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:52:735,80
04-23 13:51:52.921+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:52.931+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:52:935,80
04-23 13:51:53.121+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:53.131+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:53:136,80
04-23 13:51:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:53.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491513297,000000, pattern:[H:mm][0;m
04-23 13:51:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:53.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:53.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:51:53.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:51][0;m
04-23 13:51:53.321+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:53.331+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:53:336,80
04-23 13:51:53.521+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:53.531+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:53:536,81
04-23 13:51:53.721+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:53.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:53:736,80
04-23 13:51:53.921+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:53.931+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:53:936,81
04-23 13:51:54.121+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:54.131+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:54:136,80
04-23 13:51:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:54.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491514298,000000, pattern:[H:mm][0;m
04-23 13:51:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:54.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:54.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:51:54.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:51][0;m
04-23 13:51:54.321+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:54.331+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:54:337,80
04-23 13:51:54.521+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:54.531+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:54:536,80
04-23 13:51:54.721+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:54.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:54:737,80
04-23 13:51:54.921+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:54.931+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:54:937,80
04-23 13:51:55.121+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:55.131+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:55:137,80
04-23 13:51:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:55.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491515298,000000, pattern:[H:mm][0;m
04-23 13:51:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:55.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:55.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:51:55.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:51][0;m
04-23 13:51:55.321+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:55.331+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:55:337,80
04-23 13:51:55.521+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:55.531+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:55:538,80
04-23 13:51:55.721+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:55.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:55:737,80
04-23 13:51:55.921+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:55.931+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:55:937,80
04-23 13:51:56.121+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:56.131+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:56:138,79
04-23 13:51:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:56.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491516298,000000, pattern:[H:mm][0;m
04-23 13:51:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:56.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:56.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:51:56.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:51][0;m
04-23 13:51:56.321+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:56.331+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:56:338,79
04-23 13:51:56.521+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:56.531+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:56:538,79
04-23 13:51:56.731+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:56.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:56:739,78
04-23 13:51:56.921+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:56.931+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:56:938,79
04-23 13:51:57.121+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:57.131+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:57:138,79
04-23 13:51:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:57.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491517298,000000, pattern:[H:mm][0;m
04-23 13:51:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:57.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:57.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:51:57.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:51][0;m
04-23 13:51:57.331+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:57.331+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:57:339,79
04-23 13:51:57.531+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:57.531+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:57:538,79
04-23 13:51:57.731+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:57.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:57:739,79
04-23 13:51:57.931+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:57.931+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:57:939,79
04-23 13:51:58.131+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:58.131+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:58:139,78
04-23 13:51:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:58.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491518297,000000, pattern:[H:mm][0;m
04-23 13:51:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:58.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:58.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:51:58.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:51][0;m
04-23 13:51:58.331+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:58.331+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:58:339,79
04-23 13:51:58.531+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:58.531+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:58:539,78
04-23 13:51:58.731+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:58.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:58:739,78
04-23 13:51:58.931+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:58.931+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:58:940,78
04-23 13:51:59.131+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:59.131+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:59:140,79
04-23 13:51:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:59.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491519298,000000, pattern:[H:mm][0;m
04-23 13:51:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:51:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:51:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:51:59.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:51:59.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:51:59.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:51][0;m
04-23 13:51:59.331+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:59.331+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:59:340,79
04-23 13:51:59.531+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:59.531+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:59:540,80
04-23 13:51:59.731+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:59.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:59:740,80
04-23 13:51:59.931+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:51:59.931+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:51:59:940,81
04-23 13:52:00.131+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:00.131+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:00:140,81
04-23 13:52:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:00.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491520298,000000, pattern:[H:mm][0;m
04-23 13:52:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:00.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:00.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:00.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:00.331+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:00.331+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:00:341,81
04-23 13:52:00.531+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:00.531+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:00:540,81
04-23 13:52:00.731+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:00.731+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:00:741,82
04-23 13:52:00.931+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:00.931+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:00:941,81
04-23 13:52:01.131+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:01.131+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:01:141,82
04-23 13:52:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:01.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491521293,000000, pattern:[H:mm][0;m
04-23 13:52:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:01.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:01.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:01.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:01.281+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:52:01.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:52:01.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:52:01.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17422
04-23 13:52:01.301+0200 I/utils   (17422): specific action
04-23 13:52:01.301+0200 I/httppostreq(17422): internet connection check received
04-23 13:52:01.301+0200 I/httppostreq(17422): internet connection != null
04-23 13:52:01.301+0200 I/CAPI_NETWORK_CONNECTION(17422): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:52:01.301+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:52:01.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17422), cmd(0)
04-23 13:52:01.311+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17422)
04-23 13:52:01.311+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.httppostreq
04-23 13:52:01.311+0200 I/httppostreq(17422): internet connection type...
04-23 13:52:01.311+0200 I/httppostreq(17422): internet connection type 1
04-23 13:52:01.311+0200 I/httppostreq(17422): internet available
04-23 13:52:01.311+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:52:01.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:52:01.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17422
04-23 13:52:01.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
04-23 13:52:01.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:52:01.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17419), cmd(0)
04-23 13:52:01.331+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
04-23 13:52:01.331+0200 I/httppostreq(17422): request sent to service es.ugr.frailty.servicemanager
04-23 13:52:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:52:01.331+0200 I/utils   (17419): specific action
04-23 13:52:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:52:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:52:01.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:52:01.331+0200 I/servicemanager(17419): internet connection available. stop all sensors
04-23 13:52:01.341+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:52:01.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:52:01.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:01.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:52:01.351+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:52:01.351+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18662
04-23 13:52:01.391+0200 E/CAPI_APPFW_APPLICATION(18662): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:52:01.391+0200 E/CAPI_APPFW_APPLICATION(18662): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:52:01.391+0200 I/utils   (18662): trying to start service: es.ugr.frailty.accelerometer
04-23 13:52:01.391+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:01:351,83
04-23 13:52:01.391+0200 I/utils   (18662): es.ugr.frailty.accelerometer sensor supported
04-23 13:52:01.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18662
04-23 13:52:01.401+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(18662) type(svcapp) bg(0)
04-23 13:52:01.411+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18662) was created
04-23 13:52:01.421+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18662)
04-23 13:52:01.421+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18662]
04-23 13:52:01.421+0200 I/servicemanager(17419): es.ugr.frailty.accelerometer stop request sent!
04-23 13:52:01.421+0200 I/servicemanager(17419): App control destroyed.
04-23 13:52:01.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:01.431+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18662
04-23 13:52:01.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:01.441+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18662
04-23 13:52:01.451+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:01.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:01.501+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:01.501+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:01.501+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:01.501+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:01.501+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:01.501+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:01.501+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:01.501+0200 I/servicemanager(17419): deleting timer 0
04-23 13:52:01.501+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:01.501+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:01.501+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:01.501+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:01.501+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:01.501+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:01.501+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:01.501+0200 I/servicemanager(17419): deleting timer 1
04-23 13:52:01.501+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:01.501+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:01.501+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:01.501+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:01.501+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:01.501+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:01.501+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:01.501+0200 I/servicemanager(17419): deleting timer 2
04-23 13:52:01.511+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:01.511+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:01.511+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:01.511+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:01.511+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:01.511+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:01.511+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:01.511+0200 I/servicemanager(17419): deleting timer 3
04-23 13:52:01.511+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:01.511+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:01.511+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:01.511+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:01.511+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:01.511+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:01.511+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:01.511+0200 I/servicemanager(17419): deleting timer 4
04-23 13:52:01.511+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:01.511+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:01.511+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:01.511+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:01.511+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:01.511+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:01.511+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:01.511+0200 I/servicemanager(17419): deleting timer 5
04-23 13:52:01.511+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:01.511+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:01.511+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:01.511+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:01.511+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:01.511+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:01.511+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:01.511+0200 I/servicemanager(17419): deleting timer 6
04-23 13:52:01.521+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:01.521+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:01.521+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:01.521+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:01.521+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:01.521+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:01.521+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:01.521+0200 I/servicemanager(17419): deleting timer 7
04-23 13:52:01.521+0200 I/servicemanager(17419): deleting timer 8
04-23 13:52:01.521+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:52:01.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:52:01.521+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:52:01.531+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18675
04-23 13:52:01.541+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:52:01.551+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:01.581+0200 E/CAPI_APPFW_APPLICATION(18675): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:52:01.581+0200 E/CAPI_APPFW_APPLICATION(18675): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:52:01.581+0200 I/utils   (18675): specific action
04-23 13:52:01.581+0200 I/recorder(18675): obteniendo datos locales...
04-23 13:52:01.581+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18675
04-23 13:52:01.581+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(18675) type(svcapp) bg(0)
04-23 13:52:01.591+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18675) was created
04-23 13:52:01.601+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18675]
04-23 13:52:01.601+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18675)
04-23 13:52:01.601+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.recorder
04-23 13:52:01.601+0200 I/utils   (18662): es.ugr.frailty.accelerometer listener started
04-23 13:52:01.611+0200 I/accelerometer(18662): stopping es.ugr.frailty.accelerometer service
04-23 13:52:01.611+0200 E/CAPI_APPFW_APP_CONTROL(18662): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:52:01.611+0200 E/accelerometer(18662): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:52:01.611+0200 I/CAPI_APPFW_APPLICATION(18662): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:52:01.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:52:01.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:52:01.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:01.621+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18675
04-23 13:52:01.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:01.641+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18675
04-23 13:52:01.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:01.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:01.711+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:01.721+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18662
04-23 13:52:01.721+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:01.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:01.791+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18675
04-23 13:52:01.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:01.831+0200 I/recorder(18675): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:24:189,1.849652,-2.009971,9.454042
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:24:371,1.804188,-3.177669,9.157332
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:24:577,1.634298,-3.120241,9.145369
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:24:777,1.775474,-3.187240,9.329616
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:24:977,1.730011,-3.986443,9.047262
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:25:177,1.875973,-3.194418,9.078369
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:25:380,1.828116,-2.565106,9.475577
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:25:577,1.797010,-2.864209,9.312866
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:25:777,1.782653,-2.883351,9.391829
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:25:977,1.605584,-3.132205,9.339187
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:26:178,1.696511,-3.089134,9.427721
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:26:378,1.749153,-3.046063,9.394222
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:26:578,1.830509,-2.309074,9.410972
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:26:778,1.761117,-2.758924,9.851252
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:26:978,1.651048,-2.816352,9.568897
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:27:178,1.820938,-1.667797,9.049655
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:27:378,1.813759,-2.115255,9.659825
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:27:579,1.596013,-2.000400,9.748360
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:27:779,1.792224,-1.598405,9.580862
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:27:979,1.835295,-1.612763,9.549755
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:28:179,1.856830,-1.488336,9.547362
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:28:379,1.801795,-1.507478,9.628718
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:28:579,1.878366,-1.406980,9.509077
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:28:780,1.844866,-1.655833,9.710074
04-23 13:52:01.831+0200 I/recorder(18675): SM-R760,23/04/2018,13:46:28:980,1.741975,-1.658226,9.638289
04-23 13:52:01.871+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:01:559,83
04-23 13:52:01.871+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:01.881+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:01:881,83
04-23 13:52:01.951+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:52:01.961+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:01.961+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:52:01.981+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:01:972,83
04-23 13:52:01.991+0200 I/accelerometer(18662): es.ugr.frailty.accelerometer listener destroyed
04-23 13:52:02.021+0200 W/CRASH_MANAGER(17537): worker.c: worker_job(1205) > 1118675726563152448432
