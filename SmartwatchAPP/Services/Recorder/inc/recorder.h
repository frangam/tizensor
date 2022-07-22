#ifndef __recorder_H__
#define __recorder_H__

#include <dlog.h>

#include "utils.h"
#include "sensorutils.h"
#include "fileutils.h"


#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "recorder"


bool local_data_of_any_sensor(app_control_h app_control, operation_e op);
Eina_Bool send_local_data(char* serviceID);
bool delete_all_data_and_close_app();
bool delete_all_data_without_close_app();
bool delete_all_data_recorder(bool close_app);

#endif /* __recorder_H__ */
