S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 19156
Date: 2018-04-23 13:54:21+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf710e648, r1   = 0xf79a61b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf79a61b8, r5   = 0x00012cd0
r6   = 0xf79b8e88, r7   = 0xf710e250
r8   = 0x000005e0, r9   = 0xf6bf1824
r10  = 0xf799e9d8, fp   = 0x00000000
ip   = 0xf710d030, sp   = 0xffd17be0
lr   = 0xf70515d0, pc   = 0xf704d9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:      5352 KB
Buffers:     25896 KB
Cached:     138848 KB
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
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f6788000 f678b000 r-xp /lib/libattr.so.1.1.0
f6794000 f679b000 r-xp /lib/libcrypt-2.13.so
f67cb000 f67ce000 r-xp /lib/libcap.so.2.21
f67d6000 f67d8000 r-xp /usr/lib/libiri.so
f67e0000 f67fd000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6806000 f680a000 r-xp /usr/lib/libsmack.so.1.0.0
f6814000 f6816000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f681e000 f6823000 r-xp /usr/lib/libffi.so.5.0.10
f682b000 f682c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6834000 f6836000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f683e000 f6840000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f684a000 f685a000 r-xp /lib/libresolv-2.13.so
f685e000 f6876000 r-xp /usr/lib/liblzma.so.5.0.3
f687e000 f6880000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6888000 f68b7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68c0000 f68cf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68d8000 f68e2000 r-xp /usr/lib/libsensord-shared.so
f68eb000 f691f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6928000 f69fb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6a06000 f6a1c000 r-xp /lib/libz.so.1.2.5
f6a24000 f6a2a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6a33000 f6aa8000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ab2000 f6acc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ad4000 f6ada000 r-xp /lib/librt-2.13.so
f6ae3000 f6b01000 r-xp /usr/lib/libsystemd.so.0.4.0
f6b0b000 f6b0c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6b14000 f6b19000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b21000 f6bf1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6bf2000 f6c1c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c25000 f6c3c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c44000 f6cad000 r-xp /lib/libm-2.13.so
f6cb6000 f6d4a000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d5d000 f6d62000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d6a000 f6d71000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d79000 f6da3000 r-xp /usr/lib/libsensor.so.1.9.6
f6dac000 f6e78000 r-xp /usr/lib/libxml2.so.2.7.8
f6e85000 f6e87000 r-xp /usr/lib/libiniparser.so.0
f6e90000 f6e93000 r-xp /usr/lib/libbundle.so.0.1.22
f6e9b000 f6ea1000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ea9000 f6ecc000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6ed4000 f6f15000 r-xp /usr/lib/libeina.so.1.7.99
f6f1e000 f6f35000 r-xp /usr/lib/libecore.so.1.7.99
f6f4c000 f6f55000 r-xp /usr/lib/libvconf.so.0.2.45
f6f5d000 f6f71000 r-xp /lib/libpthread-2.13.so
f6f7c000 f6f89000 r-xp /usr/lib/libaul.so.0.1.0
f6f93000 f6f95000 r-xp /lib/libdl-2.13.so
f6f9e000 f6fa9000 r-xp /lib/libunwind.so.8.0.1
f6fd6000 f6fde000 r-xp /lib/libgcc_s-4.6.so.1
f6fdf000 f7103000 r-xp /lib/libc-2.13.so
f7111000 f7113000 r-xp /usr/lib/libdlog.so.0.0.0
f711b000 f7127000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7130000 f7135000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f713d000 f7141000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f714a000 f714c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7155000 f7158000 r-xp /usr/lib/libappcore-agent.so.1.1
f7176000 f7193000 r-xp /lib/ld-2.13.so
f719c000 f719f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f719f000 f71a3000 r-xp /usr/lib/libsys-assert.so
f7994000 f79e2000 rw-p [heap]
ffcf9000 ffd1a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:19156)
Call Stack Count: 1
 0: (0xf704d9fc) [/lib/libc.so.6] + 0x6e9fc
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

