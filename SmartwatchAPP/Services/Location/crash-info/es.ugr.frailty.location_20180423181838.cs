S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 4403
Date: 2018-04-23 18:18:38+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf766252d, r5   = 0xf79eef98
r6   = 0xffddfd08, r7   = 0xffddfbb8
r8   = 0xf79ebc18, r9   = 0x00000000
r10  = 0xffddfc94, fp   = 0xffddfd08
ip   = 0x00000001, sp   = 0xffddfb90
lr   = 0xf7662539, pc   = 0xf76cb228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     11064 KB
Buffers:     68720 KB
Cached:     216516 KB
VmPeak:      52516 KB
VmSize:      52512 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11860 KB
VmRSS:       11856 KB
VmData:      10240 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4403 TID = 4403
4403 4442 

Maps Information
f452d000 f4d2c000 rw-p [stack:4442]
f4d33000 f4d35000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4d3d000 f4d41000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4d4a000 f4d4c000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4d54000 f4d57000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4d66000 f4d6b000 r-xp /usr/lib/libsystem.so.0.0.0
f4d76000 f4d79000 r-xp /lib/libattr.so.1.1.0
f4d81000 f4d91000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4d99000 f4da2000 r-xp /usr/lib/libedbus.so.1.7.99
f4daa000 f4dab000 r-xp /usr/lib/libresponse.so.0.2.96
f4db4000 f4db9000 r-xp /usr/lib/libproc-stat.so.0.2.96
f665b000 f6761000 r-xp /usr/lib/libicuuc.so.57.1
f6777000 f68ff000 r-xp /usr/lib/libicui18n.so.57.1
f690f000 f691c000 r-xp /usr/lib/libail.so.0.1.0
f6925000 f692c000 r-xp /usr/lib/libminizip.so.1.0.0
f6935000 f6ade000 r-xp /usr/lib/libcrypto.so.1.0.0
f6afe000 f6b45000 r-xp /usr/lib/libssl.so.1.0.0
f6b51000 f6b53000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6b5b000 f6b62000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6b6b000 f6b72000 r-xp /lib/libcrypt-2.13.so
f6ba3000 f6ba6000 r-xp /lib/libcap.so.2.21
f6bae000 f6bb0000 r-xp /usr/lib/libiri.so
f6bb8000 f6c01000 r-xp /usr/lib/libmdm.so.1.2.69
f6c09000 f6c0f000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6c17000 f6c3a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6c44000 f6c46000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6c4e000 f6c6b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6c74000 f6c78000 r-xp /usr/lib/libsmack.so.1.0.0
f6c81000 f6c9a000 r-xp /usr/lib/libnetwork.so.0.0.0
f6ca3000 f6cab000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6cb3000 f6cb9000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6cc2000 f6cc4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6ccd000 f6cdd000 r-xp /lib/libresolv-2.13.so
f6ce1000 f6cf9000 r-xp /usr/lib/liblzma.so.5.0.3
f6d02000 f6d04000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6d0c000 f6d26000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6d2e000 f6d5d000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6d66000 f6d75000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6d7f000 f6d89000 r-xp /usr/lib/libsensord-shared.so
f6d92000 f6e65000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6e70000 f6e86000 r-xp /lib/libz.so.1.2.5
f6e8e000 f6e93000 r-xp /usr/lib/libffi.so.5.0.10
f6e9b000 f6e9c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6ea4000 f6eb4000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6ebc000 f6ed5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6edd000 f6edf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6ee7000 f6f5c000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6f66000 f6f6c000 r-xp /lib/librt-2.13.so
f6f75000 f6f93000 r-xp /usr/lib/libsystemd.so.0.4.0
f6f9d000 f6f9e000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6fa6000 f6fc9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6fd1000 f6fd6000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6fde000 f7008000 r-xp /usr/lib/libdbus-1.so.3.8.12
f7011000 f7028000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f7030000 f7099000 r-xp /lib/libm-2.13.so
f70a2000 f7136000 r-xp /usr/lib/libstdc++.so.6.0.16
f7149000 f714e000 r-xp /usr/lib/libctx-client.so.0.8.3
f7156000 f715d000 r-xp /usr/lib/libctx-shared.so.0.8.3
f7165000 f718f000 r-xp /usr/lib/libsensor.so.1.9.6
f7198000 f7264000 r-xp /usr/lib/libxml2.so.2.7.8
f7271000 f7273000 r-xp /usr/lib/libiniparser.so.0
f727c000 f7282000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f728b000 f735b000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f735c000 f7390000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7399000 f73d5000 r-xp /usr/lib/libSLP-location.so.0.9.24
f73dd000 f73e0000 r-xp /usr/lib/libbundle.so.0.1.22
f73e8000 f73ee000 r-xp /usr/lib/libappsvc.so.0.1.0
f73f6000 f7437000 r-xp /usr/lib/libeina.so.1.7.99
f7440000 f7457000 r-xp /usr/lib/libecore.so.1.7.99
f746e000 f7477000 r-xp /usr/lib/libvconf.so.0.2.45
f747f000 f7493000 r-xp /lib/libpthread-2.13.so
f749e000 f74ab000 r-xp /usr/lib/libaul.so.0.1.0
f74b5000 f74b7000 r-xp /lib/libdl-2.13.so
f74c0000 f74cb000 r-xp /lib/libunwind.so.8.0.1
f74f8000 f7500000 r-xp /lib/libgcc_s-4.6.so.1
f7501000 f7625000 r-xp /lib/libc-2.13.so
f7633000 f7635000 r-xp /usr/lib/libdlog.so.0.0.0
f763d000 f7649000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7652000 f7657000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f765f000 f766e000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7676000 f767a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7683000 f7686000 r-xp /usr/lib/libappcore-agent.so.1.1
f768e000 f7690000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7698000 f769c000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f76a4000 f76c1000 r-xp /lib/ld-2.13.so
f76ca000 f76cd000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f76cd000 f76d1000 r-xp /usr/lib/libsys-assert.so
f79bb000 f7a46000 rw-p [heap]
ffdc1000 ffde2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:4403)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf76cb228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7662539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf73693f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf7367c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf7373e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7379be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7379dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf73ae75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf73a91f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf7367c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf7373e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7379be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7379dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf73abe5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf73ac017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf73b08d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf769a0bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4d3e171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6e11663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf72befcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf72c07a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7450ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf744bb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf744c5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf744c879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7684183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf76847fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76cb4f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf751885c) [/lib/libc.so.6] + 0x1785c
29: (0xf76caf2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
.ugr.frailty.gyroscope
04-23 18:18:37.211+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.231+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:221,9.434900,-0.430708,1.830509
04-23 18:18:37.231+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:221,-0.910000,-5.530000,-22.120001
04-23 18:18:37.311+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:18:37.311+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 18:18:37.321+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 18:18:37.321+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:18:37.321+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.331+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:332,9.475577,0.428315,2.469393
04-23 18:18:37.331+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.331+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:337,1.260000,4.060000,-24.710001
04-23 18:18:37.331+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.341+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.341+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:345,9.375079,0.356531,2.481357
04-23 18:18:37.351+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:342,-7.140000,1.820000,-18.969999
04-23 18:18:37.351+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.361+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:362,-5.950000,2.030000,-16.030001
04-23 18:18:37.361+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.361+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:37.361+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:37:369,75
04-23 18:18:37.371+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:366,9.506684,0.019143,2.670390
04-23 18:18:37.381+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.381+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.391+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:388,9.633504,0.074178,1.907080
04-23 18:18:37.391+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:387,9.520000,3.990000,-15.470000
04-23 18:18:37.391+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.391+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.441+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 18:18:37.441+0200 W/libgps  ( 3123): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(14213109), time2(14202539)
04-23 18:18:37.441+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 18:18:37.441+0200 W/libgps  ( 3123): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 18:18:37.451+0200 I/libgps_d( 3123): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 18:18:37.451+0200 W/gpsd    ( 3104): HandleIncomingMessage() dest id:2, msg id:25
04-23 18:18:37.471+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:401,9.731609,0.457029,1.885544
04-23 18:18:37.481+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.481+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:485,9.499505,1.088734,2.364109
04-23 18:18:37.481+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.481+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:490,9.219545,0.873380,2.868994
04-23 18:18:37.481+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.491+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:493,9.303294,0.595813,3.132205
04-23 18:18:37.491+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.491+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:497,9.420543,0.579063,2.938386
04-23 18:18:37.491+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.501+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:503,9.446864,0.748954,2.529213
04-23 18:18:37.501+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:401,23.660000,7.420000,-14.630000
04-23 18:18:37.501+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.501+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:508,16.940001,11.060000,-12.320000
04-23 18:18:37.501+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.511+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:512,-3.850000,9.520000,-6.440000
04-23 18:18:37.511+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.511+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:515,-9.940000,4.550000,-2.380000
04-23 18:18:37.511+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.511+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.521+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:522,9.573684,1.182054,2.385644
04-23 18:18:37.521+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:519,-1.820000,4.130000,-0.980000
04-23 18:18:37.521+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.521+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:528,4.200000,3.780000,-1.330000
04-23 18:18:37.521+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.521+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:531,-4.200000,1.120000,-0.840000
04-23 18:18:37.531+0200 W/LOCATION( 4403): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 18:18:37.531+0200 W/LOCATION( 4403): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 18:18:37.531+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.541+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.541+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:542,9.635897,1.093520,2.933600
04-23 18:18:37.541+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:545,-20.510000,-2.450000,2.800000
04-23 18:18:37.551+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.561+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.561+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:37.561+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:563,-28.770000,-5.670000,4.200000
04-23 18:18:37.571+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:565,9.437292,0.887737,3.153740
04-23 18:18:37.571+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:37:569,76
04-23 18:18:37.581+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.581+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:587,9.418150,0.643669,3.005385
04-23 18:18:37.581+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.591+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:587,-29.820000,-11.060000,6.440000
04-23 18:18:37.591+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.591+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.601+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:602,9.568897,0.454636,2.787638
04-23 18:18:37.601+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:602,-27.230000,-12.950000,8.260000
04-23 18:18:37.651+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.651+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:655,9.722038,0.332602,2.091327
04-23 18:18:37.661+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.661+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:18:37.671+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:672,-22.540001,-11.550000,10.360000
04-23 18:18:37.671+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.671+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:677,-31.430000,-9.170000,11.060000
04-23 18:18:37.671+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.671+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:681,-35.349998,-9.310000,15.330000
04-23 18:18:37.721+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_create(453) > New handle created[0xf7276300]
04-23 18:18:37.721+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 18:18:37.721+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 18:18:37.721+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 18:18:37.721+0200 I/CAPI_NETWORK_CONNECTION( 2317): connection.c: connection_get_type(507) > Connected Network = 2
04-23 18:18:37.731+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:18:37.731+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:18:37.741+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:18:37.751+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:18:37.751+0200 E/LOCATION( 2317): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 18:18:37.751+0200 I/LOCATION( 2317): location.c: location_new(269) > method: 1
04-23 18:18:37.751+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 18:18:37.751+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (gps) open success
04-23 18:18:37.751+0200 W/LOCATION( 2317): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 18:18:37.751+0200 W/LOCATION( 2317): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 18:18:37.751+0200 W/LOCATION( 2317): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 18:18:37.751+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 18:18:37.751+0200 W/LOCATION( 2317): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 18:18:37.761+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:18:37.761+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:18:37.761+0200 E/LOCATION( 2317): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 18:18:37.771+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:18:37.771+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:37.771+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:37:777,75
04-23 18:18:37.771+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.781+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:659,9.726824,0.425922,1.794617
04-23 18:18:37.781+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.781+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:791,9.513863,0.370888,2.467000
04-23 18:18:37.791+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.791+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.791+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:795,9.470792,0.239282,2.605784
04-23 18:18:37.801+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:795,-27.580000,-11.620000,18.690001
04-23 18:18:37.801+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.801+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.801+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:806,9.588040,0.272782,2.421536
04-23 18:18:37.801+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:807,-13.510000,-11.900000,19.950001
04-23 18:18:37.811+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.831+0200 I/SECURE_STORAGE( 2505): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 18:18:37.831+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.831+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:18:37.841+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:18:37.841+0200 E/LOCATION( 2317): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 18:18:37.841+0200 I/LOCATION( 2317): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 18:18:37.841+0200 I/LOCATION( 2317): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:18:37.861+0200 W/LOCATION( 4403): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 18:18:37.861+0200 I/LOCATION( 4403): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 18:18:37.861+0200 I/LOCATION( 4403): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 18:18:37.861+0200 I/location( 4403): es.ugr.frailty.location:iniciado servicio de localización
04-23 18:18:37.881+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:816,3.010000,-11.760000,21.629999
04-23 18:18:37.881+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.881+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:887,27.299999,-9.240000,21.559999
04-23 18:18:37.881+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.891+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:892,48.860001,-4.060000,22.400000
04-23 18:18:37.891+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.911+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:903,41.020000,0.770000,24.850000
04-23 18:18:37.911+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.911+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:917,20.580000,-0.140000,29.120001
04-23 18:18:37.911+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.911+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:920,6.020000,-3.990000,31.500000
04-23 18:18:37.931+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:836,9.542577,-0.222532,2.134398
04-23 18:18:37.931+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.931+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:937,9.655040,-0.303888,1.907080
04-23 18:18:37.931+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.931+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.941+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:925,1.540000,-2.450000,33.180000
04-23 18:18:37.941+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.941+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:946,15.330000,3.010000,31.710001
04-23 18:18:37.941+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.941+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:949,58.099998,13.790000,25.830000
04-23 18:18:37.941+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.951+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:941,9.729217,0.043071,1.883151
04-23 18:18:37.951+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.951+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:958,9.523434,0.155533,2.033899
04-23 18:18:37.961+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:37.971+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:37.971+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:953,106.959999,24.290001,15.190001
04-23 18:18:37.981+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.981+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:985,101.849998,25.480000,7.350000
04-23 18:18:37.981+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:37.991+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:37:972,75
04-23 18:18:37.991+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:37:971,9.422935,-0.342174,2.227718
04-23 18:18:37.991+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.001+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:0,9.489935,-0.488136,1.983650
04-23 18:18:38.001+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.001+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:7,9.516255,-0.978664,1.545763
04-23 18:18:38.001+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.001+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:11,9.777073,-1.555335,1.409373
04-23 18:18:38.011+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:37:993,38.220001,20.650000,9.100000
04-23 18:18:38.011+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.011+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:17,-22.540001,11.060000,9.730000
04-23 18:18:38.011+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.031+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:20,-30.100000,13.300000,5.110000
04-23 18:18:38.031+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.031+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:38,-27.440001,19.950001,-0.910000
04-23 18:18:38.031+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.031+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.041+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:42,9.772287,-2.261217,1.004985
04-23 18:18:38.041+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.041+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:47,9.865608,-2.507678,2.050649
04-23 18:18:38.041+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.041+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:50,9.853643,-0.646062,2.251646
04-23 18:18:38.041+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.071+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:42,-34.160000,18.200001,-4.760000
04-23 18:18:38.071+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.071+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:76,-35.980000,10.780000,-6.720000
04-23 18:18:38.071+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.071+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:79,-28.280001,3.850000,-8.470000
04-23 18:18:38.081+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:54,9.375079,-0.232104,2.036292
04-23 18:18:38.081+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.091+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:85,9.468399,-0.878166,2.093720
04-23 18:18:38.091+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.091+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.101+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:102,-18.340000,1.400000,-10.010000
04-23 18:18:38.101+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.101+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:106,-6.020000,-0.980000,-10.290000
04-23 18:18:38.101+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:98,9.645468,-1.337588,1.885544
04-23 18:18:38.101+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.101+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:110,9.600004,-1.304088,2.519642
04-23 18:18:38.101+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.111+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.121+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:122,-1.960000,-3.010000,-9.520000
04-23 18:18:38.121+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:113,9.367901,-1.117448,3.565305
04-23 18:18:38.121+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.121+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:128,9.233903,-1.550549,3.541377
04-23 18:18:38.121+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.131+0200 I/LOCATION( 4403): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:18:38.131+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.141+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:143,-6.510000,-4.200000,-8.890000
04-23 18:18:38.151+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:132,9.355937,-1.447658,3.586841
04-23 18:18:38.151+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.151+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:155,9.358330,-1.244268,3.211168
04-23 18:18:38.151+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.151+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.161+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:163,-8.400000,-6.580000,-6.650000
04-23 18:18:38.161+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:159,9.317651,-1.117448,2.916851
04-23 18:18:38.161+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:38.161+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:38:170,75
04-23 18:18:38.161+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.171+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:174,9.454042,-0.882952,3.046063
04-23 18:18:38.171+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.181+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.181+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:187,-1.330000,-6.580000,-5.950000
04-23 18:18:38.191+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:184,9.451650,-0.660419,3.132205
04-23 18:18:38.191+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.191+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.201+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:203,5.950000,-6.160000,-5.180000
04-23 18:18:38.201+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:197,9.396614,-0.660419,2.873780
04-23 18:18:38.201+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.211+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:212,9.468399,-0.512064,2.670390
04-23 18:18:38.211+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.221+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:222,4.480000,-4.480000,-3.990000
04-23 18:18:38.221+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.231+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:229,9.506684,-0.440279,2.141576
04-23 18:18:38.231+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.261+0200 W/libgps_d( 3123): OnGpsExtensionMessage: message_id(1), data(0xf78b8138), size(2752)
04-23 18:18:38.271+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:240,-1.820000,-4.620000,-2.940000
04-23 18:18:38.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,G)
04-23 18:18:38.271+0200 W/libgps_d( 3123): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 18:18:38.271+0200 W/libgps  ( 3123): proxy__gps_sv_status_cb : called
04-23 18:18:38.271+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.281+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:282,-3.150000,-10.570000,-1.750000
04-23 18:18:38.281+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.281+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.291+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:287,9.714860,-0.155533,2.419144
04-23 18:18:38.291+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:289,6.860000,-10.290000,-0.980000
04-23 18:18:38.291+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.291+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.301+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:300,15.890000,-5.670000,-3.500000
04-23 18:18:38.301+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:298,9.391829,-0.397209,2.701497
04-23 18:18:38.301+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.301+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:309,9.540184,-0.736989,2.569891
04-23 18:18:38.301+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.311+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:313,9.611969,-0.794417,2.222932
04-23 18:18:38.311+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.311+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:317,9.590433,-0.768096,1.770689
04-23 18:18:38.311+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.321+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:322,17.570000,-2.380000,-3.080000
04-23 18:18:38.321+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.321+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:326,9.729217,-0.488136,2.275574
04-23 18:18:38.331+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.331+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.341+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:343,11.550000,-1.330000,-2.240000
04-23 18:18:38.341+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:344,9.497113,-0.145962,2.567499
04-23 18:18:38.351+0200 E/location( 4403): es.ugr.frailty.location: error intentando obtener la última localización
04-23 18:18:38.351+0200 W/AUL     ( 4403): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 18:18:38.351+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:18:38.351+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4403
04-23 18:18:38.361+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4182
04-23 18:18:38.361+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:18:38.361+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(4182), cmd(0)
04-23 18:18:38.361+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:38.361+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.361+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.371+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:373,-2.940000,-5.460000,-0.140000
04-23 18:18:38.371+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:38:373,75
04-23 18:18:38.371+0200 W/CAPI_APPFW_APP_CONTROL( 4182): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:38.371+0200 I/utils   ( 4182): specific action
04-23 18:18:38.371+0200 W/CAPI_APPFW_APP_CONTROL( 4182): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:38.371+0200 W/CAPI_APPFW_APP_CONTROL( 4182): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:38.371+0200 W/CAPI_APPFW_APP_CONTROL( 4182): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:38.371+0200 W/AUL     ( 4182): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 18:18:38.371+0200 W/AUL_AMD ( 2476): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 18:18:38.371+0200 W/AUL_AMD ( 2476): amd_launch.c: _start_app(1782) > caller pid : 4182
04-23 18:18:38.381+0200 W/AUL_AMD ( 2476): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 4186
04-23 18:18:38.391+0200 W/CAPI_APPFW_APP_CONTROL( 4186): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:38.391+0200 I/utils   ( 4186): specific action
04-23 18:18:38.391+0200 W/CAPI_APPFW_APP_CONTROL( 4186): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:38.391+0200 W/CAPI_APPFW_APP_CONTROL( 4186): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:38.391+0200 W/CAPI_APPFW_APP_CONTROL( 4186): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:38.391+0200 W/CAPI_APPFW_APP_CONTROL( 4186): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:38.391+0200 I/recorder( 4186): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 18:18:38.391+0200 E/AUL_AMD ( 2476): amd_launch.c: __real_send(909) > send fail to client
04-23 18:18:38.391+0200 W/AUL_AMD ( 2476): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(4186), cmd(0)
04-23 18:18:38.391+0200 I/recorder( 4186): guardando datos en local
04-23 18:18:38.391+0200 W/AUL     ( 4182): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4186)
04-23 18:18:38.391+0200 I/servicemanager( 4182): request sent to service es.ugr.frailty.recorder
04-23 18:18:38.391+0200 I/servicemanager( 4182): requesting to save local data
04-23 18:18:38.391+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:373,9.427721,-0.260818,2.555535
04-23 18:18:38.391+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.391+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.401+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:403,-4.830000,-7.140000,0.280000
04-23 18:18:38.401+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:402,9.492328,-0.734596,2.469393
04-23 18:18:38.401+0200 W/AUL     ( 4403): launch.c: app_request_to_launchpad(298) > request cmd(0) result(4182)
04-23 18:18:38.401+0200 I/location( 4403): request sent to service es.ugr.frailty.servicemanager
04-23 18:18:38.401+0200 W/CAPI_APPFW_APP_CONTROL( 4403): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 18:18:38.401+0200 I/utils   ( 4403): specific action
04-23 18:18:38.411+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.411+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.421+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:420,9.240000,-5.600000,-1.610000
04-23 18:18:38.421+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:419,9.619147,-0.911665,2.294717
04-23 18:18:38.421+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.421+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.431+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:428,18.059999,-5.600000,-2.170000
04-23 18:18:38.431+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:429,9.717253,-0.746561,2.005185
04-23 18:18:38.431+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.431+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.451+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:444,9.940000,-2.030000,-3.500000
04-23 18:18:38.451+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:444,9.820145,-0.394816,2.081756
04-23 18:18:38.451+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.451+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.471+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:464,-5.530000,-3.500000,-1.680000
04-23 18:18:38.471+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:463,9.738789,-0.583849,2.254039
04-23 18:18:38.481+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.481+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.481+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:488,9.547362,-0.820738,2.744568
04-23 18:18:38.491+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:488,-12.390000,-5.250000,-2.030000
04-23 18:18:38.491+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.491+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.501+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:502,9.372685,-0.725025,2.545963
04-23 18:18:38.501+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:502,-4.340000,-8.120000,-1.750000
04-23 18:18:38.511+0200 I/LOCATION( 4403): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:18:38.511+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.511+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.521+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:523,9.789038,-0.851845,2.017149
04-23 18:18:38.521+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:522,11.060000,-8.400000,-3.150000
04-23 18:18:38.531+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.531+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.541+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:543,17.990000,-3.570000,-4.060000
04-23 18:18:38.541+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:543,9.757930,-0.598206,2.423929
04-23 18:18:38.551+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.551+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.561+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:563,13.090000,-0.770000,-4.900000
04-23 18:18:38.561+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:38.561+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:38:570,75
04-23 18:18:38.561+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:563,9.387043,-0.107677,2.541178
04-23 18:18:38.581+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.581+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.581+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:589,9.442079,-0.433101,2.129612
04-23 18:18:38.591+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:588,-4.410000,-4.970000,-0.840000
04-23 18:18:38.591+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.591+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.601+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:602,9.616754,-0.540778,1.806581
04-23 18:18:38.601+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:602,-5.040000,-3.990000,-2.030000
04-23 18:18:38.611+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.621+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.621+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:625,5.670000,-4.060000,-3.920000
04-23 18:18:38.621+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:624,9.810574,-0.863809,1.634298
04-23 18:18:38.651+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.661+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:663,9.657433,-0.741775,2.660819
04-23 18:18:38.661+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.671+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.671+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:665,8.190000,1.960000,-4.550000
04-23 18:18:38.671+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.691+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:683,6.930000,0.980000,-6.230000
04-23 18:18:38.711+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:681,9.324830,-0.114855,2.514857
04-23 18:18:38.711+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.711+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.721+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:718,9.655040,-0.447458,2.117648
04-23 18:18:38.721+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:719,-1.680000,-4.690000,-5.110000
04-23 18:18:38.731+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.731+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.751+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:736,0.420000,0.490000,-8.470000
04-23 18:18:38.751+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:735,9.722038,-0.390030,2.230111
04-23 18:18:38.761+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.761+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.761+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:38.771+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:38:770,75
04-23 18:18:38.781+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:18:38.791+0200 I/AUL     ( 2317): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 18:18:38.791+0200 E/LOCATION( 2317): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 18:18:38.791+0200 I/LOCATION( 2317): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 18:18:38.791+0200 I/LOCATION( 2317): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 18:18:38.811+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:766,9.513863,-0.500100,2.136791
04-23 18:18:38.811+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:766,1.330000,0.630000,-8.680000
04-23 18:18:38.811+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.811+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.821+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:819,9.477970,-0.521635,2.445465
04-23 18:18:38.821+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:820,-0.420000,0.070000,-7.210000
04-23 18:18:38.831+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.831+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.841+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:840,-1.960000,-0.840000,-6.930000
04-23 18:18:38.851+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:839,9.363115,-0.344566,2.316252
04-23 18:18:38.861+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.861+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.891+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:867,9.724431,-0.387637,1.909473
04-23 18:18:38.911+0200 E/CAPI_TELEPHONY( 2317): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 18:18:38.921+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:867,0.840000,-0.420000,-8.260000
04-23 18:18:38.921+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.921+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.931+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:932,9.561719,-0.413958,2.060220
04-23 18:18:38.931+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:932,1.470000,0.560000,-9.870000
04-23 18:18:38.931+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:38.931+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.941+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:942,-3.710000,-1.260000,-10.360000
04-23 18:18:38.951+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:38:941,9.394222,-0.713061,2.057827
04-23 18:18:38.951+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:38.971+0200 I/heartrate( 4210): capturing data from es.ugr.frailty.heartrate
04-23 18:18:39.001+0200 I/heartrate( 4210): es.ugr.frailty.heartrate: SM-R760,23/04/2018,18:18:38:984,75
04-23 18:18:39.001+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:39.011+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:38:960,-3.780000,-2.590000,-11.130000
04-23 18:18:39.021+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:39:13,9.552148,-0.217747,2.280360
04-23 18:18:39.021+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:39.021+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:39.021+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:39:26,-8.190000,-2.800000,-11.060000
04-23 18:18:39.021+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:39:26,9.669396,0.023928,2.409572
04-23 18:18:39.031+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:39.031+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:39.041+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:39:41,-7.770000,-0.490000,-12.110000
04-23 18:18:39.041+0200 I/accelerometer( 4390): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,18:18:39:40,9.662218,-0.256032,1.708475
04-23 18:18:39.041+0200 I/accelerometer( 4390): capturing data from es.ugr.frailty.accelerometer
04-23 18:18:39.041+0200 I/gyroscope( 4411): capturing data from es.ugr.frailty.gyroscope
04-23 18:18:39.051+0200 I/gyroscope( 4411): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,18:18:39:54,-0.140000,2.660000,-12.250000
04-23 18:18:39.051+0200 W/CRASH_MANAGER( 4246): worker.c: worker_job(1205) > 11044036c6f63152450031
