S/W Version Information
Model: SM-R760
Tizen-Version: 2.3.2.3
Build-Number: R760XXU2BQC5
Build-Date: 2017.03.15 16:06:31

Crash Information
Process Name: location
PID: 22025
Date: 2018-04-23 19:47:11+0200
Executable File Path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
r0   = 0x00000000, r1   = 0x00000000
r2   = 0x00000000, r3   = 0x00000001
r4   = 0xf711052d, r5   = 0xf7501f98
r6   = 0xffaa26a8, r7   = 0xffaa2558
r8   = 0xf74fec18, r9   = 0x00000000
r10  = 0xffaa2634, fp   = 0xffaa26a8
ip   = 0x00000001, sp   = 0xffaa2530
lr   = 0xf7110539, pc   = 0xf7179228
cpsr = 0x60000030

Memory Information
MemTotal:   714612 KB
MemFree:     15500 KB
Buffers:     57764 KB
Cached:     226016 KB
VmPeak:      53552 KB
VmSize:      53548 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       11964 KB
VmRSS:       11964 KB
VmData:      11276 KB
VmStk:         136 KB
VmExe:          12 KB
VmLib:       13932 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 22025 TID = 22025
22025 22054 

Maps Information
f3fdb000 f47da000 rw-p [stack:22054]
f47e1000 f47e3000 r-xp /usr/lib/location/module/libremote_wps.so.0.5.88
f47eb000 f47ef000 r-xp /usr/lib/liblbs-dbus.so.0.1.0
f47f8000 f47fa000 r-xp /usr/lib/location/module/libwps.so.0.5.88
f4802000 f4805000 r-xp /usr/lib/location/module/libremote_gps.so.0.5.88
f4814000 f4819000 r-xp /usr/lib/libsystem.so.0.0.0
f4824000 f4827000 r-xp /lib/libattr.so.1.1.0
f482f000 f483f000 r-xp /usr/lib/libmdm-common.so.1.1.24
f4847000 f4850000 r-xp /usr/lib/libedbus.so.1.7.99
f4858000 f4859000 r-xp /usr/lib/libresponse.so.0.2.96
f4862000 f4867000 r-xp /usr/lib/libproc-stat.so.0.2.96
f6109000 f620f000 r-xp /usr/lib/libicuuc.so.57.1
f6225000 f63ad000 r-xp /usr/lib/libicui18n.so.57.1
f63bd000 f63ca000 r-xp /usr/lib/libail.so.0.1.0
f63d3000 f63da000 r-xp /usr/lib/libminizip.so.1.0.0
f63e3000 f658c000 r-xp /usr/lib/libcrypto.so.1.0.0
f65ac000 f65f3000 r-xp /usr/lib/libssl.so.1.0.0
f65ff000 f6601000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
f6609000 f6610000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
f6619000 f6620000 r-xp /lib/libcrypt-2.13.so
f6651000 f6654000 r-xp /lib/libcap.so.2.21
f665c000 f665e000 r-xp /usr/lib/libiri.so
f6666000 f66af000 r-xp /usr/lib/libmdm.so.1.2.69
f66b7000 f66bd000 r-xp /usr/lib/libcsc-feature.so.0.0.0
f66c5000 f66e8000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
f66f2000 f66f4000 r-xp /usr/lib/journal/libjournal.so.0.1.0
f66fc000 f6719000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
f6722000 f6726000 r-xp /usr/lib/libsmack.so.1.0.0
f672f000 f6748000 r-xp /usr/lib/libnetwork.so.0.0.0
f6751000 f6759000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
f6761000 f6767000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
f6770000 f6772000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
f677b000 f678b000 r-xp /lib/libresolv-2.13.so
f678f000 f67a7000 r-xp /usr/lib/liblzma.so.5.0.3
f67b0000 f67b2000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
f67ba000 f67d4000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
f67dc000 f680b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
f6814000 f6823000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
f682d000 f6837000 r-xp /usr/lib/libsensord-shared.so
f6840000 f6913000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
f691e000 f6934000 r-xp /lib/libz.so.1.2.5
f693c000 f6941000 r-xp /usr/lib/libffi.so.5.0.10
f6949000 f694a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
f6952000 f6962000 r-xp /usr/lib/libcapi-network-connection.so.1.0.64
f696a000 f6983000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
f698b000 f698d000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
f6995000 f6a0a000 r-xp /usr/lib/libsqlite3.so.0.8.6
f6a14000 f6a1a000 r-xp /lib/librt-2.13.so
f6a23000 f6a41000 r-xp /usr/lib/libsystemd.so.0.4.0
f6a4b000 f6a4c000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
f6a54000 f6a77000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
f6a7f000 f6a84000 r-xp /usr/lib/libxdgmime.so.1.1.0
f6a8c000 f6ab6000 r-xp /usr/lib/libdbus-1.so.3.8.12
f6abf000 f6ad6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
f6ade000 f6b47000 r-xp /lib/libm-2.13.so
f6b50000 f6be4000 r-xp /usr/lib/libstdc++.so.6.0.16
f6bf7000 f6bfc000 r-xp /usr/lib/libctx-client.so.0.8.3
f6c04000 f6c0b000 r-xp /usr/lib/libctx-shared.so.0.8.3
f6c13000 f6c3d000 r-xp /usr/lib/libsensor.so.1.9.6
f6c46000 f6d12000 r-xp /usr/lib/libxml2.so.2.7.8
f6d1f000 f6d21000 r-xp /usr/lib/libiniparser.so.0
f6d2a000 f6d30000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
f6d39000 f6e09000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
f6e0a000 f6e3e000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
f6e47000 f6e83000 r-xp /usr/lib/libSLP-location.so.0.9.24
f6e8b000 f6e8e000 r-xp /usr/lib/libbundle.so.0.1.22
f6e96000 f6e9c000 r-xp /usr/lib/libappsvc.so.0.1.0
f6ea4000 f6ee5000 r-xp /usr/lib/libeina.so.1.7.99
f6eee000 f6f05000 r-xp /usr/lib/libecore.so.1.7.99
f6f1c000 f6f25000 r-xp /usr/lib/libvconf.so.0.2.45
f6f2d000 f6f41000 r-xp /lib/libpthread-2.13.so
f6f4c000 f6f59000 r-xp /usr/lib/libaul.so.0.1.0
f6f63000 f6f65000 r-xp /lib/libdl-2.13.so
f6f6e000 f6f79000 r-xp /lib/libunwind.so.8.0.1
f6fa6000 f6fae000 r-xp /lib/libgcc_s-4.6.so.1
f6faf000 f70d3000 r-xp /lib/libc-2.13.so
f70e1000 f70e3000 r-xp /usr/lib/libdlog.so.0.0.0
f70eb000 f70f7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
f7100000 f7105000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
f710d000 f711c000 r-xp /usr/lib/libcapi-location-manager.so.0.4.9
f7124000 f7128000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
f7131000 f7134000 r-xp /usr/lib/libappcore-agent.so.1.1
f713c000 f713e000 r-xp /usr/lib/liblbs-agps.so.0.1.0
f7146000 f714a000 r-xp /usr/lib/location/module/libgps.so.0.5.88
f7152000 f716f000 r-xp /lib/ld-2.13.so
f7178000 f717b000 r-xp /opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location
f717b000 f717f000 r-xp /usr/lib/libsys-assert.so
f74ce000 f7558000 rw-p [heap]
ffa83000 ffaa4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:22025)
Call Stack Count: 30
 0: state_changed_cb + 0x1f (0xf7179228) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x1228
 1: (0xf7110539) [/usr/lib/libcapi-location-manager.so.0] + 0x3539
 2: g_cclosure_marshal_VOID__UINT + 0x48 (0xf6e173f9) [/usr/lib/libgobject-2.0.so.0] + 0xd3f9
 3: g_closure_invoke + 0x108 (0xf6e15c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
 4: (0xf6e21e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
 5: g_signal_emit_valist + 0x85e (0xf6e27be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
 6: g_signal_emit + 0x14 (0xf6e27dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
 7: (0xf6e5c75b) [/usr/lib/libSLP-location.so.0] + 0x1575b
 8: (0xf6e571f5) [/usr/lib/libSLP-location.so.0] + 0x101f5
 9: g_closure_invoke + 0x108 (0xf6e15c55) [/usr/lib/libgobject-2.0.so.0] + 0xbc55
10: (0xf6e21e57) [/usr/lib/libgobject-2.0.so.0] + 0x17e57
11: g_signal_emit_valist + 0x85e (0xf6e27be7) [/usr/lib/libgobject-2.0.so.0] + 0x1dbe7
12: g_signal_emit + 0x14 (0xf6e27dc5) [/usr/lib/libgobject-2.0.so.0] + 0x1ddc5
13: (0xf6e59e5f) [/usr/lib/libSLP-location.so.0] + 0x12e5f
14: (0xf6e5a017) [/usr/lib/libSLP-location.so.0] + 0x13017
15: (0xf6e5e8d9) [/usr/lib/libSLP-location.so.0] + 0x178d9
16: (0xf71480bb) [/usr/lib/location/module/libgps.so] + 0x20bb
17: (0xf47ec171) [/usr/lib/liblbs-dbus.so.0] + 0x1171
18: (0xf68bf663) [/usr/lib/libgio-2.0.so.0] + 0x7f663
19: (0xf6d6cfcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
20: g_main_context_dispatch + 0xbc (0xf6d6e7a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
21: (0xf6efeca7) [/usr/lib/libecore.so.1] + 0x10ca7
22: (0xf6ef9b4f) [/usr/lib/libecore.so.1] + 0xbb4f
23: (0xf6efa5a7) [/usr/lib/libecore.so.1] + 0xc5a7
24: ecore_main_loop_begin + 0x30 (0xf6efa879) [/usr/lib/libecore.so.1] + 0xc879
25: appcore_agent_main + 0x56 (0xf7132183) [/usr/lib/libappcore-agent.so.1] + 0x1183
26: service_app_main + 0x54 (0xf71327fd) [/usr/lib/libappcore-agent.so.1] + 0x17fd
27: main + 0xda (0xf71794f7) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0x14f7
28: __libc_start_main + 0x114 (0xf6fc685c) [/lib/libc.so.6] + 0x1785c
29: (0xf7178f2c) [/opt/usr/apps/es.ugr.frailty.frailtylauncher/bin/location] + 0xf2c
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
signal_receive_cb(1605) > [_on_lcd_signal_receive_cb:1605] _on_lcd_signal_receive_cb, 1605, Pre LCD off by [gesture]
04-23 19:47:10.129+0200 W/STARTER ( 2701): clock-mgr.c: _pre_lcd_off(1378) > [_pre_lcd_off:1378] Will LCD OFF as wake_up_setting[1]
04-23 19:47:10.129+0200 E/STARTER ( 2701): scontext_util.c: sconstext_util_check_lock_type(46) > [sconstext_util_check_lock_type:46] current lock state :[0],testmode[0]
04-23 19:47:10.129+0200 E/STARTER ( 2701): scontext_util.c: scontext_util_handle_lock_state(71) > [scontext_util_handle_lock_state:71] wear state[0],bPossible [0],usage [0]
04-23 19:47:10.129+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_popup_status(200) > [_check_reserved_popup_status:200] Current reserved apps status : 0
04-23 19:47:10.129+0200 W/STARTER ( 2701): clock-mgr.c: _check_reserved_apps_status(236) > [_check_reserved_apps_status:236] Current reserved apps status : 0
04-23 19:47:10.129+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : -145052916[0;m
04-23 19:47:10.129+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
04-23 19:47:10.129+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
04-23 19:47:10.139+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
04-23 19:47:10.139+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(301) > [0;31mERROR: db/private/com.samsung.clock/alarm/alarm_ringing FAILED[0;m
04-23 19:47:10.139+0200 E/WAKEUP-SERVICE( 3256): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
04-23 19:47:10.139+0200 I/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
04-23 19:47:10.139+0200 W/SHealthService( 3098): CpuLock.cpp: CheckAndReset(173) > [1;40;33mRELEASE POWER LOCK CPU[0;m
04-23 19:47:10.149+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:10:108,-164.639999,-27.860001,25.690001
04-23 19:47:10.149+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:10:126,2.663212,-10.317852,3.584448
04-23 19:47:10.149+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:10:129,1.591584,-4.853048,-4.487597
04-23 19:47:10.149+0200 I/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
04-23 19:47:10.149+0200 W/TIZEN_N_SOUND_MANAGER( 3256): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
04-23 19:47:10.149+0200 W/WAKEUP-SERVICE( 3256): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
04-23 19:47:10.149+0200 I/HIGEAR  ( 3256): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
04-23 19:47:10.179+0200 W/LOCATION(22025): location-common-util.c: location_is_onboard_gps_use_only(180) > app_type [capp]
04-23 19:47:10.179+0200 E/LOCATION(22025): location-common-util.c: location_is_onboard_gps_use_only(191) > Failed to get metadata. Err[-2]
04-23 19:47:10.179+0200 E/PKGMGR_INFO(22025): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_destroy_appinfo(3554) > (handle == NULL) appinfo handle is NULL
04-23 19:47:10.179+0200 W/LOCATION(22025): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:10.189+0200 I/CAPI_WATCH_APPLICATION( 2849): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
04-23 19:47:10.189+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppTimeTick(579) > 
04-23 19:47:10.199+0200 I/LOCATION(22025): location.c: location_new(269) > method: 0
04-23 19:47:10.199+0200 W/LOCATION(22025): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:10.209+0200 W/LOCATION(22025): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:10.209+0200 I/servicemanager(21592): es.ugr.frailty.gravity alive timeout
04-23 19:47:10.209+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.gravity)
04-23 19:47:10.209+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:10.209+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:10.209+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:10.219+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:10:222,-0.267593,0.215857,2.391257
04-23 19:47:10.219+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:10.219+0200 W/AUL_AMD ( 2478): amd_launch.c: start_process(606) > child process: 22039
04-23 19:47:10.219+0200 E/RESOURCED( 2577): block.c: block_prelaunch_state(138) > insert data es.ugr.frailty.frailtylauncher, table num : 2
04-23 19:47:10.239+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:10:226,2.055435,-8.784052,5.517848
04-23 19:47:10.249+0200 I/TDM     ( 1956): tdm_exynos_display.c: exynos_output_set_dpms(1457) > [3290.531078] dpms[3 -> 3]done
04-23 19:47:10.249+0200 I/TDM     ( 1956): 
04-23 19:47:10.249+0200 W/SHealthCommon( 2923): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 19:47:10.249+0200 I/watchface-viewer( 2849): viewer-feedback.cpp: DisplayStateChangedCb(151) > state[2] sDisplayStateNormal[0]
04-23 19:47:10.269+0200 W/STARTER ( 2701): clock-mgr.c: _on_lcd_signal_receive_cb(1618) > [_on_lcd_signal_receive_cb:1618] _on_lcd_signal_receive_cb, 1618, Post LCD off by [gesture]
04-23 19:47:10.269+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1510) > [_post_lcd_off:1510] LCD OFF as reserved app[(null)] alpm mode[0]
04-23 19:47:10.269+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1517) > [_post_lcd_off:1517] Current reserved apps status : 0
04-23 19:47:10.269+0200 W/STARTER ( 2701): clock-mgr.c: _post_lcd_off(1535) > [_post_lcd_off:1535] raise homescreen after 20 sec. home_visible[1]
04-23 19:47:10.269+0200 I/APP_CORE( 2773): appcore-efl.c: __do_app(453) > [APP 2773] Event: PAUSE State: RUNNING
04-23 19:47:10.269+0200 I/CAPI_APPFW_APPLICATION( 2773): app_main.c: app_appcore_pause(202) > app_appcore_pause
04-23 19:47:10.269+0200 W/W_HOME  ( 2773): main.c: _appcore_pause_cb(488) > appcore pause
04-23 19:47:10.269+0200 W/W_HOME  ( 2773): event_manager.c: _app_pause_cb(396) > state: 1 -> 2
04-23 19:47:10.269+0200 W/W_HOME  ( 2773): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 19:47:10.269+0200 W/W_HOME  ( 2773): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 19:47:10.269+0200 W/W_HOME  ( 2773): main.c: home_pause(547) > clock/widget paused
04-23 19:47:10.269+0200 W/W_HOME  ( 2773): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:47:10.269+0200 W/AUL_AMD ( 2478): amd_launch.c: __send_app_launch_signal(397) > send launch signal done: 22039
04-23 19:47:10.269+0200 W/AUL     ( 2478): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(es.ugr.frailty.gravity) pid(22039) type(svcapp) bg(0)
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
04-23 19:47:10.269+0200 I/MESSAGE_PORT( 2456): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
04-23 19:47:10.279+0200 W/STARTER ( 2701): pkg-monitor.c: _app_mgr_status_cb(395) > [_app_mgr_status_cb:395] Launch request [22039]
04-23 19:47:10.279+0200 W/WATCH_CORE( 2849): appcore-watch.c: __widget_pause(1113) > widget_pause
04-23 19:47:10.279+0200 W/AUL     ( 2849): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.watchface) pid(2849) status(bg) type(watchapp)
04-23 19:47:10.279+0200 E/watchface-loader( 2849): watchface-loader.cpp: OnAppPause(552) > 
04-23 19:47:10.289+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22039)
04-23 19:47:10.289+0200 I/servicemanager(21592): es.ugr.frailty.gravity launch request sent!
04-23 19:47:10.289+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 19:47:10.289+0200 I/servicemanager(21592): App control destroyed.
04-23 19:47:10.289+0200 W/SHealthCommon( 3098): SystemUtil.cpp: OnDeviceStatusChanged(1005) > [1;35mlcdState:3[0;m
04-23 19:47:10.299+0200 W/W_INDICATOR( 2704): windicator.c: _home_screen_clock_visibility_changed_cb(1008) > [_home_screen_clock_visibility_changed_cb:1008] Clock visibility : 0
04-23 19:47:10.299+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:10.299+0200 W/W_INDICATOR( 2704): windicator_battery.c: windicator_battery_vconfkey_unregister(432) > [windicator_battery_vconfkey_unregister:432] Unset battery cb
04-23 19:47:10.309+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(355) > [_windicator_dbus_lcd_off_completed_cb:355] LCD Off completed signal is received
04-23 19:47:10.309+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:10.309+0200 I/HealthDataService( 2915): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
04-23 19:47:10.309+0200 W/W_INDICATOR( 2704): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(360) > [_windicator_dbus_lcd_off_completed_cb:360] Moment bar status -> idle. (Hide Moment bar)
04-23 19:47:10.309+0200 W/W_INDICATOR( 2704): windicator_moment_bar.c: windicator_hide_moment_bar_directly(1530) > [windicator_hide_moment_bar_directly:1530] windicator_hide_moment_bar_directly
04-23 19:47:10.309+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:10.319+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22039
04-23 19:47:10.319+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:10.319+0200 I/watchface-viewer( 2849): viewer-data-provider.cpp: AddPendingChanges(2306) > added [134] to pending list
04-23 19:47:10.319+0200 I/watchface-viewer( 2849): viewer-data-provider.cpp: AddPendingChanges(2306) > added [135] to pending list
04-23 19:47:10.319+0200 I/healthData( 3098): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(370) > [1;35mServer said: OK {}[0;m
04-23 19:47:10.319+0200 E/CAPI_APPFW_APP_CONTROL( 3301): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
04-23 19:47:10.319+0200 W/MUSIC_CONTROL_SERVICE( 3301): music-control-service.c: _music_control_service_pasre_request(464) > [33m[TID:3301]   [com.samsung.w-home]register msg port [false][0m
04-23 19:47:10.329+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:10:308,6.160000,-17.290001,-27.790001
04-23 19:47:10.329+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:10:320,0.167900,0.926525,3.030142
04-23 19:47:10.329+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:10.339+0200 E/CAPI_APPFW_APPLICATION(22039): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:10.349+0200 W/LOCATION(22025): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:10.349+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:10:342,2.490928,-8.073383,6.156733
04-23 19:47:10.349+0200 W/LOCATION(22025): module-internal.c: module_new(311) > module (gps) open success
04-23 19:47:10.349+0200 E/CAPI_APPFW_APPLICATION(22039): service_app_error.c: service_app_error(67) > [service_app_add_event_handler] INVALID_PARAMETER(0xffffffea)
04-23 19:47:10.349+0200 I/utils   (22039): trying to start service: es.ugr.frailty.gravity
04-23 19:47:10.359+0200 W/LOCATION(22025): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:47:10.359+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:10.359+0200 W/LOCATION(22025): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:47:10.369+0200 I/utils   (22039): es.ugr.frailty.gravity sensor supported
04-23 19:47:10.369+0200 W/LOCATION(22025): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:10.369+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22025
04-23 19:47:10.369+0200 W/LOCATION(22025): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:47:10.369+0200 W/AUL_AMD ( 2478): amd_status.c: __socket_monitor_cb(1277) > (22039) was created
04-23 19:47:10.369+0200 W/LOCATION(22025): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:47:10.369+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:10.379+0200 I/utils   (22039): es.ugr.frailty.gravity listener started
04-23 19:47:10.379+0200 W/CAPI_APPFW_APP_CONTROL(22039): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:10.389+0200 I/utils   (22039): specific action
04-23 19:47:10.439+0200 W/LOCATION(22025): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 19:47:10.439+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:10.449+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22027
04-23 19:47:10.449+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:10.449+0200 W/LOCATION(22025): module-internal.c: module_is_supported(340) > module name(wps) is found
04-23 19:47:10.459+0200 W/LOCATION(22025): module-internal.c: module_new(311) > module (wps) open success
04-23 19:47:10.459+0200 W/LOCATION(22025): module-internal.c: module_is_supported(340) > module name(remote_wps) is found
04-23 19:47:10.459+0200 W/LOCATION(22025): module-internal.c: module_new(311) > module (remote_wps) open success
04-23 19:47:10.459+0200 W/LOCATION(22025): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 19:47:10.459+0200 W/LOCATION(22025): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 19:47:10.469+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 14
04-23 19:47:10.479+0200 W/AUL_AMD ( 2478): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22039
04-23 19:47:10.479+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 12
04-23 19:47:10.489+0200 W/LOCATION(22025): location-gps.c: location_gps_set_property(1651) > id [14], value [0]
04-23 19:47:10.489+0200 I/LOCATION(22025): location-gps.c: location_gps_set_property(1778) > Set prop>> hybrid_obj: 0xf74fec18
04-23 19:47:10.489+0200 I/LOCATION(22025): location-gps.c: location_gps_set_property(1793) > Set prop>> is_hybrid: 1
04-23 19:47:10.489+0200 I/LOCATION(22025): location-wps.c: location_wps_set_property(1182) > Set prop>> hybrid_obj: 0xf74fec18
04-23 19:47:10.489+0200 I/LOCATION(22025): location-wps.c: location_wps_set_property(1194) > Set prop>> is_hybrid: 1
04-23 19:47:10.499+0200 I/location(22025): es.ugr.frailty.location: creado servicio de localización
04-23 19:47:10.499+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:10.499+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:10.499+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:10.509+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:10.519+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:10:517,2.988949,-7.953576,4.896651
04-23 19:47:10.529+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:10:513,3.637090,-7.436893,3.560520
04-23 19:47:10.539+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:10:518,0.965813,1.142644,-0.367104
04-23 19:47:10.539+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:10:516,25.340000,-14.280000,-21.770000
04-23 19:47:10.569+0200 I/LOCATION(22025): location-hybrid.c: location_hybrid_start(641) > IOS Connected [0]
04-23 19:47:10.609+0200 W/LOCATION(22025): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:47:10.609+0200 W/LOCATION(22025): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:47:10.609+0200 I/LOCATION(22025): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:10.679+0200 W/libgps_d( 3158): GpsiHook: API: gpsSetPositionMode(GpsiHookStateIdle: e,c,g)
04-23 19:47:10.679+0200 W/libgps  ( 3158): proxy__gps_set_position_mode(0, 0, 1000, 50, 0)
04-23 19:47:10.679+0200 W/libgps_d( 3158): GpsiHook: API: gpsStart(GpsiHookStateIdle: e,c,g)
04-23 19:47:10.679+0200 W/libgps_d( 3158): GpsiHookStateIdle             : EXIT
04-23 19:47:10.679+0200 W/libgps_d( 3158): GpsiHookStateGps              : ENTRY
04-23 19:47:10.679+0200 W/libgps  ( 3158): [proxy__gps_start][line = 1022]: called.
04-23 19:47:10.679+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:47:10.679+0200 W/libgps_d( 3158): GpsiHook: API: gpsStatusCb(GpsiHookStateGps: e,c,g)
04-23 19:47:10.679+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:26
04-23 19:47:10.679+0200 D/gpsd_d  ( 3126): SetIgnoreAsstMask: ignore_asst_mask = 0x00000000
04-23 19:47:10.679+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:27
04-23 19:47:10.679+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:8
04-23 19:47:10.679+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(2), data((nil)), size(0)
04-23 19:47:10.679+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:0, msg id:1
04-23 19:47:10.689+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(11), data(0xf7672238), size(4)
04-23 19:47:10.689+0200 W/libgps_d( 3158): [OnGpsExtensionMessage] Received: MSG_SET_LOG_LEVEL(2)
04-23 19:47:10.689+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(6), data((nil)), size(0)
04-23 19:47:10.689+0200 W/libgps_d( 3158): GpsiHook: API: gpsRequestUtcTimeCb(GpsiHookStateGps: e,c,g)
04-23 19:47:10.699+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:10.699+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:10.699+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:10:706,3.350422,-8.071693,4.448912
04-23 19:47:10.699+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:10.709+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:10.709+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:10:713,-7.560000,-4.340000,-2.450000
04-23 19:47:10.709+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:10:710,4.000800,-7.668997,4.950750
04-23 19:47:10.719+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:10:712,1.011851,0.284579,0.054099
04-23 19:47:10.739+0200 W/LOCATION(22025): location-wps.c: __update_remote_connection_status(215) > update FALSE
04-23 19:47:10.739+0200 W/LOCATION(22025): location-wps.c: __update_remote_connection_status(220) > is_remote_connected[0]
04-23 19:47:10.779+0200 I/APP_CORE( 2773): appcore-efl.c: __do_app(453) > [APP 2773] Event: MEM_FLUSH State: PAUSED
04-23 19:47:10.829+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:10.869+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: connection_create(453) > New handle created[0xf4003eb0]
04-23 19:47:10.869+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_type_changed_callback(184) > Successfully registered(1)
04-23 19:47:10.869+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_ip_changed_callback(284) > Successfully registered(1)
04-23 19:47:10.869+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: __connection_set_proxy_changed_callback(384) > Successfully registered(1)
04-23 19:47:10.869+0200 I/CAPI_NETWORK_CONNECTION(21673): connection.c: connection_get_type(507) > Connected Network = 2
04-23 19:47:10.879+0200 W/LOCATION(21673): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:10.879+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:10.889+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:10.899+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:10.899+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:10.899+0200 E/LOCATION(21673): location-privacy.c: location_privacy_initialize(165) > Fail to get app_id. Err[-1]
04-23 19:47:10.899+0200 I/LOCATION(21673): location.c: location_new(269) > method: 1
04-23 19:47:10.899+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(gps) is found
04-23 19:47:10.899+0200 W/LOCATION(21673): module-internal.c: module_new(311) > module (gps) open success
04-23 19:47:10.899+0200 W/LOCATION(21673): module-internal.c: module_is_supported(340) > module name(remote_gps) is found
04-23 19:47:10.899+0200 W/LOCATION(21673): module-internal.c: module_new(311) > module (remote_gps) open success
04-23 19:47:10.899+0200 W/LOCATION(21673): location-common-util.c: location_is_onboard_gps_use_only(149) > onboard-gps-use-only mode: [0]
04-23 19:47:10.899+0200 W/LOCATION(21673): location-gps.c: __update_remote_connection_status(362) > update FALSE
04-23 19:47:10.899+0200 W/LOCATION(21673): location-gps.c: __update_remote_connection_status(367) > is_remote_connected[0]
04-23 19:47:10.909+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:10:907,3.570081,-7.814123,4.729100
04-23 19:47:10.909+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:10.909+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:10.909+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:10.919+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(4), data((nil)), size(0)
04-23 19:47:10.919+0200 W/libgps  ( 3158): proxy__agps_ril_request_refloc_cb: refLocationSaved(0), time1(3291201), time2(3276081)
04-23 19:47:10.919+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: agps_reflocation->type(0), refLocationInfo.refLocationSaved(0)
04-23 19:47:10.919+0200 W/libgps  ( 3158): proxy__agps_ril_set_ref_location: type(0), mcc(0), mnc(0), cid(0), psc(0), lac(0) 
04-23 19:47:10.919+0200 I/libgps_d( 3158): OnGpsExtensionMessage: MSG_REQUEST_LOCATION_ID CELL_ID
04-23 19:47:10.919+0200 W/gpsd    ( 3126): HandleIncomingMessage() dest id:2, msg id:25
04-23 19:47:10.919+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:10.919+0200 E/LOCATION(21673): location-privacy.c: location_get_app_type(54) > Fail to get app_id. Err[-1]
04-23 19:47:10.919+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:10.919+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:10.909+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:10:919,0.927945,0.608479,0.315198
04-23 19:47:10.929+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:10:917,4.278367,-7.463214,4.764110
04-23 19:47:10.929+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:10:926,8.890000,2.800000,-1.330000
04-23 19:47:10.959+0200 I/SECURE_STORAGE( 2500): ss_server_ipc.c: SsServerComm(251) > write succeed
04-23 19:47:10.999+0200 W/LOCATION(22025): location-gps.c: location_gps_set_property(1651) > id [15], value [0]
04-23 19:47:10.999+0200 I/LOCATION(22025): location-gps.c: location_gps_set_property(1799) > Set prop>> requested_start_by_hybrid: 1
04-23 19:47:10.999+0200 I/LOCATION(22025): location-wps.c: location_wps_set_property(1200) > Set prop>> requested_start_by_hybrid: 1
04-23 19:47:10.999+0200 I/location(22025): es.ugr.frailty.location:iniciado servicio de localización
04-23 19:47:11.039+0200 W/AUL_AMD ( 2478): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
04-23 19:47:11.089+0200 I/LOCATION(22025): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:11.099+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.109+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:11:112,3.797265,-7.813190,4.550299
04-23 19:47:11.109+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:11.109+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:11:117,3.495914,-8.449057,4.158726
04-23 19:47:11.109+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:11.119+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.119+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:11:123,-16.870001,-1.820000,-2.590000
04-23 19:47:11.119+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:11:120,-0.074168,-0.634933,-0.570374
04-23 19:47:11.139+0200 E/location(22025): es.ugr.frailty.location: error intentando obtener la última localización
04-23 19:47:11.139+0200 W/AUL     (22025): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.servicemanager)
04-23 19:47:11.139+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:11.139+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 22025
04-23 19:47:11.149+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21592
04-23 19:47:11.149+0200 W/AUL     (22025): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21592)
04-23 19:47:11.149+0200 I/location(22025): request sent to service es.ugr.frailty.servicemanager
04-23 19:47:11.149+0200 W/CAPI_APPFW_APP_CONTROL(22025): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:11.149+0200 I/utils   (22025): specific action
04-23 19:47:11.149+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:11.149+0200 I/utils   (21592): specific action
04-23 19:47:11.149+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:47:11.149+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21592), cmd(0)
04-23 19:47:11.149+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:11.149+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:11.149+0200 W/CAPI_APPFW_APP_CONTROL(21592): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:11.149+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(284) > request cmd(0) to(es.ugr.frailty.recorder)
04-23 19:47:11.149+0200 W/AUL_AMD ( 2478): amd_request.c: __request_handler(669) > __request_handler: 0
04-23 19:47:11.149+0200 W/AUL_AMD ( 2478): amd_launch.c: _start_app(1782) > caller pid : 21592
04-23 19:47:11.159+0200 W/AUL_AMD ( 2478): amd_launch.c: __nofork_processing(1229) > __nofork_processing, cmd: 0, pid: 21598
04-23 19:47:11.159+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:11.159+0200 E/AUL_AMD ( 2478): amd_launch.c: __real_send(909) > send fail to client
04-23 19:47:11.159+0200 W/AUL_AMD ( 2478): amd_launch.c: __reply_handler(999) > listen fd(21) , send fd(15), pid(21598), cmd(0)
04-23 19:47:11.159+0200 I/utils   (21598): specific action
04-23 19:47:11.159+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:11.159+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:11.159+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:11.159+0200 W/CAPI_APPFW_APP_CONTROL(21598): app_control.c: app_control_error(136) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-23 19:47:11.159+0200 I/recorder(21598): 1 app file path: /opt/usr/apps/es.ugr.frailty.frailtylauncher/data/es.ugr.frailty.location.csv
04-23 19:47:11.159+0200 I/recorder(21598): guardando datos en local
04-23 19:47:11.159+0200 W/AUL     (21592): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21598)
04-23 19:47:11.159+0200 I/servicemanager(21592): request sent to service es.ugr.frailty.recorder
04-23 19:47:11.159+0200 I/servicemanager(21592): requesting to save local data
04-23 19:47:11.299+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.299+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:11:307,3.402292,-8.166886,4.230457
04-23 19:47:11.299+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:11.309+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:11.309+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:11:313,-0.322886,0.031731,-1.238632
04-23 19:47:11.309+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.309+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:11:317,-13.650000,11.410000,14.210000
04-23 19:47:11.309+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:11:311,3.474378,-7.781459,3.311667
04-23 19:47:11.499+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.499+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.499+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:11:507,16.030001,-5.110000,6.860000
04-23 19:47:11.499+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:11:508,3.520973,-8.169152,4.127721
04-23 19:47:11.499+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:11.499+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:11.509+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:11:511,1.715956,-1.445083,0.382905
04-23 19:47:11.509+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:11:512,5.118248,-9.611969,4.613362
04-23 19:47:11.649+0200 W/libgps_d( 3158): OnGpsExtensionMessage: message_id(1), data(0xf7672238), size(2752)
04-23 19:47:11.649+0200 W/libgps_d( 3158): GpsiHook: API: gpsLocationCb(GpsiHookStateGps: e,c,g)
04-23 19:47:11.649+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.659+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.659+0200 W/libgps_d( 3158): GpsiHook: API: gpsSvStatusCb(GpsiHookStateGps: e,c,G)
04-23 19:47:11.659+0200 W/libgps  ( 3158): proxy__gps_sv_status_cb : called
04-23 19:47:11.659+0200 E/CAPI_LOCATION_MANAGER(21673): location_product.c: _location_manager_gps_state_cb(195) > _location_manager_gps_state_cb
04-23 19:47:11.669+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:11:662,3.195541,-8.543217,3.601716
04-23 19:47:11.669+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:11:667,-36.680000,9.590000,22.610001
04-23 19:47:11.679+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:11.679+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:11.679+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:11.679+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.689+0200 I/AUL     (21673): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/posclientd, ret : 0
04-23 19:47:11.689+0200 E/LOCATION(21673): location-privacy.c: location_get_privacy(232) > Fail to get app_id. Err[-1]
04-23 19:47:11.689+0200 I/LOCATION(21673): location-privacy.c: location_get_privacy(233) > Skip check because it might be daemon process
04-23 19:47:11.689+0200 I/LOCATION(21673): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:11.689+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.699+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:11:683,-0.975001,0.144409,-0.555653
04-23 19:47:11.699+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:11:696,-58.099998,-2.590000,17.920000
04-23 19:47:11.699+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:11:690,2.220540,-8.398808,3.046063
04-23 19:47:11.699+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:11:685,3.090966,-8.636996,3.466788
04-23 19:47:11.699+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:11.699+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.709+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:11.709+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.709+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:11:714,2.972465,-8.746048,3.292639
04-23 19:47:11.719+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:11:719,1.875973,-9.107083,2.871387
04-23 19:47:11.729+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:11:720,-1.214993,-0.470087,-0.595401
04-23 19:47:11.729+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:11:728,-68.040001,-17.780001,15.680000
04-23 19:47:11.729+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:11.729+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.729+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.729+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:11:738,2.115255,-9.391829,2.239682
04-23 19:47:11.739+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:11.749+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:11:753,-0.857210,-0.645781,-1.052957
04-23 19:47:11.749+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:11.749+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:11:744,2.888604,-8.847319,3.090517
04-23 19:47:11.749+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:11:749,-62.930000,-31.850000,12.320000
04-23 19:47:11.749+0200 I/LOCATION(22025): location-gps.c: __get_availability_use_gps(508) > Check _availability use GPS
04-23 19:47:11.749+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.769+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:11.769+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.819+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:11:775,2.844642,-8.932723,2.878341
04-23 19:47:11.819+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:11:779,-49.070000,-41.439999,9.870000
04-23 19:47:11.819+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:11:762,2.464607,-9.662218,1.560120
04-23 19:47:11.819+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:11.819+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:11:782,-0.423997,-0.814899,-1.530396
04-23 19:47:11.819+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.829+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.829+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:11.869+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:11:836,-27.930000,-46.270000,9.520000
04-23 19:47:11.869+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:11:833,2.826983,-8.991953,2.706164
04-23 19:47:11.869+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:11:831,2.581856,-9.401401,1.344766
04-23 19:47:11.869+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:11:838,-0.262787,-0.468678,-1.533575
04-23 19:47:11.879+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:11.879+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.879+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.879+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:11:889,2.457429,-8.683553,1.560120
04-23 19:47:11.889+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:11.889+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:11:894,2.805578,-9.039960,2.564806
04-23 19:47:11.909+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:11:898,-25.690001,-48.509998,11.410000
04-23 19:47:11.919+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:11:901,-0.369555,0.308400,-1.146044
04-23 19:47:11.919+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:11.919+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.929+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.939+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:11:943,2.754158,-9.120800,2.322930
04-23 19:47:11.939+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:11.939+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:11:944,-45.290001,-47.250000,18.620001
04-23 19:47:11.949+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:11:940,2.383251,-9.135797,0.447458
04-23 19:47:11.949+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:11:951,-0.422327,-0.095837,-2.117349
04-23 19:47:11.949+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:11.949+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.949+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.949+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:11:959,2.653091,-9.202491,2.108471
04-23 19:47:11.959+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:11.959+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:11:963,-53.760002,-47.459999,22.330000
04-23 19:47:11.969+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:11:973,-0.629331,-0.969732,-1.246160
04-23 19:47:11.969+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:11:958,2.124826,-10.090532,1.076770
04-23 19:47:11.969+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.969+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:11.969+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.979+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:11.989+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:11:981,1.887937,-10.760524,0.784846
04-23 19:47:11.989+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:11:983,2.582957,-9.253770,1.966331
04-23 19:47:11.989+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:11.989+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:11:988,-31.710001,-45.080002,19.740000
04-23 19:47:11.999+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:11.999+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:11.999+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:11:993,-0.765154,-1.558033,-1.323625
04-23 19:47:12.009+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:12.009+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:12:1,2.570336,-9.269806,1.906424
04-23 19:47:12.019+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:12:7,2.256432,-11.231910,0.430708
04-23 19:47:12.019+0200 E/CAPI_TELEPHONY(21673): telephony_common.c: telephony_init(358) > telephony feature is disabled
04-23 19:47:12.029+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:12.029+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:12:8,12.250000,-46.060001,22.400000
04-23 19:47:12.029+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:12.029+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:12.039+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:12:15,-0.326525,-1.978140,-1.535623
04-23 19:47:12.039+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:12.049+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:12:42,2.622534,-10.985448,0.629312
04-23 19:47:12.049+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:12:39,2.588874,-9.265695,1.901320
04-23 19:47:12.049+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:12:51,0.052198,-1.715642,-1.277112
04-23 19:47:12.049+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:12:46,32.480000,-39.410000,22.330000
04-23 19:47:12.049+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:12.049+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:12.059+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:12.059+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:12:64,2.758924,-10.480563,0.904487
04-23 19:47:12.069+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:12.069+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:12:62,2.615754,-9.252481,1.928677
04-23 19:47:12.069+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:12.079+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:12.079+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:12:68,42.000000,-29.049999,24.219999
04-23 19:47:12.079+0200 I/linearacceleration(22027): es.ugr.frailty.linearacceleration: SM-R760,23/04/2018,19:47:12:76,0.170050,-1.214869,-0.996833
04-23 19:47:12.079+0200 I/gravity (22039): es.ugr.frailty.gravity: SM-R760,23/04/2018,19:47:12:86,2.650209,-9.237038,1.955483
04-23 19:47:12.089+0200 I/gyroscope(22010): capturing data from es.ugr.frailty.gyroscope
04-23 19:47:12.089+0200 I/gyroscope(22010): es.ugr.frailty.gyroscope: SM-R760,23/04/2018,19:47:12:94,46.900002,-18.410000,21.980000
04-23 19:47:12.089+0200 I/linearacceleration(22027): capturing data from es.ugr.frailty.linearacceleration
04-23 19:47:12.099+0200 I/accelerometer(21994): es.ugr.frailty.accelerometer: SM-R760,23/04/2018,19:47:12:90,2.797210,-10.317852,1.103091
04-23 19:47:12.099+0200 I/gravity (22039): capturing data from es.ugr.frailty.gravity
04-23 19:47:12.109+0200 I/accelerometer(21994): capturing data from es.ugr.frailty.accelerometer
04-23 19:47:12.119+0200 W/CRASH_MANAGER(21684): worker.c: worker_job(1205) > 11220256c6f63152450563