04-23 13:54:11.621+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:11.621+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:11:629,74
04-23 13:54:11.821+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:11.821+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:11:828,74
04-23 13:54:12.011+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:12.021+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:12:28,75
04-23 13:54:12.211+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:12.221+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:12:228,75
04-23 13:54:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:12.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491652297,000000, pattern:[H:mm][0;m
04-23 13:54:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:12.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:12.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:12.421+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:12.421+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:12:429,75
04-23 13:54:12.621+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:12.621+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:12:628,75
04-23 13:54:12.821+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:12.821+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:12:829,75
04-23 13:54:13.021+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:13.021+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:13:29,75
04-23 13:54:13.221+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:13.221+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:13:229,75
04-23 13:54:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:13.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491653297,000000, pattern:[H:mm][0;m
04-23 13:54:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:13.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:13.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:13.421+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:13.421+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:13:429,75
04-23 13:54:13.621+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:13.621+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:13:629,75
04-23 13:54:13.821+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:13.821+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:13:829,76
04-23 13:54:14.021+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:14.021+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:14:30,75
04-23 13:54:14.221+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:14.221+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:14:230,75
04-23 13:54:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:14.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491654297,000000, pattern:[H:mm][0;m
04-23 13:54:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:14.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:14.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:14.421+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:14.421+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:14:429,75
04-23 13:54:14.621+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:14.621+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:14:630,75
04-23 13:54:14.821+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:14.821+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:14:830,75
04-23 13:54:15.021+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:15.021+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:15:30,75
04-23 13:54:15.221+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:15.221+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:15:230,75
04-23 13:54:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:15.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491655298,000000, pattern:[H:mm][0;m
04-23 13:54:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:15.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:15.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:15.421+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:15.421+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:15:431,75
04-23 13:54:15.621+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:15.621+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:15:630,75
04-23 13:54:15.821+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:15.821+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:15:831,75
04-23 13:54:16.021+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:16.021+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:16:31,75
04-23 13:54:16.221+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:16.221+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:16:231,75
04-23 13:54:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:16.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491656297,000000, pattern:[H:mm][0;m
04-23 13:54:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:16.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:16.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:16.421+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:16.421+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:16:431,76
04-23 13:54:16.621+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:16.621+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:16:631,76
04-23 13:54:16.821+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:16.821+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:16:831,76
04-23 13:54:16.991+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __alarm_handler_idle(1486) > Lock the display not to enter LCD OFF
04-23 13:54:17.001+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-23 13:54:17.011+0200 W/AUL     ( 2467): app_signal.c: aul_update_freezer_status(456) > aul_update_freezer_status pid(2693) type(wakeup)
04-23 13:54:17.011+0200 E/RESOURCED( 2551): freezer-process.c: freezer_process_pid_set(150) > Cant find process info for 2693
04-23 13:54:17.021+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:17.021+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __alarm_expired(1447) > alarm_id[2016607793] is expired.
04-23 13:54:17.021+0200 E/ALARM_MANAGER( 2693): alarm-lib.c: __handle_expiry_method_call(152) > [alarm-lib] : Alarm expired for [ALARM.astarter] : Alarm id [2016607793]
04-23 13:54:17.021+0200 W/STARTER ( 2693): clock-mgr.c: __starter_clock_mgr_alarm_cb(885) > [__starter_clock_mgr_alarm_cb:885] Reserved app alarm timer expired [2016607793]
04-23 13:54:17.021+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:54:17.031+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 17411
04-23 13:54:17.031+0200 W/STARTER ( 2693): clock-mgr.c: __starter_clock_mgr_alarm_cb(897) > [__starter_clock_mgr_alarm_cb:897] [com.samsung.shealth.alert] is now running & will raise when lcd on.
04-23 13:54:17.031+0200 W/STARTER ( 2693): clock-mgr.c: __starter_clock_mgr_alarm_cb(919) > [__starter_clock_mgr_alarm_cb:919] Raise reserved app [com.samsung.shealth.alert]
04-23 13:54:17.031+0200 W/AUL     ( 2693): launch.c: app_request_to_launchpad(284) > request cmd(1) to(com.samsung.shealth.alert)
04-23 13:54:17.041+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 1
04-23 13:54:17.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 2693
04-23 13:54:17.051+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_resume_request_signal(567) > aul_send_app_resume_request_signal app(com.samsung.shealth.alert) pid(17411) type(uiapp) bg(0)
04-23 13:54:17.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 1, pid: 17411
04-23 13:54:17.061+0200 W/AUL_AMD ( 2478): amd_launch.c: _resume_app(867) > resume done
04-23 13:54:17.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17411), cmd(3)
04-23 13:54:17.071+0200 W/AUL     ( 2693): launch.c: app_request_to_launchpad(298) > request cmd(1) result(17411)
04-23 13:54:17.091+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:17:31,77
04-23 13:54:17.091+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 2016607793, next duetime: 1524484477
04-23 13:54:17.091+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(97378666) is OVER.
04-23 13:54:17.091+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(127082321) is OVER.
04-23 13:54:17.091+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(405561765) is OVER.
04-23 13:54:17.091+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(2077840997) is OVER.
04-23 13:54:17.091+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-23 13:54:17.091+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 23-4-2018, 11:54:37 (UTC).
04-23 13:54:17.091+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-23 13:54:17.091+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __alarm_handler_idle(1512) > Unlock the display from LCD OFF
04-23 13:54:17.101+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-23 13:54:17.101+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [2693].
04-23 13:54:17.101+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(2016607793)
04-23 13:54:17.101+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(97378666) is OVER.
04-23 13:54:17.101+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(127082321) is OVER.
04-23 13:54:17.101+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(405561765) is OVER.
04-23 13:54:17.101+0200 E/ALARM_MANAGER( 2467): alarm-manager-schedule.c: __find_next_alarm_to_be_scheduled(547) > The duetime of alarm(2077840997) is OVER.
04-23 13:54:17.111+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
04-23 13:54:17.111+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
04-23 13:54:17.111+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 23-4-2018, 14:25:03 (UTC).
04-23 13:54:17.111+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
04-23 13:54:17.121+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
04-23 13:54:17.121+0200 E/ALARM_MANAGER( 2467): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[2016607793] is removed.
04-23 13:54:17.131+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(416) > [_app_mgr_status_cb:416] Resume request [17411]
04-23 13:54:17.221+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:17.221+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:17:232,77
04-23 13:54:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:17.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491657292,000000, pattern:[H:mm][0;m
04-23 13:54:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:17.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:17.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:17.421+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:17.421+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:17:431,77
04-23 13:54:17.621+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:17.621+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:17:632,78
04-23 13:54:17.821+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:17.821+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:17:833,78
04-23 13:54:18.021+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:18.021+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:18:32,78
04-23 13:54:18.061+0200 W/AUL_AMD ( 2478): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
04-23 13:54:18.061+0200 W/AUL_AMD ( 2478): amd_launch.c: __grab_timeout_handler(1453) > back key ungrab error
04-23 13:54:18.221+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:18.221+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:18:232,78
04-23 13:54:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:18.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491658297,000000, pattern:[H:mm][0;m
04-23 13:54:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:18.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:18.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:18.421+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:18.421+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:18:433,78
04-23 13:54:18.621+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:18.621+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:18:632,78
04-23 13:54:18.821+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:18.821+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:18:833,78
04-23 13:54:19.021+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:19.021+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:19:34,78
04-23 13:54:19.221+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:19.221+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:19:233,79
04-23 13:54:19.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:19.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:19.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:19.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:19.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491659299,000000, pattern:[H:mm][0;m
04-23 13:54:19.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:19.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:19.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:19.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:19.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:19.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:19.421+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:19.421+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:19:433,78
04-23 13:54:19.621+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:19.621+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:19:633,79
04-23 13:54:19.821+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:19.831+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:19:833,79
04-23 13:54:20.021+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:20.021+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:20:33,79
04-23 13:54:20.221+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:20.221+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:20:234,79
04-23 13:54:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:20.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491660297,000000, pattern:[H:mm][0;m
04-23 13:54:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:20.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:20.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:20.421+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:20.421+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:20:433,79
04-23 13:54:20.621+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:20.621+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:20:634,79
04-23 13:54:20.821+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:20.821+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:20:834,78
04-23 13:54:21.021+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:21.021+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:21:34,78
04-23 13:54:21.221+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:21.221+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:54:21:234,79
04-23 13:54:21.281+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:54:21.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:54:21.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:54:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:21.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491661300,000000, pattern:[H:mm][0;m
04-23 13:54:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:54:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:54:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:54:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:54:21.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:54:21.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:54][0;m
04-23 13:54:21.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17422
04-23 13:54:21.301+0200 I/utils   (17422): specific action
04-23 13:54:21.301+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:54:21.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17422), cmd(0)
04-23 13:54:21.301+0200 I/httppostreq(17422): internet connection check received
04-23 13:54:21.301+0200 I/httppostreq(17422): internet connection != null
04-23 13:54:21.301+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17422)
04-23 13:54:21.311+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.httppostreq
04-23 13:54:21.311+0200 I/CAPI_NETWORK_CONNECTION(17422): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:54:21.311+0200 I/httppostreq(17422): internet connection type...
04-23 13:54:21.311+0200 I/httppostreq(17422): internet connection type 1
04-23 13:54:21.311+0200 I/httppostreq(17422): internet available
04-23 13:54:21.311+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:54:21.311+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:54:21.311+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17422
04-23 13:54:21.321+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
04-23 13:54:21.331+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:54:21.331+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17419), cmd(0)
04-23 13:54:21.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:54:21.331+0200 I/utils   (17419): specific action
04-23 13:54:21.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:54:21.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:54:21.331+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
04-23 13:54:21.331+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:54:21.331+0200 I/servicemanager(17419): internet connection available. stop all sensors
04-23 13:54:21.331+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:54:21.331+0200 I/httppostreq(17422): request sent to service es.ugr.frailty.servicemanager
04-23 13:54:21.341+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:54:21.341+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:54:21.351+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 19152
04-23 13:54:21.351+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:54:21.401+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19152
04-23 13:54:21.401+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(19152) type(svcapp) bg(0)
04-23 13:54:21.401+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19152]
04-23 13:54:21.411+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19152)
04-23 13:54:21.411+0200 I/servicemanager(17419): es.ugr.frailty.accelerometer stop request sent!
04-23 13:54:21.411+0200 I/servicemanager(17419): App control destroyed.
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:21.411+0200 I/servicemanager(17419): deleting timer 0
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:21.411+0200 I/servicemanager(17419): deleting timer 1
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:21.411+0200 I/servicemanager(17419): deleting timer 2
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:21.411+0200 I/servicemanager(17419): deleting timer 3
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:21.411+0200 I/servicemanager(17419): deleting timer 4
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:21.411+0200 I/servicemanager(17419): deleting timer 5
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:21.411+0200 I/servicemanager(17419): deleting timer 6
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:54:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:54:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:54:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:54:21.411+0200 I/servicemanager(17419): deleting timer 7
04-23 13:54:21.411+0200 I/servicemanager(17419): deleting timer 8
04-23 13:54:21.411+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:54:21.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:54:21.431+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:54:21.441+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 19156
04-23 13:54:21.441+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:54:21.441+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:54:21.491+0200 E/CAPI_APPFW_APPLICATION(19156): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:54:21.491+0200 E/CAPI_APPFW_APPLICATION(19156): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:54:21.491+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 19156
04-23 13:54:21.491+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(19156) type(svcapp) bg(0)
04-23 13:54:21.501+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:54:21.511+0200 I/utils   (19156): specific action
04-23 13:54:21.511+0200 I/recorder(19156): obteniendo datos locales...
04-23 13:54:21.511+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19152
04-23 13:54:21.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:54:21.531+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19156)
04-23 13:54:21.531+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [19156]
04-23 13:54:21.531+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.recorder
04-23 13:54:21.531+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19152
04-23 13:54:21.531+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (19156) was created
04-23 13:54:21.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:54:21.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:54:21.611+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:54:21.621+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19156
04-23 13:54:21.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:54:21.651+0200 E/CAPI_APPFW_APPLICATION(19152): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:54:21.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:54:21.661+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19156
04-23 13:54:21.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:54:21.701+0200 I/recorder(19156): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:24:189,1.849652,-2.009971,9.454042
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:24:371,1.804188,-3.177669,9.157332
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:24:577,1.634298,-3.120241,9.145369
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:24:777,1.775474,-3.187240,9.329616
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:24:977,1.730011,-3.986443,9.047262
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:25:177,1.875973,-3.194418,9.078369
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:25:380,1.828116,-2.565106,9.475577
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:25:577,1.797010,-2.864209,9.312866
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:25:777,1.782653,-2.883351,9.391829
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:25:977,1.605584,-3.132205,9.339187
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:26:178,1.696511,-3.089134,9.427721
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:26:378,1.749153,-3.046063,9.394222
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:26:578,1.830509,-2.309074,9.410972
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:26:778,1.761117,-2.758924,9.851252
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:26:978,1.651048,-2.816352,9.568897
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:27:178,1.820938,-1.667797,9.049655
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:27:378,1.813759,-2.115255,9.659825
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:27:579,1.596013,-2.000400,9.748360
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:27:779,1.792224,-1.598405,9.580862
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:27:979,1.835295,-1.612763,9.549755
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:28:179,1.856830,-1.488336,9.547362
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:28:379,1.801795,-1.507478,9.628718
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:28:579,1.878366,-1.406980,9.509077
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:28:780,1.844866,-1.655833,9.710074
04-23 13:54:21.701+0200 I/recorder(19156): SM-R760,23/04/2018,13:46:28:980,1.741975,-1.658226,9.638289
04-23 13:54:21.731+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:54:21.731+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 19152
04-23 13:54:21.771+0200 W/CRASH_MANAGER(17537): worker.c: worker_job(1205) > 1119156726563152448446
