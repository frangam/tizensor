S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 18744
Date: 2018-04-23 13:52:21+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf70f0648, r1   = 0xf77dd1b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf77dd1b8, r5   = 0x00012cd0
r6   = 0xf77efe88, r7   = 0xf70f0250
r8   = 0x000005e0, r9   = 0xf6bd3824
r10  = 0xf77d59d8, fp   = 0x00000000
ip   = 0xf70ef030, sp   = 0xffbe7610
lr   = 0xf70335d0, pc   = 0xf702f9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     26900 KB
Buffers:     31768 KB
Cached:     149988 KB
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
VmPTE:          44 KB
VmSwap:          0 KB

Maps Information
f676a000 f676d000 r-xp /lib/libattr.so.1.1.0
f6776000 f677d000 r-xp /lib/libcrypt-2.13.so
f67ad000 f67b0000 r-xp /lib/libcap.so.2.21
f67b8000 f67ba000 r-xp /usr/lib/libiri.so
f67c2000 f67df000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f67e8000 f67ec000 r-xp /usr/lib/libsmack.so.1.0.0
f67f6000 f67f8000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6800000 f6805000 r-xp /usr/lib/libffi.so.5.0.10
f680d000 f680e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6816000 f6818000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6820000 f6822000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f682c000 f683c000 r-xp /lib/libresolv-2.13.so
f6840000 f6858000 r-xp /usr/lib/liblzma.so.5.0.3
f6860000 f6862000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f686a000 f6899000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f68a2000 f68b1000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f68ba000 f68c4000 r-xp /usr/lib/libsensord-shared.so
f68cd000 f6901000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f690a000 f69dd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f69e8000 f69fe000 r-xp /lib/libz.so.1.2.5
f6a06000 f6a0c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6a15000 f6a8a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a94000 f6aae000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ab6000 f6abc000 r-xp /lib/librt-2.13.so
f6ac5000 f6ae3000 r-xp /usr/lib/libsystemd.so.0.4.0
f6aed000 f6aee000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6af6000 f6afb000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6b03000 f6bd3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6bd4000 f6bfe000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6c07000 f6c1e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6c26000 f6c8f000 r-xp /lib/libm-2.13.so
f6c98000 f6d2c000 r-xp /usr/lib/libstdc++.so.6.0.16
f6d3f000 f6d44000 r-xp /usr/lib/libctx-client.so.0.8.3
f6d4c000 f6d53000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6d5b000 f6d85000 r-xp /usr/lib/libsensor.so.1.9.6
f6d8e000 f6e5a000 r-xp /usr/lib/libxml2.so.2.7.8
f6e67000 f6e69000 r-xp /usr/lib/libiniparser.so.0
f6e72000 f6e75000 r-xp /usr/lib/libbundle.so.0.1.22
f6e7d000 f6e83000 r-xp /usr/lib/libappsvc.so.0.1.0
f6e8b000 f6eae000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6eb6000 f6ef7000 r-xp /usr/lib/libeina.so.1.7.99
f6f00000 f6f17000 r-xp /usr/lib/libecore.so.1.7.99
f6f2e000 f6f37000 r-xp /usr/lib/libvconf.so.0.2.45
f6f3f000 f6f53000 r-xp /lib/libpthread-2.13.so
f6f5e000 f6f6b000 r-xp /usr/lib/libaul.so.0.1.0
f6f75000 f6f77000 r-xp /lib/libdl-2.13.so
f6f80000 f6f8b000 r-xp /lib/libunwind.so.8.0.1
f6fb8000 f6fc0000 r-xp /lib/libgcc_s-4.6.so.1
f6fc1000 f70e5000 r-xp /lib/libc-2.13.so
f70f3000 f70f5000 r-xp /usr/lib/libdlog.so.0.0.0
f70fd000 f7109000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7112000 f7117000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f711f000 f7123000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f712c000 f712e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7137000 f713a000 r-xp /usr/lib/libappcore-agent.so.1.1
f7158000 f7175000 r-xp /lib/ld-2.13.so
f717e000 f7181000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f7181000 f7185000 r-xp /usr/lib/libsys-assert.so
f77cb000 f7819000 rw-p [heap]
ffbc9000 ffbea000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18744)
Call Stack Count: 1
 0: (0xf702f9fc) [/lib/libc.so.6] + 0x6e9fc
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
:52:09:947,79
04-23 13:52:10.131+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:10.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:10:147,79
04-23 13:52:10.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:10.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:10.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:10.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:10.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491530297,000000, pattern:[H:mm][0;m
04-23 13:52:10.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:10.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:10.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:10.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:10.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:10.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:10.331+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:10.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:10:347,78
04-23 13:52:10.531+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:10.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:10:547,78
04-23 13:52:10.731+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:10.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:10:747,78
04-23 13:52:10.931+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:10.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:10:947,78
04-23 13:52:11.131+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:11.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:11:148,78
04-23 13:52:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:11.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491531297,000000, pattern:[H:mm][0;m
04-23 13:52:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:11.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:11.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:11.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:11.331+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:11.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:11:348,78
04-23 13:52:11.531+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:11.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:11:548,77
04-23 13:52:11.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:11.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:11:748,77
04-23 13:52:11.931+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:11.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:11:948,77
04-23 13:52:12.131+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:12.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:12:148,77
04-23 13:52:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:12.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491532297,000000, pattern:[H:mm][0;m
04-23 13:52:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:12.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:12.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:12.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:12.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:12.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:12:349,77
04-23 13:52:12.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:12.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:12:548,77
04-23 13:52:12.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:12.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:12:749,77
04-23 13:52:12.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:12.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:12:949,77
04-23 13:52:13.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:13.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:13:149,77
04-23 13:52:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:13.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491533298,000000, pattern:[H:mm][0;m
04-23 13:52:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:13.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:13.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:13.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:13.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:13.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:13:349,76
04-23 13:52:13.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:13.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:13:549,76
04-23 13:52:13.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:13.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:13:749,76
04-23 13:52:13.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:13.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:13:950,76
04-23 13:52:14.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:14.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:14:150,75
04-23 13:52:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:14.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491534297,000000, pattern:[H:mm][0;m
04-23 13:52:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:14.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:14.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:14.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:14.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:14.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:14:350,75
04-23 13:52:14.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:14.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:14:550,75
04-23 13:52:14.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:14.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:14:751,75
04-23 13:52:14.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:14.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:14:950,75
04-23 13:52:15.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:15.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:15:150,75
04-23 13:52:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:15.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491535297,000000, pattern:[H:mm][0;m
04-23 13:52:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:15.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:15.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:15.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:15.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:15.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:15:351,75
04-23 13:52:15.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:15.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:15:550,75
04-23 13:52:15.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:15.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:15:751,74
04-23 13:52:15.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:15.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:15:951,74
04-23 13:52:16.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:16.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:16:151,74
04-23 13:52:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:16.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491536298,000000, pattern:[H:mm][0;m
04-23 13:52:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:16.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:16.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:16.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:16.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:16.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:16:351,74
04-23 13:52:16.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:16.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:16:551,75
04-23 13:52:16.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:16.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:16:751,74
04-23 13:52:16.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:16.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:16:951,75
04-23 13:52:17.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:17.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:17:152,75
04-23 13:52:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:17.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491537298,000000, pattern:[H:mm][0;m
04-23 13:52:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:17.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:17.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:17.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:17.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:17.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:17:352,75
04-23 13:52:17.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:17.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:17:552,75
04-23 13:52:17.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:17.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:17:752,75
04-23 13:52:17.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:17.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:17:952,75
04-23 13:52:18.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:18.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:18:152,75
04-23 13:52:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:18.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491538297,000000, pattern:[H:mm][0;m
04-23 13:52:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:18.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:18.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:18.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:18.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:18.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:18:353,75
04-23 13:52:18.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:18.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:18:552,75
04-23 13:52:18.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:18.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:18:753,75
04-23 13:52:18.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:18.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:18:954,75
04-23 13:52:19.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:19.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:19:153,75
04-23 13:52:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:19.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491539297,000000, pattern:[H:mm][0;m
04-23 13:52:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:19.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:19.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:19.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:19.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:19.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:19:353,75
04-23 13:52:19.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:19.541+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:19:554,75
04-23 13:52:19.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:19.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:19:754,75
04-23 13:52:19.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:19.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:19:954,75
04-23 13:52:20.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:20.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:20:155,76
04-23 13:52:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:20.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491540297,000000, pattern:[H:mm][0;m
04-23 13:52:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:20.281+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:20.281+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:20.281+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:20.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:20.341+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:20:355,76
04-23 13:52:20.541+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:20.551+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:20:555,76
04-23 13:52:20.741+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:20.741+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:20:754,76
04-23 13:52:20.941+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:20.941+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:20:954,76
04-23 13:52:21.141+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:21.141+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:21:154,76
04-23 13:52:21.281+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 13:52:21.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:52:21.281+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:52:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:21.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1524491541299,000000, pattern:[H:mm][0;m
04-23 13:52:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
04-23 13:52:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
04-23 13:52:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
04-23 13:52:21.291+0200 E/TIZEN_N_SYSTEM_SETTINGS(17411): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
04-23 13:52:21.291+0200 E/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
04-23 13:52:21.291+0200 W/WSLib   (17411): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[13:52][0;m
04-23 13:52:21.291+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17422
04-23 13:52:21.291+0200 I/utils   (17422): specific action
04-23 13:52:21.291+0200 I/httppostreq(17422): internet connection check received
04-23 13:52:21.291+0200 I/httppostreq(17422): internet connection != null
04-23 13:52:21.291+0200 I/CAPI_NETWORK_CONNECTION(17422): connection.c: connection_get_type(507) > Connected Network = 2
04-23 13:52:21.291+0200 I/httppostreq(17422): internet connection type...
04-23 13:52:21.291+0200 I/httppostreq(17422): internet connection type 1
04-23 13:52:21.291+0200 I/httppostreq(17422): internet available
04-23 13:52:21.291+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 13:52:21.291+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:52:21.291+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17422
04-23 13:52:21.301+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 17419
04-23 13:52:21.311+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:52:21.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(17422), cmd(0)
04-23 13:52:21.311+0200 W/AUL     (17422): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17419)
04-23 13:52:21.311+0200 I/httppostreq(17422): request sent to service es.ugr.frailty.servicemanager
04-23 13:52:21.311+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(17422)
04-23 13:52:21.311+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.httppostreq
04-23 13:52:21.311+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 13:52:21.311+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(17419), cmd(0)
04-23 13:52:21.321+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:52:21.321+0200 I/utils   (17419): specific action
04-23 13:52:21.321+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:52:21.321+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:52:21.321+0200 W/CAPI_APPFW_APP_CONTROL(17419): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 13:52:21.321+0200 I/servicemanager(17419): internet connection available. stop all sensors
04-23 13:52:21.321+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 13:52:21.321+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:52:21.321+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:52:21.331+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18731
04-23 13:52:21.341+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:52:21.341+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:21.371+0200 E/CAPI_APPFW_APPLICATION(18731): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:52:21.371+0200 E/CAPI_APPFW_APPLICATION(18731): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:52:21.381+0200 I/utils   (18731): trying to start service: es.ugr.frailty.accelerometer
04-23 13:52:21.381+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:21:355,75
04-23 13:52:21.381+0200 I/utils   (18731): es.ugr.frailty.accelerometer sensor supported
04-23 13:52:21.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18731
04-23 13:52:21.391+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(18731) type(svcapp) bg(0)
04-23 13:52:21.391+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18731) was created
04-23 13:52:21.401+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18731]
04-23 13:52:21.411+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18731)
04-23 13:52:21.411+0200 I/servicemanager(17419): es.ugr.frailty.accelerometer stop request sent!
04-23 13:52:21.411+0200 I/servicemanager(17419): App control destroyed.
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:21.411+0200 I/servicemanager(17419): deleting timer 0
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:21.411+0200 I/servicemanager(17419): deleting timer 1
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:21.411+0200 I/servicemanager(17419): deleting timer 2
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:21.411+0200 I/servicemanager(17419): deleting timer 3
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:21.411+0200 I/servicemanager(17419): deleting timer 4
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:21.411+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:21.411+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:21.411+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:21.411+0200 I/servicemanager(17419): deleting timer 5
04-23 13:52:21.421+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:21.421+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:21.421+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:21.421+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:21.421+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:21.431+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18731
04-23 13:52:21.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:21.441+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18731
04-23 13:52:21.441+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:21.481+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:21.491+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:21.491+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:21.491+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:21.491+0200 I/servicemanager(17419): deleting timer 6
04-23 13:52:21.491+0200 E/EFL     (17419): ecore<17419> ecore.c:573 _ecore_magic_fail() 
04-23 13:52:21.491+0200 E/EFL     (17419): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 13:52:21.491+0200 E/EFL     (17419): *** IN FUNCTION: ecore_timer_del()
04-23 13:52:21.491+0200 E/EFL     (17419): ecore<17419> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 13:52:21.491+0200 E/EFL     (17419): ecore<17419> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 13:52:21.491+0200 E/EFL     (17419): *** SPANK SPANK SPANK!!!
04-23 13:52:21.491+0200 E/EFL     (17419): *** Now go fix your code. Tut tut tut!
04-23 13:52:21.491+0200 I/servicemanager(17419): deleting timer 7
04-23 13:52:21.491+0200 I/servicemanager(17419): deleting timer 8
04-23 13:52:21.491+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 13:52:21.511+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 13:52:21.511+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 17419
04-23 13:52:21.531+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 13:52:21.531+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 18744
04-23 13:52:21.571+0200 E/CAPI_APPFW_APPLICATION(18744): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:52:21.571+0200 E/CAPI_APPFW_APPLICATION(18744): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 13:52:21.571+0200 I/utils   (18744): specific action
04-23 13:52:21.571+0200 I/recorder(18744): obteniendo datos locales...
04-23 13:52:21.591+0200 I/recorder(18744): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:24:189,1.849652,-2.009971,9.454042
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:24:371,1.804188,-3.177669,9.157332
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:24:577,1.634298,-3.120241,9.145369
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:24:777,1.775474,-3.187240,9.329616
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:24:977,1.730011,-3.986443,9.047262
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:25:177,1.875973,-3.194418,9.078369
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:25:380,1.828116,-2.565106,9.475577
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:25:577,1.797010,-2.864209,9.312866
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:25:777,1.782653,-2.883351,9.391829
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:25:977,1.605584,-3.132205,9.339187
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:26:178,1.696511,-3.089134,9.427721
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:26:378,1.749153,-3.046063,9.394222
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:26:578,1.830509,-2.309074,9.410972
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:26:778,1.761117,-2.758924,9.851252
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:26:978,1.651048,-2.816352,9.568897
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:27:178,1.820938,-1.667797,9.049655
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:27:378,1.813759,-2.115255,9.659825
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:27:579,1.596013,-2.000400,9.748360
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:27:779,1.792224,-1.598405,9.580862
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:27:979,1.835295,-1.612763,9.549755
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:28:179,1.856830,-1.488336,9.547362
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:28:379,1.801795,-1.507478,9.628718
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:28:579,1.878366,-1.406980,9.509077
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:28:780,1.844866,-1.655833,9.710074
04-23 13:52:21.591+0200 I/recorder(18744): SM-R760,23/04/2018,13:46:28:980,1.741975,-1.658226,9.638289
04-23 13:52:21.601+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 18744
04-23 13:52:21.601+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(18744) type(svcapp) bg(0)
04-23 13:52:21.601+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (18744) was created
04-23 13:52:21.611+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [18744]
04-23 13:52:21.621+0200 W/AUL     (17419): launch.c: app_request_to_launchpad(298) > request cmd(0) result(18744)
04-23 13:52:21.621+0200 I/servicemanager(17419): request sent to service es.ugr.frailty.recorder
04-23 13:52:21.621+0200 I/utils   (18731): es.ugr.frailty.accelerometer listener started
04-23 13:52:21.621+0200 I/accelerometer(18731): stopping es.ugr.frailty.accelerometer service
04-23 13:52:21.621+0200 E/CAPI_APPFW_APP_CONTROL(18731): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 13:52:21.621+0200 E/accelerometer(18731): request sending failed to service es.ugr.frailty.servicemanager
04-23 13:52:21.621+0200 I/CAPI_APPFW_APPLICATION(18731): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 13:52:21.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:21.631+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18744
04-23 13:52:21.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 13:52:21.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 13:52:21.641+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:21.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 13:52:21.681+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 18744
04-23 13:52:21.691+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 13:52:21.781+0200 I/heartrate(17455): capturing data from heartrate -> id: es.ugr.frailty.heartrate
04-23 13:52:21.781+0200 I/heartrate(17455): es.ugr.frailty.heartrate: SM-R760,23/04/2018,13:52:21:790,75
04-23 13:52:21.781+0200 W/CRASH_MANAGER(17537): worker.c: worker_job(1205) > 1118744726563152448434
