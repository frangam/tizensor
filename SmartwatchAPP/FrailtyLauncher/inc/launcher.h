#ifndef __launcher_H__
#define __launcher_H__

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>


#include "utils.h"
#include "bleutils.h"
#include "mqtthandler.h"


#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "launcher"

void launch_service(char* service_id);
void stop_service(char* service_id);




#if !defined(PACKAGE)
#define PACKAGE "es.ugr.frailty.launcher"
#endif

#endif /* __frailtylauncher_H__ */
