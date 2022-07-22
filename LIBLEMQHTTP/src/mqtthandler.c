#include "mqtthandler.h"
//
////#if !defined(WIN32)
////#include <unistd.h>
////#else
////#include <windows.h>
////#endif
////
////#if defined(_WRS_KERNEL)
////#include <OsWrapper.h>
////#endif
//
//#define ADDRESS     "tcp://localhost:1883"
//#define CLIENTID    "ExampleClientSub"
//#define TOPIC       "MQTT Examples"
//#define PAYLOAD     "Hello World!"
//#define QOS         1
//#define TIMEOUT     10000L
//
//volatile MQTTAsync_token deliveredtoken;
//
//int disc_finished = 0;
//int subscribed = 0;
//int finished = 0;
//
//void connlost(void *context, char *cause)
//{
//	MQTTAsync client = (MQTTAsync)context;
//	MQTTAsync_connectOptions conn_opts = MQTTAsync_connectOptions_initializer;
//	int rc;
//
//	dlog_print(DLOG_INFO, LOG_TAG, "mqtt Connection lost");
//
//	if (cause){
//		dlog_print(DLOG_INFO, LOG_TAG, "mqtt cause: %s\n", cause);
//	}
//
//	dlog_print(DLOG_INFO, LOG_TAG, "mqtt Reconnecting");
//
//	conn_opts.keepAliveInterval = 20;
//	conn_opts.cleansession = 1;
//	if ((rc = MQTTAsync_connect(client, &conn_opts)) != MQTTASYNC_SUCCESS)
//	{
//		dlog_print(DLOG_ERROR, LOG_TAG, "mqtt Failed to start connect, return code %d\n", rc);
//
//		finished = 1;
//	}
//}
//
//
//int msgarrvd(void *context, char *topicName, int topicLen, MQTTAsync_message *message)
//{
//    int i;
//    char* payloadptr;
//
////    printf("Message arrived\n");
////    printf("     topic: %s\n", topicName);
////    printf("   message: ");
////	dlog_print(DLOG_INFO, LOG_TAG, "mqtt Message arrived");
////	dlog_print(DLOG_INFO, LOG_TAG, "mqtt Message topic: %s\n", topicName);
////	dlog_print(DLOG_INFO, LOG_TAG, "mqtt Message topic: %s\n", topicName);
////
////    payloadptr = message->payload;
////    for(i=0; i<message->payloadlen; i++)
////    {
////        putchar(*payloadptr++);
////    }
////    putchar('\n');
////    MQTTAsync_freeMessage(&message);
////    MQTTAsync_free(topicName);
//    char msg_str[1000];
//	strncpy(msg_str, message->payload, message->payloadlen);
//	msg_str[message->payloadlen] = '\0';
//
//	dlog_print(DLOG_INFO, LOG_TAG, "mqtt Message arrived");
//	dlog_print(DLOG_INFO, LOG_TAG, "mqtt Message arrived for topic: \"%s\": \"%s\"", topicName, msg_str);
//
//	MQTTAsync_freeMessage(&message);
//	MQTTAsync_free(topicName);
//
//    return 1;
//}
//
//
//void onDisconnect(void* context, MQTTAsync_successData* response)
//{
//	dlog_print(DLOG_INFO, LOG_TAG, "mqtt Successful disconnection");
//
//	disc_finished = 1;
//}
//
//
//void onSubscribe(void* context, MQTTAsync_successData* response)
//{
//	dlog_print(DLOG_INFO, LOG_TAG, "mqtt Subscribe succeeded");
//
//	subscribed = 1;
//}
//
//void onSubscribeFailure(void* context, MQTTAsync_failureData* response)
//{
//	dlog_print(DLOG_INFO, LOG_TAG, "mqtt Subscribe failed, rc %d\n", response ? response->code : 0);
//
//	finished = 1;
//}
//
//
//void onConnectFailure(void* context, MQTTAsync_failureData* response)
//{
//	dlog_print(DLOG_ERROR, LOG_TAG, "mqtt Connect failed, rc %d\n", response ? response->code : 0);
//
//	finished = 1;
//}
//
//
//void onConnect(void* context, MQTTAsync_successData* response)
//{
//	MQTTAsync client = (MQTTAsync)context;
//	MQTTAsync_responseOptions opts = MQTTAsync_responseOptions_initializer;
//	int rc;
//
//	dlog_print(DLOG_INFO, LOG_TAG, "mqtt Successful connection");
//	dlog_print(DLOG_INFO, LOG_TAG, "mqtt Subscribing to topic %s\nfor client %s using QoS%d\n\n"
//           "Press Q<Enter> to quit\n\n", TOPIC, CLIENTID, QOS);
//
//	opts.onSuccess = onSubscribe;
//	opts.onFailure = onSubscribeFailure;
//	opts.context = client;
//
//	deliveredtoken = 0;
//
//	if ((rc = MQTTAsync_subscribe(client, TOPIC, QOS, &opts)) != MQTTASYNC_SUCCESS)
//	{
//		dlog_print(DLOG_ERROR, LOG_TAG, "mqtt Failed to start subscribe, return code %d\n", rc);
//
//		exit(EXIT_FAILURE);
//	}
//}
//
//bool mqtt_create(void *user_data)
//{
//	MQTTAsync client;
//	MQTTAsync_connectOptions conn_opts = MQTTAsync_connectOptions_initializer;
//	MQTTAsync_disconnectOptions disc_opts = MQTTAsync_disconnectOptions_initializer;
//	int rc;
//	int ch;
//
//	dlog_print(DLOG_INFO, LOG_TAG, "mqtt version %d", conn_opts.MQTTVersion);
//
//
//	MQTTAsync_create(&client, ADDRESS, CLIENTID, MQTTCLIENT_PERSISTENCE_NONE, NULL);
//
//	MQTTAsync_setCallbacks(client, client, connlost, msgarrvd, NULL);
//
//	conn_opts.keepAliveInterval = 20;
//	conn_opts.cleansession = 1;
//	conn_opts.onSuccess = onConnect;
//	conn_opts.onFailure = onConnectFailure;
//	conn_opts.context = client;
//	if ((rc = MQTTAsync_connect(client, &conn_opts)) != MQTTASYNC_SUCCESS)
//	{
//		dlog_print(DLOG_ERROR, LOG_TAG, "mqtt Failed to start connect, return code %d\n", rc);
////		exit(EXIT_FAILURE);
//	}
//	else
//		dlog_print(DLOG_INFO, LOG_TAG, "mqtt connected");
////	while	(!subscribed)
////		#if defined(WIN32)
////			Sleep(100);
////		#else
////			usleep(10000L);
////		#endif
////
////	if (finished)
////		goto exit;
////
////	do
////	{
////		ch = getchar();
////	} while (ch!='Q' && ch != 'q');
////
////	disc_opts.onSuccess = onDisconnect;
////	if ((rc = MQTTAsync_disconnect(client, &disc_opts)) != MQTTASYNC_SUCCESS)
////	{
////		dlog_print(DLOG_ERROR, LOG_TAG, "mqtt Failed to start disconnect, return code %d\n", rc);
////
////		exit(EXIT_FAILURE);
////	}
////	while	(!disc_finished)
////		#if defined(WIN32)
////			Sleep(100);
////		#else
////			usleep(10000L);
////		#endif
////
////exit:
////	MQTTAsync_destroy(&client);
////	return rc;
//}




