S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 26259
Date: 2018-04-23 12:53:49+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf75fe648, r1   = 0xf7b861b8
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7b861b8, r5   = 0x00012cd0
r6   = 0xf7b98e88, r7   = 0xf75fe250
r8   = 0x000005c8, r9   = 0xf70e1824
r10  = 0xf7b7e9d8, fp   = 0x00000000
ip   = 0xf75fd030, sp   = 0xff9644c0
lr   = 0xf75415d0, pc   = 0xf753d9fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     13768 KB
Buffers:     71828 KB
Cached:     185004 KB
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
f6c78000 f6c7b000 r-xp /lib/libattr.so.1.1.0
f6c84000 f6c8b000 r-xp /lib/libcrypt-2.13.so
f6cbb000 f6cbe000 r-xp /lib/libcap.so.2.21
f6cc6000 f6cc8000 r-xp /usr/lib/libiri.so
f6cd0000 f6ced000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6cf6000 f6cfa000 r-xp /usr/lib/libsmack.so.1.0.0
f6d04000 f6d06000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6d0e000 f6d13000 r-xp /usr/lib/libffi.so.5.0.10
f6d1b000 f6d1c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6d24000 f6d26000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6d2e000 f6d30000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6d3a000 f6d4a000 r-xp /lib/libresolv-2.13.so
f6d4e000 f6d66000 r-xp /usr/lib/liblzma.so.5.0.3
f6d6e000 f6d70000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d78000 f6da7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6db0000 f6dbf000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6dc8000 f6dd2000 r-xp /usr/lib/libsensord-shared.so
f6ddb000 f6e0f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e18000 f6eeb000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6ef6000 f6f0c000 r-xp /lib/libz.so.1.2.5
f6f14000 f6f1a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f23000 f6f98000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6fa2000 f6fbc000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6fc4000 f6fca000 r-xp /lib/librt-2.13.so
f6fd3000 f6ff1000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ffb000 f6ffc000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f7004000 f7009000 r-xp /usr/lib/libxdgmime.so.1.1.0
f7011000 f70e1000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70e2000 f710c000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7115000 f712c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7134000 f719d000 r-xp /lib/libm-2.13.so
f71a6000 f723a000 r-xp /usr/lib/libstdc++.so.6.0.16
f724d000 f7252000 r-xp /usr/lib/libctx-client.so.0.8.3
f725a000 f7261000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7269000 f7293000 r-xp /usr/lib/libsensor.so.1.9.6
f729c000 f7368000 r-xp /usr/lib/libxml2.so.2.7.8
f7375000 f7377000 r-xp /usr/lib/libiniparser.so.0
f7380000 f7383000 r-xp /usr/lib/libbundle.so.0.1.22
f738b000 f7391000 r-xp /usr/lib/libappsvc.so.0.1.0
f7399000 f73bc000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f73c4000 f7405000 r-xp /usr/lib/libeina.so.1.7.99
f740e000 f7425000 r-xp /usr/lib/libecore.so.1.7.99
f743c000 f7445000 r-xp /usr/lib/libvconf.so.0.2.45
f744d000 f7461000 r-xp /lib/libpthread-2.13.so
f746c000 f7479000 r-xp /usr/lib/libaul.so.0.1.0
f7483000 f7485000 r-xp /lib/libdl-2.13.so
f748e000 f7499000 r-xp /lib/libunwind.so.8.0.1
f74c6000 f74ce000 r-xp /lib/libgcc_s-4.6.so.1
f74cf000 f75f3000 r-xp /lib/libc-2.13.so
f7601000 f7603000 r-xp /usr/lib/libdlog.so.0.0.0
f760b000 f7617000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7620000 f7625000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f762d000 f7631000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f763a000 f763c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f7645000 f7648000 r-xp /usr/lib/libappcore-agent.so.1.1
f7666000 f7683000 r-xp /lib/ld-2.13.so
f768c000 f768f000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f768f000 f7693000 r-xp /usr/lib/libsys-assert.so
f7b74000 f7bc2000 rw-p [heap]
ff946000 ff967000 rw-p [stack]
End of Maps Information

