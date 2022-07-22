S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: httppostreq
PID: 12106
Date: 2018-04-12 19:37:12+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/httppostreq
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x392c3532

Register Information
r0   = 0x00000000, r1   = 0xf7660738
r2   = 0x00000000, r3   = 0x00000000
r4   = 0x31373236, r5   = 0x2e302c32
r6   = 0xf7277a35, r7   = 0x30353530
r8   = 0x00000041, r9   = 0xf7314824
r10  = 0xf79f3dd8, fp   = 0x00000000
ip   = 0x00000020, sp   = 0xffef7ec8
lr   = 0xf763d9f8, pc   = 0x392c3532
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     48100 KB
Buffers:     55104 KB
Cached:     225856 KB
VmPeak:      21180 KB
VmSize:      21176 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:        9128 KB
VmRSS:        9128 KB
VmData:       9636 KB
VmStk:         136 KB
VmExe:           8 KB
VmLib:        9612 KB
VmPTE:          44 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 12106 TID = 12106
12106 12109 

Maps Information
f62da000 f6ade000 rw-p [stack:12109]
f6ade000 f6ae0000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6ae8000 f6aea000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6af4000 f6b04000 r-xp /usr/lib/libmdm-common.so.1.1.24
f6b0c000 f6b0e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6b16000 f6b1b000 r-xp /usr/lib/libffi.so.5.0.10
f6b23000 f6b24000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b2c000 f6b3c000 r-xp /lib/libresolv-2.13.so
f6b41000 f6b59000 r-xp /usr/lib/liblzma.so.5.0.3
f6b61000 f6b63000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6b6b000 f6b85000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6b8d000 f6c59000 r-xp /usr/lib/libxml2.so.2.7.8
f6c66000 f6c68000 r-xp /usr/lib/libiniparser.so.0
f6c71000 f6cba000 r-xp /usr/lib/libmdm.so.1.2.69
f6cc2000 f6cc8000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6cd0000 f6d04000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6d0d000 f6de0000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6deb000 f6df1000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6dfa000 f6e6f000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6e79000 f6ee2000 r-xp /lib/libm-2.13.so
f6eeb000 f6ef1000 r-xp /lib/librt-2.13.so
f6efa000 f6f18000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f22000 f6f23000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6f2b000 f6f4e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f56000 f6f5b000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f63000 f6f8d000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f96000 f6fad000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6fb5000 f6fcb000 r-xp /lib/libz.so.1.2.5
f6fd3000 f717c000 r-xp /usr/lib/libcrypto.so.1.0.0
f719c000 f71e3000 r-xp /usr/lib/libssl.so.1.0.0
f71ef000 f721d000 r-xp /usr/lib/libidn.so.11.5.44
f7225000 f722e000 r-xp /usr/lib/libcares.so.2.1.0
f7237000 f723c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f7244000 f7314000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f7315000 f732e000 r-xp /usr/lib/libnetwork.so.0.0.0
f7336000 f7339000 r-xp /usr/lib/libbundle.so.0.1.22
f7341000 f7347000 r-xp /usr/lib/libappsvc.so.0.1.0
f734f000 f7390000 r-xp /usr/lib/libeina.so.1.7.99
f7399000 f73b0000 r-xp /usr/lib/libecore.so.1.7.99
f73c7000 f73d0000 r-xp /usr/lib/libvconf.so.0.2.45
f73d8000 f73ec000 r-xp /lib/libpthread-2.13.so
f73f7000 f7404000 r-xp /usr/lib/libaul.so.0.1.0
f740e000 f7410000 r-xp /lib/libdl-2.13.so
f7419000 f7424000 r-xp /lib/libunwind.so.8.0.1
f7451000 f7459000 r-xp /lib/libgcc_s-4.6.so.1
f745a000 f757e000 r-xp /lib/libc-2.13.so
f758c000 f758e000 r-xp /usr/lib/libdlog.so.0.0.0
f7596000 f75da000 r-xp /usr/lib/libcurl.so.4.3.0
f75e3000 f75f3000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f75fb000 f75ff000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7608000 f760b000 r-xp /usr/lib/libappcore-agent.so.1.1
f7629000 f7646000 r-xp /lib/ld-2.13.so
f764f000 f7651000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/httppostreq
f7651000 f7655000 r-xp /usr/lib/libsys-assert.so
f79ef000 f7a52000 rw-p [heap]
ffed8000 ffef9000 rw-p [stack]
End of Maps Information

