S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 18811
Date: 2018-04-23 13:52:41+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf74ba648, r1   = 0xf79f21b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf79f21b8, r5   = 0x00012cd0
r6   = 0xf7a04e88, r7   = 0xf74ba250
r8   = 0x000005e0, r9   = 0xf6f9d824
r10  = 0xf79ea9d8, fp   = 0x00000000
ip   = 0xf74b9030, sp   = 0xffd40320
lr   = 0xf73fd5d0, pc   = 0xf73f99fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     19500 KB
Buffers:     31868 KB
Cached:     150076 KB
VmPeak:      13484 KB
VmSize:      12456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        7768 KB
VmRSS:        7764 KB
VmData:       2484 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          44 KB
VmSwap:          0 KB

Maps Information
f6b34000 f6b37000 r-xp /lib/libattr.so.1.1.0
f6b40000 f6b47000 r-xp /lib/libcrypt-2.13.so
f6b77000 f6b7a000 r-xp /lib/libcap.so.2.21
f6b82000 f6b84000 r-xp /usr/lib/libiri.so
f6b8c000 f6ba9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bb2000 f6bb6000 r-xp /usr/lib/libsmack.so.1.0.0
f6bc0000 f6bc2000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bca000 f6bcf000 r-xp /usr/lib/libffi.so.5.0.10
f6bd7000 f6bd8000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6be0000 f6be2000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6bea000 f6bec000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6bf6000 f6c06000 r-xp /lib/libresolv-2.13.so
f6c0a000 f6c22000 r-xp /usr/lib/liblzma.so.5.0.3
f6c2a000 f6c2c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c34000 f6c63000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6c6c000 f6c7b000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6c84000 f6c8e000 r-xp /usr/lib/libsensord-shared.so
f6c97000 f6ccb000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6cd4000 f6da7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6db2000 f6dc8000 r-xp /lib/libz.so.1.2.5
f6dd0000 f6dd6000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6ddf000 f6e54000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e5e000 f6e78000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6e80000 f6e86000 r-xp /lib/librt-2.13.so
f6e8f000 f6ead000 r-xp /usr/lib/libsystemd.so.0.4.0
f6eb7000 f6eb8000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ec0000 f6ec5000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6ecd000 f6f9d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6f9e000 f6fc8000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6fd1000 f6fe8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ff0000 f7059000 r-xp /lib/libm-2.13.so
f7062000 f70f6000 r-xp /usr/lib/libstdc++.so.6.0.16
f7109000 f710e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7116000 f711d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7125000 f714f000 r-xp /usr/lib/libsensor.so.1.9.6
f7158000 f7224000 r-xp /usr/lib/libxml2.so.2.7.8
f7231000 f7233000 r-xp /usr/lib/libiniparser.so.0
f723c000 f723f000 r-xp /usr/lib/libbundle.so.0.1.22
f7247000 f724d000 r-xp /usr/lib/libappsvc.so.0.1.0
f7255000 f7278000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f7280000 f72c1000 r-xp /usr/lib/libeina.so.1.7.99
f72ca000 f72e1000 r-xp /usr/lib/libecore.so.1.7.99
f72f8000 f7301000 r-xp /usr/lib/libvconf.so.0.2.45
f7309000 f731d000 r-xp /lib/libpthread-2.13.so
f7328000 f7335000 r-xp /usr/lib/libaul.so.0.1.0
f733f000 f7341000 r-xp /lib/libdl-2.13.so
f734a000 f7355000 r-xp /lib/libunwind.so.8.0.1
f7382000 f738a000 r-xp /lib/libgcc_s-4.6.so.1
f738b000 f74af000 r-xp /lib/libc-2.13.so
f74bd000 f74bf000 r-xp /usr/lib/libdlog.so.0.0.0
f74c7000 f74d3000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f74dc000 f74e1000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f74e9000 f74ed000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f74f6000 f74f8000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7501000 f7504000 r-xp /usr/lib/libappcore-agent.so.1.1
f7522000 f753f000 r-xp /lib/ld-2.13.so
f7548000 f754b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f754b000 f754f000 r-xp /usr/lib/libsys-assert.so
f79e0000 f7a2e000 rw-p [heap]
ffd22000 ffd43000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18811)
Call Stack Count: 1
 0: (0xf73f99fc) [/lib/libc.so.6] + 0x6e9fc
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
386) > Enter [system_settings_get_value]
04-23 13:52:30.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:30.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:30.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:30.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:30.351+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:30.351+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:30:361,75
04-23 13:52:30.551+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:30.551+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:30:560,75
04-23 13:52:30.751+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:30.751+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:30:761,75
04-23 13:52:30.951+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:30.951+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:30:961,75
04-23 13:52:31.151+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:31.151+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:31:161,75
04-23 13:52:31.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:31.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:31.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:31.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:31.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491551297,000000, pattern:[H:mm][0;m
04-23 13:52:31.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:31.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:31.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:31.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:31.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:31.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:31.351+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:31.351+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:31:361,75
04-23 13:52:31.551+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:31.551+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:31:561,75
04-23 13:52:31.751+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:31.751+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:31:761,75
04-23 13:52:31.951+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:31.951+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:31:961,75
04-23 13:52:32.151+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:32.151+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:32:162,75
04-23 13:52:32.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:32.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:32.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:32.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:32.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491552298,000000, pattern:[H:mm][0;m
04-23 13:52:32.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:32.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:32.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:32.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:32.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:32.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:32.351+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:32.351+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:32:362,75
04-23 13:52:32.551+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:32.551+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:32:562,75
04-23 13:52:32.751+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:32.751+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:32:762,75
04-23 13:52:32.951+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:32.951+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:32:962,75
04-23 13:52:33.151+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:33.151+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:33:162,75
04-23 13:52:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:33.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491553298,000000, pattern:[H:mm][0;m
04-23 13:52:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:33.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:33.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:33.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:33.351+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:33.351+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:33:363,75
04-23 13:52:33.551+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:33.551+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:33:562,76
04-23 13:52:33.751+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:33.751+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:33:763,76
04-23 13:52:33.951+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:33.951+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:33:964,76
04-23 13:52:34.151+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:34.151+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:34:163,76
04-23 13:52:34.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:34.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:34.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:34.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:34.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491554298,000000, pattern:[H:mm][0;m
04-23 13:52:34.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:34.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:34.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:34.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:34.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:34.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:34.351+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:34.351+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:34:363,76
04-23 13:52:34.551+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:34.551+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:34:563,76
04-23 13:52:34.751+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:34.751+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:34:763,76
04-23 13:52:34.951+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:34.951+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:34:963,76
04-23 13:52:35.151+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:35.151+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:35:164,76
04-23 13:52:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:35.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491555298,000000, pattern:[H:mm][0;m
04-23 13:52:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:35.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:35.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:35.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:35.351+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:35.351+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:35:364,76
04-23 13:52:35.551+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:35.551+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:35:564,77
04-23 13:52:35.751+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:35.751+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:35:764,77
04-23 13:52:35.951+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:35.951+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:35:964,77
04-23 13:52:36.151+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:36.151+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:36:164,77
04-23 13:52:36.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:36.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:36.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:36.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:36.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491556298,000000, pattern:[H:mm][0;m
04-23 13:52:36.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:36.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:36.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:36.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:36.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:36.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:36.351+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:36.351+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:36:365,77
04-23 13:52:36.551+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:36.551+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:36:564,77
04-23 13:52:36.751+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:36.751+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:36:765,77
04-23 13:52:36.951+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:36.961+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:36:965,77
04-23 13:52:37.151+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:37.151+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:37:165,78
04-23 13:52:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:37.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491557298,000000, pattern:[H:mm][0;m
04-23 13:52:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:37.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:37.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:37.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:37.351+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:37.361+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:37:365,78
04-23 13:52:37.551+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:37.561+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:37:565,78
04-23 13:52:37.751+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:37.761+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:37:765,78
04-23 13:52:37.951+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:37.961+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:37:965,79
04-23 13:52:38.151+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:38.161+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:38:166,79
04-23 13:52:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:38.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491558298,000000, pattern:[H:mm][0;m
04-23 13:52:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:38.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:38.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:38.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:38.351+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:38.361+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:38:366,79
04-23 13:52:38.551+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:38.561+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:38:566,79
04-23 13:52:38.751+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:38.761+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:38:766,79
04-23 13:52:38.951+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:38.961+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:38:966,79
04-23 13:52:39.151+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:39.161+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:39:166,79
04-23 13:52:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:39.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491559298,000000, pattern:[H:mm][0;m
04-23 13:52:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:39.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:39.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:39.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:39.351+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:39.361+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:39:367,79
04-23 13:52:39.551+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:39.561+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:39:566,79
04-23 13:52:39.751+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:39.761+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:39:767,79
04-23 13:52:39.951+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:39.961+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:39:967,79
04-23 13:52:40.151+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:40.161+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:40:167,78
04-23 13:52:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:40.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491560298,000000, pattern:[H:mm][0;m
04-23 13:52:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:40.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:40.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:40.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:40.351+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:40.361+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:40:367,78
04-23 13:52:40.551+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:40.561+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:40:567,78
04-23 13:52:40.751+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:40.761+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:40:767,78
04-23 13:52:40.951+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:40.961+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:40:967,78
04-23 13:52:41.151+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:41.161+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:41:168,78
04-23 13:52:41.281+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:52:41.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:52:41.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:52:41.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:41.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:41.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:41.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:41.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491561297,000000, pattern:[H:mm][0;m
04-23 13:52:41.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:41.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:41.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:41.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:41.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:41.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:41.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17422
04-23 13:52:41.301+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:52:41.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17422), cmd(0)
04-23 13:52:41.301+0200 I/utils   (17422): specific action
04-23 13:52:41.301+0200 I/httppostreq(17422): internet connection check received
04-23 13:52:41.301+0200 I/httppostreq(17422): internet connection != null
04-23 13:52:41.301+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17422)
04-23 13:52:41.301+0200 I/CAPI_NETWORK_CONNECTION(17422): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:52:41.301+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.httppostreq
04-23 13:52:41.301+0200 I/httppostreq(17422): internet connection type...
04-23 13:52:41.301+0200 I/httppostreq(17422): internet connection type 1
04-23 13:52:41.301+0200 I/httppostreq(17422): internet available
04-23 13:52:41.301+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:52:41.301+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:52:41.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17422
04-23 13:52:41.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
04-23 13:52:41.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:52:41.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17419), cmd(0)
04-23 13:52:41.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:52:41.331+0200 I/utils   (17419): specific action
04-23 13:52:41.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:52:41.331+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
04-23 13:52:41.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:52:41.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:52:41.331+0200 I/servicemanager(17419): internet connection available. stop all sensors
04-23 13:52:41.331+0200 I/httppostreq(17422): request sent to service es.ugr.frailty.servicemanager
04-23 13:52:41.331+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:52:41.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:52:41.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:52:41.351+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:52:41.351+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18799
04-23 13:52:41.381+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:41.381+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:41:389,78
04-23 13:52:41.391+0200 E/CAPI_APPFW_APPLICATION(18799): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:52:41.391+0200 E/CAPI_APPFW_APPLICATION(18799): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:52:41.391+0200 I/utils   (18799): trying to start service: es.ugr.frailty.accelerometer
04-23 13:52:41.401+0200 I/utils   (18799): es.ugr.frailty.accelerometer sensor supported
04-23 13:52:41.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18799
04-23 13:52:41.401+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(18799) type(svcapp) bg(0)
04-23 13:52:41.401+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18799) was created
04-23 13:52:41.401+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18799]
04-23 13:52:41.411+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18799)
04-23 13:52:41.411+0200 I/servicemanager(17419): es.ugr.frailty.accelerometer stop request sent!
04-23 13:52:41.411+0200 I/servicemanager(17419): App control destroyed.
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:41.411+0200 I/servicemanager(17419): deleting timer 0
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:41.411+0200 I/servicemanager(17419): deleting timer 1
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:41.411+0200 I/servicemanager(17419): deleting timer 2
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:41.411+0200 I/servicemanager(17419): deleting timer 3
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:41.411+0200 I/servicemanager(17419): deleting timer 4
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:41.411+0200 I/servicemanager(17419): deleting timer 5
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:41.411+0200 I/servicemanager(17419): deleting timer 6
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:41.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:41.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:41.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:41.411+0200 I/servicemanager(17419): deleting timer 7
04-23 13:52:41.411+0200 I/servicemanager(17419): deleting timer 8
04-23 13:52:41.411+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:52:41.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:52:41.421+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:52:41.431+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:52:41.431+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18811
04-23 13:52:41.441+0200 I/utils   (18799): es.ugr.frailty.accelerometer listener started
04-23 13:52:41.441+0200 I/accelerometer(18799): stopping es.ugr.frailty.accelerometer service
04-23 13:52:41.441+0200 E/CAPI_APPFW_APP_CONTROL(18799): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:52:41.441+0200 E/accelerometer(18799): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:52:41.441+0200 I/CAPI_APPFW_APPLICATION(18799): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:52:41.481+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18811
04-23 13:52:41.481+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(18811) type(svcapp) bg(0)
04-23 13:52:41.491+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:41.491+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18811]
04-23 13:52:41.491+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18811)
04-23 13:52:41.491+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.recorder
04-23 13:52:41.501+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18799
04-23 13:52:41.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:41.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18799
04-23 13:52:41.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:52:41.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:52:41.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:41.531+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18799
04-23 13:52:41.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:41.561+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:41.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:41.601+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:41.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:41.641+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18811
04-23 13:52:41.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:41.651+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18811
04-23 13:52:41.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:41.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:41.701+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:41:571,78
04-23 13:52:41.741+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:41.751+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18811
04-23 13:52:41.751+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:41.801+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:52:41.811+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 13:52:41.511+0200 E/CAPI_APPFW_APPLICATION(18811): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:52:41.821+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:41.821+0200 E/CAPI_APPFW_APPLICATION(18811): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:52:41.821+0200 I/utils   (18811): specific action
04-23 13:52:41.831+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18811) was created
04-23 13:52:41.831+0200 I/accelerometer(18799): es.ugr.frailty.accelerometer listener destroyed
04-23 13:52:41.831+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:41:831,78
04-23 13:52:41.831+0200 I/recorder(18811): obteniendo datos locales...
04-23 13:52:41.851+0200 I/recorder(18811): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:24:189,1.849652,-2.009971,9.454042
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:24:371,1.804188,-3.177669,9.157332
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:24:577,1.634298,-3.120241,9.145369
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:24:777,1.775474,-3.187240,9.329616
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:24:977,1.730011,-3.986443,9.047262
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:25:177,1.875973,-3.194418,9.078369
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:25:380,1.828116,-2.565106,9.475577
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:25:577,1.797010,-2.864209,9.312866
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:25:777,1.782653,-2.883351,9.391829
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:25:977,1.605584,-3.132205,9.339187
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:26:178,1.696511,-3.089134,9.427721
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:26:378,1.749153,-3.046063,9.394222
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:26:578,1.830509,-2.309074,9.410972
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:26:778,1.761117,-2.758924,9.851252
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:26:978,1.651048,-2.816352,9.568897
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:27:178,1.820938,-1.667797,9.049655
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:27:378,1.813759,-2.115255,9.659825
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:27:579,1.596013,-2.000400,9.748360
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:27:779,1.792224,-1.598405,9.580862
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:27:979,1.835295,-1.612763,9.549755
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:28:179,1.856830,-1.488336,9.547362
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:28:379,1.801795,-1.507478,9.628718
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:28:579,1.878366,-1.406980,9.509077
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:28:780,1.844866,-1.655833,9.710074
04-23 13:52:41.851+0200 I/recorder(18811): SM-R760,23/04/2018,13:46:28:980,1.741975,-1.658226,9.638289
04-23 13:52:41.911+0200 W/CRASH_MANAGER(17537): worker.c: worker_job(1205) > 1118811726563152448436
