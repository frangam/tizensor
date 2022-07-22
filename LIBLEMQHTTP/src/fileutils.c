#include "fileutils.h"


char* get_app_filepath(char* serviceID){
	char* dir = "/opt/usr/home/owner/media/Documents/";
	char* finalPath = malloc(1 + strlen(dir) + strlen(serviceID) + strlen(".csv"));
//	dlog_print(DLOG_INFO, LOG_TAG, "id before read / write : %s write file", serviceID);
//	char finalPath[1024] =
//			"/opt/usr/home/owner/media/Documents/";
//			"/home/guest/data/";
//			app_get_shared_data_path(); //carpeta pafa compartir datos con otras apps (permiso: http://tizen.org/privilege/appdir.shareddata)
//			app_get_data_path(); //carpeta privada (sin acceso desde fuera)
//	char* finalPath[1024];
//	sprintf (finalPath, "%s%s.csv",path, serviceID);
	strcpy(finalPath, dir);
	strcat(finalPath, serviceID); //dlog_print(DLOG_INFO, LOG_TAG, "id after strcat 1 read / write : %s write file", serviceID);
	strcat(finalPath, ".csv"); //dlog_print(DLOG_INFO, LOG_TAG, "id after strcat 2 read / write : %s write file", serviceID);


//	dlog_print(DLOG_INFO, LOG_TAG, "%s write file", serviceID);
	dlog_print(DLOG_INFO, LOG_TAG, "%s write file path: %s", serviceID, finalPath);
	return finalPath;
}

void write_file(char* serviceID, char* buf, bool override){
    char* path = get_app_filepath(serviceID);
    char* write_mode = override ? "w" : "a";
	FILE *appendFile = fopen(path, write_mode);
	if (appendFile != NULL){
		fputs(buf, appendFile);
		fclose(appendFile);
	}
}

void write_file_overriding_content(char* serviceID, char* buf){
	write_file(serviceID, buf, true);
}
void write_file_appending_content(char* serviceID, char* buf){
	write_file(serviceID, buf, false);
}

bool remove_file(char* filename){
	bool res = cfileexists(filename);
	dlog_print(DLOG_INFO, LOG_TAG, "exists file ? %d remove file path: %s", res, filename);

	if(res)
		res = remove(filename);
	else {
		res = false;
	}
	return res;
}

/*
 * Check if a file exist using fopen() function
 * return 1 if the file exist otherwise return 0
 */
bool cfileexists(const char * filename){
    /* try to open file to read */
	bool res = false;
    FILE *file;
    if (file = fopen(filename, "r")){
        fclose(file);
        res = true;
    }
    return res;
}

char* read_file(char* serviceID){
	char* path = get_app_filepath(serviceID);
//    FILE *fp = fopen(path, "r");
//    if (fp == NULL)
//        return NULL;
//    fseek(fp, 0, SEEK_END);
//    int bufsize = ftell(fp);
//    rewind(fp);
//    if (bufsize < 1)
//        return NULL;
//    char *buf = malloc(sizeof(char) * (bufsize));
//    memset(buf, '\0', sizeof(buf));
//    char str[4096];
//
//    while(fgets(str, 4096, fp) != NULL) {
//        dlog_print(DLOG_INFO, LOG_TAG, "read file content: %s", str);
//        sprintf(buf + strlen(buf), "%s", str);
//    }
//
//    fclose(fp);
//    return buf;


	char *buffer = "";
	int string_size, read_size;
	FILE *handler = fopen(path, "r");

	if (handler){
	   // Seek the last byte of the file
	   fseek(handler, 0, SEEK_END);
	   // Offset from the first to the last byte, or in other words, filesize
	   string_size = ftell(handler);
	   // go back to the start of the file
	   rewind(handler);

	   // Allocate a string that can hold it all
	   buffer = (char*) malloc(sizeof(char) * (string_size + 1) );

	   // Read it all in one operation
	   read_size = fread(buffer, sizeof(char), string_size, handler);

	   // fread doesn't set it so put a \0 in the last position
	   // and buffer is now officially a string
	   buffer[string_size] = '\0';

	   dlog_print(DLOG_INFO, LOG_TAG, "read file content: %s", buffer);

	   if (string_size != read_size)
	   {
		   // Something went wrong, throw away the memory and set
		   // the buffer to NULL
		   free(buffer);
		   buffer = NULL;
	   }

	   // Always remember to close the file.
	   fclose(handler);
	}

	return buffer;
}

bool delete_all_data(){
	dlog_print(DLOG_INFO, LOG_TAG, "trying to delete all");
	char* serviceID;
	int i;
	int total_deleted = 0;
	bool res = false;
	bool r = false;
	bool r2 = false;
	for(i=0; i<total_active_sensors; i++){
		serviceID = sensors[i].serviceID; // get_service_id_by_index(i);
		r = remove_file(get_app_filepath(serviceID));
		r2 = remove_file(get_app_filepath(get_last_value_id(serviceID)));

		dlog_print(DLOG_INFO, LOG_TAG, "delete trying to delete %s", serviceID);
		if(!r && !r2){
			dlog_print(DLOG_INFO, LOG_TAG, "[ delete ] %s deleted succeed", serviceID);
			total_deleted += 2;
		}
		else{
			dlog_print(DLOG_ERROR, LOG_TAG, "[ delete ] %s deleted failed", serviceID);
		}
	}

	//eliminar archivo de marcas de tiempo
	r = remove_file(get_app_filepath(TIME_MARKS_FILE_ID));
	res = !r && total_deleted == 2*total_active_sensors + 1;

	return res;
}
