#ifndef __location_H__
#define __location_H__

#include <dlog.h>
#include <locations.h>
#include "utils.h"
#include "sensorutils.h"

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "location"


void state_changed_cb(location_service_state_e state, void *user_data);
void position_updated(double latitude, double longitude, double altitude, time_t timestamp, void *user_data);
void velocity_updated(double speed, double direction, double climb, time_t timestamp, void *user_data);
void get_cur_location(sensordata_s* sd);

#endif /* __location_H__ */
