#include "FileDirectory.h"

MYRETURN my_chdir(const char *dirname)
{
    AZZ_ERROR;
//////////////////////////////// VERIFICA INPUT ////////////////////////////////
	if(  dirname == NULL )	  return MYER_STRN(1);
    if( *dirname == '\0' )	  return MYER_STRE(1);
//////////////////////////////// VERIFICA INPUT ////////////////////////////////

#if defined( _MSC_VER) || defined(__clang__)
    if( _chdir( dirname ) == 0 )
        #else
//#elif defined(__linux__)
    if( chdir( dirname ) == 0 )
#endif

        return SUCCESS;
	else
        return INSUCCESS;
}
/*
MYRETURN my_fchdir(const int fd)
{
    if( fd <= 0  )	return MYER_STRN( 1 );
    if( fd >= 27 )	return MYER_STRN( 1 );


	if ( my_fileno()) return SUCCESS;
	else		return INSUCCESS;
}*/
