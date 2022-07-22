S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: recorder
PID: 6349
Date: 2018-04-23 18:31:59+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x522d4d5f

Register Information
r0   = 0xf7368250, r1   = 0x00000000
r2   = 0x2c303637, r3   = 0x522d4d53
r4   = 0xf7a427a8, r5   = 0x00000170
r6   = 0xf7a42918, r7   = 0xf7368250
r8   = 0x000006c8, r9   = 0xf6e4b824
r10  = 0xf79589d8, fp   = 0x00000000
ip   = 0xf7367030, sp   = 0xffedabc0
lr   = 0xf72ab5d0, pc   = 0xf72a79fc
cpsr = 0x60000010

Memory Information
MemTotal:   714612 KB
MemFree:     12148 KB
Buffers:     69128 KB
Cached:     215660 KB
VmPeak:      14280 KB
VmSize:      13252 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        8548 KB
VmRSS:        8548 KB
VmData:       3280 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:        7936 KB
VmPTE:          40 KB
VmSwap:          0 KB

Maps Information
f69e2000 f69e5000 r-xp /lib/libattr.so.1.1.0
f69ee000 f69f5000 r-xp /lib/libcrypt-2.13.so
f6a25000 f6a28000 r-xp /lib/libcap.so.2.21
f6a30000 f6a32000 r-xp /usr/lib/libiri.so
f6a3a000 f6a57000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6a60000 f6a64000 r-xp /usr/lib/libsmack.so.1.0.0
f6a6e000 f6a70000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6a78000 f6a7d000 r-xp /usr/lib/libffi.so.5.0.10
f6a85000 f6a86000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6a8e000 f6a90000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6a98000 f6a9a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6aa4000 f6ab4000 r-xp /lib/libresolv-2.13.so
f6ab8000 f6ad0000 r-xp /usr/lib/liblzma.so.5.0.3
f6ad8000 f6ada000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6ae2000 f6b11000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6b1a000 f6b29000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b32000 f6b3c000 r-xp /usr/lib/libsensord-shared.so
f6b45000 f6b79000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6b82000 f6c55000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6c60000 f6c76000 r-xp /lib/libz.so.1.2.5
f6c7e000 f6c84000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6c8d000 f6d02000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6d0c000 f6d26000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d2e000 f6d34000 r-xp /lib/librt-2.13.so
f6d3d000 f6d5b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d65000 f6d66000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d6e000 f6d73000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d7b000 f6e4b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e4c000 f6e76000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6e7f000 f6e96000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6e9e000 f6f07000 r-xp /lib/libm-2.13.so
f6f10000 f6fa4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6fb7000 f6fbc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6fc4000 f6fcb000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6fd3000 f6ffd000 r-xp /usr/lib/libsensor.so.1.9.6
f7006000 f70d2000 r-xp /usr/lib/libxml2.so.2.7.8
f70df000 f70e1000 r-xp /usr/lib/libiniparser.so.0
f70ea000 f70ed000 r-xp /usr/lib/libbundle.so.0.1.22
f70f5000 f70fb000 r-xp /usr/lib/libappsvc.so.0.1.0
f7103000 f7126000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f712e000 f716f000 r-xp /usr/lib/libeina.so.1.7.99
f7178000 f718f000 r-xp /usr/lib/libecore.so.1.7.99
f71a6000 f71af000 r-xp /usr/lib/libvconf.so.0.2.45
f71b7000 f71cb000 r-xp /lib/libpthread-2.13.so
f71d6000 f71e3000 r-xp /usr/lib/libaul.so.0.1.0
f71ed000 f71ef000 r-xp /lib/libdl-2.13.so
f71f8000 f7203000 r-xp /lib/libunwind.so.8.0.1
f7230000 f7238000 r-xp /lib/libgcc_s-4.6.so.1
f7239000 f735d000 r-xp /lib/libc-2.13.so
f736b000 f736d000 r-xp /usr/lib/libdlog.so.0.0.0
f7375000 f7381000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f738a000 f738f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7397000 f739b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f73a4000 f73a6000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
f73af000 f73b2000 r-xp /usr/lib/libappcore-agent.so.1.1
f73d0000 f73ed000 r-xp /lib/ld-2.13.so
f73f6000 f73f9000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/recorder
f73f9000 f73fd000 r-xp /usr/lib/libsys-assert.so
f794e000 f7a63000 rw-p [heap]
ffebc000 ffedd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6349)
Call Stack Count: 1
 0: (0xf72a79fc) [/lib/libc.so.6] + 0x6e9fc
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
1+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:460,-5.250000,-0.630000,-3.010000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:470,4.410000,0.560000,-2.660000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:483,3.430000,1.050000,0.280000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:499,-5.530000,-0.840000,0.560000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:513,-2.310000,-0.840000,0.420000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:526,0.140000,-0.280000,2.170000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:540,-0.070000,-1.820000,2.590000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:554,-3.080000,-0.560000,-0.770000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:580,2.660000,0.140000,-0.280000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:627,0.630000,0.630000,0.140000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:639,-1.330000,0.140000,0.280000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:654,-0.350000,-0.070000,0.770000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:667,-0.910000,-0.630000,-0.070000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:685,0.770000,-0.630000,-0.910000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:694,1.470000,-0.350000,0.350000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:708,-0.210000,0.350000,0.350000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:727,-0.560000,0.140000,0.560000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:735,-0.770000,-0.560000,2.240000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:804,-3.500000,-0.140000,-0.560000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:827,2.030000,-0.560000,0.910000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:844,-0.840000,-0.420000,0.420000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:867,-1.610000,-0.770000,0.070000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:972,0.630000,-0.350000,0.280000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:987,1.190000,0.630000,0.210000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:8,-0.700000,0.630000,0.630000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:27,-0.910000,1.260000,0.910000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:38,-0.560000,0.560000,1.190000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:53,-2.380000,0.490000,0.770000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:71,-1.820000,0.630000,0.420000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:87,1.750000,-0.560000,1.890000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:101,-2.940000,0.770000,-0.700000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:123,3.710000,0.490000,-0.700000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:145,1.540000,0.140000,-0.770000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:168,-1.750000,-1.400000,0.980000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:181,-6.020000,-0.420000,0.280000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:199,-3.080000,-0.980000,-0.630000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:221,-0.210000,0.980000,-0.490000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:239,-0.700000,2.100000,-1.820000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:252,0.280000,1.400000,0.210000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:408,-0.280000,1.190000,-0.350000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:427,3.850000,1.050000,0.280000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:439,-0.350000,1.260000,-0.560000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:449,-1.330000,0.910000,-0.560000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:457,-0.770000,0.210000,0.980000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:464,-1.960000,0.490000,0.980000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:515,1.820000,1.260000,0.490000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:298,1.260000,1.610000,0.420000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:302,-0.280000,1.190000,0.070000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:384,2.030000,1.190000,-0.210000
04-23 18:31:59.111+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:388,0.560000,1.260000,0.140000
04-23 18:31:59.131+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 18:31:59.131+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7078
04-23 18:31:59.141+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 18:31:59.151+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:31:59.151+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(5575), cmd(0)
04-23 18:31:59.151+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.151+0200 I/utils   ( 5575): specific action
04-23 18:31:59.151+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.151+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.151+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.151+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.151+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.151+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.151+0200 W/AUL     ( 5575): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 18:31:59.151+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:31:59.151+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 5575
04-23 18:31:59.161+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7025
04-23 18:31:59.171+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:31:59.171+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(7025), cmd(0)
04-23 18:31:59.171+0200 W/CAPI_APPFW_APP_CONTROL( 7025): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.171+0200 I/utils   ( 7025): specific action
04-23 18:31:59.171+0200 W/CAPI_APPFW_APP_CONTROL( 7025): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.171+0200 I/httppostreq( 7025): preparing HTTP POST Request for Service ID: es.ugr.frailty.accelerometer
04-23 18:31:59.171+0200 I/httppostreq( 7025): HTTP POST request data: service=es.ugr.frailty.accelerometer&data=SM-R760,23/04/2018,18:25:30:654,7.278966,0.533599,7.334002
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:30:851,6.465407,3.476771,6.120840
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:31:35,7.219146,4.070191,6.374479
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:31:236,6.228518,4.242475,5.857630
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:31:432,6.113662,7.415358,4.417150
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:31:632,4.857430,5.785845,6.288338
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:31:832,6.946364,3.766303,5.469993
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:32:30,8.664411,0.909273,5.860023
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:32:232,5.553742,2.864209,7.712067
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:32:432,5.563312,3.962514,7.329216
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:32:475,5.460421,4.515256,7.616355
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:32:490,5.467600,4.560720,7.255038
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:32:518,5.314459,4.235296,6.855437
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:32:548,5.123034,4.280759,6.812366
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:32:559,5.501099,4.043870,7.293324
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2018,18:25:32:574,5.139783,3.481557,6.874579
04-23 18:31:59.171+0200 I/httppostreq( 7025): SM-R760,23/04/2
04-23 18:31:59.181+0200 W/AUL     ( 5575): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7025)
04-23 18:31:59.181+0200 I/servicemanager( 5575): request sent to service es.ugr.frailty.httppostreq
04-23 18:31:59.181+0200 I/servicemanager( 5575): obteniendo datos locales. Datos recibidos
04-23 18:31:59.191+0200 W/AUL     ( 7093): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 18:31:59.191+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:392,-1.610000,1.190000,1.050000
04-23 18:31:59.191+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:402,2.520000,2.100000,1.610000
04-23 18:31:59.191+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:407,-10.850000,4.830000,-2.590000
04-23 18:31:59.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 18:31:59.191+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:411,-5.950000,1.470000,1.400000
04-23 18:31:59.191+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:419,2.520000,-1.750000,3.360000
04-23 18:31:59.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 18:31:59.191+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7044
04-23 18:31:59.191+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 18:31:59.191+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:438,11.760000,1.820000,3.360000
04-23 18:31:59.191+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:458,19.180000,4.480000,4.830000
04-23 18:31:59.191+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7044
04-23 18:31:59.191+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7044)
04-23 18:31:59.191+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:467,16.170000,5.880000,3.710000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:485,10.780000,6.230000,2.450000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:498,4.830000,1.610000,2.520000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:515,-2.870000,-2.170000,0.910000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:532,-6.300000,-4.340000,0.910000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:544,-5.040000,-3.220000,0.490000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:561,-2.310000,-1.400000,0.490000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:573,3.290000,-0.280000,0.280000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:588,3.150000,-0.140000,0.070000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:609,0.070000,-0.770000,-1.050000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:624,-0.840000,-0.070000,-0.560000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:636,-2.310000,0.490000,-1.190000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:647,-0.350000,-0.350000,-0.630000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:665,-3.710000,-3.010000,-0.280000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:679,-11.480000,-4.480000,0.210000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:716,-21.700001,-6.090000,-0.420000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:770,-32.340000,-8.610000,-1.540000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:781,-46.270000,-10.010000,0.210000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:799,-68.459999,-8.120000,4.200000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:811,-87.989998,-9.870000,7.490000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:865,-113.260002,-9.450000,8.330000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:885,-145.460007,-8.190000,7.210000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:948,-167.930008,1.260000,4.830000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:994,-106.330002,8.260000,14.420000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:67,-44.029999,19.460001,1.960000
04-23 18:31:59.201+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:116,6.440000,16.799999,2.310000
04-23 18:31:59.211+0200 I/utils   ( 7078): es.ugr.frailty.pedometer listener started
04-23 18:31:59.211+0200 I/pedometer( 7078): stopping es.ugr.frailty.pedometer service
04-23 18:31:59.211+0200 E/CAPI_APPFW_APP_CONTROL( 7078): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 18:31:59.211+0200 E/pedometer( 7078): request sending failed to service es.ugr.frailty.servicemanager
04-23 18:31:59.211+0200 I/CAPI_APPFW_APPLICATION( 7078): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 18:31:59.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 18:31:59.211+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 18:31:59.211+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:166,-5.810000,8.260000,-0.210000
04-23 18:31:59.211+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:272,-24.850000,9.800000,3.360000
04-23 18:31:59.221+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:383,-8.330000,7.420000,3.990000
04-23 18:31:59.221+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:578,4.760000,6.930000,1.890000
04-23 18:31:59.221+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:621,11.620000,4.830000,-0.070000
04-23 18:31:59.261+0200 W/AUL     ( 7097): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.httppostreq]
04-23 18:31:59.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 18:31:59.271+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 18:31:59.271+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 4513
04-23 18:31:59.271+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:657,15.400000,9.380000,-3.150000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:685,24.850000,9.590000,-3.850000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:706,29.680000,10.430000,-4.270000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:735,25.129999,10.500000,-6.020000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:764,20.230000,9.380000,-5.110000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:795,4.480000,6.090000,-2.380000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:835,-3.990000,4.480000,-0.560000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:63,-5.180000,-0.140000,0.490000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:79,-4.900000,0.350000,-0.490000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:147,0.980000,0.280000,-0.420000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:245,1.260000,1.050000,-0.490000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:284,-0.700000,1.400000,-0.210000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:394,-1.260000,0.420000,0.560000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:435,-3.640000,0.420000,0.420000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:470,-5.460000,-0.630000,1.540000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:503,-9.450000,0.210000,1.680000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:529,-8.610000,-0.070000,2.170000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:589,-3.850000,-2.310000,1.610000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:626,-4.270000,0.280000,0.630000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:639,0.840000,0.210000,-0.910000
04-23 18:31:59.281+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:685,5.530000,-0.280000,-1.050000
04-23 18:31:59.281+0200 I/recorder( 6349): obteniendo datos locales es.ugr.frailty.gyroscope
04-23 18:31:59.291+0200 I/recorder( 6349): obteniendo datos locales, DATA: SM-R760,23/04/2018,18:25:30:851,45.920002,4.760000,-10.080000
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:31:31,46.759998,7.630000,-5.600000
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:31:233,38.080002,23.730000,3.850000
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:31:432,54.040001,17.780001,-30.940001
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:31:631,-24.920000,-4.410000,24.150000
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:31:832,-60.619999,-14.560000,53.130001
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:32:30,-41.720001,22.960001,-15.120000
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:32:232,6.230000,6.440000,-15.470000
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:32:439,-1.260000,14.840000,-16.100000
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:32:479,5.250000,13.860000,-2.450000
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:32:490,10.850000,11.830000,4.760000
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:32:517,11.060000,14.910000,10.710000
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:32:551,6.650000,15.750000,17.360001
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:32:564,-1.330000,13.930000,22.190001
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:32:575,-12.810000,16.799999,25.340000
04-23 18:31:59.291+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:32:592,-17.360001,13.300000,24.85000
04-23 18:31:59.291+0200 W/AUL     ( 6349): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 18:31:59.291+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4513
04-23 18:31:59.291+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(4513)
04-23 18:31:59.291+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:31:59.291+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 6349
04-23 18:31:59.301+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5575
04-23 18:31:59.311+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.311+0200 I/utils   ( 5575): specific action
04-23 18:31:59.311+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.311+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.311+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.311+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.311+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.311+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.311+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.311+0200 W/AUL     ( 5575): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 18:31:59.311+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:31:59.311+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(5575), cmd(0)
04-23 18:31:59.321+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 18:31:59.321+0200 I/LOCATION( 7075): location.c: location_new(269) > method: 0
04-23 18:31:59.321+0200 W/LOCATION( 7075): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:31:59.331+0200 W/LOCATION( 7075): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:31:59.341+0200 W/AUL     ( 6349): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5575)
04-23 18:31:59.341+0200 I/recorder( 6349): request sent to service es.ugr.frailty.servicemanager
04-23 18:31:59.341+0200 I/recorder( 6349): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.heartrate.csv
04-23 18:31:59.341+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:42:786,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:42:987,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:43:187,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:43:386,88
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:43:587,88
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:43:787,88
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:44:16,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:44:199,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:44:396,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:44:587,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:44:787,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:44:987,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:45:205,87
04-23 18:31:59.341+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 5575
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:45:400,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:45:588,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:45:789,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:45:999,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:46:212,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:46:669,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:46:924,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:46:928,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:47:8,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:47:189,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:47:395,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:47:589,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:47:789,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:47:989,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:48:189,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:48:389,85
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:48:590,85
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:48:790,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:48:990,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:49:190,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:49:390,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:49:590,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:49:790,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:49:991,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:50:191,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:50:391,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:50:591,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:50:792,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:50:992,88
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:51:191,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:51:392,88
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:51:783,88
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:51:958,88
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:52:5,88
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:52:192,88
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:52:405,88
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:52:592,88
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:52:895,88
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:52:993,88
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:193,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:393,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:593,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:794,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:993,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:194,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:401,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:54:605,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:9,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:305,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:376,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:395,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:594,87
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:55:795,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:45,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:225,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:455,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:597,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:56:796,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:5,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:196,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:403,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:605,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:57:829,86
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:58:13,85
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:58:212,85
04-23 18:31:59.341+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:58:415,85
04-23 18:31:59.341+0200 I/recorder( 6349): obteniendo datos locales es.ugr.frailty.heartrate
04-23 18:31:59.351+0200 I/recorder( 6349): obteniendo datos locales, DATA: SM-R760,23/04/2018,18:25:42:786,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:42:987,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:43:187,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:43:386,88
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:43:587,88
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:43:787,88
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:44:16,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:44:199,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:44:396,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:44:587,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:44:787,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:44:987,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:45:205,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:45:400,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:45:588,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:45:789,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:45:999,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:46:212,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:46:669,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:46:924,87
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:46:928,86
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:47:8,86
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:47:189,86
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:47:395,86
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:47:589,86
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:47:789,86
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:47:989,86
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:48:189,86
04-23 18:31:59.351+0200 I/recorder( 6349): SM-R760,23/04/
04-23 18:31:59.351+0200 W/AUL     ( 6349): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 18:31:59.351+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 7099
04-23 18:31:59.351+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 18:31:59.361+0200 W/LOCATION( 7075): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:31:59.361+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 18:31:59.371+0200 W/LOCATION( 7075): module-internal.c: module_new(311) > module (gps) open success
04-23 18:31:59.371+0200 W/LOCATION( 7075): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 18:31:59.371+0200 W/LOCATION( 7075): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 18:31:59.371+0200 W/LOCATION( 7075): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:31:59.371+0200 W/LOCATION( 7075): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:31:59.371+0200 W/LOCATION( 7075): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:31:59.401+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 7099
04-23 18:31:59.401+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.httppostreq) pid(7099) type(svcapp) bg(0)
04-23 18:31:59.401+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:31:59.411+0200 W/AUL     ( 5575): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7099)
04-23 18:31:59.411+0200 I/servicemanager( 5575): request sent to service es.ugr.frailty.httppostreq
04-23 18:31:59.411+0200 I/servicemanager( 5575): obteniendo datos locales. Datos recibidos
04-23 18:31:59.411+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 18:31:59.411+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 6349
04-23 18:31:59.421+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 18:31:59.421+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 5575
04-23 18:31:59.441+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [7099]
04-23 18:31:59.441+0200 W/AUL     ( 6349): launch.c: app_request_to_launchpad(298) > request cmd(0) result(5575)
04-23 18:31:59.441+0200 I/recorder( 6349): request sent to service es.ugr.frailty.servicemanager
04-23 18:31:59.441+0200 I/recorder( 6349): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:31:649,768.903856,37.171551,-3.593352,0.000000,0,0.000000,12.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:34:914,nan,37.171550,-3.593163,0.000000,0,0.000000,101.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:41:979,nan,37.171550,-3.593163,0.000000,0,0.000000,101.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:45:283,nan,37.171669,-3.594157,0.000000,0,0.000000,44.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:25:53:546,808.294427,37.171704,-3.593052,0.000000,0,0.000000,16.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:26:01:584,789.577621,37.171611,-3.593128,0.000000,0,0.000000,16.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:26:31:416,789.577621,37.171611,-3.593128,0.000000,0,0.000000,16.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:27:00:209,789.577621,37.171611,-3.593128,0.000000,0,0.000000,16.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:27:30:395,789.577621,37.171611,-3.593128,0.000000,0,0.000000,16.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:28:00:556,789.577621,37.171611,-3.593128,0.000000,0,0.000000,16.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:28:30:330,789.577621,37.171611,-3.593128,0.000000,0,0.000000,16.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:29:00:350,789.577621,37.171611,-3.593128,0.000000,0,0.000000,16.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:29:30:396,789.577621,37.171611,-3.593128,0.000000,0,0.000000,16.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:30:00:256,789.577621,37.171611,-3.593128,0.000000,0,0.000000,16.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:30:30:305,789.577621,37.171611,-3.593128,0.000000,0,0.000000,16.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:31:00:363,789.577621,37.171611,-3.593128,0.000000,0,0.000000,16.000000,-1.000000
04-23 18:31:59.441+0200 I/recorder( 6349): SM-R760,23/04/2018,18:31:30:533,789.577621,37.171611,-3.593128,0.000000,0,0.000000,16.000000,-1.000000
04-23 18:31:59.451+0200 I/pedometer( 7078): es.ugr.frailty.pedometer listener destroyed
04-23 18:31:59.451+0200 E/CAPI_APPFW_APPLICATION( 7099): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 18:31:59.451+0200 E/CAPI_APPFW_APPLICATION( 7099): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 18:31:59.461+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 18:31:59.461+0200 I/heartrate( 7054): es.ugr.frailty.heartrate listener destroyed
04-23 18:31:59.471+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7099
04-23 18:31:59.471+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (7099) was created
04-23 18:31:59.471+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 18:31:59.481+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:31:59.481+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(5575), cmd(0)
04-23 18:31:59.481+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.481+0200 I/utils   ( 5575): specific action
04-23 18:31:59.481+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.481+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.481+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.481+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.481+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.481+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.481+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.481+0200 W/CAPI_APPFW_APP_CONTROL( 5575): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.481+0200 W/AUL     ( 5575): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-23 18:31:59.481+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:31:59.491+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 5575
04-23 18:31:59.491+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 7099
04-23 18:31:59.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 18:31:59.511+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 7099
04-23 18:31:59.511+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 18:31:59.531+0200 W/AUL     ( 5575): launch.c: app_request_to_launchpad(298) > request cmd(0) result(7099)
04-23 18:31:59.531+0200 W/LOCATION( 7075): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 18:31:59.531+0200 I/servicemanager( 5575): request sent to service es.ugr.frailty.httppostreq
04-23 18:31:59.531+0200 W/LOCATION( 7075): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 18:31:59.541+0200 W/LOCATION( 7075): module-internal.c: module_new(311) > module (wps) open success
04-23 18:31:59.541+0200 I/servicemanager( 5575): obteniendo datos locales. Datos recibidos
04-23 18:31:59.541+0200 W/LOCATION( 7075): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 18:31:59.541+0200 W/LOCATION( 7075): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 18:31:59.541+0200 W/LOCATION( 7075): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 18:31:59.541+0200 W/LOCATION( 7075): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 18:31:59.571+0200 W/LOCATION( 7075): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 18:31:59.571+0200 I/LOCATION( 7075): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7935c18
04-23 18:31:59.571+0200 I/LOCATION( 7075): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 18:31:59.571+0200 I/LOCATION( 7075): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7935c18
04-23 18:31:59.571+0200 I/LOCATION( 7075): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 18:31:59.571+0200 I/location( 7075): es.ugr.frailty.location: creado servicio de localización
04-23 18:31:59.591+0200 W/AUL     ( 7104): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.heartrate]
04-23 18:31:59.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 18:31:59.591+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 18:31:59.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7054
04-23 18:31:59.591+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 18:31:59.601+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7054
04-23 18:31:59.601+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7054)
04-23 18:31:59.611+0200 W/AUL     ( 7105): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.pedometer]
04-23 18:31:59.611+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 18:31:59.611+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 18:31:59.611+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 7078
04-23 18:31:59.611+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 18:31:59.611+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 7078
04-23 18:31:59.611+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(7078)
04-23 18:31:59.631+0200 I/CAPI_NETWORK_CONNECTION( 7099): connection.c: connection_create(453) > New handle created[0xf73611c0]
04-23 18:31:59.631+0200 I/httppostreq( 7099): internet creating connection
04-23 18:31:59.631+0200 W/CAPI_APPFW_APP_CONTROL( 7099): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.631+0200 I/utils   ( 7099): specific action
04-23 18:31:59.631+0200 W/CAPI_APPFW_APP_CONTROL( 7099): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.631+0200 W/CAPI_APPFW_APP_CONTROL( 7099): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:31:59.631+0200 I/httppostreq( 7099): preparing HTTP POST Request for Service ID: es.ugr.frailty.gyroscope
04-23 18:31:59.631+0200 I/httppostreq( 7099): HTTP POST request data: service=es.ugr.frailty.gyroscope&data=SM-R760,23/04/2018,18:25:30:851,45.920002,4.760000,-10.080000
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:31:31,46.759998,7.630000,-5.600000
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:31:233,38.080002,23.730000,3.850000
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:31:432,54.040001,17.780001,-30.940001
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:31:631,-24.920000,-4.410000,24.150000
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:31:832,-60.619999,-14.560000,53.130001
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:32:30,-41.720001,22.960001,-15.120000
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:32:232,6.230000,6.440000,-15.470000
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:32:439,-1.260000,14.840000,-16.100000
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:32:479,5.250000,13.860000,-2.450000
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:32:490,10.850000,11.830000,4.760000
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:32:517,11.060000,14.910000,10.710000
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:32:551,6.650000,15.750000,17.360001
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:32:564,-1.330000,13.930000,22.190001
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:32:575,-12.810000,16.799999,25.340000
04-23 18:31:59.631+0200 I/httppostreq( 7099): SM-R760,23/04/2018,18:25:32:592
04-23 18:31:59.651+0200 I/LOCATION( 7075): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 18:31:59.691+0200 W/LOCATION( 7075): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:31:59.691+0200 W/LOCATION( 7075): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:31:59.691+0200 I/LOCATION( 7075): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:31:59.771+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 18:31:59.771+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:31:59.771+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(17), pid(7099), cmd(0)
04-23 18:31:59.771+0200 W/AUL     ( 7111): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.httppostreq]
04-23 18:31:59.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 18:31:59.771+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 18:31:59.771+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 4564
04-23 18:31:59.771+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 18:31:59.791+0200 W/AUL     ( 7112): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.recorder]
04-23 18:31:59.791+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 18:31:59.791+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 18:31:59.791+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 5582
04-23 18:31:59.791+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 18:31:59.801+0200 W/CRASH_MANAGER( 7108): worker.c: worker_job(1205) > 1106349726563152450111
