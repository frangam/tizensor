S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 14533
Date: 2018-04-23 19:27:08+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf733052d, r5   = 0xf7a2ef98
r6   = 0xff90f690, r7   = 0xff90f540
r8   = 0xf7a2bc18, r9   = 0x00000000
r10  = 0xff90f61c, fp   = 0xff90f690
ip   = 0x00000001, sp   = 0xff90f518
lr   = 0xf7330539, pc   = 0xf7399228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     16304 KB
Buffers:     52016 KB
Cached:     237104 KB
VmPeak:      53468 KB
VmSize:      53456 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12132 KB
VmRSS:       12132 KB
VmData:      11184 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 14533 TID = 14533
14533 14562 

Maps Information
f41fb000 f49fa000 rw-p [stack:14562]
f4a01000 f4a03000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4a0b000 f4a0f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4a18000 f4a1a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4a22000 f4a25000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4a34000 f4a39000 r-xp /usr/lib/libsystem.so.0.0.0
f4a44000 f4a47000 r-xp /lib/libattr.so.1.1.0
f4a4f000 f4a5f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4a67000 f4a70000 r-xp /usr/lib/libedbus.so.1.7.99
f4a78000 f4a79000 r-xp /usr/lib/libresponse.so.0.2.96
f4a82000 f4a87000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6329000 f642f000 r-xp /usr/lib/libicuuc.so.57.1
f6445000 f65cd000 r-xp /usr/lib/libicui18n.so.57.1
f65dd000 f65ea000 r-xp /usr/lib/libail.so.0.1.0
f65f3000 f65fa000 r-xp /usr/lib/libminizip.so.1.0.0
f6603000 f67ac000 r-xp /usr/lib/libcrypto.so.1.0.0
f67cc000 f6813000 r-xp /usr/lib/libssl.so.1.0.0
f681f000 f6821000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6829000 f6830000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6839000 f6840000 r-xp /lib/libcrypt-2.13.so
f6871000 f6874000 r-xp /lib/libcap.so.2.21
f687c000 f687e000 r-xp /usr/lib/libiri.so
f6886000 f68cf000 r-xp /usr/lib/libmdm.so.1.2.69
f68d7000 f68dd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f68e5000 f6908000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6912000 f6914000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f691c000 f6939000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6942000 f6946000 r-xp /usr/lib/libsmack.so.1.0.0
f694f000 f6968000 r-xp /usr/lib/libnetwork.so.0.0.0
f6971000 f6979000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6981000 f6987000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6990000 f6992000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f699b000 f69ab000 r-xp /lib/libresolv-2.13.so
f69af000 f69c7000 r-xp /usr/lib/liblzma.so.5.0.3
f69d0000 f69d2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f69da000 f69f4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f69fc000 f6a2b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6a34000 f6a43000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6a4d000 f6a57000 r-xp /usr/lib/libsensord-shared.so
f6a60000 f6b33000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6b3e000 f6b54000 r-xp /lib/libz.so.1.2.5
f6b5c000 f6b61000 r-xp /usr/lib/libffi.so.5.0.10
f6b69000 f6b6a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6b72000 f6b82000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6b8a000 f6ba3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6bab000 f6bad000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6bb5000 f6c2a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6c34000 f6c3a000 r-xp /lib/librt-2.13.so
f6c43000 f6c61000 r-xp /usr/lib/libsystemd.so.0.4.0
f6c6b000 f6c6c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6c74000 f6c97000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6c9f000 f6ca4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6cac000 f6cd6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6cdf000 f6cf6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6cfe000 f6d67000 r-xp /lib/libm-2.13.so
f6d70000 f6e04000 r-xp /usr/lib/libstdc++.so.6.0.16
f6e17000 f6e1c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6e24000 f6e2b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6e33000 f6e5d000 r-xp /usr/lib/libsensor.so.1.9.6
f6e66000 f6f32000 r-xp /usr/lib/libxml2.so.2.7.8
f6f3f000 f6f41000 r-xp /usr/lib/libiniparser.so.0
f6f4a000 f6f50000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6f59000 f7029000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f702a000 f705e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7067000 f70a3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f70ab000 f70ae000 r-xp /usr/lib/libbundle.so.0.1.22
f70b6000 f70bc000 r-xp /usr/lib/libappsvc.so.0.1.0
f70c4000 f7105000 r-xp /usr/lib/libeina.so.1.7.99
f710e000 f7125000 r-xp /usr/lib/libecore.so.1.7.99
f713c000 f7145000 r-xp /usr/lib/libvconf.so.0.2.45
f714d000 f7161000 r-xp /lib/libpthread-2.13.so
f716c000 f7179000 r-xp /usr/lib/libaul.so.0.1.0
f7183000 f7185000 r-xp /lib/libdl-2.13.so
f718e000 f7199000 r-xp /lib/libunwind.so.8.0.1
f71c6000 f71ce000 r-xp /lib/libgcc_s-4.6.so.1
f71cf000 f72f3000 r-xp /lib/libc-2.13.so
f7301000 f7303000 r-xp /usr/lib/libdlog.so.0.0.0
f730b000 f7317000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7320000 f7325000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f732d000 f733c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7344000 f7348000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7351000 f7354000 r-xp /usr/lib/libappcore-agent.so.1.1
f735c000 f735e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7366000 f736a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7372000 f738f000 r-xp /lib/ld-2.13.so
f7398000 f739b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f739b000 f739f000 r-xp /usr/lib/libsys-assert.so
f79fb000 f7a6c000 rw-p [heap]
ff8f0000 ff911000 rw-p [stack]
End of Maps Information

