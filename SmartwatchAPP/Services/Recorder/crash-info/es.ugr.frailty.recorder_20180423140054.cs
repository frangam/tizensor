S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 20443
Date: 2018-04-23 14:00:54+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf6f96648, r1   = 0xf74071b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf74071b8, r5   = 0x00012cd0
r6   = 0xf7419e88, r7   = 0xf6f96250
r8   = 0x000005a0, r9   = 0xf6a79824
r10  = 0xf73ff9d8, fp   = 0x00000000
ip   = 0xf6f95030, sp   = 0xffc76480
lr   = 0xf6ed95d0, pc   = 0xf6ed59fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     64092 KB
Buffers:     29332 KB
Cached:     142700 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7700 KB
VmRSS:        7696 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          44 KB
VmSwap:          0 KB

Maps Information
f6610000 f6613000 r-xp /lib/libattr.so.1.1.0
f661c000 f6623000 r-xp /lib/libcrypt-2.13.so
f6653000 f6656000 r-xp /lib/libcap.so.2.21
f665e000 f6660000 r-xp /usr/lib/libiri.so
f6668000 f6685000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f668e000 f6692000 r-xp /usr/lib/libsmack.so.1.0.0
f669c000 f669e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f66a6000 f66ab000 r-xp /usr/lib/libffi.so.5.0.10
f66b3000 f66b4000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f66bc000 f66be000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66c6000 f66c8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f66d2000 f66e2000 r-xp /lib/libresolv-2.13.so
f66e6000 f66fe000 r-xp /usr/lib/liblzma.so.5.0.3
f6706000 f6708000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6710000 f673f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6748000 f6757000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6760000 f676a000 r-xp /usr/lib/libsensord-shared.so
f6773000 f67a7000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f67b0000 f6883000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f688e000 f68a4000 r-xp /lib/libz.so.1.2.5
f68ac000 f68b2000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f68bb000 f6930000 r-xp /usr/lib/libsqlite3.so.0.8.6
f693a000 f6954000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f695c000 f6962000 r-xp /lib/librt-2.13.so
f696b000 f6989000 r-xp /usr/lib/libsystemd.so.0.4.0
f6993000 f6994000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f699c000 f69a1000 r-xp /usr/lib/libxdgmime.so.1.1.0
f69a9000 f6a79000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6a7a000 f6aa4000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6aad000 f6ac4000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6acc000 f6b35000 r-xp /lib/libm-2.13.so
f6b3e000 f6bd2000 r-xp /usr/lib/libstdc++.so.6.0.16
f6be5000 f6bea000 r-xp /usr/lib/libctx-client.so.0.8.3
f6bf2000 f6bf9000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c01000 f6c2b000 r-xp /usr/lib/libsensor.so.1.9.6
f6c34000 f6d00000 r-xp /usr/lib/libxml2.so.2.7.8
f6d0d000 f6d0f000 r-xp /usr/lib/libiniparser.so.0
f6d18000 f6d1b000 r-xp /usr/lib/libbundle.so.0.1.22
f6d23000 f6d29000 r-xp /usr/lib/libappsvc.so.0.1.0
f6d31000 f6d54000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d5c000 f6d9d000 r-xp /usr/lib/libeina.so.1.7.99
f6da6000 f6dbd000 r-xp /usr/lib/libecore.so.1.7.99
f6dd4000 f6ddd000 r-xp /usr/lib/libvconf.so.0.2.45
f6de5000 f6df9000 r-xp /lib/libpthread-2.13.so
f6e04000 f6e11000 r-xp /usr/lib/libaul.so.0.1.0
f6e1b000 f6e1d000 r-xp /lib/libdl-2.13.so
f6e26000 f6e31000 r-xp /lib/libunwind.so.8.0.1
f6e5e000 f6e66000 r-xp /lib/libgcc_s-4.6.so.1
f6e67000 f6f8b000 r-xp /lib/libc-2.13.so
f6f99000 f6f9b000 r-xp /usr/lib/libdlog.so.0.0.0
f6fa3000 f6faf000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f6fb8000 f6fbd000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f6fc5000 f6fc9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f6fd2000 f6fd4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f6fdd000 f6fe0000 r-xp /usr/lib/libappcore-agent.so.1.1
f6ffe000 f701b000 r-xp /lib/ld-2.13.so
f7024000 f7027000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7027000 f702b000 r-xp /usr/lib/libsys-assert.so
f73f5000 f7443000 rw-p [heap]
ffc58000 ffc79000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20443)
Call Stack Count: 1
 0: (0xf6ed59fc) [/lib/libc.so.6] + 0x6e9fc
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
gs_get_item], index = 13, key = 13, type = 0
04-23 14:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:46.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492046340,000000, pattern:[H:mm][0;m
04-23 14:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:46.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:46.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:46.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:46.371+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:46.381+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:46:383,77
04-23 14:00:46.581+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:46.581+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:46:583,77
04-23 14:00:46.781+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:46.781+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:46:783,77
04-23 14:00:46.981+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:46.981+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:46:983,77
04-23 14:00:47.171+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:47.181+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:47:183,77
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:47.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492047337,000000, pattern:[H:mm][0;m
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:47.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:47.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:47.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:47.371+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:47.381+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:47:383,77
04-23 14:00:47.581+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:47.581+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:47:583,77
04-23 14:00:47.781+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:47.781+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:47:783,77
04-23 14:00:47.981+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:47.981+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:47:984,78
04-23 14:00:48.181+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:48.181+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:48:184,77
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:48.341+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492048347,000000, pattern:[H:mm][0;m
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:48.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:48.341+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:48.341+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:48.371+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:48.381+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:48:385,78
04-23 14:00:48.581+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:48.581+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:48:584,78
04-23 14:00:48.781+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:48.781+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:48:784,77
04-23 14:00:48.981+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:48.981+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:48:984,77
04-23 14:00:49.181+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:49.181+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:49:184,77
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:49.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492049341,000000, pattern:[H:mm][0;m
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:49.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:49.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:49.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:49.371+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:49.381+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:49:385,77
04-23 14:00:49.581+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:49.581+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:49:585,77
04-23 14:00:49.781+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:49.781+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:49:785,77
04-23 14:00:49.971+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:49.981+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:49:985,77
04-23 14:00:50.171+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:50.181+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:50:185,76
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:50.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492050340,000000, pattern:[H:mm][0;m
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:50.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:50.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:50.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:50.371+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:50.381+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:50:385,76
04-23 14:00:50.581+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:50.581+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:50:586,75
04-23 14:00:50.781+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:50.781+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:50:785,76
04-23 14:00:50.981+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:50.981+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:50:986,75
04-23 14:00:51.181+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:51.181+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:51:186,75
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:51.321+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492051337,000000, pattern:[H:mm][0;m
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:51.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:51.321+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:51.321+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:51.371+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:51.381+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:51:386,75
04-23 14:00:51.581+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:51.581+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:51:586,75
04-23 14:00:51.771+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:51.781+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:51:787,75
04-23 14:00:51.971+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:51.981+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:51:987,75
04-23 14:00:52.171+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:52.181+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:52:187,74
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:52.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492052340,000000, pattern:[H:mm][0;m
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:52.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:52.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:52.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:52.371+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:52.381+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:52:387,75
04-23 14:00:52.571+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:52.581+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:52:588,74
04-23 14:00:52.781+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:52.781+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:52:788,74
04-23 14:00:52.991+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:53.031+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:52:999,74
04-23 14:00:53.171+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:53.181+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:53:187,73
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:53.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492053337,000000, pattern:[H:mm][0;m
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:53.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:53.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:53.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:53.371+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:53.381+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:53:388,73
04-23 14:00:53.581+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:53.581+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:53:588,73
04-23 14:00:53.781+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:53.781+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:53:788,73
04-23 14:00:53.981+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:53.981+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:53:988,73
04-23 14:00:54.181+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:54.181+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:54:188,73
04-23 14:00:54.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:54.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:54.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:54.321+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:54.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:54.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:54.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:54.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:54.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:54.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:54.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:54.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:54.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524492054339,000000, pattern:[H:mm][0;m
04-23 14:00:54.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 14:00:54.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 14:00:54.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 14:00:54.331+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 14:00:54.331+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 14:00:54.331+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[14:00][0;m
04-23 14:00:54.351+0200 W/AUL     (19730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 14:00:54.351+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:00:54.351+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19730
04-23 14:00:54.371+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19733
04-23 14:00:54.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 14:00:54.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19733), cmd(0)
04-23 14:00:54.401+0200 I/utils   (19733): specific action
04-23 14:00:54.401+0200 I/httppostreq(19733): internet connection check received
04-23 14:00:54.401+0200 W/AUL     (19730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19733)
04-23 14:00:54.401+0200 I/httppostreq(19733): internet connection != null
04-23 14:00:54.401+0200 I/CAPI_NETWORK_CONNECTION(19733): connection.c: connection_get_type(507) > Connected Network = 2
04-23 14:00:54.411+0200 I/servicemanager(19730): request sent to service es.ugr.frailty.httppostreq
04-23 14:00:54.411+0200 I/httppostreq(19733): internet connection type...
04-23 14:00:54.411+0200 I/httppostreq(19733): internet connection type 1
04-23 14:00:54.411+0200 I/httppostreq(19733): internet available
04-23 14:00:54.411+0200 W/AUL     (19733): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 14:00:54.411+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:00:54.411+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19733
04-23 14:00:54.431+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19730
04-23 14:00:54.451+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 14:00:54.451+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(19730), cmd(0)
04-23 14:00:54.461+0200 W/CAPI_APPFW_APP_CONTROL(19730): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:00:54.461+0200 I/utils   (19730): specific action
04-23 14:00:54.461+0200 W/CAPI_APPFW_APP_CONTROL(19730): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:00:54.461+0200 W/CAPI_APPFW_APP_CONTROL(19730): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:00:54.461+0200 W/CAPI_APPFW_APP_CONTROL(19730): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 14:00:54.461+0200 I/servicemanager(19730): internet connection available. stop all sensors
04-23 14:00:54.461+0200 W/AUL     (19733): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19730)
04-23 14:00:54.461+0200 W/AUL     (19730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 14:00:54.471+0200 I/httppostreq(19733): request sent to service es.ugr.frailty.servicemanager
04-23 14:00:54.471+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:00:54.471+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19730
04-23 14:00:54.491+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 20429
04-23 14:00:54.491+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 14:00:54.491+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:54.501+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:54:508,74
04-23 14:00:54.541+0200 E/CAPI_APPFW_APPLICATION(20429): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:00:54.541+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20429
04-23 14:00:54.541+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(20429) type(svcapp) bg(0)
04-23 14:00:54.541+0200 E/CAPI_APPFW_APPLICATION(20429): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:00:54.541+0200 I/utils   (20429): trying to start service: es.ugr.frailty.accelerometer
04-23 14:00:54.551+0200 I/utils   (20429): es.ugr.frailty.accelerometer sensor supported
04-23 14:00:54.551+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (20429) was created
04-23 14:00:54.561+0200 I/utils   (20429): es.ugr.frailty.accelerometer listener started
04-23 14:00:54.561+0200 I/accelerometer(20429): stopping es.ugr.frailty.accelerometer service
04-23 14:00:54.561+0200 E/CAPI_APPFW_APP_CONTROL(20429): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 14:00:54.561+0200 E/accelerometer(20429): request sending failed to service es.ugr.frailty.servicemanager
04-23 14:00:54.561+0200 I/CAPI_APPFW_APPLICATION(20429): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 14:00:54.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 14:00:54.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 14:00:54.571+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20429]
04-23 14:00:54.581+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:00:54.581+0200 W/AUL     (19730): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20429)
04-23 14:00:54.581+0200 I/servicemanager(19730): es.ugr.frailty.accelerometer stop request sent!
04-23 14:00:54.581+0200 I/servicemanager(19730): App control destroyed.
04-23 14:00:54.581+0200 E/EFL     (19730): ecore<19730> ecore.c:573 _ecore_magic_fail() 
04-23 14:00:54.581+0200 E/EFL     (19730): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:00:54.581+0200 E/EFL     (19730): *** IN FUNCTION: ecore_timer_del()
04-23 14:00:54.581+0200 E/EFL     (19730): ecore<19730> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:00:54.581+0200 E/EFL     (19730): ecore<19730> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:00:54.581+0200 E/EFL     (19730): *** SPANK SPANK SPANK!!!
04-23 14:00:54.581+0200 E/EFL     (19730): *** Now go fix your code. Tut tut tut!
04-23 14:00:54.581+0200 I/servicemanager(19730): deleting dead timer 0
04-23 14:00:54.581+0200 E/EFL     (19730): ecore<19730> ecore.c:573 _ecore_magic_fail() 
04-23 14:00:54.581+0200 E/EFL     (19730): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:00:54.581+0200 E/EFL     (19730): *** IN FUNCTION: ecore_timer_del()
04-23 14:00:54.581+0200 E/EFL     (19730): ecore<19730> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:00:54.581+0200 E/EFL     (19730): ecore<19730> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:00:54.581+0200 E/EFL     (19730): *** SPANK SPANK SPANK!!!
04-23 14:00:54.581+0200 E/EFL     (19730): *** Now go fix your code. Tut tut tut!
04-23 14:00:54.581+0200 I/servicemanager(19730): deleting dead timer 2
04-23 14:00:54.581+0200 E/EFL     (19730): ecore<19730> ecore.c:573 _ecore_magic_fail() 
04-23 14:00:54.581+0200 E/EFL     (19730): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:00:54.581+0200 E/EFL     (19730): *** IN FUNCTION: ecore_timer_del()
04-23 14:00:54.581+0200 E/EFL     (19730): ecore<19730> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:00:54.581+0200 E/EFL     (19730): ecore<19730> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:00:54.581+0200 E/EFL     (19730): *** SPANK SPANK SPANK!!!
04-23 14:00:54.581+0200 E/EFL     (19730): *** Now go fix your code. Tut tut tut!
04-23 14:00:54.591+0200 I/servicemanager(19730): deleting dead timer 3
04-23 14:00:54.591+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20429
04-23 14:00:54.591+0200 E/EFL     (19730): ecore<19730> ecore.c:573 _ecore_magic_fail() 
04-23 14:00:54.591+0200 E/EFL     (19730): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:00:54.591+0200 E/EFL     (19730): *** IN FUNCTION: ecore_timer_del()
04-23 14:00:54.591+0200 E/EFL     (19730): ecore<19730> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:00:54.591+0200 E/EFL     (19730): ecore<19730> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:00:54.591+0200 E/EFL     (19730): *** SPANK SPANK SPANK!!!
04-23 14:00:54.591+0200 E/EFL     (19730): *** Now go fix your code. Tut tut tut!
04-23 14:00:54.591+0200 I/servicemanager(19730): deleting dead timer 5
04-23 14:00:54.591+0200 E/EFL     (19730): ecore<19730> ecore.c:573 _ecore_magic_fail() 
04-23 14:00:54.591+0200 E/EFL     (19730): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:00:54.591+0200 E/EFL     (19730): *** IN FUNCTION: ecore_timer_del()
04-23 14:00:54.591+0200 E/EFL     (19730): ecore<19730> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:00:54.591+0200 E/EFL     (19730): ecore<19730> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:00:54.591+0200 E/EFL     (19730): *** SPANK SPANK SPANK!!!
04-23 14:00:54.591+0200 E/EFL     (19730): *** Now go fix your code. Tut tut tut!
04-23 14:00:54.591+0200 I/servicemanager(19730): deleting dead timer 6
04-23 14:00:54.591+0200 E/EFL     (19730): ecore<19730> ecore.c:573 _ecore_magic_fail() 
04-23 14:00:54.591+0200 E/EFL     (19730): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 14:00:54.591+0200 E/EFL     (19730): *** IN FUNCTION: ecore_timer_del()
04-23 14:00:54.591+0200 E/EFL     (19730): ecore<19730> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 14:00:54.591+0200 E/EFL     (19730): ecore<19730> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 14:00:54.591+0200 E/EFL     (19730): *** SPANK SPANK SPANK!!!
04-23 14:00:54.591+0200 E/EFL     (19730): *** Now go fix your code. Tut tut tut!
04-23 14:00:54.591+0200 I/servicemanager(19730): deleting dead timer 7
04-23 14:00:54.591+0200 W/AUL     (19730): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 14:00:54.591+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 14:00:54.601+0200 I/heartrate(19762): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 14:00:54.601+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20429
04-23 14:00:54.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 14:00:54.601+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 19730
04-23 14:00:54.621+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 20443
04-23 14:00:54.641+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 14:00:54.661+0200 E/CAPI_APPFW_APPLICATION(20443): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:00:54.661+0200 E/CAPI_APPFW_APPLICATION(20443): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 14:00:54.661+0200 I/utils   (20443): specific action
04-23 14:00:54.661+0200 I/recorder(20443): obteniendo datos locales...
04-23 14:00:54.681+0200 I/heartrate(19762): es.ugr.frailty.heartrate: SM-R760,23/04/2018,14:00:54:611,73
04-23 14:00:54.681+0200 I/recorder(20443): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:57:283,1.428515,-2.667997,9.466006
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:57:485,1.452443,-2.641676,9.454042
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:57:684,1.351945,-2.610569,9.116654
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:57:885,1.435694,-2.684747,9.454042
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:58:85,1.426122,-2.615355,9.408579
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:58:283,1.452443,-2.656033,9.454042
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:58:484,1.450050,-2.684747,9.477970
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:58:683,1.466800,-2.646462,9.473185
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:58:884,1.373480,-2.713461,9.504292
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:59:84,1.378266,-2.670390,9.544970
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:59:284,1.517050,-2.581856,9.506684
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:59:484,1.418944,-2.636890,9.492328
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:59:684,1.462015,-2.672783,9.446864
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,13:59:59:885,1.380659,-2.636890,9.509077
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,14:00:00:85,1.423729,-2.687140,9.497113
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,14:00:00:285,1.438086,-2.615355,9.473185
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,14:00:00:485,1.409373,-2.541178,9.506684
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,14:00:00:685,1.452443,-2.591427,9.485149
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,14:00:00:886,1.430908,-2.612962,9.504292
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,14:00:01:85,1.521835,-2.651247,9.367901
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,14:00:01:286,1.426122,-2.790031,9.410972
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,14:00:01:486,1.438086,-2.569891,9.578469
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,14:00:01:686,1.404587,-2.679961,9.454042
04-23 14:00:54.681+0200 I/recorder(20443): SM-R760,23/04/2018,14:00:01:886,1.406980,-2.464607,9.585647
04-23 14:00:54.691+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 20443
04-23 14:00:54.691+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(20443) type(svcapp) bg(0)
04-23 14:00:54.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:00:54.701+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [20443]
04-23 14:00:54.731+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (20443) was created
04-23 14:00:54.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 14:00:54.771+0200 W/CRASH_MANAGER(20303): worker.c: worker_job(1205) > 1120443726563152448485
