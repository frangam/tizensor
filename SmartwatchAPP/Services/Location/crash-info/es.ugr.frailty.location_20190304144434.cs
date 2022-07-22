S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 3684
Date: 2019-03-04 14:44:34+0100
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf75a052d, r5   = 0xf7aadfe0
r6   = 0xffc3ab48, r7   = 0xffc3a9f8
r8   = 0xf7a7fc18, r9   = 0x00000000
r10  = 0xffc3aad4, fp   = 0xffc3ab48
ip   = 0x00000001, sp   = 0xffc3a9d0
lr   = 0xf75a0539, pc   = 0xf760927c
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    295040 KB
Buffers:      4108 KB
Cached:      53108 KB
VmPeak:      53548 KB
VmSize:      53544 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11224 KB
VmRSS:        8320 KB
VmData:      11272 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 3684 TID = 3684
3684 3764 

Maps Information
f446b000 f4c6a000 rw-p [stack:3764]
f4c71000 f4c73000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4c7b000 f4c7f000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4c88000 f4c8a000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4c92000 f4c95000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4ca4000 f4ca9000 r-xp /usr/lib/libsystem.so.0.0.0
f4cb4000 f4cb7000 r-xp /lib/libattr.so.1.1.0
f4cbf000 f4ccf000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4cd7000 f4ce0000 r-xp /usr/lib/libedbus.so.1.7.99
f4ce8000 f4ce9000 r-xp /usr/lib/libresponse.so.0.2.96
f4cf2000 f4cf7000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6599000 f669f000 r-xp /usr/lib/libicuuc.so.57.1
f66b5000 f683d000 r-xp /usr/lib/libicui18n.so.57.1
f684d000 f685a000 r-xp /usr/lib/libail.so.0.1.0
f6863000 f686a000 r-xp /usr/lib/libminizip.so.1.0.0
f6873000 f6a1c000 r-xp /usr/lib/libcrypto.so.1.0.0
f6a3c000 f6a83000 r-xp /usr/lib/libssl.so.1.0.0
f6a8f000 f6a91000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6a99000 f6aa0000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6aa9000 f6ab0000 r-xp /lib/libcrypt-2.13.so
f6ae1000 f6ae4000 r-xp /lib/libcap.so.2.21
f6aec000 f6aee000 r-xp /usr/lib/libiri.so
f6af6000 f6b3f000 r-xp /usr/lib/libmdm.so.1.2.69
f6b47000 f6b4d000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f6b55000 f6b78000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f6b82000 f6b84000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f6b8c000 f6ba9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6bb2000 f6bb6000 r-xp /usr/lib/libsmack.so.1.0.0
f6bbf000 f6bd8000 r-xp /usr/lib/libnetwork.so.0.0.0
f6be1000 f6be9000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6bf1000 f6bf7000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6c00000 f6c02000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6c0b000 f6c1b000 r-xp /lib/libresolv-2.13.so
f6c1f000 f6c37000 r-xp /usr/lib/liblzma.so.5.0.3
f6c40000 f6c42000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6c4a000 f6c64000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6c6c000 f6c9b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6ca4000 f6cb3000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6cbd000 f6cc7000 r-xp /usr/lib/libsensord-shared.so
f6cd0000 f6da3000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6dae000 f6dc4000 r-xp /lib/libz.so.1.2.5
f6dcc000 f6dd1000 r-xp /usr/lib/libffi.so.5.0.10
f6dd9000 f6dda000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6de2000 f6df2000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6dfa000 f6e13000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6e1b000 f6e1d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6e25000 f6e9a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6ea4000 f6ec2000 r-xp /usr/lib/libsystemd.so.0.4.0
f6ecc000 f6ecd000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6ed5000 f6ef8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6f00000 f6f05000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6f0d000 f6f37000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6f40000 f6f57000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6f5f000 f6f65000 r-xp /lib/librt-2.13.so
f6f6e000 f6fd7000 r-xp /lib/libm-2.13.so
f6fe0000 f7074000 r-xp /usr/lib/libstdc++.so.6.0.16
f7087000 f708c000 r-xp /usr/lib/libctx-client.so.0.8.3
f7094000 f709b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f70a3000 f70cd000 r-xp /usr/lib/libsensor.so.1.9.6
f70d6000 f71a2000 r-xp /usr/lib/libxml2.so.2.7.8
f71af000 f71b1000 r-xp /usr/lib/libiniparser.so.0
f71ba000 f71c0000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f71c9000 f7299000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f729a000 f72ce000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f72d7000 f7313000 r-xp /usr/lib/libSLP-location.so.0.9.24
f731b000 f731e000 r-xp /usr/lib/libbundle.so.0.1.22
f7326000 f732c000 r-xp /usr/lib/libappsvc.so.0.1.0
f7334000 f7375000 r-xp /usr/lib/libeina.so.1.7.99
f737e000 f7387000 r-xp /usr/lib/libvconf.so.0.2.45
f738f000 f73a3000 r-xp /lib/libpthread-2.13.so
f73ae000 f73bb000 r-xp /usr/lib/libaul.so.0.1.0
f73c5000 f73c7000 r-xp /lib/libdl-2.13.so
f73d0000 f73db000 r-xp /lib/libunwind.so.8.0.1
f7408000 f7410000 r-xp /lib/libgcc_s-4.6.so.1
f7411000 f7535000 r-xp /lib/libc-2.13.so
f7543000 f755a000 r-xp /usr/lib/libecore.so.1.7.99
f7571000 f7573000 r-xp /usr/lib/libdlog.so.0.0.0
f757b000 f7587000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7590000 f7595000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f759d000 f75ac000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f75b4000 f75b8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f75c1000 f75c4000 r-xp /usr/lib/libappcore-agent.so.1.1
f75cc000 f75ce000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f75d6000 f75da000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f75e2000 f75ff000 r-xp /lib/ld-2.13.so
f7608000 f760b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f760b000 f760f000 r-xp /usr/lib/libsys-assert.so
f7a79000 f7b02000 rw-p [heap]
ffc1c000 ffc3d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:3684)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf760927c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x127c
 1: (0xf75a0539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf72a73f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf72a5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf72b1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf72b7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf72b7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf72ec75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf72e71f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf72a5c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf72b1e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf72b7be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf72b7dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf72e9e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf72ea017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf72ee8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf75d80bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf4c7c171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6d4f663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf71fcfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf71fe7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf7553ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf754eb4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf754f5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf754f879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf75c2183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf75c27fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf76096bb) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x16bb