Callstack Information (PID:26259)
Call Stack Count: 1
 0: (0xf753d9fc) [/lib/libc.so.6] + 0x6e9fc
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
:53:33.751+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:53:33.751+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:33:753,-0.070000,0.070000,0.140000
04-23 12:53:33.951+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:33:959,-0.070000,0.070000,0.070000
04-23 12:53:33.951+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:53:34.151+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:34:159,-0.070000,0.070000,-0.070000
04-23 12:53:34.151+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:53:34.351+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:34:359,-0.070000,0.070000,-0.070000
04-23 12:53:34.351+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:53:34.551+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:34:559,-0.210000,-0.140000,-0.210000
04-23 12:53:34.551+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:53:34.671+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1294) > data_avail_chg = 1, index_chg = 0
04-23 12:53:34.671+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1296) > last_wall_time_chg = 1524480694, curr_wall_time = 1524480814
04-23 12:53:34.671+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1297) > time diff before averaging = 120 seconds
04-23 12:53:34.671+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_get_time_diff_avg(1206) > time_diff after averaging= 99 seconds
04-23 12:53:34.671+0200 E/RESOURCED( 2551): heart-battery.c: heart_battery_cal_charging_rem_time(1337) > Capacity = 91, charging remaining time = 15 minutes
04-23 12:53:34.751+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:53:34.751+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:34:753,-0.210000,0.140000,-0.140000
04-23 12:53:34.951+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:53:34.951+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:34:953,-0.140000,-0.070000,0.140000
04-23 12:53:35.151+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:35:159,-0.140000,0.140000,-0.210000
04-23 12:53:35.151+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:53:35.351+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:35:359,-0.140000,0.140000,-0.210000
04-23 12:53:35.351+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:53:35.551+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:35:559,-0.070000,-0.140000,-0.140000
04-23 12:53:35.551+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:53:35.751+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:53:35.751+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:35:753,0.140000,0.210000,0.070000
04-23 12:53:35.951+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:35:959,0.140000,0.070000,0.420000
04-23 12:53:35.951+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:53:36.151+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:36:159,-0.140000,0.140000,0.420000
04-23 12:53:36.151+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:53:36.351+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:53:36.351+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:36:352,-0.070000,0.070000,0.420000
04-23 12:53:36.551+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:53:36.551+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:36:553,0.140000,0.070000,-0.280000
04-23 12:53:36.741+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:53:36.751+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:36:759,0.210000,-0.210000,-0.280000
04-23 12:53:36.931+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer sleep timeout
04-23 12:53:36.931+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:53:36.931+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:36.931+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:36.961+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26148
04-23 12:53:36.961+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26148)
04-23 12:53:36.961+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:53:36.961+0200 I/servicemanager(25863): App control destroyed.
04-23 12:53:36.961+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:53:36.961+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(26148), cmd(0)
04-23 12:53:36.981+0200 I/accelerometer(26148): stopping es.ugr.frailty.accelerometer service
04-23 12:53:36.981+0200 W/AUL     (26148): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:53:36.981+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:36.981+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 26148
04-23 12:53:36.991+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:53:37.001+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:53:37.001+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:53:37.001+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:37.001+0200 I/utils   (25863): specific action
04-23 12:53:37.001+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:53:37.001+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:37.011+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:37.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25868
04-23 12:53:37.021+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:53:37.021+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25868), cmd(0)
04-23 12:53:37.031+0200 W/CAPI_APPFW_APP_CONTROL(25868): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:37.031+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25868)
04-23 12:53:37.031+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:53:37.031+0200 I/servicemanager(25863): requesting to save local data
04-23 12:53:37.031+0200 I/servicemanager(25863): es.ugr.frailty.gyroscope sleep timeout
04-23 12:53:37.031+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 12:53:37.031+0200 I/utils   (25868): specific action
04-23 12:53:37.031+0200 W/CAPI_APPFW_APP_CONTROL(25868): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:37.031+0200 I/recorder(25868): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:53:37.031+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:37.031+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:37.031+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,12:53:36:980,-0.210000,-0.140000,0.140000
04-23 12:53:37.041+0200 W/AUL     (26148): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:53:37.041+0200 I/accelerometer(26148): request sent to service es.ugr.frailty.servicemanager
04-23 12:53:37.041+0200 I/CAPI_APPFW_APPLICATION(26148): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:53:37.041+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 26161
04-23 12:53:37.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:53:37.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:53:37.051+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26161)
04-23 12:53:37.051+0200 I/servicemanager(25863): es.ugr.frailty.gyroscope stop request sent!
04-23 12:53:37.051+0200 I/servicemanager(25863): App control destroyed.
04-23 12:53:37.051+0200 I/recorder(25868): guardando datos en local
04-23 12:53:37.051+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:53:37.051+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(26161), cmd(0)
04-23 12:53:37.051+0200 I/gyroscope(26161): stopping es.ugr.frailty.gyroscope service
04-23 12:53:37.051+0200 W/AUL     (26161): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:53:37.051+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:37.051+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 26161
04-23 12:53:37.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:53:37.071+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:53:37.071+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:53:37.071+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:37.071+0200 I/utils   (25863): specific action
04-23 12:53:37.071+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:37.071+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:53:37.071+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:37.071+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:37.091+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25868
04-23 12:53:37.091+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25868)
04-23 12:53:37.091+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:53:37.091+0200 I/servicemanager(25863): requesting to save local data
04-23 12:53:37.091+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:53:37.091+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25868), cmd(0)
04-23 12:53:37.091+0200 W/CAPI_APPFW_APP_CONTROL(25868): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:37.091+0200 I/utils   (25868): specific action
04-23 12:53:37.091+0200 W/CAPI_APPFW_APP_CONTROL(25868): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:37.091+0200 W/CAPI_APPFW_APP_CONTROL(25868): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:37.091+0200 I/recorder(25868): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 12:53:37.091+0200 I/recorder(25868): guardando datos en local
04-23 12:53:37.091+0200 W/AUL     (26161): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:53:37.091+0200 I/gyroscope(26161): request sent to service es.ugr.frailty.servicemanager
04-23 12:53:37.091+0200 I/CAPI_APPFW_APPLICATION(26161): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:53:37.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:53:37.091+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:53:37.101+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:53:37.111+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:53:37.151+0200 I/accelerometer(26148): es.ugr.frailty.accelerometer listener destroyed
04-23 12:53:37.151+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:53:37.161+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:53:37.181+0200 I/gyroscope(26161): es.ugr.frailty.gyroscope listener destroyed
04-23 12:53:37.271+0200 W/AUL     (26178): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:53:37.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:53:37.281+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:53:37.281+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26148
04-23 12:53:37.281+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:53:37.311+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26148
04-23 12:53:37.311+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26148)
04-23 12:53:37.331+0200 W/AUL     (26179): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 12:53:37.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:53:37.331+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:53:37.331+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26161
04-23 12:53:37.331+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:53:37.341+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26161
04-23 12:53:37.341+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26161)
04-23 12:53:39.061+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:53:39.091+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:53:39.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:53:39.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:39.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:39.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:53:39.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:53:39.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:53:39.391+0200 I/utils   (25866): specific action
04-23 12:53:39.391+0200 I/httppostreq(25866): internet connection check received
04-23 12:53:39.391+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:53:39.391+0200 I/httppostreq(25866): internet connection != null
04-23 12:53:39.391+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:53:39.391+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:53:39.391+0200 I/httppostreq(25866): internet connection type...
04-23 12:53:39.391+0200 I/httppostreq(25866): internet connection type 1
04-23 12:53:39.391+0200 I/httppostreq(25866): internet available
04-23 12:53:39.391+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:53:39.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:39.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:53:39.421+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:53:39.421+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:53:39.421+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:53:39.431+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:39.431+0200 I/utils   (25863): specific action
04-23 12:53:39.431+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:39.431+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:39.431+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:53:39.431+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:53:39.431+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:53:39.431+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:53:39.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:39.431+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:39.451+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26180
04-23 12:53:39.461+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:53:39.501+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26180
04-23 12:53:39.501+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26180) type(svcapp) bg(0)
04-23 12:53:39.501+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26180)
04-23 12:53:39.501+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:53:39.501+0200 I/servicemanager(25863): App control destroyed.
04-23 12:53:39.501+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:39.501+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:39.501+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:39.501+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:39.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:39.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:39.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:39.501+0200 E/servicemanager(25863): deleting timer 0
04-23 12:53:39.501+0200 E/servicemanager(25863): deleting timer 1
04-23 12:53:39.501+0200 E/servicemanager(25863): deleting timer 2
04-23 12:53:39.501+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:39.501+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:39.501+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:39.501+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:39.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:39.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:39.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:39.501+0200 E/servicemanager(25863): deleting timer 3
04-23 12:53:39.501+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:39.501+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:39.501+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:39.501+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:39.501+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:39.501+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:39.501+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:39.501+0200 E/servicemanager(25863): deleting timer 4
04-23 12:53:39.501+0200 E/EFL     (25863): <25863> ecore_timer.c:559 _ecore_timer_del() safety check failed: timer->delete_me is true
04-23 12:53:39.501+0200 E/servicemanager(25863): deleting timer 5
04-23 12:53:39.501+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:53:39.511+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26180]
04-23 12:53:39.521+0200 E/CAPI_APPFW_APPLICATION(26180): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:39.521+0200 E/CAPI_APPFW_APPLICATION(26180): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:39.521+0200 I/utils   (26180): trying to start service: es.ugr.frailty.accelerometer
04-23 12:53:39.521+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:39.521+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:39.531+0200 I/utils   (26180): es.ugr.frailty.accelerometer sensor supported
04-23 12:53:39.531+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25868
04-23 12:53:39.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:53:39.541+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26180
04-23 12:53:39.541+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26180) was created
04-23 12:53:39.551+0200 I/utils   (26180): es.ugr.frailty.accelerometer listener started
04-23 12:53:39.551+0200 I/accelerometer(26180): stopping es.ugr.frailty.accelerometer service
04-23 12:53:39.551+0200 E/CAPI_APPFW_APP_CONTROL(26180): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:53:39.551+0200 E/accelerometer(26180): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:53:39.551+0200 I/CAPI_APPFW_APPLICATION(26180): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:53:39.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:53:39.561+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26180
04-23 12:53:39.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:53:39.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:53:39.561+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:53:39.561+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25868)
04-23 12:53:39.571+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:53:39.571+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:53:39.571+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25868), cmd(0)
04-23 12:53:39.571+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:53:39.571+0200 I/utils   (25868): specific action
04-23 12:53:39.571+0200 I/recorder(25868): obteniendo datos locales...
04-23 12:53:39.571+0200 I/recorder(25868): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:53:39.571+0200 I/recorder(25868): obteniendo datos locales es.ugr.frailty.accelerometer
04-23 12:53:39.571+0200 I/recorder(25868): obteniendo datos locales, DATA: SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:53:39.571+0200 I/recorder(25868): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798
04-23 12:53:39.631+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:53:39.641+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:53:39.661+0200 I/accelerometer(26180): es.ugr.frailty.accelerometer listener destroyed
04-23 12:53:39.681+0200 W/AUL     (26196): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 12:53:39.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:53:39.681+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:53:39.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 25868
04-23 12:53:39.681+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:53:39.681+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 25868
04-23 12:53:39.681+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(25868)
04-23 12:53:39.751+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 06258687265631524480819
04-23 12:53:39.781+0200 W/AUL     (26203): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 12:53:39.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 12:53:39.781+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 12:53:39.781+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 26180
04-23 12:53:39.781+0200 W/AUL_AMD ( 2478): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 12:53:39.801+0200 I/AUL_AMD ( 2478): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 26180
04-23 12:53:39.801+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(26180)
04-23 12:53:41.561+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 12:53:49.371+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 12:53:49.371+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:49.371+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:49.381+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25866
04-23 12:53:49.391+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:53:49.391+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25866), cmd(0)
04-23 12:53:49.391+0200 I/utils   (25866): specific action
04-23 12:53:49.391+0200 I/httppostreq(25866): internet connection check received
04-23 12:53:49.391+0200 I/httppostreq(25866): internet connection != null
04-23 12:53:49.391+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25866)
04-23 12:53:49.391+0200 I/CAPI_NETWORK_CONNECTION(25866): connection.c: connection_get_type(507) > Connected Network = 2
04-23 12:53:49.391+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.httppostreq
04-23 12:53:49.391+0200 I/httppostreq(25866): internet connection type...
04-23 12:53:49.391+0200 I/httppostreq(25866): internet connection type 1
04-23 12:53:49.401+0200 I/httppostreq(25866): internet available
04-23 12:53:49.401+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 12:53:49.401+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:49.401+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25866
04-23 12:53:49.421+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 25863
04-23 12:53:49.421+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 12:53:49.421+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(25863), cmd(0)
04-23 12:53:49.431+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:49.431+0200 I/utils   (25863): specific action
04-23 12:53:49.431+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:49.431+0200 W/CAPI_APPFW_APP_CONTROL(25863): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 12:53:49.431+0200 I/servicemanager(25863): internet connection available. stop all sensors
04-23 12:53:49.431+0200 W/AUL     (25866): launch.c: app_request_to_launchpad(298) > request cmd(0) result(25863)
04-23 12:53:49.431+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 12:53:49.431+0200 I/httppostreq(25866): request sent to service es.ugr.frailty.servicemanager
04-23 12:53:49.431+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:49.431+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:49.461+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:53:49.461+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26246
04-23 12:53:49.511+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26246
04-23 12:53:49.511+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.accelerometer) pid(26246) type(svcapp) bg(0)
04-23 12:53:49.521+0200 E/CAPI_APPFW_APPLICATION(26246): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:49.521+0200 E/CAPI_APPFW_APPLICATION(26246): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:49.521+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26246]
04-23 12:53:49.521+0200 I/utils   (26246): trying to start service: es.ugr.frailty.accelerometer
04-23 12:53:49.521+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26246) was created
04-23 12:53:49.521+0200 I/utils   (26246): es.ugr.frailty.accelerometer sensor supported
04-23 12:53:49.531+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26246)
04-23 12:53:49.531+0200 I/servicemanager(25863): es.ugr.frailty.accelerometer stop request sent!
04-23 12:53:49.531+0200 I/servicemanager(25863): App control destroyed.
04-23 12:53:49.531+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:49.531+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:49.531+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:49.531+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:49.531+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:49.531+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:49.531+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:49.531+0200 E/servicemanager(25863): deleting timer 0
04-23 12:53:49.531+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:49.531+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:49.531+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:49.531+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:49.531+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:49.531+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:49.531+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:49.531+0200 E/servicemanager(25863): deleting timer 1
04-23 12:53:49.531+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:53:49.541+0200 I/utils   (26246): es.ugr.frailty.accelerometer listener started
04-23 12:53:49.541+0200 I/accelerometer(26246): stopping es.ugr.frailty.accelerometer service
04-23 12:53:49.541+0200 E/CAPI_APPFW_APP_CONTROL(26246): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 12:53:49.541+0200 E/accelerometer(26246): request sending failed to service es.ugr.frailty.servicemanager
04-23 12:53:49.541+0200 I/CAPI_APPFW_APPLICATION(26246): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 12:53:49.541+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26246
04-23 12:53:49.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 12:53:49.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(999) > app status : 4
04-23 12:53:49.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:49.551+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:49.551+0200 E/servicemanager(25863): deleting timer 2
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:49.551+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:49.551+0200 E/servicemanager(25863): deleting timer 3
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:49.551+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:49.551+0200 E/servicemanager(25863): deleting timer 4
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:573 _ecore_magic_fail() 
04-23 12:53:49.551+0200 E/EFL     (25863): *** ECORE ERROR: Ecore Magic Check Failed!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** IN FUNCTION: ecore_timer_del()
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:577 _ecore_magic_fail()   Input handle has already been freed!
04-23 12:53:49.551+0200 E/EFL     (25863): ecore<25863> ecore.c:586 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** SPANK SPANK SPANK!!!
04-23 12:53:49.551+0200 E/EFL     (25863): *** Now go fix your code. Tut tut tut!
04-23 12:53:49.551+0200 E/servicemanager(25863): deleting timer 5
04-23 12:53:49.551+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 12:53:49.551+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 12:53:49.561+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 25863
04-23 12:53:49.571+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 26259
04-23 12:53:49.601+0200 E/RESOURCED( 2551): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 12:53:49.621+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 26259
04-23 12:53:49.621+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.recorder) pid(26259) type(svcapp) bg(0)
04-23 12:53:49.621+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:53:49.621+0200 W/STARTER ( 2693): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [26259]
04-23 12:53:49.631+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26246
04-23 12:53:49.631+0200 W/AUL     (25863): launch.c: app_request_to_launchpad(298) > request cmd(0) result(26259)
04-23 12:53:49.631+0200 I/servicemanager(25863): request sent to service es.ugr.frailty.recorder
04-23 12:53:49.631+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:53:49.651+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:53:49.661+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26259
04-23 12:53:49.661+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:53:49.661+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:53:49.671+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 12:53:49.681+0200 E/PKGMGR_INFO( 2979): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 12:53:49.681+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 26259
04-23 12:53:49.681+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 12:53:49.691+0200 E/CAPI_APPFW_APPLICATION(26259): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:49.691+0200 E/CAPI_APPFW_APPLICATION(26259): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 12:53:49.691+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (26259) was created
04-23 12:53:49.691+0200 I/utils   (26259): specific action
04-23 12:53:49.691+0200 I/recorder(26259): obteniendo datos locales...
04-23 12:53:49.691+0200 I/accelerometer(26246): es.ugr.frailty.accelerometer listener destroyed
04-23 12:53:49.711+0200 I/recorder(26259): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:31:960,9.865608,-0.136391,0.598206
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:32:156,0.155533,9.789038,0.674776
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:32:354,0.102891,9.812965,0.653241
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:32:553,0.162712,9.822537,0.619741
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:32:753,0.150748,9.789038,0.741775
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:32:954,0.090927,9.808180,0.674776
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:33:153,0.131605,9.798609,0.653241
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:33:353,0.172283,9.784252,0.710668
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:33:553,0.095713,9.817751,0.729811
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:33:759,0.098106,9.812965,0.693919
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:33:953,0.157926,9.784252,0.708275
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:34:153,0.141177,9.789038,0.672383
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:34:353,0.153141,9.846465,0.638884
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:34:553,0.126820,9.841680,0.780060
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:34:759,0.136391,9.812965,0.648455
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:34:959,0.138784,9.817751,0.732204
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:35:152,0.145962,9.798609,0.686740
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:35:353,0.177069,9.796216,0.705883
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:35:552,0.143569,9.834501,0.717847
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:35:759,0.107677,9.844072,0.684347
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:35:953,0.143569,9.810574,0.681954
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:36:152,0.174676,9.812965,0.722632
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:36:359,0.145962,9.841680,0.701097
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:36:559,0.157926,9.801002,0.679562
04-23 12:53:49.711+0200 I/recorder(26259): SM-R760,23/04/2018,12:53:36:752,0.143569,9.767502,0.669990
04-23 12:53:49.761+0200 W/CRASH_MANAGER(26197): worker.c: worker_job(1205) > 1126259726563152448082
