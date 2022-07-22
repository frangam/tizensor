#ifndef _MQTTHANDLER_H_
#define _MQTTHANDLER_H_

#include <stdio.h>
#include <dlog.h>
//#include <paho-mqtt/MQTTClient.h>
//#include "paho-mqtt/MQTTAsync.h"
#include "mosquitto.h"

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "mqtthandler"



#ifdef __cplusplus
extern "C" {
#endif

//
//extern void connlost(void *context, char *cause);
//extern int msgarrvd(void *context, char *topicName, int topicLen, MQTTAsync_message *message);
//extern void onDisconnect(void* context, MQTTAsync_successData* response);
//extern void onSubscribe(void* context, MQTTAsync_successData* response);
//extern void onSubscribeFailure(void* context, MQTTAsync_failureData* response);
//extern void onConnectFailure(void* context, MQTTAsync_failureData* response);
//extern void onConnect(void* context, MQTTAsync_successData* response);
void my_log_callback(struct mosquitto *mosq, void *userdata, int level, const char *str);
void my_subscribe_callback(struct mosquitto *mosq, void *userdata, int mid, int qos_count, const int *granted_qos);
void my_connect_callback(struct mosquitto *mosq, void *userdata, int result);
void my_message_callback(struct mosquitto *mosq, void *userdata, const struct mosquitto_message *message);
bool mqtt_create();

#ifdef __cplusplus
}
#endif
#endif /* _MQTTHANDLER_H_ */
