S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 20368
Date: 2018-04-23 14:00:34+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf740e648, r1   = 0xf7cb91b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7cb91b8, r5   = 0x00012cd0
r6   = 0xf7ccbe88, r7   = 0xf740e250
r8   = 0x000005a0, r9   = 0xf6ef1824
r10  = 0xf7cb19d8, fp   = 0x00000000
ip   = 0xf740d030, sp   = 0xfffa9f80
lr   = 0xf73515d0, pc   = 0xf734d9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     68260 KB
Buffers:     29208 KB
Cached:     142568 KB
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
VmPTE:          36 KB
VmSwap:          0 KB

Maps Information
f6a88000 f6a8b000 r-xp /lib/libattr.so.1.1.0
f6a94000 f6a9b000 r-xp /lib/libcrypt-2.13.so
f6acb000 f6ace000 r-xp /lib/libcap.so.2.21
f6ad6000 f6ad8000 r-xp /usr/lib/libiri.so
f6ae0000 f6afd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6b06000 f6b0a000 r-xp /usr/lib/libsmack.so.1.0.0
f6b14000 f6b16000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b1e000 f6b23000 r-xp /usr/lib/libffi.so.5.0.10
f6b2b000 f6b2c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b34000 f6b36000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b3e000 f6b40000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6b4a000 f6b5a000 r-xp /lib/libresolv-2.13.so
f6b5e000 f6b76000 r-xp /usr/lib/liblzma.so.5.0.3
f6b7e000 f6b80000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b88000 f6bb7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6bc0000 f6bcf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6bd8000 f6be2000 r-xp /usr/lib/libsensord-shared.so
f6beb000 f6c1f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6c28000 f6cfb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6d06000 f6d1c000 r-xp /lib/libz.so.1.2.5
f6d24000 f6d2a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d33000 f6da8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6db2000 f6dcc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6dd4000 f6dda000 r-xp /lib/librt-2.13.so
f6de3000 f6e01000 r-xp /usr/lib/libsystemd.so.0.4.0
f6e0b000 f6e0c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6e14000 f6e19000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6e21000 f6ef1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6ef2000 f6f1c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f25000 f6f3c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f44000 f6fad000 r-xp /lib/libm-2.13.so
f6fb6000 f704a000 r-xp /usr/lib/libstdc++.so.6.0.16
f705d000 f7062000 r-xp /usr/lib/libctx-client.so.0.8.3
f706a000 f7071000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7079000 f70a3000 r-xp /usr/lib/libsensor.so.1.9.6
f70ac000 f7178000 r-xp /usr/lib/libxml2.so.2.7.8
f7185000 f7187000 r-xp /usr/lib/libiniparser.so.0
f7190000 f7193000 r-xp /usr/lib/libbundle.so.0.1.22
f719b000 f71a1000 r-xp /usr/lib/libappsvc.so.0.1.0
f71a9000 f71cc000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f71d4000 f7215000 r-xp /usr/lib/libeina.so.1.7.99
f721e000 f7235000 r-xp /usr/lib/libecore.so.1.7.99
f724c000 f7255000 r-xp /usr/lib/libvconf.so.0.2.45
f725d000 f7271000 r-xp /lib/libpthread-2.13.so
f727c000 f7289000 r-xp /usr/lib/libaul.so.0.1.0
f7293000 f7295000 r-xp /lib/libdl-2.13.so
f729e000 f72a9000 r-xp /lib/libunwind.so.8.0.1
f72d6000 f72de000 r-xp /lib/libgcc_s-4.6.so.1
f72df000 f7403000 r-xp /lib/libc-2.13.so
f7411000 f7413000 r-xp /usr/lib/libdlog.so.0.0.0
f741b000 f7427000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7430000 f7435000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f743d000 f7441000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f744a000 f744c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7455000 f7458000 r-xp /usr/lib/libappcore-agent.so.1.1
f7476000 f7493000 r-xp /lib/ld-2.13.so
f749c000 f749f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f749f000 f74a3000 r-xp /usr/lib/libsys-assert.so
f7ca7000 f7cf5000 rw-p [heap]
fff8c000 fffad000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20368)
Call Stack Count: 1
 0: (0xf734d9fc) [/lib/libc.so.6] + 0x6e9fc
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
tem], index = 13, key = 13, type = 0
04-23 14:00:26.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:26.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:26.361+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:26.371+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:26:369,73
04-23 14:00:26.561+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:26.561+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:26:570,74
04-23 14:00:26.761+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:26.761+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:26:770,74
04-23 14:00:26.961+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:26.961+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:26:970,74
04-23 14:00:27.161+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:27.161+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:27:170,74
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:27.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492027340,000000, pattern:[H:mm][0;m
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:27.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:27.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:27.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:27.361+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:27.361+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:27:370,74
04-23 14:00:27.561+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:27.561+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:27:570,75
04-23 14:00:27.761+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:27.761+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:27:770,75
04-23 14:00:27.961+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:27.961+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:27:970,75
04-23 14:00:28.161+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:28.161+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:28:170,74
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:28.321+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492028337,000000, pattern:[H:mm][0;m
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:28.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:28.321+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:28.321+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:28.361+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:28.371+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:28:371,75
04-23 14:00:28.561+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:28.571+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:28:571,74
04-23 14:00:28.761+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:28.771+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:28:771,74
04-23 14:00:28.961+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:28.971+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:28:971,74
04-23 14:00:29.161+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:29.171+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:29:171,74
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:29.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492029341,000000, pattern:[H:mm][0;m
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:29.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:29.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:29.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:29.361+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:29.371+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:29:372,74
04-23 14:00:29.571+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:29.571+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:29:572,74
04-23 14:00:29.761+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:29.771+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:29:772,73
04-23 14:00:29.961+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:29.971+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:29:972,72
04-23 14:00:30.171+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:30.171+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:30:172,73
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:30.321+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492030337,000000, pattern:[H:mm][0;m
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:30.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:30.321+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:30.321+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:30.361+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:30.371+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:30:372,73
04-23 14:00:30.571+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:30.571+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:30:572,73
04-23 14:00:30.771+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:30.771+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:30:772,73
04-23 14:00:30.971+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:30.971+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:30:972,73
04-23 14:00:31.171+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:31.171+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:31:172,73
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:31.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492031341,000000, pattern:[H:mm][0;m
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:31.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:31.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:31.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:31.361+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:31.371+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:31:373,73
04-23 14:00:31.571+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:31.571+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:31:573,73
04-23 14:00:31.771+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:31.771+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:31:773,73
04-23 14:00:31.971+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:31.971+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:31:973,74
04-23 14:00:32.161+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:32.171+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:32:173,73
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:32.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492032337,000000, pattern:[H:mm][0;m
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:32.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:32.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:32.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:32.361+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:32.371+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:32:373,74
04-23 14:00:32.561+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:32.571+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:32:574,73
04-23 14:00:32.771+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:32.771+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:32:774,74
04-23 14:00:32.971+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:32.971+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:32:974,74
04-23 14:00:33.171+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:33.171+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:33:174,74
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:33.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492033340,000000, pattern:[H:mm][0;m
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:33.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:33.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:33.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:33.361+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:33.371+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:33:374,74
04-23 14:00:33.571+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:33.571+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:33:574,75
04-23 14:00:33.771+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:33.771+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:33:774,74
04-23 14:00:33.971+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:33.971+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:33:974,74
04-23 14:00:34.171+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:34.171+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:34:174,74
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:34.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492034337,000000, pattern:[H:mm][0;m
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:34.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:34.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:34.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:34.351+0200 W/AUL     (19730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:00:34.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:00:34.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19730
04-23 14:00:34.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19733
04-23 14:00:34.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 14:00:34.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19733), cmd(0)
04-23 14:00:34.401+0200 I/utils   (19733): specific action
04-23 14:00:34.401+0200 I/httppostreq(19733): internet connection check received
04-23 14:00:34.401+0200 I/httppostreq(19733): internet connection != null
04-23 14:00:34.401+0200 W/AUL     (19730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19733)
04-23 14:00:34.401+0200 I/servicemanager(19730): request sent to service es.ugr.frailty.httppostreq
04-23 14:00:34.401+0200 I/CAPI_NETWORK_CONNECTION(19733): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:00:34.401+0200 I/httppostreq(19733): internet connection type...
04-23 14:00:34.401+0200 I/httppostreq(19733): internet connection type 1
04-23 14:00:34.411+0200 I/httppostreq(19733): internet available
04-23 14:00:34.411+0200 W/AUL     (19733): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:00:34.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:00:34.411+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19733
04-23 14:00:34.431+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:34.431+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19730
04-23 14:00:34.431+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:34:442,74
04-23 14:00:34.441+0200 W/CAPI_APPFW_APP_CONTROL(19730): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:00:34.441+0200 I/utils   (19730): specific action
04-23 14:00:34.441+0200 W/CAPI_APPFW_APP_CONTROL(19730): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:00:34.441+0200 W/CAPI_APPFW_APP_CONTROL(19730): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:00:34.441+0200 W/CAPI_APPFW_APP_CONTROL(19730): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:00:34.441+0200 I/servicemanager(19730): internet connection available. stop all sensors
04-23 14:00:34.441+0200 W/AUL     (19730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:00:34.441+0200 W/AUL     (19733): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19730)
04-23 14:00:34.441+0200 I/httppostreq(19733): request sent to service es.ugr.frailty.servicemanager
04-23 14:00:34.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:00:34.451+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19730
04-23 14:00:34.461+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 14:00:34.461+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 20355
04-23 14:00:34.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20355
04-23 14:00:34.511+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(20355) type(svcapp) bg(0)
04-23 14:00:34.521+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 14:00:34.521+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19730), cmd(0)
04-23 14:00:34.521+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20355]
04-23 14:00:34.541+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:00:34.551+0200 W/AUL     (19730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20355)
04-23 14:00:34.551+0200 I/servicemanager(19730): es.ugr.frailty.accelerometer stop request sent!
04-23 14:00:34.551+0200 I/servicemanager(19730): App control destroyed.
04-23 14:00:34.551+0200 E/EFL     (19730): ecore<19730> ecore.c:573 _ecore_magic_fail() 
04-23 14:00:34.551+0200 E/EFL     (19730): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:00:34.551+0200 E/EFL     (19730): *** IN FUNCTION: ecore_timer_del()
04-23 14:00:34.551+0200 E/EFL     (19730): ecore<19730> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:00:34.551+0200 E/EFL     (19730): ecore<19730> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:00:34.551+0200 E/EFL     (19730): *** SPANK SPANK SPANK!!!
04-23 14:00:34.551+0200 E/EFL     (19730): *** Now go fix your code. Tut tut tut!
04-23 14:00:34.551+0200 I/servicemanager(19730): deleting dead timer 0
04-23 14:00:34.551+0200 E/EFL     (19730): ecore<19730> ecore.c:573 _ecore_magic_fail() 
04-23 14:00:34.551+0200 E/EFL     (19730): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:00:34.551+0200 E/EFL     (19730): *** IN FUNCTION: ecore_timer_del()
04-23 14:00:34.551+0200 E/EFL     (19730): ecore<19730> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:00:34.551+0200 E/EFL     (19730): ecore<19730> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:00:34.551+0200 E/EFL     (19730): *** SPANK SPANK SPANK!!!
04-23 14:00:34.551+0200 E/EFL     (19730): *** Now go fix your code. Tut tut tut!
04-23 14:00:34.551+0200 I/servicemanager(19730): deleting dead timer 2
04-23 14:00:34.551+0200 E/EFL     (19730): ecore<19730> ecore.c:573 _ecore_magic_fail() 
04-23 14:00:34.551+0200 E/EFL     (19730): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:00:34.551+0200 E/EFL     (19730): *** IN FUNCTION: ecore_timer_del()
04-23 14:00:34.551+0200 E/EFL     (19730): ecore<19730> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:00:34.551+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20355
04-23 14:00:34.551+0200 E/EFL     (19730): ecore<19730> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:00:34.551+0200 E/EFL     (19730): *** SPANK SPANK SPANK!!!
04-23 14:00:34.551+0200 E/EFL     (19730): *** Now go fix your code. Tut tut tut!
04-23 14:00:34.561+0200 I/servicemanager(19730): deleting dead timer 3
04-23 14:00:34.561+0200 E/EFL     (19730): ecore<19730> ecore.c:573 _ecore_magic_fail() 
04-23 14:00:34.561+0200 E/EFL     (19730): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:00:34.561+0200 E/EFL     (19730): *** IN FUNCTION: ecore_timer_del()
04-23 14:00:34.561+0200 E/EFL     (19730): ecore<19730> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:00:34.561+0200 E/EFL     (19730): ecore<19730> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:00:34.561+0200 E/EFL     (19730): *** SPANK SPANK SPANK!!!
04-23 14:00:34.561+0200 E/EFL     (19730): *** Now go fix your code. Tut tut tut!
04-23 14:00:34.561+0200 I/servicemanager(19730): deleting dead timer 5
04-23 14:00:34.561+0200 E/EFL     (19730): ecore<19730> ecore.c:573 _ecore_magic_fail() 
04-23 14:00:34.561+0200 E/EFL     (19730): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:00:34.561+0200 E/EFL     (19730): *** IN FUNCTION: ecore_timer_del()
04-23 14:00:34.561+0200 E/EFL     (19730): ecore<19730> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:00:34.561+0200 E/EFL     (19730): ecore<19730> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:00:34.561+0200 E/EFL     (19730): *** SPANK SPANK SPANK!!!
04-23 14:00:34.561+0200 E/EFL     (19730): *** Now go fix your code. Tut tut tut!
04-23 14:00:34.561+0200 I/servicemanager(19730): deleting dead timer 6
04-23 14:00:34.561+0200 E/EFL     (19730): ecore<19730> ecore.c:573 _ecore_magic_fail() 
04-23 14:00:34.561+0200 E/EFL     (19730): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:00:34.561+0200 E/EFL     (19730): *** IN FUNCTION: ecore_timer_del()
04-23 14:00:34.561+0200 E/EFL     (19730): ecore<19730> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:00:34.561+0200 E/EFL     (19730): ecore<19730> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:00:34.561+0200 E/EFL     (19730): *** SPANK SPANK SPANK!!!
04-23 14:00:34.561+0200 E/EFL     (19730): *** Now go fix your code. Tut tut tut!
04-23 14:00:34.561+0200 I/servicemanager(19730): deleting dead timer 7
04-23 14:00:34.561+0200 W/AUL     (19730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:00:34.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:00:34.561+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:34.571+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20355
04-23 14:00:34.571+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:34:574,74
04-23 14:00:34.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:00:34.581+0200 E/CAPI_APPFW_APPLICATION(20355): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:00:34.581+0200 E/CAPI_APPFW_APPLICATION(20355): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:00:34.581+0200 I/utils   (20355): trying to start service: es.ugr.frailty.accelerometer
04-23 14:00:34.581+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20355
04-23 14:00:34.581+0200 I/utils   (20355): es.ugr.frailty.accelerometer sensor supported
04-23 14:00:34.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:00:34.591+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19730
04-23 14:00:34.601+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 20368
04-23 14:00:34.601+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 14:00:34.601+0200 I/utils   (20355): es.ugr.frailty.accelerometer listener started
04-23 14:00:34.601+0200 I/accelerometer(20355): stopping es.ugr.frailty.accelerometer service
04-23 14:00:34.601+0200 E/CAPI_APPFW_APP_CONTROL(20355): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:00:34.601+0200 E/accelerometer(20355): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:00:34.601+0200 I/CAPI_APPFW_APPLICATION(20355): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:00:34.651+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20368
04-23 14:00:34.651+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(20368) type(svcapp) bg(0)
04-23 14:00:34.651+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (20355) was created
04-23 14:00:34.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:00:34.691+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20368]
04-23 14:00:34.691+0200 W/AUL     (19730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20368)
04-23 14:00:34.691+0200 I/servicemanager(19730): request sent to service es.ugr.frailty.recorder
04-23 14:00:34.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:00:34.721+0200 E/CAPI_APPFW_APPLICATION(20368): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:00:34.721+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:00:34.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:00:34.751+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 14:00:34.751+0200 E/CAPI_APPFW_APPLICATION(20368): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:00:34.761+0200 I/utils   (20368): specific action
04-23 14:00:34.761+0200 I/recorder(20368): obteniendo datos locales...
04-23 14:00:34.761+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:34.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:00:34.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 14:00:34.771+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (20368) was created
04-23 14:00:34.771+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:00:34.771+0200 I/accelerometer(20355): es.ugr.frailty.accelerometer listener destroyed
04-23 14:00:34.781+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20368
04-23 14:00:34.781+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:34:778,74
04-23 14:00:34.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:00:34.791+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20368
04-23 14:00:34.791+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:00:34.801+0200 I/recorder(20368): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:57:283,1.428515,-2.667997,9.466006
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:57:485,1.452443,-2.641676,9.454042
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:57:684,1.351945,-2.610569,9.116654
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:57:885,1.435694,-2.684747,9.454042
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:58:85,1.426122,-2.615355,9.408579
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:58:283,1.452443,-2.656033,9.454042
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:58:484,1.450050,-2.684747,9.477970
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:58:683,1.466800,-2.646462,9.473185
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:58:884,1.373480,-2.713461,9.504292
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:59:84,1.378266,-2.670390,9.544970
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:59:284,1.517050,-2.581856,9.506684
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:59:484,1.418944,-2.636890,9.492328
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:59:684,1.462015,-2.672783,9.446864
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,13:59:59:885,1.380659,-2.636890,9.509077
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,14:00:00:85,1.423729,-2.687140,9.497113
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,14:00:00:285,1.438086,-2.615355,9.473185
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,14:00:00:485,1.409373,-2.541178,9.506684
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,14:00:00:685,1.452443,-2.591427,9.485149
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,14:00:00:886,1.430908,-2.612962,9.504292
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,14:00:01:85,1.521835,-2.651247,9.367901
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,14:00:01:286,1.426122,-2.790031,9.410972
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,14:00:01:486,1.438086,-2.569891,9.578469
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,14:00:01:686,1.404587,-2.679961,9.454042
04-23 14:00:34.811+0200 I/recorder(20368): SM-R760,23/04/2018,14:00:01:886,1.406980,-2.464607,9.585647
04-23 14:00:34.831+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:00:34.841+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20368
04-23 14:00:34.841+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:00:34.861+0200 W/CRASH_MANAGER(20303): worker.c: worker_job(1205) > 1120368726563152448483