Callstack Information (PID:12106)
Call Stack Count: 1
 0: (0x392c3532) (null)
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: httppostreq
App ID: es.ugr.frailty.httppostreq
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
0.066999,9.827322
04-12 19:36:40.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:40
04-12 19:36:40.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:40,0.203390,0.040678,9.817751
04-12 19:36:40.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:40
04-12 19:36:40.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:40,0.174676,0.050249,9.875179
04-12 19:36:40.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:40
04-12 19:36:40.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:40,0.179462,0.050249,9.865608
04-12 19:36:40.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:40
04-12 19:36:40.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:40,0.210568,0.055035,9.832108
04-12 19:36:41.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:41
04-12 19:36:41.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:41,0.184247,0.016750,9.808180
04-12 19:36:41.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:41
04-12 19:36:41.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:41,0.162712,0.052642,9.805787
04-12 19:36:41.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:41
04-12 19:36:41.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:41,0.212961,0.007178,9.829715
04-12 19:36:41.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:41
04-12 19:36:41.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:41,0.155533,0.009571,9.810574
04-12 19:36:41.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:41
04-12 19:36:41.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:41,0.162712,0.002393,9.805787
04-12 19:36:42.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:42
04-12 19:36:42.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:42,0.177069,0.031107,9.796216
04-12 19:36:42.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:42
04-12 19:36:42.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:42,0.165105,0.064606,9.839286
04-12 19:36:42.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:42
04-12 19:36:42.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:42,0.179462,0.021535,9.844072
04-12 19:36:42.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:42
04-12 19:36:42.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:42,0.174676,0.014357,9.836893
04-12 19:36:42.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:42
04-12 19:36:42.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:42,0.172283,0.045464,9.822537
04-12 19:36:43.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:43
04-12 19:36:43.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:43,0.153141,0.045464,9.848858
04-12 19:36:43.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:43
04-12 19:36:43.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:43,0.169890,0.045464,9.829715
04-12 19:36:43.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:43
04-12 19:36:43.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:43,0.157926,0.035892,9.676575
04-12 19:36:43.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:43
04-12 19:36:43.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:43,0.160319,-0.038285,9.863215
04-12 19:36:43.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:43
04-12 19:36:43.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:43,0.191426,0.031107,9.844072
04-12 19:36:44.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:44
04-12 19:36:44.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:44,0.157926,0.033500,9.851252
04-12 19:36:44.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:44
04-12 19:36:44.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:44,0.222532,0.004786,9.824929
04-12 19:36:44.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:44
04-12 19:36:44.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:44,0.150748,0.064606,9.796216
04-12 19:36:44.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:44
04-12 19:36:44.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:44,0.179462,0.088534,9.844072
04-12 19:36:44.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:44
04-12 19:36:44.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:44,0.145962,0.043071,9.851252
04-12 19:36:45.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:45
04-12 19:36:45.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:45,0.157926,0.019143,9.822537
04-12 19:36:45.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:45
04-12 19:36:45.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:45,0.160319,0.031107,9.884750
04-12 19:36:45.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:45
04-12 19:36:45.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:45,0.167498,0.019143,9.836893
04-12 19:36:45.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:45
04-12 19:36:45.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:45,0.165105,0.066999,9.839286
04-12 19:36:45.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:45
04-12 19:36:45.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:45,0.162712,0.019143,9.841680
04-12 19:36:46.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:46
04-12 19:36:46.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:46,0.184247,0.078963,9.815358
04-12 19:36:46.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:46
04-12 19:36:46.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:46,0.196211,0.031107,9.824929
04-12 19:36:46.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:46
04-12 19:36:46.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:46,0.193819,0.076570,9.817751
04-12 19:36:46.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:46
04-12 19:36:46.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:46,0.186640,0.050249,9.812965
04-12 19:36:46.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:46
04-12 19:36:46.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:46,0.150748,0.062213,9.839286
04-12 19:36:47.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:47
04-12 19:36:47.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:47,0.150748,0.055035,9.803394
04-12 19:36:47.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:47
04-12 19:36:47.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:47,0.133998,0.090927,9.860823
04-12 19:36:47.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:47
04-12 19:36:47.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:47,0.153141,0.016750,9.834501
04-12 19:36:47.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:47
04-12 19:36:47.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:47,0.177069,0.066999,9.803394
04-12 19:36:47.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:47
04-12 19:36:47.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:47,0.165105,0.066999,9.863215
04-12 19:36:48.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:48
04-12 19:36:48.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:48,0.193819,0.004786,9.815358
04-12 19:36:48.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:48
04-12 19:36:48.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:48,0.179462,0.023928,9.841680
04-12 19:36:48.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:48
04-12 19:36:48.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:48,0.189033,0.047856,9.824929
04-12 19:36:48.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:48
04-12 19:36:48.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:48,0.193819,0.035892,9.781858
04-12 19:36:48.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:48
04-12 19:36:48.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:48,0.229711,0.055035,9.841680
04-12 19:36:49.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:49
04-12 19:36:49.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:49,0.150748,0.045464,9.817751
04-12 19:36:49.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:49
04-12 19:36:49.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:49,0.148355,0.055035,9.832108
04-12 19:36:49.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:49
04-12 19:36:49.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:49,0.162712,0.055035,9.836893
04-12 19:36:49.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:49
04-12 19:36:49.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:49,0.220140,-0.023928,9.839286
04-12 19:36:49.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:49
04-12 19:36:49.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:49,0.208176,0.071785,9.824929
04-12 19:36:50.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:50
04-12 19:36:50.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:50,0.222532,0.019143,9.877571
04-12 19:36:50.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:50
04-12 19:36:50.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:50,0.191426,-0.026321,9.784252
04-12 19:36:50.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:50
04-12 19:36:50.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:50,0.191426,0.040678,9.832108
04-12 19:36:50.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:50
04-12 19:36:50.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:50,0.177069,-0.009571,9.856036
04-12 19:36:50.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:50
04-12 19:36:50.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:50,0.160319,0.055035,9.851252
04-12 19:36:51.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:51
04-12 19:36:51.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:51,0.169890,0.093320,9.860823
04-12 19:36:51.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:51
04-12 19:36:51.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:51,0.208176,0.002393,9.827322
04-12 19:36:51.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:51
04-12 19:36:51.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:51,0.174676,0.031107,9.801002
04-12 19:36:51.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:51
04-12 19:36:51.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:51,0.155533,0.088534,9.870394
04-12 19:36:51.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:51
04-12 19:36:51.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:51,0.205783,0.038285,9.815358
04-12 19:36:52.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:52
04-12 19:36:52.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:52,0.193819,0.016750,9.844072
04-12 19:36:52.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:52
04-12 19:36:52.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:52,0.196211,0.047856,9.815358
04-12 19:36:52.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:52
04-12 19:36:52.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:52,0.157926,0.021535,9.815358
04-12 19:36:52.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:52
04-12 19:36:52.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:52,0.148355,0.033500,9.815358
04-12 19:36:52.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:52
04-12 19:36:52.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:52,0.189033,0.038285,9.805787
04-12 19:36:53.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:53
04-12 19:36:53.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:53,0.210568,0.059821,9.882358
04-12 19:36:53.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:53
04-12 19:36:53.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:53,0.167498,0.059821,9.863215
04-12 19:36:53.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:53
04-12 19:36:53.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:53,0.198604,-0.026321,9.789038
04-12 19:36:53.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:53
04-12 19:36:53.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:53,0.189033,0.059821,9.872787
04-12 19:36:53.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:53
04-12 19:36:53.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:53,0.193819,0.009571,9.841680
04-12 19:36:54.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:54
04-12 19:36:54.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:54,0.131605,0.059821,9.858429
04-12 19:36:54.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:54
04-12 19:36:54.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:54,0.157926,0.071785,9.851252
04-12 19:36:54.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:54
04-12 19:36:54.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:54,0.150748,0.047856,9.781858
04-12 19:36:54.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:54
04-12 19:36:54.659+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:54,0.193819,0.019143,9.801002
04-12 19:36:54.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:54
04-12 19:36:54.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:54,0.186640,0.023928,9.817751
04-12 19:36:55.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:55
04-12 19:36:55.059+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:55,0.157926,0.059821,9.822537
04-12 19:36:55.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:55
04-12 19:36:55.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:55,0.220140,-0.019143,9.801002
04-12 19:36:55.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:55
04-12 19:36:55.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:55,0.145962,0.069392,9.822537
04-12 19:36:55.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:55
04-12 19:36:55.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:55,0.153141,0.023928,9.853643
04-12 19:36:55.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:55
04-12 19:36:55.859+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:55,0.162712,0.033500,9.827322
04-12 19:36:56.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:56
04-12 19:36:56.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:56,0.172283,0.011964,9.829715
04-12 19:36:56.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:56
04-12 19:36:56.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:56,0.181855,0.023928,9.832108
04-12 19:36:56.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:56
04-12 19:36:56.459+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:56,0.200997,0.002393,9.856036
04-12 19:36:56.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:56
04-12 19:36:56.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:56,0.184247,0.047856,9.812965
04-12 19:36:56.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:56
04-12 19:36:56.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:56,0.172283,0.004786,9.839286
04-12 19:36:57.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:57
04-12 19:36:57.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:57,0.155533,0.038285,9.810574
04-12 19:36:57.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:57
04-12 19:36:57.259+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:57,0.112463,0.102891,9.879964
04-12 19:36:57.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:57
04-12 19:36:57.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:57,0.189033,0.074178,9.844072
04-12 19:36:57.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:57
04-12 19:36:57.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:57,0.200997,0.023928,9.767502
04-12 19:36:57.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:57
04-12 19:36:57.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:57,0.174676,0.052642,9.863215
04-12 19:36:58.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:58
04-12 19:36:58.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:58,0.179462,0.043071,9.839286
04-12 19:36:58.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:58
04-12 19:36:58.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:58,0.165105,0.019143,9.824929
04-12 19:36:58.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:58
04-12 19:36:58.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:58,0.157926,0.045464,9.798609
04-12 19:36:58.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:58
04-12 19:36:58.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:58,0.181855,0.031107,9.844072
04-12 19:36:58.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:58
04-12 19:36:58.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:58,0.177069,0.047856,9.817751
04-12 19:36:59.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:59
04-12 19:36:59.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:59,0.157926,0.043071,9.817751
04-12 19:36:59.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:59
04-12 19:36:59.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:59,0.165105,0.050249,9.901501
04-12 19:36:59.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:59
04-12 19:36:59.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:59,0.160319,0.031107,9.844072
04-12 19:36:59.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:59
04-12 19:36:59.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:59,0.184247,0.076570,9.846465
04-12 19:36:59.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:36:59
04-12 19:36:59.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:36:59,0.186640,0.050249,9.827322
04-12 19:37:00.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:00
04-12 19:37:00.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:00,0.196211,0.026321,9.827322
04-12 19:37:00.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:00
04-12 19:37:00.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:00,0.234497,0.023928,9.798609
04-12 19:37:00.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:00
04-12 19:37:00.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:00,0.145962,0.004786,9.832108
04-12 19:37:00.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:00
04-12 19:37:00.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:00,0.208176,0.009571,9.796216
04-12 19:37:00.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:00
04-12 19:37:00.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:00,0.119641,0.086142,9.882358
04-12 19:37:01.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:01
04-12 19:37:01.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:01,0.160319,0.052642,9.839286
04-12 19:37:01.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:01
04-12 19:37:01.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:01,0.181855,0.026321,9.822537
04-12 19:37:01.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:01
04-12 19:37:01.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:01,0.198604,0.050249,9.789038
04-12 19:37:01.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:01
04-12 19:37:01.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:01,0.167498,0.033500,9.803394
04-12 19:37:01.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:01
04-12 19:37:01.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:01,0.157926,0.028714,9.858429
04-12 19:37:02.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:02
04-12 19:37:02.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:02,0.177069,0.026321,9.858429
04-12 19:37:02.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:02
04-12 19:37:02.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:02,0.196211,0.069392,9.810574
04-12 19:37:02.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:02
04-12 19:37:02.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:02,0.186640,0.035892,9.810574
04-12 19:37:02.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:02
04-12 19:37:02.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:02,0.162712,0.055035,9.839286
04-12 19:37:02.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:02
04-12 19:37:02.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:02,0.189033,0.035892,9.844072
04-12 19:37:03.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:03
04-12 19:37:03.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:03,0.177069,0.047856,9.803394
04-12 19:37:03.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:03
04-12 19:37:03.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:03,0.167498,-0.014357,9.851252
04-12 19:37:03.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:03
04-12 19:37:03.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:03,0.200997,0.045464,9.839286
04-12 19:37:03.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:03
04-12 19:37:03.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:03,0.215354,0.028714,9.796216
04-12 19:37:03.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:03
04-12 19:37:03.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:03,0.189033,0.050249,9.863215
04-12 19:37:04.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:04
04-12 19:37:04.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:04,0.189033,0.016750,9.846465
04-12 19:37:04.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:04
04-12 19:37:04.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:04,0.165105,0.064606,9.870394
04-12 19:37:04.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:04
04-12 19:37:04.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:04,0.177069,0.014357,9.829715
04-12 19:37:04.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:04
04-12 19:37:04.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:04,0.189033,0.074178,9.844072
04-12 19:37:04.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:04
04-12 19:37:04.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:04,0.212961,0.050249,9.851252
04-12 19:37:05.039+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:05
04-12 19:37:05.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:05,0.162712,0.055035,9.875179
04-12 19:37:05.239+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:05
04-12 19:37:05.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:05,0.167498,0.014357,9.808180
04-12 19:37:05.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:05
04-12 19:37:05.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:05,0.148355,0.014357,9.801002
04-12 19:37:05.649+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:05
04-12 19:37:05.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:05,0.203390,0.052642,9.824929
04-12 19:37:05.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:05
04-12 19:37:05.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:05,0.184247,0.033500,9.827322
04-12 19:37:06.049+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:06
04-12 19:37:06.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:06,0.172283,0.016750,9.844072
04-12 19:37:06.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:06
04-12 19:37:06.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:06,0.129212,0.040678,9.841680
04-12 19:37:06.449+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:06
04-12 19:37:06.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:06,0.133998,0.009571,9.870394
04-12 19:37:06.639+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:06
04-12 19:37:06.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:06,0.141177,0.062213,9.829715
04-12 19:37:06.839+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:06
04-12 19:37:06.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:06,0.150748,0.026321,9.846465
04-12 19:37:07.039+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:07
04-12 19:37:07.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:07,0.155533,0.098106,9.851252
04-12 19:37:07.239+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:07
04-12 19:37:07.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:07,0.172283,-0.004786,9.803394
04-12 19:37:07.439+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:07
04-12 19:37:07.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:07,0.133998,0.019143,9.786645
04-12 19:37:07.639+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:07
04-12 19:37:07.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:07,0.186640,0.062213,9.839286
04-12 19:37:07.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:07
04-12 19:37:07.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:07,0.191426,0.004786,9.798609
04-12 19:37:08.039+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:08
04-12 19:37:08.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:08,0.184247,0.023928,9.812965
04-12 19:37:08.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:08
04-12 19:37:08.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:08,0.200997,0.014357,9.808180
04-12 19:37:08.439+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:08
04-12 19:37:08.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:08,0.155533,0.031107,9.894321
04-12 19:37:08.639+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:08
04-12 19:37:08.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:08,0.186640,0.045464,9.841680
04-12 19:37:08.839+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:08
04-12 19:37:08.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:08,0.150748,0.074178,9.839286
04-12 19:37:09.039+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:09
04-12 19:37:09.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:09,0.172283,0.062213,9.820145
04-12 19:37:09.239+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:09
04-12 19:37:09.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:09,0.177069,0.035892,9.817751
04-12 19:37:09.439+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:09
04-12 19:37:09.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:09,0.198604,0.023928,9.822537
04-12 19:37:09.639+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:09
04-12 19:37:09.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:09,0.181855,0.081356,9.872787
04-12 19:37:09.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:09
04-12 19:37:09.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:09,0.198604,0.035892,9.805787
04-12 19:37:10.039+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:10
04-12 19:37:10.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:10,0.181855,0.035892,9.832108
04-12 19:37:10.249+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:10
04-12 19:37:10.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:10,0.220140,0.007178,9.889536
04-12 19:37:10.439+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:10
04-12 19:37:10.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:10,0.165105,0.071785,9.841680
04-12 19:37:10.639+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:10
04-12 19:37:10.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:10,0.203390,0.040678,9.820145
04-12 19:37:10.849+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:10
04-12 19:37:10.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:10,0.200997,0.043071,9.853643
04-12 19:37:11.039+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:11
04-12 19:37:11.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:11,0.162712,0.021535,9.812965
04-12 19:37:11.239+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:11
04-12 19:37:11.249+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:11,0.193819,0.033500,9.832108
04-12 19:37:11.439+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:11
04-12 19:37:11.449+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:11,0.179462,0.064606,9.846465
04-12 19:37:11.639+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:11
04-12 19:37:11.649+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:11,0.177069,0.033500,9.824929
04-12 19:37:11.839+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:11
04-12 19:37:11.849+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:11,0.193819,0.064606,9.832108
04-12 19:37:12.039+0200 I/utils   (12114): accelerometer utils fecha 12/04/2018,19:37:12
04-12 19:37:12.049+0200 I/accelerometer(12114): accelerometer: SM-R760,12/04/2018,19:37:12,0.208176,0.033500,9.841680
04-12 19:37:12.239+0200 I/servicemanager(12103): accelerometer sleep timeout
04-12 19:37:12.239+0200 W/AUL     (12103): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-12 19:37:12.239+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:37:12.239+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 12103
04-12 19:37:12.259+0200 W/AUL_AMD ( 2499): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12114
04-12 19:37:12.259+0200 W/AUL     (12103): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12114)
04-12 19:37:12.259+0200 I/servicemanager(12103): es.ugr.frailty.accelerometer stop request sent!
04-12 19:37:12.259+0200 I/servicemanager(12103): App control destroyed.
04-12 19:37:12.259+0200 E/AUL_AMD ( 2499): amd_launch.c: __real_send(909) > send fail to client
04-12 19:37:12.259+0200 W/AUL_AMD ( 2499): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(12114), cmd(0)
04-12 19:37:12.259+0200 I/accelerometer(12114): Stopping es.ugr.frailty.accelerometer service
04-12 19:37:12.259+0200 W/AUL     (12114): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-12 19:37:12.269+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:37:12.269+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 12114
04-12 19:37:12.279+0200 W/AUL_AMD ( 2499): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12103
04-12 19:37:12.289+0200 E/AUL_AMD ( 2499): amd_launch.c: __real_send(909) > send fail to client
04-12 19:37:12.289+0200 W/AUL_AMD ( 2499): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(12103), cmd(0)
04-12 19:37:12.289+0200 W/CAPI_APPFW_APP_CONTROL(12103): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:37:12.289+0200 I/servicemanager(12103): Requesting Record Service. Service ID: es.ugr.frailty.accelerometer
04-12 19:37:12.289+0200 I/servicemanager(12103): Requesting Record Service. Data received: SM-R760,12/04/2018,19:36:12,0.191426,0.050249,9.841680
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.177069,0.028714,9.856036
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.160319,0.045464,9.805787
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.193819,0.078963,9.851252
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.224925,0.019143,9.846465
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.177069,0.021535,9.822537
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.196211,0.059821,9.793823
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.184247,0.023928,9.791430
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.203390,0.031107,9.834501
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.179462,0.076570,9.829715
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.179462,0.004786,9.827322
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.148355,0.019143,9.810574
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.203390,0.043071,9.848858
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.138784,0.055035,9.781858
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.133998,0.009571,9.846465
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.155533,0.033500,9.841680
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.172283,0.011964,9.824929
04-12 19:37:12.289+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:14,0.141177,0.081356,
04-12 19:37:12.289+0200 W/AUL     (12103): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-12 19:37:12.299+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:37:12.299+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 12103
04-12 19:37:12.319+0200 W/AUL_AMD ( 2499): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12111
04-12 19:37:12.319+0200 E/AUL_AMD ( 2499): amd_launch.c: __real_send(909) > send fail to client
04-12 19:37:12.319+0200 W/AUL_AMD ( 2499): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(12111), cmd(0)
04-12 19:37:12.329+0200 W/CAPI_APPFW_APP_CONTROL(12111): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:37:12.329+0200 I/recorder(12111): Requesting Record Service. Service ID: es.ugr.frailty.accelerometer
04-12 19:37:12.329+0200 I/recorder(12111): Requesting Record Service. Data received: SM-R760,12/04/2018,19:36:12,0.191426,0.050249,9.841680
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:12,0.177069,0.028714,9.856036
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:12,0.160319,0.045464,9.805787
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:12,0.193819,0.078963,9.851252
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:12,0.224925,0.019143,9.846465
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:12,0.177069,0.021535,9.822537
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:12,0.196211,0.059821,9.793823
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:13,0.184247,0.023928,9.791430
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:13,0.203390,0.031107,9.834501
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:13,0.179462,0.076570,9.829715
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:13,0.179462,0.004786,9.827322
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:13,0.148355,0.019143,9.810574
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:13,0.203390,0.043071,9.848858
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:13,0.138784,0.055035,9.781858
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:13,0.133998,0.009571,9.846465
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:13,0.155533,0.033500,9.841680
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:13,0.172283,0.011964,9.824929
04-12 19:37:12.329+0200 I/recorder(12111): SM-R760,12/04/2018,19:36:14,0.141177,0.081356,
04-12 19:37:12.329+0200 W/AUL     (12103): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12111)
04-12 19:37:12.329+0200 I/servicemanager(12103): request sent to service es.ugr.frailty.recorder with message: es.ugr.frailty.accelerometer and data: SM-R760,12/04/2018,19:36:12,0.191426,0.050249,9.841680
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.177069,0.028714,9.856036
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.160319,0.045464,9.805787
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.193819,0.078963,9.851252
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.224925,0.019143,9.846465
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.177069,0.021535,9.822537
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.196211,0.059821,9.793823
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.184247,0.023928,9.791430
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.203390,0.031107,9.834501
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.179462,0.076570,9.829715
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.179462,0.004786,9.827322
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.148355,0.019143,9.810574
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.203390,0.043071,9.848858
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.138784,0.055035,9.781858
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.133998,0.009571,9.846465
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.155533,0.033500,9.841680
04-12 19:37:12.329+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.172283,0.011
04-12 19:37:12.329+0200 W/AUL     (12103): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.httppostreq)
04-12 19:37:12.329+0200 W/AUL     (12114): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12103)
04-12 19:37:12.329+0200 I/utils   (12114): request sent to service es.ugr.frailty.servicemanager
04-12 19:37:12.329+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 0
04-12 19:37:12.329+0200 W/AUL_AMD ( 2499): amd_launch.c: _start_app(1782) > caller pid : 12103
04-12 19:37:12.349+0200 W/AUL_AMD ( 2499): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 12106
04-12 19:37:12.349+0200 E/AUL_AMD ( 2499): amd_launch.c: __real_send(909) > send fail to client
04-12 19:37:12.349+0200 W/AUL_AMD ( 2499): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(12106), cmd(0)
04-12 19:37:12.349+0200 W/CAPI_APPFW_APP_CONTROL(12106): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-12 19:37:12.349+0200 I/httppostreq(12106): Requesting HTTP POST Request Service. Service ID: es.ugr.frailty.accelerometer Data received: SM-R760,12/04/2018,19:36:12,0.191426,0.050249,9.841680
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:12,0.177069,0.028714,9.856036
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:12,0.160319,0.045464,9.805787
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:12,0.193819,0.078963,9.851252
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:12,0.224925,0.019143,9.846465
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:12,0.177069,0.021535,9.822537
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:12,0.196211,0.059821,9.793823
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:13,0.184247,0.023928,9.791430
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:13,0.203390,0.031107,9.834501
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:13,0.179462,0.076570,9.829715
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:13,0.179462,0.004786,9.827322
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:13,0.148355,0.019143,9.810574
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:13,0.203390,0.043071,9.848858
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:13,0.138784,0.055035,9.781858
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:13,0.133998,0.009571,9.846465
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:13,0.155533,0.033500,9.841680
04-12 19:37:12.349+0200 I/httppostreq(12106): SM-R760,12/04/2018,19:36:13,0.172283,0.011964,9.8
04-12 19:37:12.359+0200 W/AUL     (12103): launch.c: app_request_to_launchpad(298) > request cmd(0) result(12106)
04-12 19:37:12.359+0200 I/servicemanager(12103): request sent to service es.ugr.frailty.httppostreq with message: es.ugr.frailty.accelerometer and data: SM-R760,12/04/2018,19:36:12,0.191426,0.050249,9.841680
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.177069,0.028714,9.856036
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.160319,0.045464,9.805787
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.193819,0.078963,9.851252
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.224925,0.019143,9.846465
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.177069,0.021535,9.822537
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:12,0.196211,0.059821,9.793823
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.184247,0.023928,9.791430
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.203390,0.031107,9.834501
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.179462,0.076570,9.829715
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.179462,0.004786,9.827322
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.148355,0.019143,9.810574
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.203390,0.043071,9.848858
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.138784,0.055035,9.781858
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.133998,0.009571,9.846465
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.155533,0.033500,9.841680
04-12 19:37:12.359+0200 I/servicemanager(12103): SM-R760,12/04/2018,19:36:13,0.172283,0.
04-12 19:37:12.359+0200 I/CAPI_APPFW_APPLICATION(12114): service_app_main.c: service_app_exit(441) > service_app_exit
04-12 19:37:12.359+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 22
04-12 19:37:12.359+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(999) > app status : 4
04-12 19:37:12.409+0200 E/PKGMGR_INFO( 2938): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-12 19:37:12.419+0200 E/PKGMGR_INFO( 2938): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-12 19:37:12.449+0200 I/accelerometer(12114): es.ugr.frailty.accelerometer listener destroyed
04-12 19:37:12.569+0200 W/AUL     (12133): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-12 19:37:12.569+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 19:37:12.569+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 19:37:12.569+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12114
04-12 19:37:12.569+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 19:37:12.619+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12114
04-12 19:37:12.619+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12114)
04-12 19:37:12.629+0200 W/AUL     (12136): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.httppostreq]
04-12 19:37:12.649+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(669) > __request_handler: 23
04-12 19:37:12.649+0200 W/AUL_AMD ( 2499): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-12 19:37:12.649+0200 W/AUL_AMD ( 2499): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 12106
04-12 19:37:12.649+0200 W/AUL_AMD ( 2499): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-12 19:37:12.649+0200 I/AUL_AMD ( 2499): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 12106
04-12 19:37:12.649+0200 W/AUL     ( 2499): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(12106)
04-12 19:37:12.729+0200 W/CRASH_MANAGER(12137): worker.c: worker_job(1205) > 1112106687474152355463
