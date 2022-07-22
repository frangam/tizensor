#ifndef _FILEUTILS_H_
#define _FILEUTILS_H_

#include "utils.h"
#include "sensorutils.h"

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "fileutils"

#ifdef __cplusplus
extern "C" {
#endif

extern char* get_app_filepath(char*);
extern void write_file(char* serviceID, char* buf, bool override);
extern void write_file_overriding_content(char* serviceID, char* buf);
extern void write_file_appending_content(char* serviceID, char* buf);
extern char* read_file(char*);
extern bool cfileexists(const char * filename);
extern bool remove_file(char* filename);

#ifdef __cplusplus
}
#endif
#endif /* _FILEUTILS_H_ */