28: __libc_start_main + 0x114 (0xf742885c) [/lib/libc.so.6] + 0x1785c
29: (0xf7608f74) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf74
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
rtrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:22.359+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:22.353,76
03-04 14:44:22.379+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:22.389+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:22.384,1064.000000
03-04 14:44:22.549+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:22.549+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:22.552,76
03-04 14:44:22.579+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:22.589+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:22.586,1064.000000
03-04 14:44:22.609+0100 E/CAPI_APPFW_APP_CONTROL( 3684): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
03-04 14:44:22.609+0100 E/location( 3684): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
03-04 14:44:22.749+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:22.759+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:22.752,76
03-04 14:44:22.779+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:22.789+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:22.785,1064.000000
03-04 14:44:22.949+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:22.959+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:22.952,76
03-04 14:44:23.029+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 14:44:23.029+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
03-04 14:44:23.029+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 14:44:23.039+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:23.079+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:23.42,1064.000000
03-04 14:44:23.149+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:23.159+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:23.153,76
03-04 14:44:23.179+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:23.189+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:23.185,1065.000000
03-04 14:44:23.349+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:23.359+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:23.353,76
03-04 14:44:23.379+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:23.389+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:23.387,1065.000000
03-04 14:44:23.549+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:23.559+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:23.552,77
03-04 14:44:23.579+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:23.589+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:23.585,1065.000000
03-04 14:44:23.749+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:23.759+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:23.752,77
03-04 14:44:23.779+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:23.789+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:23.785,1065.000000
03-04 14:44:23.949+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:23.959+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:23.953,77
03-04 14:44:24.019+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 14:44:24.019+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
03-04 14:44:24.029+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 14:44:24.029+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:24.049+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:24.34,1067.000000
03-04 14:44:24.149+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:24.159+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:24.154,77
03-04 14:44:24.179+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:24.189+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:24.185,1068.000000
03-04 14:44:24.349+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:24.359+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:24.355,77
03-04 14:44:24.379+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:24.389+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:24.386,1068.000000
03-04 14:44:24.549+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:24.559+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:24.555,77
03-04 14:44:24.579+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:24.589+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:24.586,1069.000000
03-04 14:44:24.749+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:24.759+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:24.753,77
03-04 14:44:24.779+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:24.789+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:24.788,1068.000000
03-04 14:44:24.949+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:24.959+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:24.953,77
03-04 14:44:25.019+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 14:44:25.029+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
03-04 14:44:25.029+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 14:44:25.029+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:25.049+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:25.39,1069.000000
03-04 14:44:25.149+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:25.159+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:25.154,77
03-04 14:44:25.179+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:25.189+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:25.186,1069.000000
03-04 14:44:25.349+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:25.359+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:25.354,77
03-04 14:44:25.379+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:25.389+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:25.388,1069.000000
03-04 14:44:25.549+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:25.559+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:25.554,77
03-04 14:44:25.579+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:25.589+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:25.586,1069.000000
03-04 14:44:25.749+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:25.759+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:25.754,77
03-04 14:44:25.779+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:25.789+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:25.786,1069.000000
03-04 14:44:25.949+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:25.959+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:25.954,77
03-04 14:44:26.019+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 14:44:26.029+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
03-04 14:44:26.029+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 14:44:26.029+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:26.049+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:26.38,1069.000000
03-04 14:44:26.099+0100 W/AUL     ( 3679): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
03-04 14:44:26.099+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:44:26.109+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 3679
03-04 14:44:26.129+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3650
03-04 14:44:26.139+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:44:26.139+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(3650), cmd(0)
03-04 14:44:26.139+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.139+0100 I/utils   ( 3650): specific action
03-04 14:44:26.139+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.139+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.139+0100 W/AUL     ( 3679): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3650)
03-04 14:44:26.139+0100 I/servicemanager( 3650): requesting to save local data for es.ugr.frailty.heartrate
03-04 14:44:26.139+0100 W/AUL     ( 3650): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
03-04 14:44:26.149+0100 I/heartrate( 3679): request sent to service es.ugr.frailty.servicemanager
03-04 14:44:26.149+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:26.159+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:44:26.159+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 3650
03-04 14:44:26.179+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:26.179+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3653
03-04 14:44:26.189+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:44:26.189+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(3653), cmd(0)
03-04 14:44:26.189+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:26.189,1069.000000
03-04 14:44:26.189+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.189+0100 I/utils   ( 3653): specific action
03-04 14:44:26.189+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.189+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.189+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.189+0100 I/recorder( 3653): saving local data for es.ugr.frailty.heartrate
03-04 14:44:26.189+0100 I/recorder( 3653): es.ugr.frailty.heartrate file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.heartrate.csv
03-04 14:44:26.199+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:26.156,77
03-04 14:44:26.199+0100 W/AUL     ( 3650): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3653)
03-04 14:44:26.199+0100 I/servicemanager( 3650): request sent to service es.ugr.frailty.recorder
03-04 14:44:26.199+0100 I/servicemanager( 3650): requesting to save local data
03-04 14:44:26.349+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:26.359+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:26.355,77
03-04 14:44:26.379+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:26.389+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:26.387,1069.000000
03-04 14:44:26.419+0100 E/CAPI_APPFW_APP_CONTROL( 3720): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
03-04 14:44:26.419+0100 E/pressure( 3720): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.pressure; data: 
03-04 14:44:26.469+0100 W/AUL     ( 3733): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
03-04 14:44:26.469+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:44:26.479+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 3733
03-04 14:44:26.489+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3650
03-04 14:44:26.499+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.499+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:44:26.499+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(3650), cmd(0)
03-04 14:44:26.499+0100 W/AUL     ( 3733): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3650)
03-04 14:44:26.499+0100 I/light   ( 3733): request sent to service es.ugr.frailty.servicemanager
03-04 14:44:26.499+0100 I/utils   ( 3650): specific action
03-04 14:44:26.499+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.499+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.499+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.499+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.499+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.499+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.499+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.499+0100 I/servicemanager( 3650): requesting to save local data for es.ugr.frailty.light
03-04 14:44:26.499+0100 W/AUL     ( 3650): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
03-04 14:44:26.499+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:44:26.499+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 3650
03-04 14:44:26.519+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3653
03-04 14:44:26.529+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.529+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:44:26.529+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(3653), cmd(0)
03-04 14:44:26.529+0100 I/utils   ( 3653): specific action
03-04 14:44:26.529+0100 W/AUL     ( 3650): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3653)
03-04 14:44:26.529+0100 I/servicemanager( 3650): request sent to service es.ugr.frailty.recorder
03-04 14:44:26.529+0100 I/servicemanager( 3650): requesting to save local data
03-04 14:44:26.529+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.529+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.529+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.529+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.529+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.529+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.529+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.529+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:26.529+0100 I/recorder( 3653): saving local data for es.ugr.frailty.light
03-04 14:44:26.529+0100 I/recorder( 3653): es.ugr.frailty.light file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
03-04 14:44:26.549+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:26.559+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:26.556,77
03-04 14:44:26.579+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:26.589+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:26.587,1069.000000
03-04 14:44:26.609+0100 E/CAPI_APPFW_APP_CONTROL( 3747): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
03-04 14:44:26.609+0100 E/pedometer( 3747): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.pedometer; data: 
03-04 14:44:26.749+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:26.759+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:26.757,76
03-04 14:44:26.779+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:26.789+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:26.787,1077.000000
03-04 14:44:26.949+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:26.959+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:26.955,76
03-04 14:44:27.019+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 14:44:27.029+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
03-04 14:44:27.029+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 14:44:27.029+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:27.049+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:27.34,1150.000000
03-04 14:44:27.149+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:27.159+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:27.155,76
03-04 14:44:27.179+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:27.189+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:27.187,1122.000000
03-04 14:44:27.349+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:27.359+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:27.356,76
03-04 14:44:27.379+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:27.389+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:27.389,1093.000000
03-04 14:44:27.549+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:27.559+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:27.555,76
03-04 14:44:27.579+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:27.589+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:27.588,1107.000000
03-04 14:44:27.609+0100 E/CAPI_APPFW_APP_CONTROL( 3684): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
03-04 14:44:27.609+0100 E/location( 3684): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
03-04 14:44:27.749+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:27.759+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:27.755,76
03-04 14:44:27.779+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:27.789+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:27.788,1110.000000
03-04 14:44:27.949+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:27.959+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:27.955,76
03-04 14:44:28.049+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 14:44:28.049+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
03-04 14:44:28.049+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 14:44:28.059+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:28.069+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:28.63,1114.000000
03-04 14:44:28.149+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:28.159+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:28.155,75
03-04 14:44:28.179+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:28.189+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:28.190,1121.000000
03-04 14:44:28.349+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:28.359+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:28.356,75
03-04 14:44:28.379+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:28.389+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:28.389,1118.000000
03-04 14:44:28.549+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:28.559+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:28.556,75
03-04 14:44:28.579+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:28.589+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:28.589,1112.000000
03-04 14:44:28.749+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:28.759+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:28.756,75
03-04 14:44:28.779+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:28.789+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:28.790,1108.000000
03-04 14:44:28.949+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:28.959+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:28.956,75
03-04 14:44:29.019+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 14:44:29.029+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
03-04 14:44:29.029+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 14:44:29.029+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:29.039+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:29.35,1103.000000
03-04 14:44:29.149+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:29.159+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:29.159,75
03-04 14:44:29.179+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:29.189+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:29.190,1102.000000
03-04 14:44:29.349+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:29.369+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:29.357,75
03-04 14:44:29.389+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:29.389+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:29.391,1102.000000
03-04 14:44:29.549+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:29.559+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:29.556,75
03-04 14:44:29.579+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:29.589+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:29.591,1102.000000
03-04 14:44:29.749+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:29.759+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:29.756,74
03-04 14:44:29.779+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:29.789+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:29.790,1102.000000
03-04 14:44:29.949+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:29.959+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:29.957,74
03-04 14:44:30.019+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 14:44:30.029+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
03-04 14:44:30.029+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 14:44:30.029+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:30.049+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:30.36,1102.000000
03-04 14:44:30.149+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:30.159+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:30.161,75
03-04 14:44:30.179+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:30.189+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:30.189,1100.000000
03-04 14:44:30.349+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:30.359+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:30.358,74
03-04 14:44:30.379+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:30.389+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:30.390,1085.000000
03-04 14:44:30.549+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:30.559+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:30.557,74
03-04 14:44:30.579+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:30.589+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:30.590,1066.000000
03-04 14:44:30.749+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:30.759+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:30.757,74
03-04 14:44:30.779+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:30.799+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:30.790,1060.000000
03-04 14:44:30.949+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:30.959+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:30.957,74
03-04 14:44:31.019+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 14:44:31.029+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
03-04 14:44:31.029+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 14:44:31.029+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:31.059+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:31.39,1067.000000
03-04 14:44:31.099+0100 W/AUL     ( 3679): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
03-04 14:44:31.109+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:44:31.109+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 3679
03-04 14:44:31.139+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3650
03-04 14:44:31.139+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:44:31.139+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(3650), cmd(0)
03-04 14:44:31.139+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.139+0100 I/utils   ( 3650): specific action
03-04 14:44:31.149+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.149+0100 W/AUL     ( 3679): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3650)
03-04 14:44:31.149+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.149+0100 I/heartrate( 3679): request sent to service es.ugr.frailty.servicemanager
03-04 14:44:31.149+0100 I/servicemanager( 3650): requesting to save local data for es.ugr.frailty.heartrate
03-04 14:44:31.149+0100 W/AUL     ( 3650): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
03-04 14:44:31.149+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:31.159+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:44:31.169+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 3650
03-04 14:44:31.189+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3653
03-04 14:44:31.189+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:44:31.189+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(3653), cmd(0)
03-04 14:44:31.189+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.189+0100 I/utils   ( 3653): specific action
03-04 14:44:31.189+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.189+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.189+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.199+0100 I/recorder( 3653): saving local data for es.ugr.frailty.heartrate
03-04 14:44:31.199+0100 I/recorder( 3653): es.ugr.frailty.heartrate file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.heartrate.csv
03-04 14:44:31.199+0100 W/AUL     ( 3650): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3653)
03-04 14:44:31.199+0100 I/servicemanager( 3650): request sent to service es.ugr.frailty.recorder
03-04 14:44:31.199+0100 I/servicemanager( 3650): requesting to save local data
03-04 14:44:31.209+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:31.219+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:31.162,74
03-04 14:44:31.219+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:31.217,1069.000000
03-04 14:44:31.359+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:31.359+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:31.361,74
03-04 14:44:31.389+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:31.389+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:31.392,1062.000000
03-04 14:44:31.419+0100 E/CAPI_APPFW_APP_CONTROL( 3720): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
03-04 14:44:31.419+0100 E/pressure( 3720): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.pressure; data: 
03-04 14:44:31.469+0100 W/AUL     ( 3733): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
03-04 14:44:31.469+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:44:31.479+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 3733
03-04 14:44:31.489+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3650
03-04 14:44:31.489+0100 W/AUL     ( 3733): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3650)
03-04 14:44:31.489+0100 I/light   ( 3733): request sent to service es.ugr.frailty.servicemanager
03-04 14:44:31.489+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:44:31.489+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(3650), cmd(0)
03-04 14:44:31.489+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.489+0100 I/utils   ( 3650): specific action
03-04 14:44:31.489+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.489+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.489+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.489+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.489+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.489+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.489+0100 W/CAPI_APPFW_APP_CONTROL( 3650): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.489+0100 I/servicemanager( 3650): requesting to save local data for es.ugr.frailty.light
03-04 14:44:31.489+0100 W/AUL     ( 3650): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
03-04 14:44:31.499+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 0
03-04 14:44:31.499+0100 W/AUL_AMD ( 2470): amd_launch.c: _start_app(1782) > caller pid : 3650
03-04 14:44:31.519+0100 W/AUL_AMD ( 2470): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 3653
03-04 14:44:31.519+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.519+0100 E/AUL_AMD ( 2470): amd_launch.c: __real_send(909) > send fail to client
03-04 14:44:31.519+0100 W/AUL_AMD ( 2470): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(21), pid(3653), cmd(0)
03-04 14:44:31.519+0100 W/AUL     ( 3650): launch.c: app_request_to_launchpad(298) > request cmd(0) result(3653)
03-04 14:44:31.519+0100 I/servicemanager( 3650): request sent to service es.ugr.frailty.recorder
03-04 14:44:31.519+0100 I/servicemanager( 3650): requesting to save local data
03-04 14:44:31.519+0100 I/utils   ( 3653): specific action
03-04 14:44:31.519+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.519+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.519+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.519+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.519+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.519+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.519+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.519+0100 W/CAPI_APPFW_APP_CONTROL( 3653): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
03-04 14:44:31.519+0100 I/recorder( 3653): saving local data for es.ugr.frailty.light
03-04 14:44:31.519+0100 I/recorder( 3653): es.ugr.frailty.light file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.light.csv
03-04 14:44:31.549+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:31.559+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:31.559,74
03-04 14:44:31.589+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:31.589+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:31.592,1119.000000
03-04 14:44:31.609+0100 E/CAPI_APPFW_APP_CONTROL( 3747): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
03-04 14:44:31.609+0100 E/pedometer( 3747): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.pedometer; data: 
03-04 14:44:31.749+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:31.759+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:31.760,74
03-04 14:44:31.789+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:31.789+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:31.792,1064.000000
03-04 14:44:31.959+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:31.959+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:31.962,75
03-04 14:44:31.989+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:31.999+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:31.995,1034.000000
03-04 14:44:32.029+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 14:44:32.029+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
03-04 14:44:32.029+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 14:44:32.159+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:32.159+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:32.161,75
03-04 14:44:32.189+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:32.189+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:32.192,1054.000000
03-04 14:44:32.349+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:32.369+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:32.361,75
03-04 14:44:32.389+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:32.399+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:32.394,1034.000000
03-04 14:44:32.549+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:32.559+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:32.559,75
03-04 14:44:32.589+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:32.599+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:32.593,1089.000000
03-04 14:44:32.609+0100 E/CAPI_APPFW_APP_CONTROL( 3684): app_control.c: app_control_error(138) > [app_control_add_extra_data] INVALID_PARAMETER(0xffffffea)
03-04 14:44:32.609+0100 E/location( 3684): request sending failed to service es.ugr.frailty.servicemanager; message: es.ugr.frailty.location; data: 
03-04 14:44:32.749+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:32.759+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:32.759,75
03-04 14:44:32.789+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:32.799+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:32.793,1116.000000
03-04 14:44:32.949+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:32.959+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:32.960,75
03-04 14:44:33.039+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 14:44:33.059+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
03-04 14:44:33.059+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 14:44:33.059+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:33.069+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:33.67,1116.000000
03-04 14:44:33.149+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:33.169+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:33.160,76
03-04 14:44:33.189+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:33.199+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:33.193,1118.000000
03-04 14:44:33.349+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:33.359+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:33.360,76
03-04 14:44:33.389+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:33.399+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:33.394,1116.000000
03-04 14:44:33.549+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:33.559+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:33.560,76
03-04 14:44:33.589+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:33.599+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:33.593,1116.000000
03-04 14:44:33.759+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:33.759+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:33.761,76
03-04 14:44:33.789+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:33.799+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:33.794,1115.000000
03-04 14:44:33.949+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:33.959+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:33.960,75
03-04 14:44:34.039+0100 W/libgps_d( 3110): OnGpsExtensionMessage: message_id(1), data(0xf7b43738), size(2752)
03-04 14:44:34.049+0100 W/libgps_d( 3110): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
03-04 14:44:34.049+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:34.079+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:34.57,1112.000000
03-04 14:44:34.109+0100 W/libgps_d( 3110): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
03-04 14:44:34.109+0100 W/libgps  ( 3110): proxy__gps_sv_status_cb : called
03-04 14:44:34.139+0100 E/CAPI_LOCATION_MANAGER( 3765): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
03-04 14:44:34.149+0100 I/AUL     ( 3765): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
03-04 14:44:34.149+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:34.159+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:34.161,75
03-04 14:44:34.169+0100 I/AUL     ( 3765): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
03-04 14:44:34.169+0100 E/LOCATION( 3765): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
03-04 14:44:34.169+0100 I/LOCATION( 3765): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
03-04 14:44:34.169+0100 I/LOCATION( 3765): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
03-04 14:44:34.189+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:34.209+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:34.194,1115.000000
03-04 14:44:34.249+0100 I/LOCATION( 3684): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
03-04 14:44:34.349+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:34.359+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:34.360,75
03-04 14:44:34.389+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:34.389+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:34.393,1115.000000
03-04 14:44:34.469+0100 W/AUL     ( 3841): daemon-manager-release-agent.c: main(12) > release agent : [2:/es.ugr.frailty.location]
03-04 14:44:34.469+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(669) > __request_handler: 23
03-04 14:44:34.469+0100 W/AUL_AMD ( 2470): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
03-04 14:44:34.469+0100 W/AUL_AMD ( 2470): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 3684
03-04 14:44:34.469+0100 W/AUL_AMD ( 2470): amd_request.c: __send_app_termination_signal(528) > send dead signal done
03-04 14:44:34.479+0100 W/libgps_d( 3110): GpsiHook: API: gpsStop(GpsiHookStateGps: e,c,G)
03-04 14:44:34.479+0100 W/libgps  ( 3110): [proxy__gps_stop][line = 1067]: called.
03-04 14:44:34.489+0100 W/libgps_d( 3110): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,G)
03-04 14:44:34.489+0100 W/libgps_d( 3110): GpsiHook::deliverStatus() GPS_STATUS_SESSION_END
03-04 14:44:34.489+0100 W/libgps_d( 3110): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: E,c,G)
03-04 14:44:34.489+0100 E/CAPI_LOCATION_MANAGER( 3765): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
03-04 14:44:34.489+0100 W/libgps_d( 3110): GpsiHookStateGps              : EXIT
03-04 14:44:34.489+0100 W/gpsd    ( 3094): HandleIncomingMessage() dest id:0, msg id:2
03-04 14:44:34.489+0100 W/libgps_d( 3110): GpsiHookStateIdle             : ENTRY
03-04 14:44:34.499+0100 I/AUL_AMD ( 2470): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 3684
03-04 14:44:34.499+0100 W/AUL     ( 2470): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(3684)
03-04 14:44:34.559+0100 I/SECURE_STORAGE( 2502): ss_server_ipc.c: SsServerComm(251) > write succeed
03-04 14:44:34.559+0100 I/heartrate( 3679): es.ugr.frailty.heartrate - capturing data
03-04 14:44:34.559+0100 I/heartrate( 3679): es.ugr.frailty.heartrate: SM-R760,04/03/2019,14:44:34.561,75
03-04 14:44:34.589+0100 I/light   ( 3733): es.ugr.frailty.light - capturing data
03-04 14:44:34.609+0100 I/light   ( 3733): es.ugr.frailty.light: SM-R760,04/03/2019,14:44:34.598,1114.000000
03-04 14:44:34.669+0100 I/CAPI_NETWORK_CONNECTION( 3765): connection.c: __connection_set_type_changed_callback(195) > Successfully de-registered(0)
03-04 14:44:34.669+0100 I/CAPI_NETWORK_CONNECTION( 3765): connection.c: __connection_set_ip_changed_callback(295) > Successfully de-registered(0)
03-04 14:44:34.669+0100 I/CAPI_NETWORK_CONNECTION( 3765): connection.c: __connection_set_proxy_changed_callback(395) > Successfully de-registered(0)
03-04 14:44:34.669+0100 I/CAPI_NETWORK_CONNECTION( 3765): connection.c: connection_destroy(471) > Destroy handle: 0xf7613348
03-04 14:44:34.689+0100 W/CRASH_MANAGER( 3840): worker.c: worker_job(1205) > 11036846c6f63155170707
