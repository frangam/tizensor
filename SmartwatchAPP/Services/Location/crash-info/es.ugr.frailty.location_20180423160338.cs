S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 24150
Date: 2018-04-23 16:03:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf716052d, r5   = 0xf7678f98
r6   = 0xffb71ed8, r7   = 0xffb71d88
r8   = 0xf7675c18, r9   = 0x00000000
r10  = 0xffb71e64, fp   = 0xffb71ed8
ip   = 0x00000001, sp   = 0xffb70c08
lr   = 0xf7160539, pc   = 0xf71c92b2
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:      8616 KB
Buffers:     61668 KB
Cached:     227240 KB
VmPeak:      53568 KB
VmSize:      53564 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12368 KB
VmRSS:       12368 KB
VmData:      11292 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 24150 TID = 24150
24150 24154 

Maps Information
f402b000 f482a000 rw-p [stack:24154]
f4831000 f4833000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f483b000 f483f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4848000 f484a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4852000 f4855000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4864000 f4869000 r-xp /usr/lib/libsystem.so.0.0.0
f4874000 f4877000 r-xp /lib/libattr.so.1.1.0
f487f000 f488f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4897000 f48a0000 r-xp /usr/lib/libedbus.so.1.7.99
f48a8000 f48a9000 r-xp /usr/lib/libresponse.so.0.2.96
f48b2000 f48b7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6159000 f625f000 r-xp /usr/lib/libicuuc.so.57.1
f6275000 f63fd000 r-xp /usr/lib/libicui18n.so.57.1
f640d000 f641a000 r-xp /usr/lib/libail.so.0.1.0
f6423000 f642a000 r-xp /usr/lib/libminizip.so.1.0.0
f6433000 f65dc000 r-xp /usr/lib/libcrypto.so.1.0.0
f65fc000 f6643000 r-xp /usr/lib/libssl.so.1.0.0
f664f000 f6651000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6659000 f6660000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6669000 f6670000 r-xp /lib/libcrypt-2.13.so
f66a1000 f66a4000 r-xp /lib/libcap.so.2.21
f66ac000 f66ae000 r-xp /usr/lib/libiri.so
f66b6000 f66ff000 r-xp /usr/lib/libmdm.so.1.2.69
f6707000 f670d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6715000 f6738000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6742000 f6744000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f674c000 f6769000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6772000 f6776000 r-xp /usr/lib/libsmack.so.1.0.0
f677f000 f6798000 r-xp /usr/lib/libnetwork.so.0.0.0
f67a1000 f67a9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f67b1000 f67b7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f67c0000 f67c2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f67cb000 f67db000 r-xp /lib/libresolv-2.13.so
f67df000 f67f7000 r-xp /usr/lib/liblzma.so.5.0.3
f6800000 f6802000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f680a000 f6824000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f682c000 f685b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6864000 f6873000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f687d000 f6887000 r-xp /usr/lib/libsensord-shared.so
f6890000 f6963000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f696e000 f6984000 r-xp /lib/libz.so.1.2.5
f698c000 f6991000 r-xp /usr/lib/libffi.so.5.0.10
f6999000 f699a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f69a2000 f69b2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f69ba000 f69d3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f69db000 f69dd000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f69e5000 f6a5a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a64000 f6a6a000 r-xp /lib/librt-2.13.so
f6a73000 f6a91000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a9b000 f6a9c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6aa4000 f6ac7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6acf000 f6ad4000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6adc000 f6b06000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6b0f000 f6b26000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6b2e000 f6b97000 r-xp /lib/libm-2.13.so
f6ba0000 f6c34000 r-xp /usr/lib/libstdc++.so.6.0.16
f6c47000 f6c4c000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c54000 f6c5b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c63000 f6c8d000 r-xp /usr/lib/libsensor.so.1.9.6
f6c96000 f6d62000 r-xp /usr/lib/libxml2.so.2.7.8
f6d6f000 f6d71000 r-xp /usr/lib/libiniparser.so.0
f6d7a000 f6d80000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d89000 f6e59000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e5a000 f6e8e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e97000 f6ed3000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6edb000 f6ede000 r-xp /usr/lib/libbundle.so.0.1.22
f6ee6000 f6eec000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ef4000 f6f35000 r-xp /usr/lib/libeina.so.1.7.99
f6f3e000 f6f55000 r-xp /usr/lib/libecore.so.1.7.99
f6f6c000 f6f75000 r-xp /usr/lib/libvconf.so.0.2.45
f6f7d000 f6f91000 r-xp /lib/libpthread-2.13.so
f6f9c000 f6fa9000 r-xp /usr/lib/libaul.so.0.1.0
f6fb3000 f6fb5000 r-xp /lib/libdl-2.13.so
f6fbe000 f6fc9000 r-xp /lib/libunwind.so.8.0.1
f6ff6000 f6ffe000 r-xp /lib/libgcc_s-4.6.so.1
f6fff000 f7123000 r-xp /lib/libc-2.13.so
f7131000 f7133000 r-xp /usr/lib/libdlog.so.0.0.0
f713b000 f7147000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7150000 f7155000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f715d000 f716c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7174000 f7178000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7181000 f7184000 r-xp /usr/lib/libappcore-agent.so.1.1
f718c000 f718e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7196000 f719a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f71a2000 f71bf000 r-xp /lib/ld-2.13.so
f71c8000 f71cb000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f71cb000 f71cf000 r-xp /usr/lib/libsys-assert.so
f7645000 f76cf000 rw-p [heap]
ffb53000 ffb74000 rw-p [stack]
End of Maps Information

