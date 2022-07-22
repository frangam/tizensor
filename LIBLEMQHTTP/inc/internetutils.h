#ifndef _INTERNETUTILS_H_
#define _INTERNETUTILS_H_

#include "utils.h"
#include "fileutils.h"
#include <curl/curl.h>
#include <net_connection.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "internetutils"


#ifdef __cplusplus
extern "C" {
#endif

#define SERVER_URL "http://52.47.66.31/frailty/post.php" //"http://mydass.ddns.net/frailty/post.php"

extern CURL *curl;
extern CURLcode curl_err;
extern connection_h connection;

extern bool init_internet_connection();
extern void terminate_http_connection();
extern bool check_internet();
extern void send_request(char* serviceID);
extern void send_all_data_to_server();

#ifdef __cplusplus
}
#endif
#endif /* _INTERNETUTILS_H_ */