void my_message_callback(struct mosquitto *mosq, void *userdata, const struct mosquitto_message *message)
{
	if(message->payloadlen){
//		dlog_print(DLOG_INFO, LOG_TAG, "mqtt %s %s\n", message->topic, message->payload);
		char msg_str[1000];
		strncpy(msg_str, message->payload, message->payloadlen);
		msg_str[message->payloadlen] = '\0';

		dlog_print(DLOG_INFO, LOG_TAG, "mqtt Message arrived");
		dlog_print(DLOG_INFO, LOG_TAG, "mqtt Message arrived for topic: \"%s\": \"%s\"", message->topic, msg_str);
	}else{
		dlog_print(DLOG_INFO, LOG_TAG, "mqtt %s (null)\n", message->topic);
	}
	fflush(stdout);
}

void my_connect_callback(struct mosquitto *mosq, void *userdata, int result)
{
	int i;
	if(!result){
		/* Subscribe to broker information topics on successful connect. */
		mosquitto_subscribe(mosq, NULL, "SYS/#", 2);
		dlog_print(DLOG_INFO, LOG_TAG, "mqtt Connect successful");
	}else{
		fprintf(stderr, "Connect failed\n");
		dlog_print(DLOG_INFO, LOG_TAG, "mqtt Connect failed");
	}
}

void my_subscribe_callback(struct mosquitto *mosq, void *userdata, int mid, int qos_count, const int *granted_qos)
{
	int i;

	dlog_print(DLOG_INFO, LOG_TAG, "mqtt Subscribed (mid: %d): %d", mid, granted_qos[0]);
	for(i=1; i<qos_count; i++){
		printf(", %d", granted_qos[i]);
	}
	printf("\n");
}

void my_log_callback(struct mosquitto *mosq, void *userdata, int level, const char *str)
{
	/* Pring all log messages regardless of level. */
	printf("%s\n", str);
}

bool mqtt_create()
{
	int i;
	char *host = "m24.cloudmqtt.com";//"192.168.1.32";
	int port = 15189; //1883;
	int keepalive = 60;
	bool clean_session = true;
	struct mosquitto *mosq = NULL;

	dlog_print(DLOG_INFO, LOG_TAG, "mqtt init");

	mosquitto_lib_init();
	mosq = mosquitto_new(NULL, clean_session, NULL);
	if(!mosq){
		fprintf(stderr, "Error: Out of memory.\n");
		dlog_print(DLOG_ERROR, LOG_TAG, "mqtt Error: Out of memory.");

		return false;
	}
	mosquitto_log_callback_set(mosq, my_log_callback);
	mosquitto_connect_callback_set(mosq, my_connect_callback);
	mosquitto_message_callback_set(mosq, my_message_callback);
	mosquitto_subscribe_callback_set(mosq, my_subscribe_callback);

	int r = mosquitto_connect(mosq, host, port, keepalive);
	if(r != MOSQ_ERR_SUCCESS){
		fprintf(stderr, "Unable to connect.\n");
		dlog_print(DLOG_ERROR, LOG_TAG, "mqtt Unable to connect. Error: %s", mosquitto_strerror(r));

		return false;
	}

	mosquitto_loop_forever(mosq, -1, 1);

	mosquitto_destroy(mosq);
	mosquitto_lib_cleanup();
	return true;
}