Callstack Information (PID:24150)
Call Stack Count: 30
 0: state_changed_cb + 0x31 (0xf71c92b2) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x12b2
 1: (0xf7160539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e673f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e65c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e71e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e77be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e77dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6eac75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6ea71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e65c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e71e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e77be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e77dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6ea9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6eaa017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6eae8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf71980bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf483c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf690f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6dbcfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6dbe7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6f4eca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6f49b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6f4a5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6f4a879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7182183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71827fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71c96a7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16a7
28: __libc_start_main + 0x114 (0xf701685c) [/lib/libc.so.6] + 0x1785c
29: (0xf71c8fa4) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xfa4
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
16:03:52:360,28.630001,16.590000,-8.750000
04-23 16:03:52.361+0200 I/gyroscope(24292): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:52.371+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:52.381+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:321,-7.410572,-6.326623,-0.334995
04-23 16:03:52.381+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.381+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:387,-6.494121,-10.762917,-0.157926
04-23 16:03:52.381+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.391+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:391,-5.749953,-10.688738,-0.189033
04-23 16:03:52.391+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.391+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:397,-6.503692,-7.685746,0.801596
04-23 16:03:52.391+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.391+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:400,-8.738588,-3.768696,1.186840
04-23 16:03:52.391+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.401+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:404,-9.348758,-4.338188,1.328017
04-23 16:03:52.401+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.401+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:408,-7.819745,-7.027720,1.098306
04-23 16:03:52.401+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.411+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:412,-7.204789,-8.080563,1.227518
04-23 16:03:52.411+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.411+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:416,-7.956135,-7.073184,1.127020
04-23 16:03:52.411+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.411+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:420,-7.771888,-5.374279,0.775275
04-23 16:03:52.411+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.421+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:423,-7.532606,-6.453443,0.007178
04-23 16:03:52.421+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:52:366,-20.510000,12.390000,9.800000
04-23 16:03:52.421+0200 I/gyroscope(24292): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:52.421+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.421+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:52:429,-21.980000,8.610000,12.180000
04-23 16:03:52.431+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:52.431+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:52.431+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:52.431+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7347228
04-23 16:03:52.431+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:430,-7.470392,-6.766902,0.076570
04-23 16:03:52.451+0200 I/gyroscope(24292): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:52.451+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:52:455,2.240000,12.320000,3.710000
04-23 16:03:52.461+0200 I/gyroscope(24292): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:52.461+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:52:467,28.490000,16.170000,-4.340000
04-23 16:03:52.461+0200 I/gyroscope(24292): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:52.471+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:52:472,21.980000,12.810000,-4.480000
04-23 16:03:52.471+0200 I/gyroscope(24292): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:52.481+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:52:480,-3.780000,15.470000,-3.360000
04-23 16:03:52.481+0200 I/gyroscope(24292): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:52.491+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:52:487,-1.890000,17.080000,-5.530000
04-23 16:03:52.501+0200 I/servicemanager(19708): es.ugr.frailty.location sleep timeout
04-23 16:03:52.501+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:03:52.501+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:52.501+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:52.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf736d4d0]
04-23 16:03:52.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:52.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:52.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:52.511+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:52.511+0200 W/AUL_AMD ( 2476): amd_launch.c: start_process(606) > child process: 24350
04-23 16:03:52.511+0200 E/RESOURCED( 2584): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 1
04-23 16:03:52.521+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:52.521+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:52.521+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.521+0200 I/gyroscope(24292): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:52.521+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:526,-7.200003,-6.692725,-0.023928
04-23 16:03:52.521+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:52.521+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:52:526,18.059999,19.180000,-8.890000
04-23 16:03:52.531+0200 I/accelerometer(24285): capturing data from es.ugr.frailty.accelerometer
04-23 16:03:52.531+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:52.541+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:52.541+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:52.541+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:52.541+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:52.541+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:52.541+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:52.541+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:52.541+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:52.541+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:52.541+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:52.551+0200 I/gyroscope(24292): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:52.551+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:52.551+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:52.551+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:52.561+0200 W/AUL_AMD ( 2476): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 24350
04-23 16:03:52.561+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.location) pid(24350) type(svcapp) bg(0)
04-23 16:03:52.571+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [24350]
04-23 16:03:52.571+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24350)
04-23 16:03:52.581+0200 I/servicemanager(19708): es.ugr.frailty.location stop request sent!
04-23 16:03:52.581+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:52.581+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:52.591+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24350
04-23 16:03:52.591+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:52.601+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer sleep timeout
04-23 16:03:52.601+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
04-23 16:03:52.601+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:52.601+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:52.611+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 24285
04-23 16:03:52.611+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24285)
04-23 16:03:52.611+0200 I/servicemanager(19708): es.ugr.frailty.accelerometer stop request sent!
04-23 16:03:52.611+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:52.611+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 16:03:52.621+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,16:03:52:535,-6.967900,-6.740582,-0.162712
04-23 16:03:52.621+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 24350
04-23 16:03:52.631+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:52:555,34.509998,21.000000,-10.290000
04-23 16:03:52.631+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:52.631+0200 I/accelerometer(24285): stopping es.ugr.frailty.accelerometer service
04-23 16:03:52.631+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:52.631+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(24285), cmd(0)
04-23 16:03:52.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 16:03:52.631+0200 W/AUL     (24285): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:52.631+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:52.631+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24285
04-23 16:03:52.641+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:52.641+0200 W/AUL     (24285): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:52.641+0200 I/accelerometer(24285): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:52.641+0200 I/CAPI_APPFW_APPLICATION(24285): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:03:52.641+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.641+0200 I/utils   (19708): specific action
04-23 16:03:52.651+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:52.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:52.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:52.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:52.651+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf736d4d0
04-23 16:03:52.661+0200 I/gyroscope(24292): capturing data from es.ugr.frailty.gyroscope
04-23 16:03:52.661+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,16:03:52:670,-15.890000,11.270000,1.050000
04-23 16:03:52.671+0200 E/CAPI_APPFW_APPLICATION(24350): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:52.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:03:52.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:03:52.671+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:52.671+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:52.681+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:52.691+0200 E/CAPI_APPFW_APPLICATION(24350): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 16:03:52.691+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:52.691+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:52.691+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:52.691+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:52.691+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:52.691+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope sleep timeout
04-23 16:03:52.691+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
04-23 16:03:52.691+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:52.691+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:52.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 24292
04-23 16:03:52.701+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24292)
04-23 16:03:52.701+0200 I/servicemanager(19708): es.ugr.frailty.gyroscope stop request sent!
04-23 16:03:52.701+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:52.701+0200 W/AUL_AMD ( 2476): amd_status.c: __socket_monitor_cb(1277) > (24350) was created
04-23 16:03:52.701+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:52.701+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(23) , send fd(21), pid(22624), cmd(0)
04-23 16:03:52.711+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:52.711+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(24292), cmd(0)
04-23 16:03:52.711+0200 I/gyroscope(24292): stopping es.ugr.frailty.gyroscope service
04-23 16:03:52.711+0200 W/AUL     (24292): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:52.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:52.711+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.711+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24292
04-23 16:03:52.711+0200 I/utils   (22624): specific action
04-23 16:03:52.711+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.711+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.accelerometer.csv
04-23 16:03:52.711+0200 I/recorder(22624): guardando datos en local
04-23 16:03:52.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:52.721+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.721+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:52.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:52.721+0200 I/utils   (19708): specific action
04-23 16:03:52.721+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.721+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:52.721+0200 W/AUL     (24292): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:52.721+0200 I/gyroscope(24292): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:52.721+0200 I/CAPI_APPFW_APPLICATION(24292): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:03:52.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:03:52.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:03:52.721+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:52.731+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:52.731+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:52.741+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:52.741+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:52.741+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:52.741+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:52.741+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:52.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.741+0200 I/utils   (22624): specific action
04-23 16:03:52.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:52.741+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.gyroscope.csv
04-23 16:03:52.741+0200 I/recorder(22624): guardando datos en local
04-23 16:03:52.751+0200 W/LOCATION(24350): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 16:03:52.761+0200 E/LOCATION(24350): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 16:03:52.761+0200 E/PKGMGR_INFO(24350): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 16:03:52.761+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:52.811+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:03:52.821+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:03:52.841+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:03:52.851+0200 I/LOCATION(24350): location.c: location_new(269) > method: 0
04-23 16:03:52.851+0200 W/LOCATION(24350): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:52.851+0200 E/PKGMGR_INFO( 2982): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(411) > syslocale is null
04-23 16:03:52.871+0200 I/gyroscope(24292): es.ugr.frailty.gyroscope listener destroyed
04-23 16:03:52.871+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:52.881+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:52.881+0200 I/accelerometer(24285): es.ugr.frailty.accelerometer listener destroyed
04-23 16:03:52.891+0200 W/LOCATION(24350): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:52.901+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:52.901+0200 W/LOCATION(24350): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:52.901+0200 W/LOCATION(24350): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:52.901+0200 W/LOCATION(24350): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:52.901+0200 W/LOCATION(24350): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:52.931+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:52.941+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 16:03:52.941+0200 W/LOCATION(24350): module-internal.c: module_new(311) > module (wps) open success
04-23 16:03:52.941+0200 W/LOCATION(24350): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 16:03:52.951+0200 W/LOCATION(24350): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 16:03:52.951+0200 W/LOCATION(24350): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:52.951+0200 W/LOCATION(24350): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:52.981+0200 W/LOCATION(24350): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 16:03:52.981+0200 I/LOCATION(24350): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf7a15c18
04-23 16:03:52.981+0200 I/LOCATION(24350): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 16:03:52.991+0200 I/LOCATION(24350): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf7a15c18
04-23 16:03:52.991+0200 I/LOCATION(24350): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 16:03:52.991+0200 I/location(24350): es.ugr.frailty.location: creado servicio de localización
04-23 16:03:53.031+0200 W/AUL     (24356): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.gyroscope]
04-23 16:03:53.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:53.031+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:53.031+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24292
04-23 16:03:53.031+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:53.051+0200 W/AUL     (24357): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.accelerometer]
04-23 16:03:53.061+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:53.061+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:53.061+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24285
04-23 16:03:53.061+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:53.061+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24292
04-23 16:03:53.061+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24292)
04-23 16:03:53.061+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24285
04-23 16:03:53.061+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24285)
04-23 16:03:53.081+0200 I/LOCATION(24350): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 16:03:53.131+0200 W/LOCATION(24350): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:53.131+0200 W/LOCATION(24350): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:53.131+0200 I/LOCATION(24350): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:53.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 16:03:53.201+0200 W/libgps  ( 3123): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 16:03:53.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 16:03:53.201+0200 W/libgps_d( 3123): GpsiHookStateIdle             : EXIT
04-23 16:03:53.201+0200 W/libgps_d( 3123): GpsiHookStateGps              : ENTRY
04-23 16:03:53.201+0200 W/libgps  ( 3123): [proxy__gps_start][line = 1022]: called.
04-23 16:03:53.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:53.201+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 16:03:53.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:26
04-23 16:03:53.201+0200 D/gpsd_d  ( 3104): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 16:03:53.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:27
04-23 16:03:53.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:8
04-23 16:03:53.201+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 16:03:53.201+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:1
04-23 16:03:53.211+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(11), data(0xf78b8138), size(4)
04-23 16:03:53.211+0200 W/libgps_d( 3123): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 16:03:53.211+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 16:03:53.211+0200 W/libgps_d( 3123): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 16:03:53.261+0200 W/LOCATION(24350): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 16:03:53.261+0200 W/LOCATION(24350): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 16:03:53.361+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:53.381+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 16:03:53.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 16:03:53.381+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:53.381+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 16:03:53.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e1a358]
04-23 16:03:53.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:53.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:53.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:53.421+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:53.431+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:53.431+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:53.441+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:53.441+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 16:03:53.441+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(1), time1(6129105), time2(6122691)
04-23 16:03:53.441+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(1)
04-23 16:03:53.441+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 16:03:53.441+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 16:03:53.441+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 16:03:53.451+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:53.451+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:53.451+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:53.451+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:53.451+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:53.451+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:53.451+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:53.451+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:53.451+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:53.451+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:53.461+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:53.461+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:53.461+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:53.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:53.511+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:53.521+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:53.531+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:53.541+0200 E/LOCATION(19762): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 16:03:53.541+0200 I/LOCATION(19762): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 16:03:53.541+0200 I/LOCATION(19762): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:53.571+0200 W/LOCATION(24350): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:53.571+0200 I/LOCATION(24350): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:53.571+0200 I/LOCATION(24350): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 16:03:53.571+0200 I/location(24350): es.ugr.frailty.location:iniciado servicio de localización
04-23 16:03:53.661+0200 I/LOCATION(24350): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 16:03:53.711+0200 W/AUL     (24350): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 16:03:53.711+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:53.711+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 24350
04-23 16:03:53.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 19708
04-23 16:03:53.721+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:53.721+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(19708), cmd(0)
04-23 16:03:53.721+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.721+0200 I/utils   (19708): specific action
04-23 16:03:53.721+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.721+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.721+0200 W/CAPI_APPFW_APP_CONTROL(19708): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.721+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 16:03:53.731+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:53.731+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:53.741+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 22624
04-23 16:03:53.741+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:53.741+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(22624), cmd(0)
04-23 16:03:53.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.741+0200 I/utils   (22624): specific action
04-23 16:03:53.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.741+0200 W/CAPI_APPFW_APP_CONTROL(22624): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 16:03:53.741+0200 I/recorder(22624): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 16:03:53.741+0200 I/recorder(22624): guardando datos en local
04-23 16:03:53.741+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22624)
04-23 16:03:53.741+0200 I/servicemanager(19708): request sent to service es.ugr.frailty.recorder
04-23 16:03:53.741+0200 I/servicemanager(19708): requesting to save local data
04-23 16:03:53.741+0200 W/AUL     (24350): launch.c: app_request_to_launchpad(298) > request cmd(0) result(19708)
04-23 16:03:53.741+0200 I/location(24350): request sent to service es.ugr.frailty.servicemanager
04-23 16:03:53.741+0200 I/location(24350): stopping es.ugr.frailty.location service
04-23 16:03:53.741+0200 E/CAPI_APPFW_APP_CONTROL(24350): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
04-23 16:03:53.741+0200 E/location(24350): request sending failed to service es.ugr.frailty.servicemanager
04-23 16:03:53.741+0200 I/CAPI_APPFW_APPLICATION(24350): service_app_main.c: service_app_exit(441) > service_app_exit
04-23 16:03:53.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 22
04-23 16:03:53.741+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(999) > app status : 4
04-23 16:03:53.791+0200 W/LOCATION(24350): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 16:03:53.791+0200 I/LOCATION(24350): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:53.791+0200 I/LOCATION(24350): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 0
04-23 16:03:53.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
04-23 16:03:53.861+0200 W/libgps  ( 3123): [proxy__gps_stop][line = 1067]: called.
04-23 16:03:53.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
04-23 16:03:53.861+0200 W/libgps_d( 3123): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
04-23 16:03:53.861+0200 W/libgps_d( 3123): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
04-23 16:03:53.861+0200 W/libgps_d( 3123): GpsiHookStateGps              : EXIT
04-23 16:03:53.861+0200 W/libgps_d( 3123): GpsiHookStateIdle             : ENTRY
04-23 16:03:53.861+0200 E/CAPI_LOCATION_MANAGER(19762): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 16:03:53.861+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:0, msg id:2
04-23 16:03:53.981+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:54.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:54.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:54.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:54.041+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e1a358
04-23 16:03:54.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf3e01a60]
04-23 16:03:54.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:54.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:54.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:54.111+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:54.121+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:54.121+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:54.131+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.141+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.141+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:54.141+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:54.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:54.141+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:54.141+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:54.141+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:54.141+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:54.141+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:54.141+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:54.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.161+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.161+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:54.171+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:54.241+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:54.251+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:54.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:54.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:54.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:54.301+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf3e01a60
04-23 16:03:54.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_create(453) > New handle created[0xf7345e00]
04-23 16:03:54.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 16:03:54.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 16:03:54.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 16:03:54.361+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_get_type(507) > Connected Network = 2
04-23 16:03:54.371+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:54.371+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:54.391+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.411+0200 E/LOCATION(19762): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 16:03:54.411+0200 I/LOCATION(19762): location.c: location_new(269) > method: 1
04-23 16:03:54.411+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 16:03:54.411+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (gps) open success
04-23 16:03:54.411+0200 W/LOCATION(19762): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 16:03:54.411+0200 W/LOCATION(19762): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 16:03:54.411+0200 W/LOCATION(19762): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 16:03:54.411+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 16:03:54.411+0200 W/LOCATION(19762): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 16:03:54.411+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.421+0200 I/AUL     (19762): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 16:03:54.421+0200 E/LOCATION(19762): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 16:03:54.421+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:54.471+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 16:03:54.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
04-23 16:03:54.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
04-23 16:03:54.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
04-23 16:03:54.481+0200 I/CAPI_NETWORK_CONNECTION(19762): connection.c: connection_destroy(471) > Destroy handle: 0xf7345e00
04-23 16:03:54.611+0200 I/servicemanager(19708): es.ugr.frailty.location alive timeout
04-23 16:03:54.611+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
04-23 16:03:54.611+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 16:03:54.611+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 19708
04-23 16:03:54.621+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 24350
04-23 16:03:54.621+0200 W/AUL     (19708): launch.c: app_request_to_launchpad(298) > request cmd(0) result(24350)
04-23 16:03:54.621+0200 I/servicemanager(19708): es.ugr.frailty.location launch request sent!
04-23 16:03:54.621+0200 I/servicemanager(19708): App control destroyed.
04-23 16:03:54.631+0200 E/AUL_AMD ( 2476): amd_launch.c: __reply_handler(975) > recv error : Connection reset by peer
04-23 16:03:54.631+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 16:03:54.631+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(24350), cmd(0)
04-23 16:03:54.651+0200 W/AUL     (24369): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
04-23 16:03:54.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 23
04-23 16:03:54.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
04-23 16:03:54.651+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 24318
04-23 16:03:54.651+0200 W/AUL_AMD ( 2476): amd_request.c: __send_app_termination_signal(528) > send dead signal done
04-23 16:03:54.651+0200 I/AUL_AMD ( 2476): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 24318
04-23 16:03:54.651+0200 W/AUL     ( 2476): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(24318)
04-23 16:03:54.671+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:03:54.721+0200 W/AUL_AMD ( 2476): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 16:03:55.451+0200 W/CRASH_MANAGER(21562): worker.c: worker_job(1205) > 11241506c6f63152449221
