S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 11991
Date: 2018-06-07 16:53:12+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf73ea52d, r5   = 0xf795ef98
r6   = 0xffa5a190, r7   = 0xffa5a040
r8   = 0xf795bc18, r9   = 0x00000000
r10  = 0xffa5a11c, fp   = 0xffa5a190
ip   = 0x00000001, sp   = 0xffa5a018
lr   = 0xf73ea539, pc   = 0xf7453228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:    103000 KB
Buffers:     15316 KB
Cached:     127816 KB
VmPeak:      52528 KB
VmSize:      52524 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       12000 KB
VmRSS:       12000 KB
VmData:      10252 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 11991 TID = 11991
11991 11995 

Maps Information
f42b5000 f4ab4000 rw-p [stack:11995]
f4abb000 f4abd000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f4ac5000 f4ac9000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f4ad2000 f4ad4000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4adc000 f4adf000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4aee000 f4af3000 r-xp /usr/lib/libsystem.so.0.0.0
f4afe000 f4b01000 r-xp /lib/libattr.so.1.1.0
f4b09000 f4b19000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4b21000 f4b2a000 r-xp /usr/lib/libedbus.so.1.7.99
f4b32000 f4b33000 r-xp /usr/lib/libresponse.so.0.2.96
f4b3c000 f4b41000 r-xp /usr/lib/libproc-stat.so.0.2.96
f63e3000 f64e9000 r-xp /usr/lib/libicuuc.so.57.1
f64ff000 f6687000 r-xp /usr/lib/libicui18n.so.57.1
f6697000 f66a4000 r-xp /usr/lib/libail.so.0.1.0
f66ad000 f66b4000 r-xp /usr/lib/libminizip.so.1.0.0
f66bd000 f6866000 r-xp /usr/lib/libcrypto.so.1.0.0
f6886000 f68cd000 r-xp /usr/lib/libssl.so.1.0.0
f68d9000 f68db000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f68e3000 f68ea000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f68f3000 f68fa000 r-xp /lib/libcrypt-2.13.so
f692b000 f692e000 r-xp /lib/libcap.so.2.21
f6936000 f6938000 r-xp /usr/lib/libiri.so
f6940000 f6989000 r-xp /usr/lib/libmdm.so.1.2.69
f6991000 f6997000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f699f000 f69c2000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f69cc000 f69ce000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f69d6000 f69f3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f69fc000 f6a00000 r-xp /usr/lib/libsmack.so.1.0.0
f6a09000 f6a22000 r-xp /usr/lib/libnetwork.so.0.0.0
f6a2b000 f6a33000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6a3b000 f6a41000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6a4a000 f6a4c000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f6a55000 f6a65000 r-xp /lib/libresolv-2.13.so
f6a69000 f6a81000 r-xp /usr/lib/liblzma.so.5.0.3
f6a8a000 f6a8c000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f6a94000 f6aae000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f6ab6000 f6ae5000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6aee000 f6afd000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f6b07000 f6b11000 r-xp /usr/lib/libsensord-shared.so
f6b1a000 f6bed000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f6bf8000 f6c0e000 r-xp /lib/libz.so.1.2.5
f6c16000 f6c1b000 r-xp /usr/lib/libffi.so.5.0.10
f6c23000 f6c24000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6c2c000 f6c3c000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f6c44000 f6c5d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f6c65000 f6c67000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6c6f000 f6ce4000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6cee000 f6cf4000 r-xp /lib/librt-2.13.so
f6cfd000 f6d1b000 r-xp /usr/lib/libsystemd.so.0.4.0
f6d25000 f6d26000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6d2e000 f6d51000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6d59000 f6d5e000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6d66000 f6d90000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6d99000 f6db0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6db8000 f6e21000 r-xp /lib/libm-2.13.so
f6e2a000 f6ebe000 r-xp /usr/lib/libstdc++.so.6.0.16
f6ed1000 f6ed6000 r-xp /usr/lib/libctx-client.so.0.8.3
f6ede000 f6ee5000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6eed000 f6f17000 r-xp /usr/lib/libsensor.so.1.9.6
f6f20000 f6fec000 r-xp /usr/lib/libxml2.so.2.7.8
f6ff9000 f6ffb000 r-xp /usr/lib/libiniparser.so.0
f7004000 f700a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f7013000 f70e3000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f70e4000 f7118000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f7121000 f715d000 r-xp /usr/lib/libSLP-location.so.0.9.24
f7165000 f7168000 r-xp /usr/lib/libbundle.so.0.1.22
f7170000 f7176000 r-xp /usr/lib/libappsvc.so.0.1.0
f717e000 f71bf000 r-xp /usr/lib/libeina.so.1.7.99
f71c8000 f71df000 r-xp /usr/lib/libecore.so.1.7.99
f71f6000 f71ff000 r-xp /usr/lib/libvconf.so.0.2.45
f7207000 f721b000 r-xp /lib/libpthread-2.13.so
f7226000 f7233000 r-xp /usr/lib/libaul.so.0.1.0
f723d000 f723f000 r-xp /lib/libdl-2.13.so
f7248000 f7253000 r-xp /lib/libunwind.so.8.0.1
f7280000 f7288000 r-xp /lib/libgcc_s-4.6.so.1
f7289000 f73ad000 r-xp /lib/libc-2.13.so
f73bb000 f73bd000 r-xp /usr/lib/libdlog.so.0.0.0
f73c5000 f73d1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f73da000 f73df000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f73e7000 f73f6000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f73fe000 f7402000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f740b000 f740e000 r-xp /usr/lib/libappcore-agent.so.1.1
f7416000 f7418000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7420000 f7424000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f742c000 f7449000 r-xp /lib/ld-2.13.so
f7452000 f7455000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f7455000 f7459000 r-xp /usr/lib/libsys-assert.so
f792b000 f79b9000 rw-p [heap]
ffa3b000 ffa5c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:11991)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7453228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf73ea539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf70f13f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf70efc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf70fbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf7101be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf7101dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf713675b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf71311f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf70efc55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf70fbe57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf7101be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf7101dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf7133e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf7134017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf713bf93) [/usr/lib/libSLP-location.so.0] + 0x1af93
16: (0xf4ad31fb) [/usr/lib/location/module/libwps.so] + 0x11fb
17: (0xf4ac6171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf6b99663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf7046fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf70487a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf71d8ca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf71d3b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf71d45a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf71d4879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf740c183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf740c7fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf74535c3) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x15c3
28: __libc_start_main + 0x114 (0xf72a085c) [/lib/libc.so.6] + 0x1785c
29: (0xf7452f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
11:936,2.641676,-0.488136,9.451650
06-07 16:53:11.931+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:11.931+0200 W/CAPI_APPFW_APP_CONTROL(11827): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:11.931+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:11.931+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(22) , send fd(15), pid(11827), cmd(0)
06-07 16:53:11.941+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:11:941,0.104556,0.049855,-0.110104
06-07 16:53:11.941+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:11:945,2.699972,-0.687819,9.402523
06-07 16:53:11.941+0200 I/utils   (11827): specific action
06-07 16:53:11.941+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:11.951+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:11.951+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:11.951+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:11:958,2.648855,-0.492921,9.494720
06-07 16:53:11.961+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:11:952,1.610000,0.070000,-0.350000
06-07 16:53:11.961+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:11.961+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:11:966,2.688852,-0.686839,9.405781
06-07 16:53:11.961+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:11.961+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:11:971,1.680000,0.210000,-0.350000
06-07 16:53:11.971+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:11:963,0.041426,0.033818,0.155261
06-07 16:53:11.971+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:11.971+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:11:978,2.682354,-0.452243,9.487542
06-07 16:53:11.971+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:11.971+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:11.981+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:11.981+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:11:984,-0.119841,0.330794,0.175521
06-07 16:53:11.991+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:11.991+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:11:996,2.624927,-0.413958,9.456435
06-07 16:53:11.991+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:11.991+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:11:985,2.677649,-0.679234,9.409528
06-07 16:53:11.991+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.001+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:12.011+0200 I/WIFI_EFL(10916): app_main.c: __wifi_manager_background_scan_cb(689) > [Enter]
06-07 16:53:12.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:53:12.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:53:12.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:53:12.071+0200 I/CAPI_NETWORK_WIFI(10916): libnetwork.c: __libnet_update_profile_iterator(227) > Wi-Fi profile count: 5
06-07 16:53:12.071+0200 I/WIFI_EFL(10916): wifi_manager.c: __update_ap_list_foreach(370) > EAP type AP skip(No SIM model).
06-07 16:53:12.071+0200 I/WIFI_EFL(10916): layout_scan.c: layout_scan_ap_list_clear_data(453) > AP data list is empty.
06-07 16:53:12.071+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:53:12.071+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:53:12.081+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:53:12.081+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:53:12.081+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:53:12.081+0200 E/EFL     (10916): elementary<10916> elm_genlist.c:6966 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
06-07 16:53:12.131+0200 I/WIFI_EFL(10916): layout_scan.c: layout_scan_ap_list_update(432) > AP list update success and AP data list clear.
06-07 16:53:12.131+0200 I/WIFI_EFL(10916): layout_scan.c: layout_scan_ap_list_show(364) > AP list layout exists in naviframe.
06-07 16:53:12.131+0200 I/WIFI_EFL(10916): wifi_manager.c: _update_wifi_config_list(183) > [Enter]
06-07 16:53:12.141+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:12.141+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:12:147,1030.000000
06-07 16:53:12.151+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:12:13,89
06-07 16:53:12.191+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:11:993,-0.210000,0.350000,-0.420000
06-07 16:53:12.201+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.201+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:12.211+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:12:212,89
06-07 16:53:12.211+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.211+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:221,-0.770000,-0.420000,-0.350000
06-07 16:53:12.221+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:12.221+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:12:230,1032.000000
06-07 16:53:12.231+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:5,-0.205262,0.229032,0.109280
06-07 16:53:12.231+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:196,2.672688,-0.673769,9.411331
06-07 16:53:12.231+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.241+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.241+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:248,2.667897,-0.671562,9.412848
06-07 16:53:12.251+0200 E/CAPI_NETWORK_WIFI(10916): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
06-07 16:53:12.261+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:238,2.632105,-0.459422,9.533006
06-07 16:53:12.261+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.261+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.261+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.271+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:252,-0.179114,-0.252337,0.123113
06-07 16:53:12.271+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.271+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:267,0.420000,-0.420000,-0.420000
06-07 16:53:12.281+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.281+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:270,2.648855,-0.440279,9.480364
06-07 16:53:12.291+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:281,2.667594,-0.668679,9.413139
06-07 16:53:12.291+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.291+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:284,-0.173863,-0.502736,0.219726
06-07 16:53:12.301+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.301+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.301+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:297,1.190000,0.630000,-0.140000
06-07 16:53:12.311+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:300,2.641676,-0.454636,9.509077
06-07 16:53:12.311+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:313,2.672529,-0.674157,9.411348
06-07 16:53:12.311+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.321+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.321+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:317,-0.153757,-0.198837,0.166492
06-07 16:53:12.321+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:330,0.980000,0.980000,-0.210000
06-07 16:53:12.331+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.331+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:53:12.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:53:12.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:53:12.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:53:12.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390392346,000000, pattern:[H:mm][0;m
06-07 16:53:12.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:53:12.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:53:12.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:53:12.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:53:12.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:53:12.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:53][0;m
06-07 16:53:12.351+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:349,-0.285775,-0.022962,-0.028501
06-07 16:53:12.351+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:335,2.634498,-0.476172,9.485149
06-07 16:53:12.351+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.351+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.361+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:345,2.666350,-0.677069,9.412892
06-07 16:53:12.361+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.361+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.371+0200 I/servicemanager(11799): es.ugr.frailty.accelerometer alive timeout
06-07 16:53:12.371+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.accelerometer)
06-07 16:53:12.371+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:377,2.655480,-0.675334,9.416089
06-07 16:53:12.381+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:362,2.605784,-0.413958,9.463614
06-07 16:53:12.381+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:381,-0.370504,-0.116954,0.183242
06-07 16:53:12.381+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:363,0.910000,1.470000,-0.490000
06-07 16:53:12.381+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.381+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.401+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.401+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.401+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:12.401+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:12:411,90
06-07 16:53:12.411+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:12.411+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:12.421+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11823
06-07 16:53:12.421+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11823)
06-07 16:53:12.421+0200 I/servicemanager(11799): es.ugr.frailty.accelerometer launch request sent!
06-07 16:53:12.421+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:12.421+0200 I/servicemanager(11799): es.ugr.frailty.gyroscope alive timeout
06-07 16:53:12.421+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gyroscope)
06-07 16:53:12.421+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:12.421+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:12.431+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11827
06-07 16:53:12.431+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11827)
06-07 16:53:12.431+0200 I/servicemanager(11799): es.ugr.frailty.gyroscope launch request sent!
06-07 16:53:12.431+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:12.431+0200 I/servicemanager(11799): es.ugr.frailty.heartrate alive timeout
06-07 16:53:12.431+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.heartrate)
06-07 16:53:12.431+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:12.441+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:12.451+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11839
06-07 16:53:12.451+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11839)
06-07 16:53:12.451+0200 I/servicemanager(11799): es.ugr.frailty.heartrate launch request sent!
06-07 16:53:12.451+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:12.451+0200 I/servicemanager(11799): es.ugr.frailty.location alive timeout
06-07 16:53:12.451+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.location)
06-07 16:53:12.451+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:12.451+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:12.461+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11991
06-07 16:53:12.461+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11991)
06-07 16:53:12.461+0200 I/servicemanager(11799): es.ugr.frailty.location launch request sent!
06-07 16:53:12.461+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:12.461+0200 I/servicemanager(11799): es.ugr.frailty.linearacceleration alive timeout
06-07 16:53:12.461+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.linearacceleration)
06-07 16:53:12.461+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:12.461+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:12.481+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11854
06-07 16:53:12.481+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11854)
06-07 16:53:12.481+0200 I/servicemanager(11799): es.ugr.frailty.linearacceleration launch request sent!
06-07 16:53:12.481+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:12.481+0200 I/servicemanager(11799): es.ugr.frailty.gravity alive timeout
06-07 16:53:12.481+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
06-07 16:53:12.481+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:12.481+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:12.491+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11864
06-07 16:53:12.491+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11864)
06-07 16:53:12.491+0200 I/servicemanager(11799): es.ugr.frailty.gravity launch request sent!
06-07 16:53:12.491+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:12.491+0200 I/servicemanager(11799): es.ugr.frailty.pressure alive timeout
06-07 16:53:12.491+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pressure)
06-07 16:53:12.491+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:12.491+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:12.501+0200 W/CAPI_APPFW_APP_CONTROL(11991): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:12.501+0200 I/utils   (11991): specific action
06-07 16:53:12.501+0200 W/LOCATION(11991): location-hybrid.c: hybrid_get_current_method(139) > Current Method [2]
06-07 16:53:12.501+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11875
06-07 16:53:12.511+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:12.511+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(11991), cmd(0)
06-07 16:53:12.511+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11875)
06-07 16:53:12.511+0200 I/servicemanager(11799): es.ugr.frailty.pressure launch request sent!
06-07 16:53:12.511+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:12.511+0200 I/servicemanager(11799): es.ugr.frailty.light alive timeout
06-07 16:53:12.511+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.light)
06-07 16:53:12.511+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:12.511+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:12.521+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11887
06-07 16:53:12.521+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11887)
06-07 16:53:12.521+0200 I/servicemanager(11799): es.ugr.frailty.light launch request sent!
06-07 16:53:12.521+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:12.521+0200 I/servicemanager(11799): es.ugr.frailty.pedometer alive timeout
06-07 16:53:12.521+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.pedometer)
06-07 16:53:12.521+0200 W/AUL_AMD ( 2479): amd_request.c: __request_handler(669) > __request_handler: 0
06-07 16:53:12.521+0200 W/AUL_AMD ( 2479): amd_launch.c: _start_app(1782) > caller pid : 11799
06-07 16:53:12.531+0200 W/AUL_AMD ( 2479): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 11894
06-07 16:53:12.541+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:12.541+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(32) , send fd(15), pid(11894), cmd(0)
06-07 16:53:12.541+0200 W/CAPI_APPFW_APP_CONTROL(11894): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:12.541+0200 I/utils   (11894): specific action
06-07 16:53:12.541+0200 W/AUL     (11799): launch.c: app_request_to_launchpad(298) > request cmd(0) result(11894)
06-07 16:53:12.541+0200 I/servicemanager(11799): es.ugr.frailty.pedometer launch request sent!
06-07 16:53:12.541+0200 I/servicemanager(11799): App control destroyed.
06-07 16:53:12.541+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:12.541+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(31) , send fd(15), pid(11875), cmd(0)
06-07 16:53:12.541+0200 W/CAPI_APPFW_APP_CONTROL(11875): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:12.541+0200 I/utils   (11875): specific action
06-07 16:53:12.581+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:12.581+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(28) , send fd(15), pid(11887), cmd(0)
06-07 16:53:12.581+0200 W/CAPI_APPFW_APP_CONTROL(11887): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:12.581+0200 I/utils   (11887): specific action
06-07 16:53:12.581+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:12.581+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:12:588,1032.000000
06-07 16:53:12.581+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:12.581+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(27) , send fd(15), pid(11839), cmd(0)
06-07 16:53:12.581+0200 W/CAPI_APPFW_APP_CONTROL(11839): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:12.581+0200 I/utils   (11839): specific action
06-07 16:53:12.591+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:394,2.586641,-0.468993,9.466006
06-07 16:53:12.591+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:398,0.980000,1.190000,-0.420000
06-07 16:53:12.601+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:408,2.660757,-0.675483,9.414589
06-07 16:53:12.601+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.611+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.611+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:617,-1.120000,-0.140000,-0.280000
06-07 16:53:12.611+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:415,-0.462938,-0.263382,0.153425
06-07 16:53:12.611+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.611+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.631+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:627,-0.374241,-0.165088,0.337260
06-07 16:53:12.631+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:612,2.663212,-0.442672,9.458827
06-07 16:53:12.631+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.631+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.641+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:626,2.662510,-0.680543,9.413729
06-07 16:53:12.641+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.641+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.651+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:12.651+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:12:658,89
06-07 16:53:12.651+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:12.661+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:12:664,1032.000000
06-07 16:53:12.671+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:643,2.691926,-0.382852,9.571291
06-07 16:53:12.681+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:686,2.652028,-0.678580,9.416828
06-07 16:53:12.681+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:647,1.050000,1.750000,-0.840000
06-07 16:53:12.701+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.701+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.711+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:686,-0.504179,-0.232269,0.210896
06-07 16:53:12.711+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.721+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.721+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:715,1.190000,1.260000,-0.420000
06-07 16:53:12.741+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:712,2.567499,-0.521635,9.317651
06-07 16:53:12.741+0200 E/CAPI_NETWORK_WIFI(10916): wifi_config.c: _wifi_last_error_to_enum(93) > Not supported error type (connect-failed)
06-07 16:53:12.751+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.751+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.771+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:733,2.642762,-0.672982,9.419835
06-07 16:53:12.771+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:736,-0.349092,-0.107988,-0.018942
06-07 16:53:12.771+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.771+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.811+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:12.811+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:12:820,89
06-07 16:53:12.821+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:768,2.725425,-0.394816,9.401401
06-07 16:53:12.821+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:12.821+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:12:829,1032.000000
06-07 16:53:12.831+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:772,-0.140000,0.140000,0.560000
06-07 16:53:12.831+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.841+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:787,2.647494,-0.672774,9.418521
06-07 16:53:12.841+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.841+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:786,-0.290209,-0.238008,0.309317
06-07 16:53:12.851+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.851+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.861+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:860,-0.238292,-0.028080,0.037193
06-07 16:53:12.861+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:843,2.510071,-0.421137,9.475577
06-07 16:53:12.861+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.861+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:851,-0.770000,0.630000,0.420000
06-07 16:53:12.861+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.871+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:860,2.647354,-0.672447,9.418584
06-07 16:53:12.871+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.871+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.881+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:874,2.615355,-0.275175,9.485149
06-07 16:53:12.881+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:879,0.420000,0.490000,0.630000
06-07 16:53:12.891+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:890,-0.259227,-0.024934,0.081102
06-07 16:53:12.891+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.901+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.901+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:892,2.640332,-0.670212,9.420713
06-07 16:53:12.901+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.911+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.921+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:905,2.653640,-0.387637,9.542577
06-07 16:53:12.921+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.921+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:910,-0.140000,0.630000,0.280000
06-07 16:53:12.921+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.931+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:922,2.629097,-0.664865,9.424234
06-07 16:53:12.931+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:918,-0.280518,-0.161128,0.106940
06-07 16:53:12.941+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.941+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.941+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:930,2.622534,-0.378066,9.506684
06-07 16:53:12.941+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:950,-0.237038,-0.022671,0.118153
06-07 16:53:12.951+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.951+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:941,-0.630000,0.630000,0.350000
06-07 16:53:12.961+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:962,2.689533,-0.416351,9.449257
06-07 16:53:12.961+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:12.961+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:12.961+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:955,2.616928,-0.657432,9.428142
06-07 16:53:12.971+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:12.971+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(26) , send fd(15), pid(11864), cmd(0)
06-07 16:53:12.971+0200 W/CAPI_APPFW_APP_CONTROL(11864): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:12.981+0200 I/utils   (11864): specific action
06-07 16:53:12.981+0200 E/AUL_AMD ( 2479): amd_launch.c: __real_send(909) > send fail to client
06-07 16:53:12.981+0200 W/AUL_AMD ( 2479): amd_launch.c: __reply_handler(999) > listen fd(30) , send fd(15), pid(11864), cmd(0)
06-07 16:53:12.981+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:12.981+0200 W/CAPI_APPFW_APP_CONTROL(11864): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
06-07 16:53:12.981+0200 I/utils   (11864): specific action
06-07 16:53:12.981+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:12.991+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:12:991,2.606163,-0.649465,9.431675
06-07 16:53:12.991+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:12:979,-0.222904,-0.059705,0.117813
06-07 16:53:12.991+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:12:972,-0.910000,0.140000,0.490000
06-07 16:53:13.001+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.001+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:6,-0.172057,-0.065580,0.134943
06-07 16:53:13.001+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:13.011+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:13:12,89
06-07 16:53:13.011+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.011+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:17,-0.071626,-0.154682,0.140341
06-07 16:53:13.011+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.021+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:22,-0.098790,-0.211957,0.100691
06-07 16:53:13.021+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:13.021+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:13:29,1032.000000
06-07 16:53:13.021+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:13.031+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:12:992,2.610569,-0.435494,9.497113
06-07 16:53:13.031+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.031+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.041+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:13.051+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:46,-0.229958,-0.133863,0.083983
06-07 16:53:13.051+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:13:34,-0.630000,-0.280000,0.700000
06-07 16:53:13.061+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:13.061+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:13:47,2.596212,-0.375673,9.430114
06-07 16:53:13.061+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:51,2.605000,-0.644896,9.432310
06-07 16:53:13.061+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.061+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.061+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:13.071+0200 W/libgps_d( 3131): OnGpsExtensionMessage: message_id(1), data(0xf7cebb38), size(2752)
06-07 16:53:13.071+0200 W/libgps_d( 3131): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,g)
06-07 16:53:13.071+0200 W/libgps  ( 3131): proxy__gps_sv_status_cb : called
06-07 16:53:13.081+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:13:66,-1.680000,-0.770000,0.770000
06-07 16:53:13.081+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:73,2.611161,-0.648926,9.430329
06-07 16:53:13.081+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:77,-0.191627,-0.127451,0.111184
06-07 16:53:13.091+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:13:75,2.591427,-0.358923,9.456435
06-07 16:53:13.091+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:13.101+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.101+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.101+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:13.121+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:112,2.610568,-0.650664,9.430374
06-07 16:53:13.121+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:13:104,-3.290000,-0.980000,0.280000
06-07 16:53:13.121+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:13.121+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:117,-0.095159,-0.037187,0.016026
06-07 16:53:13.131+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.131+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:13:118,2.593820,-0.325424,9.544970
06-07 16:53:13.131+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.141+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:13.141+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:148,2.604967,-0.646363,9.432219
06-07 16:53:13.141+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:151,-0.066214,0.062243,0.108727
06-07 16:53:13.151+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:13:156,2.589034,-0.279960,9.566505
06-07 16:53:13.151+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:13:139,-1.260000,-0.350000,-0.140000
06-07 16:53:13.161+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.161+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:13.161+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:13.161+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.161+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:171,2.596090,-0.637976,9.435237
06-07 16:53:13.171+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:178,-0.086002,0.055843,0.072987
06-07 16:53:13.181+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:13:175,2.629712,-0.397209,9.499505
06-07 16:53:13.181+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:13:170,3.290000,0.490000,-0.350000
06-07 16:53:13.181+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:13.181+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.191+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.191+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:13.191+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:13:197,2.870000,0.700000,-0.560000
06-07 16:53:13.201+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:13.211+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:13:212,89
06-07 16:53:13.211+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:205,-0.123513,0.064880,0.126170
06-07 16:53:13.211+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:201,2.590415,-0.631407,9.437238
06-07 16:53:13.211+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:13:206,2.644069,-0.466600,9.523434
06-07 16:53:13.221+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:13.221+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:13:229,1032.000000
06-07 16:53:13.221+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.231+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:13.231+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:13.231+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.251+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:13:244,2.723032,-0.521635,9.487542
06-07 16:53:13.251+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:245,-0.066945,0.101493,0.084389
06-07 16:53:13.251+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:13:239,0.910000,-0.210000,-0.350000
06-07 16:53:13.251+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:13.251+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:248,2.585943,-0.627813,9.438704
06-07 16:53:13.251+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.261+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:13.271+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.271+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:275,2.581663,-0.623539,9.440159
06-07 16:53:13.281+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:13:269,0.420000,0.070000,-0.490000
06-07 16:53:13.281+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:270,-0.020354,-0.126309,0.082323
06-07 16:53:13.281+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:13:273,2.715853,-0.442672,9.466006
06-07 16:53:13.281+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.281+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:13.291+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.291+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:13.301+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:305,-0.051708,-0.213631,0.084368
06-07 16:53:13.301+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:13:302,2.629712,-0.318245,9.403792
06-07 16:53:13.311+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:303,2.570045,-0.615625,9.443848
06-07 16:53:13.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:53:13.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:53:13.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:53:13.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:53:13.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(147) > [1;35mts:1528390393351,000000, pattern:[H:mm][0;m
06-07 16:53:13.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
06-07 16:53:13.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
06-07 16:53:13.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
06-07 16:53:13.341+0200 E/TIZEN_N_SYSTEM_SETTINGS(11356): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
06-07 16:53:13.341+0200 E/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(170) > [0;40;31mlocale es_ES[0;m
06-07 16:53:13.341+0200 W/WSLib   (11356): ICUStringUtil.cpp: GetStrFromIcu(195) > [1;35mformattedString:[16:53][0;m
06-07 16:53:13.351+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.351+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:356,2.562336,-0.603248,9.446741
06-07 16:53:13.351+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.361+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:361,2.562110,-0.595213,9.447311
06-07 16:53:13.361+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.361+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:368,2.566082,-0.594831,9.446258
06-07 16:53:13.361+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.371+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.371+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:374,2.567356,-0.594479,9.445933
06-07 16:53:13.381+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:13:298,-0.070000,0.490000,-0.420000
06-07 16:53:13.381+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:13.381+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:13.381+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.401+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:382,-0.043939,-0.087455,0.018020
06-07 16:53:13.401+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:13:395,-0.070000,0.210000,-0.350000
06-07 16:53:13.401+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:13:393,2.622534,-0.313460,9.494720
06-07 16:53:13.401+0200 I/heartrate(11839): es.ugr.frailty.heartrate - capturing data
06-07 16:53:13.411+0200 I/heartrate(11839): es.ugr.frailty.heartrate: SM-R760,07/06/2018,16:53:13:412,89
06-07 16:53:13.411+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.421+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:13.421+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:13.421+0200 I/light   (11887): es.ugr.frailty.light - capturing data
06-07 16:53:13.421+0200 I/light   (11887): es.ugr.frailty.light: SM-R760,07/06/2018,16:53:13:429,1030.000000
06-07 16:53:13.421+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:400,2.565806,-0.590797,9.446586
06-07 16:53:13.431+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer: SM-R760,07/06/2018,16:53:13:434,2.622534,-0.449851,9.451650
06-07 16:53:13.431+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.431+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:13:439,0.140000,0.210000,-0.560000
06-07 16:53:13.441+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration: SM-R760,07/06/2018,16:53:13:422,-0.016069,0.033598,0.041083
06-07 16:53:13.441+0200 I/linearacceleration(11854): es.ugr.frailty.linearacceleration - capturing data
06-07 16:53:13.441+0200 I/gravity (11864): es.ugr.frailty.gravity: SM-R760,07/06/2018,16:53:13:444,2.564666,-0.586384,9.447170
06-07 16:53:13.451+0200 I/accelerometer(11823): es.ugr.frailty.accelerometer - capturing data
06-07 16:53:13.451+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope - capturing data
06-07 16:53:13.451+0200 I/gravity (11864): es.ugr.frailty.gravity - capturing data
06-07 16:53:13.461+0200 I/gyroscope(11827): es.ugr.frailty.gyroscope: SM-R760,07/06/2018,16:53:13:465,0.560000,-0.210000,-0.700000
06-07 16:53:13.461+0200 W/CRASH_MANAGER(11751): worker.c: worker_job(1205) > 11119916c6f63152838319
