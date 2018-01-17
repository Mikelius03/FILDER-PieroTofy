#include "MyFilder.h"


MYRETURN searchF( SettFILDER* myFILDER )
{
// Variabili di Lavoro

    char* currDirWork=NULL; // Stringa per la cartella corrent
    DIRDATA *l = calloc(1, sizeof( DIRDATA* ) );


    if(my_getcwd( &currDirWork )) return FATALITY;
    if(my_chdir( myFILDER->dirWork )  ) return FATALITY;  // Cartellla di lavoro
    
    l->levelSubFolder = -1;
    MotoreFILDER( myFILDER, l );                   // MOTORE 
    

    if( my_chdir( currDirWork ) ) return FATALITY; // Ritorno alla cartella iniziale
    free( currDirWork );                           // Libero la memoria allocata con my_getcwd()
    currDirWork = NULL;

    return SUCCESS;
}