Callstack Information (PID:14533)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7399228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7330539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70373f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7035c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7041e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7047be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7047dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf707c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf70771f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7035c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7041e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7047be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7047dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7079e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf707a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf7081f93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4a191fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4a0c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6adf663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6f8cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6f8e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf711eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf7119b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf711a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf711a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7352183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf73527fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf73994f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf71e685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7398f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
End of Call Stack

Package Information
Package Name: es.ugr.frailty.frailtylauncher
Package ID : es.ugr.frailty.frailtylauncher
Version: 1.0.0
Package Type: rpm
App Name: location
App ID: es.ugr.frailty.location
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
19:27:07.439+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:445,2.030000,1.540000,0.210000
04-23 19:27:07.439+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:442,-1.079963,-4.602316,8.592017
04-23 19:27:07.439+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.439+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.449+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.449+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.449+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:452,-0.490000,0.070000,0.560000
04-23 19:27:07.449+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.449+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:454,-0.988236,-4.752146,8.470592
04-23 19:27:07.449+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.449+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:458,-0.980000,-1.120000,0.980000
04-23 19:27:07.459+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:453,-1.077600,-4.598908,8.594138
04-23 19:27:07.459+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:452,0.012764,-0.058903,0.113071
04-23 19:27:07.459+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:458,-0.990629,-4.510471,8.559127
04-23 19:27:07.459+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.459+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:467,-1.162912,-4.491328,8.676375
04-23 19:27:07.459+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.459+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.469+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:471,-1.075974,-4.596535,8.595611
04-23 19:27:07.469+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:471,-0.210000,-1.470000,1.330000
04-23 19:27:07.469+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.469+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.469+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:27:07.479+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:476,-0.006349,-0.119738,0.008059
04-23 19:27:07.479+0200 I/heartrate(14276): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:27:07:480,71
04-23 19:27:07.479+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:477,-1.153341,-4.577469,8.745767
04-23 19:27:07.479+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.479+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:487,-1.067199,-4.661219,8.705089
04-23 19:27:07.479+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.489+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.489+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.489+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:495,0.047060,-0.134075,-0.002985
04-23 19:27:07.489+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:495,-1.071770,-4.595041,8.596935
04-23 19:27:07.489+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:491,-1.083949,-4.718646,8.602197
04-23 19:27:07.489+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.489+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.499+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:501,-1.028914,-4.730610,8.592626
04-23 19:27:07.499+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:501,-0.140000,-1.470000,1.190000
04-23 19:27:07.509+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.519+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:521,0.112248,-0.188212,0.093797
04-23 19:27:07.519+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.519+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.529+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:531,0.070925,-0.231756,0.086968
04-23 19:27:07.529+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.529+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:527,-0.959522,-4.783253,8.690732
04-23 19:27:07.529+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:537,0.840000,0.070000,0.980000
04-23 19:27:07.529+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.539+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:542,-0.995414,-4.828716,8.683553
04-23 19:27:07.539+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.539+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.539+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.549+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:552,0.038427,-0.255666,0.070395
04-23 19:27:07.549+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.549+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:557,-1.026521,-4.862216,8.662018
04-23 19:27:07.549+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:547,0.630000,1.540000,0.420000
04-23 19:27:07.549+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.559+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:562,-0.140000,0.910000,-0.280000
04-23 19:27:07.559+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.569+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:572,0.130473,-0.227426,-0.076733
04-23 19:27:07.569+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.569+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:576,-0.933201,-4.845466,8.508877
04-23 19:27:07.569+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.579+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:551,-1.066339,-4.596960,8.596584
04-23 19:27:07.579+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.579+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:580,1.610000,0.280000,-0.700000
04-23 19:27:07.579+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:585,-1.064948,-4.606549,8.591622
04-23 19:27:07.579+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.589+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.609+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:27:07.609+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:27:07.609+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:27:07.619+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.619+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:625,-0.856631,-4.680361,8.494520
04-23 19:27:07.619+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.629+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:596,0.200558,-0.053467,-0.087122
04-23 19:27:07.629+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.629+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.639+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:639,-0.086794,0.077195,0.055220
04-23 19:27:07.639+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:633,3.360000,1.610000,-0.560000
04-23 19:27:07.639+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.639+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:644,-1.136591,-4.553542,8.635696
04-23 19:27:07.639+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.639+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:593,-1.063673,-4.618040,8.585609
04-23 19:27:07.639+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.649+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:649,-1.110270,-4.661219,8.733803
04-23 19:27:07.649+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.649+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.649+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:653,-1.100698,-4.675575,8.654840
04-23 19:27:07.649+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:647,1.680000,1.680000,-0.070000
04-23 19:27:07.649+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.649+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:658,-1.057188,-4.626894,8.581642
04-23 19:27:07.659+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:653,-0.053895,-0.032413,0.153091
04-23 19:27:07.659+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.659+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:661,-0.280000,0.280000,0.630000
04-23 19:27:07.659+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.659+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.659+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:665,0.280000,-0.630000,1.050000
04-23 19:27:07.659+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.669+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:671,-1.043271,-4.711468,8.611769
04-23 19:27:07.669+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.669+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:27:07.669+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:664,-0.041650,-0.048464,0.073544
04-23 19:27:07.669+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:665,-1.049797,-4.630737,8.580477
04-23 19:27:07.669+0200 I/heartrate(14276): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:27:07:679,70
04-23 19:27:07.669+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.679+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:676,0.560000,-1.050000,1.190000
04-23 19:27:07.679+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.679+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:683,0.016851,-0.088607,0.028315
04-23 19:27:07.679+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:686,-1.056375,-4.628806,8.580711
04-23 19:27:07.679+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.689+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:690,-1.059048,-4.627111,8.581296
04-23 19:27:07.689+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.689+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.689+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.689+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:695,1.400000,-0.840000,1.050000
04-23 19:27:07.689+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:696,-1.007378,-4.658825,8.626125
04-23 19:27:07.689+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.689+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:693,-1.060122,-4.622861,8.583454
04-23 19:27:07.689+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.699+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:701,0.050531,-0.039855,0.040304
04-23 19:27:07.699+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:702,-1.057909,-4.618970,8.585821
04-23 19:27:07.699+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.699+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:706,-1.054308,-4.612475,8.589755
04-23 19:27:07.699+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.699+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.709+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:711,1.540000,0.420000,0.700000
04-23 19:27:07.709+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.709+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:712,-0.959522,-4.656433,8.724231
04-23 19:27:07.709+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.709+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:716,-1.050120,-4.608861,8.592208
04-23 19:27:07.709+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:717,0.094787,-0.043958,0.134476
04-23 19:27:07.719+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.719+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.719+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.729+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:731,-1.009771,-4.733003,8.736196
04-23 19:27:07.729+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:731,0.420000,1.400000,0.140000
04-23 19:27:07.729+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.729+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:731,-1.049736,-4.614115,8.589435
04-23 19:27:07.729+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:736,0.040349,-0.124142,0.143988
04-23 19:27:07.749+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.749+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:753,0.420000,0.420000,-0.490000
04-23 19:27:07.749+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.749+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:757,-1.033699,-4.785645,8.563912
04-23 19:27:07.759+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.759+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.759+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.779+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:772,2.660000,0.770000,-0.210000
04-23 19:27:07.779+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:773,-0.959522,-4.790431,8.504091
04-23 19:27:07.779+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:764,-1.049042,-4.622364,8.585083
04-23 19:27:07.779+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.789+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.789+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.799+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.809+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:800,2.450000,1.470000,0.070000
04-23 19:27:07.809+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:804,0.016036,-0.171530,-0.025522
04-23 19:27:07.809+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.809+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:798,-0.911665,-4.601398,8.542377
04-23 19:27:07.819+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:791,-1.045596,-4.628001,8.582466
04-23 19:27:07.819+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.819+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.829+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:821,0.089520,-0.168067,-0.080992
04-23 19:27:07.829+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:833,0.280000,1.610000,0.420000
04-23 19:27:07.829+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.839+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.839+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:827,-0.973879,-4.651647,8.650054
04-23 19:27:07.849+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:841,-1.041650,-4.628178,8.582850
04-23 19:27:07.849+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.849+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.849+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:847,0.133931,0.026603,-0.040089
04-23 19:27:07.849+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.849+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.859+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:861,0.067772,-0.023469,0.067204
04-23 19:27:07.859+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.859+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:857,-1.002593,-4.754539,8.733803
04-23 19:27:07.859+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:867,0.038488,-0.122708,0.152854
04-23 19:27:07.859+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.869+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:860,0.280000,1.960000,0.420000
04-23 19:27:07.869+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:871,0.005809,-0.147183,0.089537
04-23 19:27:07.869+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.869+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.869+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:863,-1.041081,-4.631831,8.580949
04-23 19:27:07.869+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:27:07.869+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:876,-0.074864,-0.070616,0.077046
04-23 19:27:07.879+0200 I/heartrate(14276): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:27:07:879,71
04-23 19:27:07.879+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:881,-1.036092,-4.785645,8.666803
04-23 19:27:07.879+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.879+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.879+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:886,-1.119841,-4.716253,8.650054
04-23 19:27:07.879+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.879+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:886,1.960000,2.450000,0.350000
04-23 19:27:07.879+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.889+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.889+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:892,4.060000,2.380000,0.420000
04-23 19:27:07.889+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.889+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.889+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:897,4.480000,1.190000,0.630000
04-23 19:27:07.889+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:891,-1.041901,-4.638462,8.577267
04-23 19:27:07.899+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.899+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:897,-0.072988,0.053841,0.018056
04-23 19:27:07.899+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:897,-1.124627,-4.591826,8.590233
04-23 19:27:07.899+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:903,-1.044977,-4.645638,8.573008
04-23 19:27:07.899+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.899+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.899+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.909+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.909+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:912,1.610000,1.050000,0.980000
04-23 19:27:07.909+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:908,-1.051639,-4.645667,8.572177
04-23 19:27:07.909+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.909+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:913,-0.079709,0.045279,0.081065
04-23 19:27:07.919+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:912,-1.136591,-4.591826,8.657232
04-23 19:27:07.919+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:919,-1.056882,-4.637105,8.576167
04-23 19:27:07.919+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.919+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:924,-1.062539,-4.631883,8.578290
04-23 19:27:07.919+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.919+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.919+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.929+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.929+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:932,-0.490000,-0.420000,0.490000
04-23 19:27:07.929+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:933,0.007304,-0.144191,0.114835
04-23 19:27:07.929+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:932,-1.055235,-4.776074,8.693125
04-23 19:27:07.939+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:931,-1.061035,-4.633596,8.577551
04-23 19:27:07.939+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.939+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.949+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.949+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:951,0.910000,-0.770000,0.210000
04-23 19:27:07.949+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.949+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:953,0.206797,-0.120942,0.082074
04-23 19:27:07.949+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:951,-0.854238,-4.754539,8.659625
04-23 19:27:07.949+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:956,-1.049464,-4.632464,8.579586
04-23 19:27:07.959+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.959+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.969+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:07:971,-0.940379,-4.627719,8.647661
04-23 19:27:07.969+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:972,3.430000,1.750000,0.280000
04-23 19:27:07.969+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.969+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.969+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:07:976,0.109084,0.004745,0.068075
04-23 19:27:07.969+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:977,-1.046687,-4.630005,8.581252
04-23 19:27:07.989+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:07.989+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.989+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:07:998,3.150000,2.870000,0.490000
04-23 19:27:07.989+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:07.999+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:07:999,-1.052821,-4.629268,8.580899
04-23 19:27:07.999+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:07.999+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:3,-1.074377,-4.558327,8.592626
04-23 19:27:07.999+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:4,-0.027690,0.071678,0.011374
04-23 19:27:07.999+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:07.999+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.009+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:12,1.400000,2.170000,0.770000
04-23 19:27:08.009+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:12,-1.056889,-4.628937,8.580578
04-23 19:27:08.009+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.009+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.019+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:20,-1.062413,-4.596612,8.676375
04-23 19:27:08.019+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:19,-0.009592,0.032656,0.095476
04-23 19:27:08.019+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.019+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.029+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.029+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:32,0.910000,1.680000,0.840000
04-23 19:27:08.029+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.039+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:32,-1.062241,-4.628832,8.579973
04-23 19:27:08.039+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:39,-1.110270,-4.625326,8.669197
04-23 19:27:08.039+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:38,-0.053381,0.003611,0.088619
04-23 19:27:08.039+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.039+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.049+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:52,-1.067133,-4.627722,8.579966
04-23 19:27:08.049+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.049+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.059+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:60,-0.057600,-0.034779,0.060509
04-23 19:27:08.059+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.069+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:27:08.079+0200 I/heartrate(14276): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:27:08:80,71
04-23 19:27:08.079+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:52,1.820000,1.330000,0.910000
04-23 19:27:08.079+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.079+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.089+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:73,-1.066566,-4.627235,8.580298
04-23 19:27:08.089+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.089+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:62,-1.119841,-4.663611,8.640482
04-23 19:27:08.099+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.099+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:91,2.520000,1.050000,0.490000
04-23 19:27:08.099+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.109+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:93,0.038219,-0.083746,0.067696
04-23 19:27:08.109+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.109+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:103,-1.028914,-4.711468,8.647661
04-23 19:27:08.109+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.109+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:104,-1.067767,-4.623793,8.582005
04-23 19:27:08.119+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.119+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:108,2.590000,1.330000,0.140000
04-23 19:27:08.119+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.129+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:121,0.006545,0.011480,0.105648
04-23 19:27:08.129+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:132,2.590000,1.260000,0.210000
04-23 19:27:08.129+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.129+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.129+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:128,-1.070996,-4.620618,8.583312
04-23 19:27:08.139+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.139+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:121,-1.060020,-4.615755,8.685946
04-23 19:27:08.139+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.139+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:142,-0.032931,0.017609,0.051299
04-23 19:27:08.139+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:145,-1.100698,-4.606184,8.633304
04-23 19:27:08.139+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.149+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:149,-1.072639,-4.615424,8.585901
04-23 19:27:08.149+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:152,-1.074377,-4.508078,8.662018
04-23 19:27:08.149+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.149+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.159+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.159+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:158,-0.003381,0.112540,0.078706
04-23 19:27:08.159+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.169+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:138,0.700000,0.840000,0.350000
04-23 19:27:08.169+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.169+0200 W/LOCATION(14533): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
04-23 19:27:08.179+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:175,-2.520000,0.840000,0.070000
04-23 19:27:08.179+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.179+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:165,-1.072638,-4.623897,8.581341
04-23 19:27:08.179+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:184,-1.820000,-0.420000,-0.490000
04-23 19:27:08.179+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:158,-1.040878,-4.670790,8.635696
04-23 19:27:08.179+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.189+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.189+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.199+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:196,3.150000,1.470000,-0.490000
04-23 19:27:08.199+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:178,0.031761,-0.055366,0.049795
04-23 19:27:08.199+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:193,-0.921237,-4.871787,8.563912
04-23 19:27:08.199+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.199+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.199+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.209+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:197,-1.064376,-4.636633,8.575495
04-23 19:27:08.209+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:208,-0.993021,-4.666004,8.595018
04-23 19:27:08.209+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.209+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.219+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:212,3.500000,2.940000,-0.420000
04-23 19:27:08.219+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:220,-1.146162,-4.565506,8.697910
04-23 19:27:08.219+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:223,-1.062562,-4.637266,8.575378
04-23 19:27:08.219+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.219+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:211,0.151401,-0.247890,-0.017428
04-23 19:27:08.219+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.219+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.229+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.229+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:233,-1.134198,-4.541577,8.764909
04-23 19:27:08.229+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:230,0.071354,-0.029371,0.019524
04-23 19:27:08.229+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:231,1.680000,2.170000,-0.420000
04-23 19:27:08.229+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.239+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:229,-1.070265,-4.635178,8.575549
04-23 19:27:08.239+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.239+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:244,-1.075781,-4.632004,8.576574
04-23 19:27:08.239+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.239+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.249+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.249+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:241,-0.083600,0.071761,0.122532
04-23 19:27:08.249+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.249+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:253,-1.172483,-4.587041,8.709875
04-23 19:27:08.249+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:252,0.840000,0.980000,0.700000
04-23 19:27:08.249+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:252,-1.081779,-4.627283,8.578368
04-23 19:27:08.259+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:257,-0.063932,0.093600,0.189360
04-23 19:27:08.259+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.259+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:264,-0.096702,0.044963,0.133301
04-23 19:27:08.259+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.269+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.269+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.269+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:274,-1.184447,-4.517649,8.592626
04-23 19:27:08.269+0200 I/heartrate(14276): capturing data from es.ugr.frailty.heartrate
04-23 19:27:08.279+0200 I/heartrate(14276): es.ugr.frailty.heartrate: SM-R760,23/04/2018,19:27:08:279,71
04-23 19:27:08.279+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:272,0.280000,-0.140000,1.190000
04-23 19:27:08.279+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:273,-1.087332,-4.619022,8.582117
04-23 19:27:08.279+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.279+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:287,-0.102668,0.109633,0.014257
04-23 19:27:08.289+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.289+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.289+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:296,-1.148555,-4.663611,8.559127
04-23 19:27:08.289+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:296,-1.089068,-4.616434,8.583289
04-23 19:27:08.289+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.299+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.299+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:300,-0.770000,-1.190000,1.190000
04-23 19:27:08.299+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:303,-0.061223,-0.044589,-0.022990
04-23 19:27:08.299+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.299+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.309+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.309+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:312,-1.085545,-4.614187,8.584944
04-23 19:27:08.309+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.309+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:312,-0.560000,-1.540000,1.120000
04-23 19:27:08.309+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:317,0.031441,-0.097427,0.006944
04-23 19:27:08.309+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:313,-1.057628,-4.713861,8.590233
04-23 19:27:08.319+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.319+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.329+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:332,-0.070000,-0.630000,0.910000
04-23 19:27:08.329+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:332,-1.083364,-4.612815,8.585956
04-23 19:27:08.329+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.329+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.329+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:337,-1.055235,-4.685147,8.614161
04-23 19:27:08.339+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:338,0.030310,-0.070960,0.029218
04-23 19:27:08.339+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.339+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.349+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:352,-0.560000,-0.420000,0.350000
04-23 19:27:08.349+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:352,-1.079526,-4.616560,8.584427
04-23 19:27:08.349+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.349+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.349+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:356,-1.033699,-4.816752,8.736196
04-23 19:27:08.349+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:357,0.049664,-0.203937,0.150240
04-23 19:27:08.359+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.359+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.359+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.369+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:371,-0.892523,-4.840680,8.604590
04-23 19:27:08.369+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:372,1.260000,-0.700000,-0.490000
04-23 19:27:08.369+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:373,-1.068555,-4.620992,8.583414
04-23 19:27:08.369+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.379+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:381,0.187004,-0.224121,0.020164
04-23 19:27:08.389+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.389+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.389+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.389+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:396,-0.827917,-4.697111,8.604590
04-23 19:27:08.399+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:396,-1.058368,-4.622848,8.583677
04-23 19:27:08.399+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:400,4.200000,1.540000,-0.910000
04-23 19:27:08.399+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.399+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:405,0.240639,-0.076119,0.021176
04-23 19:27:08.399+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.399+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.399+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.409+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:412,-1.062413,-4.457829,8.571091
04-23 19:27:08.409+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:412,3.430000,3.150000,-0.700000
04-23 19:27:08.409+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:413,-1.063396,-4.621635,8.583709
04-23 19:27:08.409+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.419+0200 I/linearacceleration(14536): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:27:08:422,-0.004045,0.165019,-0.012587
04-23 19:27:08.419+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.419+0200 I/gravity (14549): capturing data from es.ugr.frailty.gravity
04-23 19:27:08.419+0200 I/gyroscope(14520): capturing data from es.ugr.frailty.gyroscope
04-23 19:27:08.429+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:431,-1.268196,-4.481757,8.638089
04-23 19:27:08.429+0200 I/gravity (14549): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:27:08:432,-1.075803,-4.620211,8.582930
04-23 19:27:08.429+0200 I/gyroscope(14520): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:27:08:433,0.630000,1.890000,-0.700000
04-23 19:27:08.439+0200 I/linearacceleration(14536): capturing data from es.ugr.frailty.linearacceleration
04-23 19:27:08.449+0200 I/accelerometer(14507): capturing data from es.ugr.frailty.accelerometer
04-23 19:27:08.459+0200 I/accelerometer(14507): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:27:08:459,-1.170090,-4.560720,8.721838
04-23 19:27:08.459+0200 W/CRASH_MANAGER(14336): worker.c: worker_job(1205) > 11145336c6f63152450442
